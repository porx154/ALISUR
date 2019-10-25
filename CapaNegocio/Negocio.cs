using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class Negocio
    {
        //acceso al sistema
        public static DataTable NegAccesoAlSistema(Entidad objEntidad)
        {
            return Datos.DtoAccederAlSistema(objEntidad);
        }
        //mantenimiento cargo
        public static DataTable NegListarCargo()
        {
            return Datos.DtoListarCargo();
        }
        public static int NegMantenerCargo(Entidad objEntidad)
        {
            return Datos.DtoMantenerCargo(objEntidad);
        }
        //mantenimiento tipo producto
        public static DataTable NegListarTipoProducto(Entidad objEntidad)
        {
            return Datos.DtoListarTipoProducto(objEntidad);
        }
        public static int NegMantenerTipoProducto(Entidad objEntidad)
        {
            return Datos.DtoMantenerTipoProducto(objEntidad);
        }
        //mantenimiento de producto
        public static DataTable NegListarProducto()
        {
            return Datos.DtoListarProducto();
        }
        public static int NegMantenerProducto(Entidad objEntidad)
        {
            return Datos.DtoMantenerProducto(objEntidad);
        }
        //mantenimiento proveedor
        public static int NegMantenerProveedor(Entidad objEntidad)
        {
            return Datos.DtoMantenerProveedor(objEntidad);
        }
        public static DataTable NegConsultarProveedor(string parametro)
        {
            return Datos.DtoConsultarProveedor(parametro);
        }
        //proceso de estado
        public static DataTable NegListarEstado()
        {
            return Datos.DtoListarEstado();
        }
        //tranaccion compra
        public static bool NegSerieNumeroCompra(Entidad objEntidad)
        {
            return Datos.DtoSerieNumeroCompra(objEntidad);
        }
        public static bool NegBuscarProveedorDni(Entidad objEntidad)
        {
            return Datos.DtoBuscarProveedorDni(objEntidad);
        }
        public static bool NegPrecioProducto(Entidad objEntidad)
        {
            return Datos.DtoPrecioProducto(objEntidad);
        }
        //registrar cabecera compra
        public static int NegRegistrarCabCompra(Entidad objEntidad)
        {
            return Datos.DtoRegistrarCabCompra(objEntidad);
        }
        //registrar detalle compra
        public static int NegRegistrarDetCompra(Entidad objEntidad)
        {
            return Datos.DtoRegistrarDetCompra(objEntidad);
        }
        //listar compra actual
        public static DataTable NegListarCompraActual(string codsucursal)
        {
            return Datos.DtoListarCompraActual(codsucursal);
        }
        //listar compra por fecha y sucursal
        public static DataTable NegListarCompraPorFechaSucursal(string codsucursal,DateTime fechacompra)
        {
            return Datos.DtoListarCompraPorFechaSucursal(codsucursal, fechacompra);
        }
        //listar detalle de la compra
        public static DataTable NegListarDetalleCompra(string codigocompra)
        {
            return Datos.DtoListarDetalleCompra(codigocompra);
        }
        //matenimiento sucursal
        public static DataTable NegListarSucursal()
        {
            return Datos.DtoListarSucursal();
        }
        public static int NegMantenerSucursal(Entidad objEntidad)
        {
            return Datos.DtoMantenerSucursal(objEntidad);
        }
        //almacen
        public static DataTable NegListarAlmacen(Entidad objEntidad)
        {
            return Datos.DtoListarAlmacen(objEntidad);
        }
        public static int NegRetirarAlmacen(Entidad objEntidad)
        {
            return Datos.DtoRetirarAlmacen(objEntidad);
        }
        public static int NegRegistrarAlmacen(Entidad objEntidad)
        {
            return Datos.DtoRegistrarAlmacen(objEntidad);
        }
        //mantenimiento personal
        public static DataTable NegListarPersonal()
        {
            return Datos.DtoListarPersonal();
        }
        public static DataTable NegBuscarPersonal(string parametro)
        {
            return Datos.DtoBuscarPersonal(parametro);
        }
        public static int NegMantenerPersonal(Entidad objEntidad)
        {
            return Datos.DtoMantenerPersonal(objEntidad);
        }
        //almacen general sarandeo
        public static DataTable NegListarAlmGeneral()
        {
            return Datos.DtoListarAlmGeneral();
        }
        public static double NegCantTotSarandeo()
        {
            return Datos.DtoCantTotSarandeo();
        }
        public static int NegRegistrarAlmacenGeneral(Entidad objEntidad)
        {
            return Datos.DtoRegistrarAlmacenGeneral(objEntidad);
        }
        //mostrar almacen general para validar venta
        public static DataTable NegMostrarAlmacenGeneral()
        {
            return Datos.DtoMostrarAlmacenGeneral();
        }
        //sarandeo
        public static int NegMantenerSarandeo(Entidad objEntidad)
        {
            return Datos.DtoMantenerSarandeo(objEntidad);
        }
        public static DataTable NegListarSarandeo()
        {
            return Datos.DtoListarSarandeo();
        }
        //caja
        public static int NegMantenerCaja(Entidad objEntidad)
        {
            return Datos.DtoMantenerCaja(objEntidad);
        }
        public static DataTable NegListarCajaIngresos(Entidad objEntidad)
        {
            return Datos.DtoListarCajaIngresos(objEntidad);
        }
        public static DataTable NegListarCajaRetiros(Entidad objEntidad)
        {
            return Datos.DtoListarCajaRetiros(objEntidad);
        }
        public static int NegRegistrarRetiroCaja(Entidad objEntidad)
        {
            return Datos.DtoRegistrarRetiroCaja(objEntidad);
        }
        //confirmacion
        public static int NegRegistrarConfirmacion(Entidad objEntidad)
        {
            return Datos.DtoRegistrarConfirmacion(objEntidad);
        }
        public static bool NegBuscarConfirmacion(Entidad objEntidad)
        {
            return Datos.DtoBuscarConfirmacion(objEntidad);
        }
        public static bool NegBuscarConfirmacionConfirmacion(Entidad objEntidad)
        {
            return Datos.DtoBuscarConfirmacionConfirmacion(objEntidad);
        }
        public static int NegAfirmarConfirmacion(Entidad objEntidad)
        {
            return Datos.DtoAfirmarConfirmacion(objEntidad);
        }
        //saldo tienda
        public static double NegListarSaldoTienda(string codSucursal)
        {
            return Datos.DtoListarSaldoTienda(codSucursal);
        }
        //cliente
        public static Entidad NegBuscarCliente(string parametro)
        {
            return Datos.DtoBuscarCliente(parametro);
        }
        public static int NegMantenerCliente(Entidad objEntidad)
        {
            return Datos.DtoMantenerCliente(objEntidad);
        }
        public static DataTable NegMostrarCliente()
        {
            return Datos.DtoMostrarCliente();
        }
        public static DataTable NegFiltrarCliente(Entidad objEntidad)
        {
            return Datos.DtoFiltrarCliente(objEntidad);
        }
        //listartipoproducto
        public static DataTable NegMostrarTipoProducto()
        {
            return Datos.DtoMostrarTipoProducto();
        }
        //venta general
        public static int NegMantenerVentaGeneral(Entidad objEntidad)
        {
            return Datos.DtoMantenerVentaGeneral(objEntidad);
        }
        public static DataTable NegListarVentaActual()
        {
            return Datos.DtoListarVentaActual();
        }
        public static DataTable NegListarVentaPorFecha(Entidad objEntidad)
        {
            return Datos.DtoListarVentaPorFecha(objEntidad);
        }
        public static bool NegVerFacturaElectronica(Entidad objEntidad)
        {
            return Datos.DtoVerFacturaElectronica(objEntidad);
        }
        //listar tipogasto
        public static DataTable NegMostrarTipoGasto()
        {
            return Datos.DtoMostrarTipoGasto();
        }
        //mantener gasto
        public static int NegMantenerGasto(Entidad objEntidad)
        {
            return Datos.DtoMantenerGasto(objEntidad);
        }
        //listar gasto
        public static DataTable NegListarGasto()
        {
            return Datos.DtoListarGasto();
        }
        //filtrar gasto
        public static DataTable NegFiltrarGastoPorMes(string MesGasto)
        {
            return Datos.DtoFiltrarGastoPorMes(MesGasto);
        }
        //listar tipo gasto
        public static DataTable NegListarTipoGasto()
        {
            return Datos.DtoListarTipoGasto();
        }
        //mantener tipo de gasto
        public static int NegMantenerTipoGasto(Entidad objEntidad)
        {
            return Datos.DtoMantenerTipoGasto(objEntidad);
        }
        //filtrar por fecha
        public static DataTable NegFiltrarGastoPorFecha(Entidad objEntidad)
        {
            return Datos.DtoFiltrarGastoPorFecha(objEntidad);
        }
        //mantener prestamo
        public static int NegMantenerPrestamo(Entidad objEntidad)
        {
            return Datos.DtoMantenerPrestamo(objEntidad);
        }
        //listar prestamo

        public static DataTable NegListarPrestamo(Entidad objEntidad)
        {
            return Datos.DtoListarPrestamo(objEntidad);
        }
        //listar adelanto
        public static DataTable NegListarAdelanto()
        {
            return Datos.DtoListarAdelanto();
        }
        //LISTAR DET PRESTAMO
        public static DataTable NegListarDetPrestamo(Entidad objEntidad)
        {
            return Datos.DtoListarDetPrestamo(objEntidad);
        }
        //LISTAR DET ADELANTO
        public static DataTable NegListarDetAdelanto()
        {
            return Datos.DtoListarDetAdelanto();
        }
        //registrar det prestamo
        public static int NegRegistrarDetPrestamo(Entidad objEntidad)
        {
            return Datos.DtoRegistrarDetPrestamo(objEntidad);
        }
        //filtrar temporal proveedor por dni
        public static DataTable NegBuscarProveedorDniTemporal(Entidad objEntidad)
        {
            return Datos.DtoBuscarProveedorDniTemporal(objEntidad);
        }
        //registro de detalle en aumento del detalle de prestamo
        public static int NegRegistrarDetAumentoPrestamo(Entidad objEntidad)
        {
            return Datos.DtoRegistrarDetAumentoPrestamo(objEntidad);
        }
        public static int NegCancelarDeudaPrestamo(Entidad objEntidad)
        {
            return Datos.DtoCancelarDeudaPrestamo(objEntidad);
        }
        //listar adelanto
        public static DataTable NegListarAdelanto(Entidad objEntidad)
        {
            return Datos.DtoListarAdelando(objEntidad);
        }
        public static int NegMantenerAdelanto(Entidad objEntidad)
        {
            return Datos.DtoMantenerAdelanto(objEntidad);
        }
    }
}
