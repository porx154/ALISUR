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
    public partial class FrmSucursal : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        string CodSucursal = "";
        public FrmSucursal()
        {
            InitializeComponent();
        }
        public void cargar_sucursal()
        {
            try
            {
                dgsucursal.DataSource = Negocio.NegListarSucursal();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void limpiar_controles()
        {
            txtnomsucursal.Clear();
            txtrucsucursal.Clear();
            txttelsucursal.Clear();
            txtdirsucursal.Clear();
            txtnomsucursal.Focus();
        }
        public void habilitar_controles()
        {
            txtnomsucursal.Enabled = true;
            txtrucsucursal.Enabled = true;
            txttelsucursal.Enabled = true;
            txtdirsucursal.Enabled = true;
            btnnuevo.Enabled = false;
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;

        }
        public void deshabilitar_controles()
        {
            txtnomsucursal.Enabled = false;
            txtrucsucursal.Enabled = false;
            txttelsucursal.Enabled = false;
            txtdirsucursal.Enabled = false;
            btnnuevo.Enabled = true;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
        }
        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal();
            }
            catch (Exception)
            {

                throw;
            }
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
                err.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool validar_texto_vacio()
        {
            if (txtnomsucursal.Text == "")
            {
                return true;
            }else if(txttelsucursal.Text == "")
            {
                return true;
            }else if(txtrucsucursal.Text == "")
            {
                return true;
            }else if(txtdirsucursal.Text == "")
            {
                return true;
            }else if(txttelsucursal.Text.Length > 9)
            {
                MessageBox.Show("El campo TELEFONO tiene mas de 9 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }else if(txtrucsucursal.Text.Length > 11)
            {
                MessageBox.Show("El campo RUC tiene mas de 11 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar_texto_vacio()) return;
                objEnt.CodSucursalS = CodSucursal;
                objEnt.nomSucursal = txtnomsucursal.Text;
                objEnt.telSucursal = txttelsucursal.Text;
                objEnt.dirSucursal = txtdirsucursal.Text;
                objEnt.rucSucursal = txtrucsucursal.Text;
                int rpta = Negocio.NegMantenerSucursal(objEnt);
                if(rpta == 1)
                {
                    MessageBox.Show("Se registro una SUCURSAL", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_controles();
                    deshabilitar_controles();
                    cargar_sucursal();
                    err.Clear();
                }
                else
                {
                    MessageBox.Show("Error al REGISTRAR SUCURSAL", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txttelsucursal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrucsucursal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnomsucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if(txtnomsucursal.Text == "")
                {
                    err.SetError(txtnomsucursal, "Campo Vacio");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txttelsucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txttelsucursal.Text == "")
                {
                    err.SetError(txttelsucursal, "Campo Vacio");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdirsucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtdirsucursal.Text == "")
                {
                    err.SetError(txtdirsucursal, "Campo Vacio");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtrucsucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtrucsucursal.Text == "")
                {
                    err.SetError(txtrucsucursal, "Campo Vacio");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgsucursal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgsucursal.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgsucursal.SelectedRows[0].DataBoundItem as DataRowView;
                    CodSucursal = datarow.Row["CodSucursal"].ToString();
                    txtnomsucursal.Text = datarow.Row["nomSucursal"].ToString();
                    txtdirsucursal.Text = datarow.Row["dirSucursal"].ToString();
                    txtrucsucursal.Text = datarow.Row["rucSucursal"].ToString();
                    txttelsucursal.Text = datarow.Row["telSucursal"].ToString();
                    habilitar_controles();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
