using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
namespace SisPronaSur.Mantenimiento
{
    public partial class FrmManCargo : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public FrmManCargo()
        {
            InitializeComponent();
        }

        private void FrmManCargo_Load(object sender, EventArgs e)
        {
            try
            {
                ListarCargo();
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ListarCargo()
        {
            dgvcargo.DataSource = Negocio.NegListarCargo();
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
        private void dgvcargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcargo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvcargo.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgvcargo.SelectedRows[0].DataBoundItem as DataRowView;
                    txtcod.Text = datarow.Row["CodCargo"].ToString();
                    txtdes.Text = datarow.Row["desCargo"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(txtdes.Text == "")
            {
                MessageBox.Show("Debe ingresar el cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            objentidad.CodCargo = txtcod.Text;
            objentidad.desCargo = txtdes.Text;
            int rpta = Negocio.NegMantenerCargo(objentidad);
            if (rpta == 1)
            {
                MessageBox.Show("El CARGO fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarCargo();
            }
            else
            {
                MessageBox.Show("Error al registrar el CARGO", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
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
            dgvcargo_SelectionChanged(sender, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
