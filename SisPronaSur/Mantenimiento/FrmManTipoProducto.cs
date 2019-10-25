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
    public partial class FrmManTipoProducto : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public FrmManTipoProducto()
        {
            InitializeComponent();
        }
        public void ListarTipoProducto(string codproducto)
        {
            objentidad.CodProductoFKTipo = codproducto;
            dgvtipopro.DataSource = Negocio.NegListarTipoProducto(objentidad);
        }
        public void cargar_combo()
        {
            cmbproducto.DataSource = Negocio.NegListarProducto();
            cmbproducto.DisplayMember = "nomProducto";
            cmbproducto.ValueMember = "CodProducto";
        }
        public void limpiarControles()
        {
            txtcod.Clear();
            txtdestipro.Clear();
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
            txtdestipro.Enabled = false;
        }
        public void Deshabilitar_Habilitar()
        {
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
           
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
        }
        private void FrmManTipoProducto_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
                ListarTipoProducto(cmbproducto.SelectedValue.ToString());
                //Deshabilitar_Controles();
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
                
                txtdestipro.Enabled = true;
                txtdestipro.Focus();
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
                    txtdestipro.Enabled = true;
                    Habilitar_Deshabilitar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdestipro.Text == "")
            {
                MessageBox.Show("Debe ingresar el cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            objentidad.CodTipoProducto = txtcod.Text;
            objentidad.desTipoProducto = txtdestipro.Text;
            int rpta = Negocio.NegMantenerTipoProducto(objentidad);
            if (rpta == 1)
            {
                MessageBox.Show("El Tipo de Producto fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarTipoProducto(cmbproducto.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Error al registrar el Tipo de Producto", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar_Habilitar();
            Deshabilitar_Controles();
            dgvtipopro_SelectionChanged(sender, e);
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

        private void dgvtipopro_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvtipopro.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgvtipopro.SelectedRows[0].DataBoundItem as DataRowView;
                    txtcod.Text = datarow.Row["CodTipoProdcuto"].ToString();
                    txtdestipro.Text = datarow.Row["desTipoProducto"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbproducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListarTipoProducto(cmbproducto.SelectedValue.ToString());
        }
    }
}
