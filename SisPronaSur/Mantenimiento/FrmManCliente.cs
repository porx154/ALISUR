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
    public partial class FrmManCliente : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        string codigocliente = "";
        public FrmManCliente()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            habilitar_controles();
        }
        public void limpiar_controles()
        {
            txtnombcliente.Clear();
            txtrucdnicliente.Clear();
            txtdircliente.Clear();
            txttelcliente.Clear();
            txtnombcliente.Focus();
        }
        public void habilitar_controles()
        {
            txtnombcliente.Enabled = true;
            txtrucdnicliente.Enabled = true;
            txtdircliente.Enabled = true;
            txttelcliente.Enabled = true;
            btnnuevo.Enabled = false;
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
        }
        public void deshabilitar_controles()
        {
            txtnombcliente.Enabled = false;
            txtrucdnicliente.Enabled = false;
            txtdircliente.Enabled = false;
            txttelcliente.Enabled = false;
            btnnuevo.Enabled = true;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
        }
        public bool validar_vacio(TextBox txtnombre,TextBox txtruc,TextBox txtdir,TextBox txttelefono)
        {
            if (txtnombre.Text == "")
            {
                err.Clear();
                err.SetError(txtnombre, "Campo Nombre Vacio");
                return false;
            }
            else if (txtruc.Text == "")
            {
                err.Clear();
                err.SetError(txtruc, "Campo Ruc/DNI Vacio");
                return false;
            }
            else if (txtdir.Text == "")
            {
                err.Clear();
                err.SetError(txtdir, "Campo Direccion Vacio");
                return false;
            }
            else if (txttelefono.Text == "")
            {
                err.Clear();
                err.SetError(txttelefono, "Campo Telefono Vacio");
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
        }
        public void cargar_cliente()
        {
            try
            {
                objEnt.rucCliente = "";
                dgcliente.DataSource = Negocio.NegFiltrarCliente(objEnt);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmManCliente_Load(object sender, EventArgs e)
        {
            try
            {
                
                cargar_cliente();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtrucdnicliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelcliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbuscliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objEnt.rucCliente = txtbuscliente.Text;
                dgcliente.DataSource = Negocio.NegFiltrarCliente(objEnt);
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
                if (validar_vacio(txtnombcliente, txtrucdnicliente, txtdircliente, txttelcliente))
                {
                    objEnt.CodCliente = codigocliente;
                    objEnt.nomCliente = txtnombcliente.Text;
                    objEnt.rucCliente = txtrucdnicliente.Text;
                    objEnt.dirCliente = txtdircliente.Text;
                    objEnt.telCliente = txttelcliente.Text;
                    int rpta = Negocio.NegMantenerCliente(objEnt);
                    if (rpta == 1)
                    {
                        MessageBox.Show("Se ha registrado un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_controles();
                        deshabilitar_controles();
                        cargar_cliente();
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else
                {
                    return;
                }
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

        private void dgcliente_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgcliente.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgcliente.SelectedRows[0].DataBoundItem as DataRowView;
                    codigocliente = datarow.Row["CodCliente"].ToString();
                    txtnombcliente.Text= datarow.Row["nombCliente"].ToString();
                    txtrucdnicliente.Text = datarow.Row["rucCliente"].ToString();
                    txttelcliente.Text = datarow.Row["telCliente"].ToString();
                    txtdircliente.Text = datarow.Row["dirCliente"].ToString();
                    

                    habilitar_controles();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
