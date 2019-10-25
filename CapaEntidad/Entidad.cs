using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Entidad
    {
        //mantenimiento Personal Usuarios
        public string CodPersonal { get; set; }
        public string nomPersonal { get; set; }
        public string apePersonal { get; set; }
        public string dirPersonal { get; set; }
        public string telPersonal { get; set; }
        public string dniPersonal { get; set; }
        public string emailPersonal { get; set; }
        public string nomUsuarioPersonal { get; set; }
        public string passPersonal { get; set; }
        public string CodCargoFKPersonal { get; set; }
        public string CodSucursal { get; set; }
        //matenimiento cargo
        public string CodCargo { get; set; }
        public string desCargo { get; set; }
        //mantenimiento tipo de producto
        public string CodTipoProducto { get; set; }
        public string CodProductoFKTipo { get; set; }
        public string desTipoProducto { get; set; }
        //mantenimiento producto
        public string CodProducto { get; set; }
        public string nomProducto { get; set; }
        public double preProducto { get; set; }
        //mantenimiento proveedor
        public string CodProveedor { get; set; }
        public string nomProveedor { get; set; }
        public string apeProveedor { get; set; }
        public string dirProveedor { get; set; }
        public string telProveedor { get; set; }
        public string dniProveedor { get; set; }
        public string rucProveedor { get; set; }
        //tabla estado
        public string CodEstado { get; set; }
        public string DesEstado { get; set; }
        //transaccion venta
        public string CodCompra { get; set; }
        public string CodSucursalFKVenta { get; set; }
        public double serieCompra { get; set; }
        public double numCompra { get; set; }
        public DateTime fechCompra { get; set; }
        public string CodProveedorFKVenta { get; set; }
        public string CodPersonalFKVenta { get; set; }
        public string CodEstadoFKVenta { get; set; }
        //detalle
        public string CodCompraFKDetalle { get; set; }
        public DateTime fechDetCompra { get; set; }
        public double pesoDetCompra { get; set; }
        public double preDetCompra { get; set; }
        public string CodSucursalFKDetalle { get; set; }
        public string CodProductoFKDetalle { get; set; }
        public string CodTipoProductoFKDetalle { get; set; }
        //parametro adicional
        public string NombreyApellidoProveedor { get; set; }
        //Almacen
        public string CodAlmacen { get; set; }
        public double cantProAlmacen { get; set; }
        public string CodProductoFKAlmacen { get; set; }
        public string CodSucursalFKAlmacen { get; set; }
        public double cantTotAlmacen { get; set; }
        public bool estOpTienda { get; set; }
        //add almacen tienda
        public DateTime fechAlmTienda { get; set; }
        public string CodTipoProductoFKAlmacen { get; set; }
        //sarandeo
        public string CodSarandeo { get; set; }
        public DateTime FechSarandeo { get; set; }
        public double CantSarandeo { get; set; }
        public double SaPrimera { get; set; }
        public double SaSegunda { get; set; }
        public double SaPolvillo { get; set; }
        public double SaMerma { get; set; }
        public string CodPersonalFKSarandeo { get; set; }
        public double CantTotalSarandeo { get; set; }
        //almcen general
        public string CodAlmGeneral { get; set; }
        public DateTime FechAlmGeneral { get; set; }
        public string CodSucuralFKAlmacenGeneral { get; set; }
        public double CantKilo { get; set; }
        public double CantTotal { get; set; }
        //caja
        public string CodCaja { get; set; }
        public bool tipoOperacion { get; set; }
        public double montoCaja { get; set; }
        public double saldoCaja { get; set; }
        public DateTime fechCaja { get; set; }
        public string CodSucursalFKCaja { get; set; }
        public string NroOperacion { get; set; }
        public string CodPersonalFKCaja { get; set; }
        //sucursal
        public string CodSucursalS { get; set; }
        public string nomSucursal { get; set; }
        public string dirSucursal { get; set; }
        public string rucSucursal { get; set; }
        public string telSucursal { get; set; }
        public double saldoSucursal { get; set; }
        //confimacion
        public string CodConfirmacion { get; set; }
        public string CodSucursalFKConfirmacion { get; set; }
        public string codigoConfirmacion { get; set; }
        public double cantidadConfirmacion { get; set; }
        public string CodPersonalFKConfirmacion { get; set; }
        public bool estConfirmacion { get; set; }
        //venta general
        public string CodVenta { get; set; }
        public DateTime fechEmision { get; set; }
        public string CodClienteFKVentaGeneral { get; set; }
        public bool tipoMoneda { get; set; }
        public string destipomoneda { get; set; }
        public string CodTipoProductoFKVentaGeneral { get; set; }
        public double pesoTotalVenta { get; set; }
        public double precioUnitarioVenta { get; set; }
        public double phVenta { get; set; }
        public DateTime fechVenta { get; set; }
        public string CodPersonalFKVentaGeneral { get; set; }
        public string CodSucursalFKVentaGeneral { get; set; }
        public double TotVentaGeneral { get; set; }
        //cliente
        public string CodCliente { get; set; }
        public string nomCliente { get; set; }
        public string rucCliente { get; set; }
        public string dniCliente { get; set; }
        public string dirCliente { get; set; }
        public string telCliente { get; set; }
        //tipo gasto
        public string codtipogasto { get; set; }
        public string destipogasto { get; set; }
        //gasto
        public string codgastogeneral { get; set; }
        public string desgasto { get; set; }
        public double montogasto { get; set; }
        public string codPersonalFKGasto { get; set; }
        public string codTipoGastoFKGasto { get; set; }
        public DateTime fechGasto { get; set; }
        //filtrar gasto
        public DateTime fechInicialGasto { get; set; }
        public DateTime fechFinGasto { get; set; }
        //prestamo
        public string codPrestamo { get; set; }
        public string codProveedorFKPrestamo { get; set; }
        public DateTime fechInicioPrestamo { get; set; }
        public DateTime fechDevPrestamo { get; set; }
        public double montoPrestamo { get; set; }
        public string codPersonalFKPrestamo { get; set; }
        public bool estPrestamo { get; set; }
        public int interesPrestamo { get; set; }
        //detalle prestamos
        public string codDetPrestamo { get; set; }
        public string codPrestamoFKDetall { get; set; }
        public double montodetPrestamo { get; set; }
        public double montodetInteres { get; set; }
        public double tipoCambio { get; set; }
        public DateTime fechdetPrestamo { get; set; }
    
        public string desDetPrestamo { get; set; }
        //adelanto
        public string codAdelanto { get; set; }
        public double montoadelanto { get; set; }
        public DateTime fechiniAdelanto { get; set; }
        public string CodPersonalFKAdelanto { get; set; }
        public DateTime fechFinAdelanto { get; set; }
        public bool estAdelanto { get; set; }
        public string CodProveedorFKAdelanto { get; set; }


    }
}
