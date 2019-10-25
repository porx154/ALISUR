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
    public partial class FrmManPersonal : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        string codigoPersonal = "";
        public FrmManPersonal()
        {
            InitializeComponent();
        }
        public void cargar_cmbcargo()
        {
            cmbcargoper.DataSource = Negocio.NegListarCargo();
            cmbcargoper.DisplayMember = "desCargo";
            cmbcargoper.ValueMember = "CodCargo";
        }
        public void cargar_cmbsucursal()
        {
            cmbsucursal.DataSource = Negocio.NegListarSucursal();
            cmbsucursal.DisplayMember = "nomSucursal";
            cmbsucursal.ValueMember = "CodSucursal";
        }
        public void listar_personal()
        {
            dgvpersonal.DataSource = Negocio.NegListarPersonal();
        }
        public void buscar_personal(string parametro)
        {
            dgvpersonal.DataSource = Negocio.NegBuscarPersonal(parametro);
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void deshabilitar_controles()
        {
            btnnuevo.Enabled = true;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
            txtnomper.Enabled = false;
            txtapeper.Enabled = false;
            txtdirper.Enabled = false;
            txttelper.Enabled = false;
            txtdniper.Enabled = false;
            txtemailper.Enabled = false;
            txtnomusuarioper.Enabled = false;
            txtpassper.Enabled = false;
            cmbcargoper.Enabled = false;
            cmbsucursal.Enabled = false;
        }
        public void habilitar_controles()
        {
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            txtnomper.Enabled = true;
            txtapeper.Enabled = true;
            txtdirper.Enabled = true;
            txttelper.Enabled = true;
            txtdniper.Enabled = true;
            txtemailper.Enabled = true;
            txtnomusuarioper.Enabled = true;
            txtpassper.Enabled = true;
            cmbcargoper.Enabled = true;
            cmbsucursal.Enabled = true;
        }
        public void limpiar_controles()
        {
            txtnomper.Clear();
            txtapeper.Clear();
            txtdirper.Clear();
            txttelper.Clear();
            txtdniper.Clear();
            txtemailper.Clear();
            txtnomusuarioper.Clear();
            txtpassper.Clear();
        }
        public bool validar_email(string textcorreo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(textcorreo, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        private void FrmManPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_cmbcargo();
                cargar_cmbsucursal();
                listar_personal();
                deshabilitar_controles();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buscar_personal(txtbuscar.Text);
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
                limpiar_controles();
                habilitar_controles();
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
                deshabilitar_controles();
                btnnuevo.Enabled = true;
                limpiar_controles();
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
                if(txtnomper.Text == "")
                {
                    MessageBox.Show("El campo esta NOMBRE esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtapeper.Text == "")
                {
                    MessageBox.Show("El campo esta APELLIDO esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtdniper.Text == "")
                {
                    MessageBox.Show("El campo esta DNI esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txttelper.Text == "")
                {
                    MessageBox.Show("El campo esta TELEFONO esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtnomusuarioper.Text == "")
                {
                    MessageBox.Show("El campo esta NOMBRE DE USUARIO esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtpassper.Text == "")
                {
                    MessageBox.Show("El campo esta CONTRASEÑA esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                objentidad.CodPersonal = codigoPersonal;
                objentidad.nomPersonal = txtnomper.Text;
                objentidad.apePersonal = txtapeper.Text;
                objentidad.dirPersonal = txtdirper.Text;
                objentidad.telPersonal = txttelper.Text;
                objentidad.dniPersonal = txtdniper.Text;
                objentidad.emailPersonal = txtemailper.Text;
                objentidad.nomUsuarioPersonal = txtnomusuarioper.Text;
                objentidad.passPersonal = txtpassper.Text;
                objentidad.CodCargoFKPersonal = cmbcargoper.SelectedValue.ToString();
                objentidad.CodSucursal = cmbsucursal.SelectedValue.ToString();
                int rpta = Negocio.NegMantenerPersonal(objentidad);
                if(rpta == 1)
                {
                    MessageBox.Show("El Personal fue registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar_personal();
                    limpiar_controles();
                    deshabilitar_controles();
                    tabControl1.SelectedTab = tabPage2;
                    
                }else
                {
                    MessageBox.Show("Error al registrar Personal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                codigoPersonal = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtnomper_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapeper_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelper_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txttelper.Text == "")
                {
                    err.SetError(txttelper, "");
                    return;
                }
                if (txttelper.Text.Length != 9)
                {
                    e.Cancel = true;
                    err.SetError(txttelper, "El celular debe tener 9 dígitos");
                }
                else if (txttelper.Text.Substring(0, 1) != "9")
                {
                    e.Cancel = true;
                    err.SetError(txttelper, "El celular debe comenzar con 9");
                }
                else
                {
                    e.Cancel = false;
                    err.SetError(txttelper, "");
                }
            }
            catch
            {
            }
        }

        private void txtdniper_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpassper_Validating(object sender, CancelEventArgs e)
        {
            if (txtpassper.Text.Length < 8)
            {
                e.Cancel = true;
                err.SetError(txtpassper, "La Clave debe tener minimo 8 DIGITOS");
            }
        }

        private void dgvpersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvpersonal_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvpersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvpersonal.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgvpersonal.SelectedRows[0].DataBoundItem as DataRowView;
                    codigoPersonal = datarow.Row["CodPersonal"].ToString();
                    txtnomper.Text = datarow.Row["nomPersonal"].ToString();
                    txtapeper.Text = datarow.Row["apePersonal"].ToString();
                    txtdirper.Text = datarow.Row["dirPersonal"].ToString();
                    txtdniper.Text = datarow.Row["dniPersonal"].ToString();
                    txttelper.Text = datarow.Row["telPersonal"].ToString();
                    txtemailper.Text = datarow.Row["emailPersonal"].ToString();
                    cmbcargoper.Text = datarow.Row["desCargo"].ToString();
                    cmbsucursal.Text = datarow.Row["nomSucursal"].ToString();
                    txtnomusuarioper.Text = datarow.Row["nomUsuarioPersonal"].ToString();
                    txtpassper.Text = datarow.Row["passPersonal"].ToString();
                    habilitar_controles();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdniper_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtdniper.Text.Length == 8)
                {
                    err.SetError(txtdniper, "");
                    return;
                }
                if (txtdniper.Text.Length != 8)
                {
                    e.Cancel = true;
                    err.SetError(txtdniper, "El DNI consta de 8 digitos");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtemailper_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!validar_email(txtemailper.Text))
                {
                    e.Cancel = true;
                    err.SetError(txtemailper, "Debe ingresar un correo válido");
                }
                else
                {
                    e.Cancel = false;
                    err.SetError(txtemailper, "");
                }
            }
            catch
            {
            }
        }

        private void txttelper_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
