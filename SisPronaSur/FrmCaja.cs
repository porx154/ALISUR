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
using System.Security.Cryptography;
namespace SisPronaSur
{
    public partial class FrmCaja : MetroFramework.Forms.MetroForm
    {
        Negocio ObjNegocio = new Negocio();
        Entidad objEnt = new Entidad();
        string CodCaja = "";
        public FrmCaja()
        {
            InitializeComponent();
        }
        public void cargar_sucursal()
        {
            try
            {
                cmbsucursal.DataSource = Negocio.NegListarSucursal();
                cmbsucursal.DisplayMember = "nomSucursal";
                cmbsucursal.ValueMember = "CodSucursal";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btnsalircon_Click(object sender, EventArgs e)
        {

        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal();
                rdbIngreso.Checked = true;
                listar_caja(cmbsucursal.SelectedValue.ToString());
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void hablilitar_controles()
        {
            txtmontocaja.Enabled = true;
            txtnrooperacion.Enabled = true;
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            //cmbsucursal.Enabled = true;
        }
        public void deshabilitar_controles()
        {
            txtmontocaja.Enabled = false;
            txtnrooperacion.Enabled = false;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
            btnnuevo.Enabled = true;
        }
        public void limpiar_controles()
        {
            txtmontocaja.Clear();
            txtnrooperacion.Clear();
            txtmontocaja.Focus();
        }
        public void listar_caja(string codSucursal)
        {
            try
            {
                objEnt.CodSucursalFKCaja = codSucursal;
                if(rdbIngreso.Checked == true)
                {
                    dgcaja.Columns[3].Visible = true;
                    dgcaja.DataSource = Negocio.NegListarCajaIngresos(objEnt);
                }else if(rdbRetiro.Checked == true)
                {
                    dgcaja.Columns[3].Visible = false;
                    dgcaja.DataSource = Negocio.NegListarCajaRetiros(objEnt);
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
                hablilitar_controles();
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
                limpiar_controles();
                cmbsucursal.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            try
            {
                //int longitud = 10;
                //Guid miGuid = Guid.NewGuid();
                //string token = Convert.ToBase64String(miGuid.ToByteArray());
                //token = token.Replace("=", "").Replace("+", "");
                //MessageBox.Show(token.Substring(0, longitud));
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rdbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listar_caja(cmbsucursal.SelectedValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rdbRetiro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listar_caja(cmbsucursal.SelectedValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listar_caja(cmbsucursal.SelectedValue.ToString());
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
                if(txtmontocaja.Text == "" || txtnrooperacion.Text == "")
                {
                    MessageBox.Show("Existen Campos Vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                objEnt.CodCaja = CodCaja;
                objEnt.montoCaja = Convert.ToDouble(txtmontocaja.Text);
                objEnt.NroOperacion = txtnrooperacion.Text;
                objEnt.CodSucursalFKCaja = cmbsucursal.SelectedValue.ToString();
                objEnt.CodPersonalFKCaja = Acesso.FrmPorxLogin.CodPersonal;
                int rpta = Negocio.NegMantenerCaja(objEnt);
                if(rpta == 1)
                {
                    listar_caja(cmbsucursal.SelectedValue.ToString());
                    MessageBox.Show("Se registro un INGRESO de "+txtmontocaja.Text+" S/.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_controles();
                    deshabilitar_controles();
                    if(Acesso.FrmPorxLogin.Cargo !="Administrador") SisPronaSur.Menu.FrmMenuUAdmin.cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                   
                }
                else
                {
                    MessageBox.Show("No se pudo registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtmontocaja_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnrooperacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgcaja_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                //cmbsucursal.Enabled = false;
                if (rdbIngreso.Checked == false)
                {
                    MessageBox.Show("Solo se puede Modificar Los INGRESOS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_controles();
                    deshabilitar_controles();
                    return;
                }
                cmbsucursal.Enabled = false;
                if (dgcaja.SelectedRows.Count > 0)
                {
                    
                    DataRowView datarow = dgcaja.SelectedRows[0].DataBoundItem as DataRowView;
                    CodCaja = datarow.Row["CodCaja"].ToString();
                    txtmontocaja.Text = datarow.Row["montoCaja"].ToString();
                    txtnrooperacion.Text = datarow.Row["NroOperacion"].ToString();

                    hablilitar_controles();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
