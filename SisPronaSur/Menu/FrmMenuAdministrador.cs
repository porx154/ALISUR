using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisPronaSur.Menu
{
    public partial class FrmMenuAdministrador : MetroFramework.Forms.MetroForm
    {
        public static int saldoTienda = 0;
        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }
        
        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            try
            {
                mtlblusuario.Text = Acesso.FrmPorxLogin.NomPersonal;
                
                mtlblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        private void tmrmenu_Tick(object sender, EventArgs e)
        {
            try
            {
                mtlblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtncompras_Click(object sender, EventArgs e)
        {
            try
            {
                using ( Consulta.FrmConCompras  frmconcompra = new Consulta.FrmConCompras())
                {
                    frmconcompra.ShowDialog();
                };

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtncaja_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmCaja frmcaja = new FrmCaja())
                {
                    frmcaja.ShowDialog();
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
                using (Consulta.FrmConAlmTiendaAdmin frmalmacentienda = new Consulta.FrmConAlmTiendaAdmin())
                {
                    frmalmacentienda.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsarandeo_Click(object sender, EventArgs e)
        {
            try
            {
                using (Consulta.FrmConSarandeo frmconsa = new Consulta.FrmConSarandeo())
                {
                    frmconsa.ShowDialog();
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
                using (Consulta.FrmConProveedor frmconprove = new Consulta.FrmConProveedor())
                {
                    frmconprove.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnpersonal_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManPersonal frmmanpersonal = new Mantenimiento.FrmManPersonal())
                {
                    frmmanpersonal.ShowDialog();
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
                using (Mantenimiento.FrmManProveedor frmmanprovee = new Mantenimiento.FrmManProveedor())
                {
                    frmmanprovee.ShowDialog();
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
                using (Consulta.FrmBusVentaGeneral frmbusventa = new Consulta.FrmBusVentaGeneral())
                {
                    frmbusventa.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtncargo_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManCargo frmcargo = new Mantenimiento.FrmManCargo())
                {
                    frmcargo.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnproducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManProducto frmproducto = new Mantenimiento.FrmManProducto())
                {
                    frmproducto.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtntipoproducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManTipoProducto frmtipoproducto = new Mantenimiento.FrmManTipoProducto())
                {
                    frmtipoproducto.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsucursal_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmSucursal frmsucursal = new Mantenimiento.FrmSucursal())
                {
                    frmsucursal.ShowDialog();
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
                using (FrmRegGasto frmgasto = new FrmRegGasto())
                {
                    frmgasto.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmPrestamo frmprestamo = new FrmPrestamo())
                {
                    frmprestamo.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                using (Consulta.FrmConGasto frmcongasto = new Consulta.FrmConGasto())
                {
                    frmcongasto.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mantenimiento.FrmManTipoGasto frmtipogasto = new Mantenimiento.FrmManTipoGasto())
                {
                    frmtipogasto.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {
                using (Consulta.FrmConPrestamo frmconpretamo= new Consulta.FrmConPrestamo())
                {
                    frmconpretamo.ShowDialog();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
