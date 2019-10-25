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
namespace SisPronaSur.Consulta
{
    public partial class FrmBusVentaGeneral : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        public static string codigoventa = "";
        public FrmBusVentaGeneral()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            //MessageBox.Show(dtpfechaventa.Value.ToShortDateString());
        }

        private void chkopcion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkopcion.Checked == false)
            {
                dtpfechaventa.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dtpfechaventa.Enabled = false;
            }else
            {
                cargar_ventaActual();
                dtpfechaventa.Enabled = true;
            }
        }
        public void cargar_ventaActual()
        {
            try
            {
                //dgventageneral.DataSource = Negocio.NegListarVentaActual();
                mtdgventa.DataSource = Negocio.NegListarVentaActual();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmBusVentaGeneral_Load(object sender, EventArgs e)
        {
            try
            {
               
                cargar_ventaActual();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_ventaporfecha(Entidad objEnt)
        {
            try
            {
                //dgventageneral.DataSource = Negocio.NegListarVentaPorFecha(objEnt);
                mtdgventa.DataSource = Negocio.NegListarVentaPorFecha(objEnt);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dtpfechaventa_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                objEnt.fechVenta = Convert.ToDateTime(dtpfechaventa.Value.ToShortDateString());
                cargar_ventaporfecha(objEnt);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgventageneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Consulta.FrmConVentaGeneral frmconventa = new FrmConVentaGeneral();
                //if (dgventageneral.SelectedRows.Count > 0)
                //{
                //    DataRowView datarow = dgventageneral.SelectedRows[0].DataBoundItem as DataRowView;
                //    codigoventa = datarow.Row["CodVenta"].ToString();
                //    //MessageBox.Show(codigoventa);
                //    frmconventa.Show();
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtdgventa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Consulta.FrmConVentaGeneral frmconventa = new FrmConVentaGeneral();
                if (mtdgventa.SelectedRows.Count > 0)
                {
                    DataRowView datarow = mtdgventa.SelectedRows[0].DataBoundItem as DataRowView;
                    codigoventa = datarow.Row["CodVenta"].ToString();
                    //MessageBox.Show(codigoventa);
                    frmconventa.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
