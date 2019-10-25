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
namespace SisPronaSur.Mantenimiento
{
    public partial class FrmManTipoGasto : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public FrmManTipoGasto()
        {
            InitializeComponent();
        }

        private void FrmManTipoGasto_Load(object sender, EventArgs e)
        {
            try
            {
                listarTipoGasto();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void listarTipoGasto()
        {
            dggasto.DataSource = Negocio.NegListarTipoGasto();
        }
        public void limpiarControles()
        {
            txtcod.Clear();
            txtdes.Clear();
        }
        public void Habilitar_Deshabilitar()
        {
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
            btneditar.Enabled = false;

        }
        public void Deshabilitar_Controles()
        {
            btnregistrar.Enabled = false;
            txtcod.Enabled = false;
            txtdes.Enabled = false;
        }
        public void Deshabilitar_Habilitar()
        {
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;

            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarControles();
                btnregistrar.Enabled = true;
                btncancelar.Enabled = true;
                btneditar.Enabled = false;

                txtdes.Enabled = true;
                txtdes.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea editar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtdes.Enabled = true;
                    Habilitar_Deshabilitar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar_Habilitar();
            Deshabilitar_Controles();
            dggasto_SelectionChanged(sender, e);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dggasto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dggasto.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dggasto.SelectedRows[0].DataBoundItem as DataRowView;
                    txtcod.Text = datarow.Row["codTipoGasto"].ToString();
                    txtdes.Text = datarow.Row["desTipoGasto"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdes.Text == "")
            {
                MessageBox.Show("Debe ingresar el tipo de gasto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            objentidad.codtipogasto = txtcod.Text;
            objentidad.destipogasto = txtdes.Text;
            int rpta = Negocio.NegMantenerTipoGasto(objentidad);
            if (rpta == 1)
            {
                MessageBox.Show("El GASTO fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarTipoGasto();
            }
            else
            {
                MessageBox.Show("Error al registrar el GASTO", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void dggasto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
