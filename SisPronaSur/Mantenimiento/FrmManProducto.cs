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
    public partial class FrmManProducto : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public FrmManProducto()
        {
            InitializeComponent();
        }

        private void FrmManProducto_Load(object sender, EventArgs e)
        {
            try
            {

                listarProducto();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void listarProducto()
        {
            dgvproducto.DataSource = Negocio.NegListarProducto();
        }


        public void limpiarControles()
        {
            txtcodproducto.Clear();
            txtdespro.Clear();
            txtpreproducto.Clear();
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
            txtcodproducto.Enabled = false;
            txtdespro.Enabled = false;

            txtpreproducto.Enabled = false;
        }
        public void Deshabilitar_Habilitar()
        {
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
            
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
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

        private void dgvproducto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvproducto.SelectedRows.Count > 0)
                {
                    DataRowView dataRow = dgvproducto.SelectedRows[0].DataBoundItem as DataRowView;
                    txtcodproducto.Text = dataRow.Row["CodProducto"].ToString();

                    txtdespro.Text = dataRow.Row["nomProducto"].ToString();
                    txtpreproducto.Text = Convert.ToDouble(dataRow.Row["preProducto"]).ToString("#0.00");
                    
                }
            }
            catch
            {
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
                
                txtdespro.Enabled = true;

                txtpreproducto.Enabled = true;
                txtdespro.Focus();
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
                    txtdespro.Enabled = true;

                    txtpreproducto.Enabled = true;
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
            dgvproducto_SelectionChanged(sender, e);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdespro.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtpreproducto.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            objentidad.CodProducto = txtcodproducto.Text;

            objentidad.nomProducto = txtdespro.Text;
            objentidad.preProducto = Convert.ToDouble(txtpreproducto.Text);
            int rpta = Negocio.NegMantenerProducto(objentidad);
            if (rpta == 1)
            {
                MessageBox.Show("El Producto fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarProducto();
                Deshabilitar_Controles();
            }
            else
            {
                MessageBox.Show("Error al registrar el Producto", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void txtpreproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
