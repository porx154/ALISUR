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
    public partial class FrmManProveedor : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public FrmManProveedor()
        {
            InitializeComponent();
        }
        public void habilitar_controles()
        {
            txtnompro.Enabled = true;
            txtapepro.Enabled = true;
            txtdnipro.Enabled = true;
            txtrucpro.Enabled = true;
            txttelpro.Enabled = true;
            txtdirpro.Enabled = true;
            btncancelar.Enabled = true;
            btnregistrar.Enabled = true;
            btnnuevo.Enabled = false;
        }
        public void limpiar_controles()
        {
            txtnompro.Clear();
            txtapepro.Clear();
            txtdnipro.Clear();
            txtrucpro.Clear();
            txttelpro.Clear();
            txtdirpro.Clear();
        }
        public void deshabilitar_controles()
        {
            txtnompro.Enabled = false;
            txtapepro.Enabled = false;
            txtdnipro.Enabled = false;
            txtrucpro.Enabled = false;
            txttelpro.Enabled = false;
            txtdirpro.Enabled = false;
            btncancelar.Enabled = false;
            btnregistrar.Enabled = false;
            btnnuevo.Enabled = true;
        }
        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                habilitar_controles();
                limpiar_controles();
                limpiar_temporal();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {
                
                limpiar_controles();
                deshabilitar_controles();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnompro.Text == "")
                {
                    MessageBox.Show("Debe ingresar el NOMBRE del proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtapepro.Text == "")
                {
                    MessageBox.Show("Debe ingresar el APELLIDO del proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtdnipro.Text == "")
                {
                    MessageBox.Show("Debe ingresar el DNI del proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (txtdnipro.Text == "")
                {
                    MessageBox.Show("Debe ingresar la DIRECCION del proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                objentidad.CodProveedor = txtcodpro.Text;
                objentidad.nomProveedor = txtnompro.Text;
                objentidad.apeProveedor = txtapepro.Text;
                objentidad.dniProveedor = txtdnipro.Text;
                objentidad.rucProveedor = txtrucpro.Text;
                objentidad.telProveedor = txttelpro.Text;
                objentidad.dirProveedor = txtdirpro.Text;
                int rpt = Negocio.NegMantenerProveedor(objentidad);
                if(rpt == 1)
                {
                    MessageBox.Show("El Proveedor fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_controles();
                    deshabilitar_controles();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void limpiar_temporal()
        {
            Consulta.FrmConProveedor.CodProveedor="";
            Consulta.FrmConProveedor.nomProveedor="";
            Consulta.FrmConProveedor.apeProveedor="";
            Consulta.FrmConProveedor.dniProveedor="";
            Consulta.FrmConProveedor.rucProveedor="";
            Consulta.FrmConProveedor.telProveedor="";
            Consulta.FrmConProveedor.dirProveedor="";
        }
        private void FrmManProveedor_Load(object sender, EventArgs e)
        {
            txtcodpro.Text = Consulta.FrmConProveedor.CodProveedor;
            txtnompro.Text = Consulta.FrmConProveedor.nomProveedor;
            txtapepro.Text = Consulta.FrmConProveedor.apeProveedor;
            txtdnipro.Text = Consulta.FrmConProveedor.dniProveedor;
            txtrucpro.Text = Consulta.FrmConProveedor.rucProveedor;
            txttelpro.Text = Consulta.FrmConProveedor.telProveedor;
            txtdirpro.Text = Consulta.FrmConProveedor.dirProveedor;
        }

        private void txtnompro_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtdnipro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtdnipro.Text == "")
                {
                    err.SetError(txtdnipro, "");
                    return;
                }
                if(txtdnipro.Text.Length != 8)
                {
                    e.Cancel = true;
                    err.SetError(txtdnipro, "El DNI tiene 8 DIGITOS");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdnipro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
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

        private void txtrucpro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtrucpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
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

        private void txttelpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
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

        private void txtrucpro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtrucpro.Text == "")
                {
                    err.SetError(txtrucpro, "");
                    return;
                }
                if (txtrucpro.Text.Length != 11)
                {
                    e.Cancel = true;
                    err.SetError(txtrucpro, "El RUC tiene 11 DIGITOS");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txttelpro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txttelpro.Text == "")
                {
                    err.SetError(txttelpro, "");
                    return;
                }
                if (txttelpro.Text.Length != 9)
                {
                    e.Cancel = true;
                    err.SetError(txttelpro, "El TELEFONO tiene 11 DIGITOS");
                }
                else if (txttelpro.Text.Substring(0, 1) != "9")
                {
                    e.Cancel = true;
                    err.SetError(txttelpro, "El TELEFONO debe comenzar con 9");
                }
                else
                {
                    e.Cancel = false;
                    err.SetError(txttelpro, "");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtnompro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Debe ingresar sólo letras", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        private void txtapepro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Debe ingresar sólo letras", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }
    }
}
