using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        //probando cambios
        public static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //acceso al sistema
        public static DataTable DtoAccederAlSistema(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "acceso_sistema", objEntidad.nomUsuarioPersonal, objEntidad.passPersonal);
        }
        //mantenimiento cargo
        
        public static DataTable DtoListarCargo()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarCargo");
        }
        public static int DtoMantenerCargo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_cargo", objEntidad.CodCargo, objEntidad.desCargo);
        }
        //mantenimiento tipo de producto
        public static DataTable DtoListarTipoProducto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarTipoProducto", objEntidad.CodProductoFKTipo);
        }
        public static int DtoMantenerTipoProducto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_tipoProducto", objEntidad.CodTipoProducto, objEntidad.desTipoProducto, objEntidad.CodProductoFKTipo);
        }
        //mantenimiento producto
        public static DataTable DtoListarProducto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarProducto");
        }
        public static int DtoMantenerProducto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_prodcuto", objEntidad.CodProducto, objEntidad.nomProducto, objEntidad.preProducto);
        }
        //matenimiento proveedor
        public static int DtoMantenerProveedor(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_proveedor", objEntidad.CodProveedor, objEntidad.nomProveedor, objEntidad.apeProveedor, objEntidad.dirProveedor, objEntidad.telProveedor, objEntidad.dniProveedor, objEntidad.rucProveedor);
        }
        public static DataTable DtoConsultarProveedor(string parametro)
        {
            return SqlHelper.ExecuteDataTable(conexion, "consultar_proveedor", parametro);
        }
        //proceso de estado
        public static DataTable DtoListarEstado()
        {
            return SqlHelper.ExecuteDataTable(conexion, "Listar_Estado");
        }

        //transaccion de compra
        public static bool DtoSerieNumeroCompra(Entidad objEntidad)
        {
            SqlDataReader readerSerieNumero = SqlHelper.ExecuteReader(conexion, "max_compra_serienum", objEntidad.CodSucursalFKVenta);
            if (readerSerieNumero.HasRows)
            {
                readerSerieNumero.Read();
                if (Convert.ToDouble(readerSerieNumero[2].ToString()) < 99999)
                {
                    objEntidad.numCompra = Convert.ToDouble(readerSerieNumero[2].ToString()) + 1;
                    objEntidad.serieCompra = Convert.ToDouble(readerSerieNumero[1].ToString());
                }else
                {
                    objEntidad.numCompra = 1;
                    objEntidad.serieCompra = Convert.ToDouble(readerSerieNumero[1].ToString()) + 1;
                }
                return true;
            }else
            {
                objEntidad.serieCompra = 1;
                objEntidad.numCompra = 1;
                return false;
            }
        }
        public static bool DtoBuscarProveedorDni(Entidad objEntidad)
        {
            SqlDataReader readerProveedor = SqlHelper.ExecuteReader(conexion, "buscar_proveedor_venta", objEntidad.dniProveedor);
            if (readerProveedor.Read())
            {
                objEntidad.CodProveedorFKVenta = readerProveedor[0].ToString();
                objEntidad.NombreyApellidoProveedor = readerProveedor[1].ToString();
                objEntidad.rucProveedor = readerProveedor[2].ToString();
                return true;
            }else
            {
                return false;
            }
        }
        //filtrar temporal buscar proveedor por dni
        public static DataTable DtoBuscarProveedorDniTemporal(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "buscar_proveedor_venta", objEntidad.dniProveedor);
        }
        //fin temporal proveedor
        public static bool DtoPrecioProducto(Entidad objEntidad)
        {
            SqlDataReader readerPrecio = SqlHelper.ExecuteReader(conexion, "precio_producto", objEntidad.nomProducto);
            if (readerPrecio.Read())
            {
                objEntidad.preProducto = Convert.ToDouble(readerPrecio[0].ToString());
                return true;
            }else
            {
                return false;
            }
        }
        //listar compra actual
        public static DataTable DtoListarCompraActual(string codsucursal)
        {
            return SqlHelper.ExecuteDataTable(conexion, "sp_ListarCompraActualPorSucursal", codsucursal);
        }
        //listar compra por fecha y sucursal
        public static DataTable DtoListarCompraPorFechaSucursal(string codsucursal, DateTime fechacompra)
        {
            return SqlHelper.ExecuteDataTable(conexion, "sp_BuscarCompraPorFecha", codsucursal, fechacompra);
        }
        //listar detalle de la compra
        public static DataTable DtoListarDetalleCompra(string codigocompra)
        {
            return SqlHelper.ExecuteDataTable(conexion, "sp_ListarCompraDetalleActual", codigocompra);
        }
        //registrar cabecera de compra
        public static int DtoRegistrarCabCompra(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_cab_compra",objEntidad.CodSucursalFKVenta,objEntidad.serieCompra,objEntidad.numCompra,objEntidad.CodProveedorFKVenta,objEntidad.CodPersonalFKVenta,objEntidad.CodEstadoFKVenta);
        }
        //registrar detalle de compra
        public static int DtoRegistrarDetCompra(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_detalle_compra", objEntidad.pesoDetCompra, objEntidad.preDetCompra, objEntidad.CodSucursalFKDetalle, objEntidad.CodProductoFKDetalle, objEntidad.CodTipoProductoFKDetalle);
        }
        //mantenimiento sucursal
        public static DataTable DtoListarSucursal()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_sucursal");
        }
        public static int DtoMantenerSucursal(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_sucursal",objEntidad.CodSucursalS,objEntidad.nomSucursal,objEntidad.dirSucursal,objEntidad.rucSucursal,objEntidad.telSucursal);
        }
        //mantenimiento almacen
        public static DataTable DtoListarAlmacen(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_almacen", objEntidad.CodSucursalFKAlmacen);
        }
        public static int DtoRetirarAlmacen(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "retirar_delAlmacen", objEntidad.cantProAlmacen,objEntidad.CodProductoFKAlmacen,objEntidad.CodSucursalFKAlmacen,objEntidad.cantTotAlmacen);
        }
        public static int DtoRegistrarAlmacen(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_almacen", objEntidad.cantProAlmacen, objEntidad.CodProductoFKAlmacen, objEntidad.CodSucursalFKAlmacen,objEntidad.CodTipoProductoFKAlmacen);
        }
        //mantenimiento personal
        public static DataTable DtoListarPersonal()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_personal");
        }
        public static DataTable DtoBuscarPersonal(string parametro)
        {
            return SqlHelper.ExecuteDataTable(conexion, "buscar_personal", parametro);
        }
        public static int DtoMantenerPersonal(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantener_personal", objEntidad.CodPersonal,objEntidad.nomPersonal,objEntidad.apePersonal,objEntidad.dirPersonal,objEntidad.telPersonal,objEntidad.dniPersonal,objEntidad.emailPersonal,objEntidad.nomUsuarioPersonal,objEntidad.passPersonal,objEntidad.CodCargoFKPersonal,objEntidad.CodSucursal);
        }
        //almacen general sarandeo
        public static DataTable DtoListarAlmGeneral()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarAlmacenGeneral");
        }
        public static double DtoCantTotSarandeo()
        {
            SqlDataReader readerTotSarandeo = SqlHelper.ExecuteReader(conexion, "SumaCantSarandeo");
            Entidad objentidad = new Entidad();
            if (readerTotSarandeo.Read()) { 
                if(readerTotSarandeo[0].ToString() == "")
                {
                    return 0;
                }
                return Convert.ToDouble(readerTotSarandeo[0].ToString());
            }
            else
            {
                return 0;
            }
        }
        //almacen general mostrar para validar venta
        public static DataTable DtoMostrarAlmacenGeneral()
        {
            return SqlHelper.ExecuteDataTable(conexion, "sp_mostrarAlmacenGeneral");
        }
        public static int DtoRegistrarAlmacenGeneral(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_almacengeneral",objEntidad.CodSucuralFKAlmacenGeneral,objEntidad.CantKilo);
        }
        //sarandeo mantener
        public static int DtoMantenerSarandeo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_sarandeo",objEntidad.CodSarandeo,objEntidad.CantSarandeo,objEntidad.SaPrimera,objEntidad.SaSegunda,objEntidad.SaPolvillo,objEntidad.SaMerma,objEntidad.CodPersonalFKSarandeo);
        }
        public static DataTable DtoListarSarandeo()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_sarandeo");
        }
        //caja mantener
        public static int DtoMantenerCaja(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_ingresosCaja", objEntidad.CodCaja, objEntidad.montoCaja, objEntidad.CodSucursalFKCaja, objEntidad.NroOperacion, objEntidad.CodPersonalFKCaja);
        }
        public static int DtoRegistrarRetiroCaja(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_retirocaja",objEntidad.montoCaja,objEntidad.CodSucursalFKCaja,objEntidad.CodPersonalFKCaja);
        }
        public static DataTable DtoListarCajaIngresos(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_caja_ingresos", objEntidad.CodSucursalFKCaja);
        }
        public static DataTable DtoListarCajaRetiros(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listar_caja_retiros", objEntidad.CodSucursalFKCaja);
        }
      //confirmacion
        public static int DtoRegistrarConfirmacion(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrar_confirmacion", objEntidad.CodSucursalFKConfirmacion,objEntidad.codigoConfirmacion,objEntidad.cantidadConfirmacion,objEntidad.CodPersonalFKConfirmacion);
        }
        public static bool DtoBuscarConfirmacion(Entidad objEntidad)
        {
            SqlDataReader readerconfirmacion = SqlHelper.ExecuteReader(conexion, "buscar_confirmacion", objEntidad.codigoConfirmacion);
            if (readerconfirmacion.Read())
            {
                objEntidad.CodConfirmacion = readerconfirmacion[0].ToString();
                objEntidad.CodSucursalFKConfirmacion = readerconfirmacion[1].ToString();
                objEntidad.codigoConfirmacion =Convert.ToString(readerconfirmacion[2].ToString());
                objEntidad.cantidadConfirmacion = Convert.ToDouble(readerconfirmacion[3].ToString());
                objEntidad.CodPersonalFKConfirmacion = readerconfirmacion[4].ToString();
                objEntidad.estConfirmacion = Convert.ToBoolean(readerconfirmacion[5].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DtoBuscarConfirmacionConfirmacion(Entidad objEntidad)
        {
            SqlDataReader readerconfirmacion = SqlHelper.ExecuteReader(conexion, "buscar_confirmacion_confirmacion", objEntidad.codigoConfirmacion);
            if (readerconfirmacion.Read())
            {
                objEntidad.CodConfirmacion = readerconfirmacion[0].ToString();
                objEntidad.CodSucursalFKConfirmacion = readerconfirmacion[1].ToString();
                objEntidad.codigoConfirmacion = Convert.ToString(readerconfirmacion[2].ToString());
                objEntidad.cantidadConfirmacion = Convert.ToDouble(readerconfirmacion[3].ToString());
                objEntidad.CodPersonalFKConfirmacion = readerconfirmacion[4].ToString();
                objEntidad.estConfirmacion = Convert.ToBoolean(readerconfirmacion[5].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int DtoAfirmarConfirmacion(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "afirmar_confirmacion", objEntidad.codigoConfirmacion);
        }
        //saldo tienda
        public static double DtoListarSaldoTienda(string codSucursal)
        {
            SqlDataReader readersaldotienda = SqlHelper.ExecuteReader(conexion, "listar_salgo_tienda", codSucursal);
            if (readersaldotienda.Read())
            {
                return Convert.ToDouble(readersaldotienda[0].ToString());
            }else
            {
                return 0;
            }
        }
        //cliente
        public static Entidad DtoBuscarCliente(string parametro)
        {
            SqlDataReader readerbuscli = SqlHelper.ExecuteReader(conexion, "BuscarCliente", parametro);
            Entidad objent = new Entidad();
            if (readerbuscli.Read())
            {
                objent.CodCliente = readerbuscli[0].ToString();
                objent.nomCliente = readerbuscli[1].ToString();
                objent.rucCliente = readerbuscli[2].ToString();
                objent.dirCliente = readerbuscli[3].ToString();
                objent.telCliente = readerbuscli[4].ToString();
                return objent;
            }else
            {
                return null;
            }

        }
        public static DataTable DtoFiltrarCliente(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "buscar_cliente", objEntidad.rucCliente);
        }
        public static int DtoMantenerCliente(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantenerCliente", objEntidad.CodCliente, objEntidad.nomCliente, objEntidad.rucCliente, objEntidad.dirCliente, objEntidad.telCliente);
        }
        //mostrar cliente para el temporal
        public static DataTable DtoMostrarCliente()
        {
            return SqlHelper.ExecuteDataTable(conexion, "sp_mostrarCliente");
        }
        //ventas generales
        public static int DtoMantenerVentaGeneral(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "MantenerVentas", objEntidad.CodVenta,objEntidad.CodClienteFKVentaGeneral,objEntidad.tipoMoneda,objEntidad.CodTipoProductoFKVentaGeneral,objEntidad.pesoTotalVenta,objEntidad.precioUnitarioVenta,objEntidad.phVenta,objEntidad.CodPersonalFKVentaGeneral,objEntidad.CodSucursalFKVentaGeneral);
        }
        public static DataTable DtoListarVentaActual()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarVentaActual");
        }
        public static DataTable DtoListarVentaPorFecha(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarVentaPorFecha", objEntidad.fechVenta);
        }
        public static bool DtoVerFacturaElectronica(Entidad objEntidad)
        {
            SqlDataReader readerFactura = SqlHelper.ExecuteReader(conexion, "verFacturaElectronica", objEntidad.CodVenta);
            if (readerFactura.Read())
            {
                objEntidad.dirSucursal = readerFactura[0].ToString();
                objEntidad.rucSucursal = readerFactura[1].ToString();
                objEntidad.fechVenta = Convert.ToDateTime(readerFactura[2].ToString());
                objEntidad.nomCliente = readerFactura[3].ToString();
                objEntidad.rucCliente = readerFactura[4].ToString();
                objEntidad.dirCliente = readerFactura[5].ToString();
                objEntidad.destipomoneda = readerFactura[6].ToString();
                objEntidad.pesoTotalVenta = Convert.ToDouble(readerFactura[7].ToString());
                objEntidad.desTipoProducto = readerFactura[8].ToString();
                objEntidad.precioUnitarioVenta = Convert.ToDouble(readerFactura[9].ToString());
                objEntidad.phVenta = Convert.ToDouble(readerFactura[10].ToString());
                objEntidad.nomPersonal = readerFactura[11].ToString();
                objEntidad.TotVentaGeneral = Convert.ToDouble(readerFactura[12].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        //listartipoproducto
        public static DataTable DtoMostrarTipoProducto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "mostrarTipoProducto");
        }
        //listar tipo gasto
        public static DataTable DtoMostrarTipoGasto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarTipoGasto");
        }
        //mantener gasto
        public static int DtoMantenerGasto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantenerGasto", objEntidad.codgastogeneral,objEntidad.desgasto,objEntidad.montogasto,objEntidad.codPersonalFKGasto,objEntidad.codTipoGastoFKGasto);
        }
        //listar gasto
        public static DataTable DtoListarGasto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarGastos");
        }
        //filtrar gasto
        public static DataTable DtoFiltrarGastoPorMes(string MesGasto)
        {
            return SqlHelper.ExecuteDataTable(conexion, "filtrarGasto", MesGasto);
        }
        //listar tipo de gasto
        public static DataTable DtoListarTipoGasto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarTipoGasto");
        }
        //mantener tipo de gasto
        public static int DtoMantenerTipoGasto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "registrarTipoGasto", objEntidad.codtipogasto, objEntidad.destipogasto);
        }
        //filtrar por fecha
        public static DataTable DtoFiltrarGastoPorFecha(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "filtrarGastoInicialFinal", objEntidad.fechInicialGasto, objEntidad.fechFinGasto);
        }
        //mantener prestamo
        public static int DtoMantenerPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantenerPrestamo", objEntidad.codPrestamo,objEntidad.codProveedorFKPrestamo,objEntidad.fechDevPrestamo,objEntidad.montoPrestamo,objEntidad.codPersonalFKPrestamo,objEntidad.interesPrestamo);
        }
        //listar prestamo
        public static DataTable DtoListarPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarPrestamo",objEntidad.estPrestamo);
        }
        //listar adelantos
        public static DataTable DtoListarAdelanto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarAdelanto");
        }
        //listar det prestamo
        public static DataTable DtoListarDetPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarDetPrestamo", objEntidad.codPrestamoFKDetall);
        }
        //listar det adelanto
        public static DataTable DtoListarDetAdelanto()
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarDetAdelanto");
        }
        //registrar detalle prestamo
        public static int DtoRegistrarDetPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "MantenerDetPrestamo", objEntidad.codDetPrestamo,objEntidad.codPrestamoFKDetall,objEntidad.montodetPrestamo,objEntidad.desDetPrestamo);
        }
        //registrar detalle en aumento del prestamo
        public static int DtoRegistrarDetAumentoPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "MantenerDetPrestamoAumento", objEntidad.codDetPrestamo, objEntidad.codPrestamoFKDetall, objEntidad.montodetPrestamo);
        }
        public static int DtoCancelarDeudaPrestamo(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "cancelarDeuda", objEntidad.codPrestamoFKDetall);
        }
        //LISTAR ADELANTO
        public static DataTable DtoListarAdelando(Entidad objEntidad)
        {
            return SqlHelper.ExecuteDataTable(conexion, "listarAdelanto", objEntidad.estAdelanto);
        }
        public static int DtoMantenerAdelanto(Entidad objEntidad)
        {
            return SqlHelper.ExecuteNonQuery(conexion, "mantenerAdelanto",objEntidad.codAdelanto,objEntidad.montoadelanto,objEntidad.CodPersonalFKAdelanto,objEntidad.fechFinAdelanto,objEntidad.estAdelanto,objEntidad.CodProveedorFKAdelanto);
        }
    }
}
