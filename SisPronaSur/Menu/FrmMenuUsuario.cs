using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
namespace SisPronaSur.Menu
{
    public partial class FrmMenuUsuario : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        public static double saldoTienda = 0;
        public static FrmMenuUsuario mdi;
        public FrmMenuUsuario()
        {
            InitializeComponent();
            FrmMenuUsuario.mdi = this;
        }
        public static bool listarsaldo(string codigo, TextBox txt)
        {
            saldoTienda = Negocio.NegListarSaldoTienda(codigo);
            txt.Text = Convert.ToString(saldoTienda);
            if (saldoTienda <= 1000) MessageBox.Show("Queda poco saldo en la CAJA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public static void cargar_saldo(string codSucursal)
        {
            try
            {

                listarsaldo(codSucursal, mdi.txtsaldotienda);
                //saldo.txtsaldotienda.Text = Convert.ToString(listarsaldo(codSucursal));



            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmMenuUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                mtlblusuario.Text = Acesso.FrmPorxLogin.NomPersonal;
                mtlblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtbtncompras_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                using (FrmVentas frmventcompra = new FrmVentas())
                {
                    frmventcompra.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void mtbtnalmacen_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                using (FrmAlmacen frmalmacen = new FrmAlmacen())
                {
                    frmalmacen.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                using (Mantenimiento.FrmManProveedor frmproveedor = new Mantenimiento.FrmManProveedor())
                {
                    frmproveedor.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtncliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManCliente frmcliente = new Mantenimiento.FrmManCliente())
                {
                    frmcliente.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnconproveedor_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                using (Consulta.FrmConProveedor frmconproveedor = new Consulta.FrmConProveedor())
                {
                    frmconproveedor.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            try
            {
                using(Consulta.FrmBusVentaGeneral frmbusventa = new Consulta.FrmBusVentaGeneral())
                {
                    frmbusventa.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmVentaGeneral frmventa = new FrmVentaGeneral())
                {
                    frmventa.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnayuda_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
