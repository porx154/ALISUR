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
namespace SisPronaSur
{
    public partial class FrmVentaGeneral : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        bool tipomoneda = true;
        DataTable dtalmGeneral = new DataTable();
        DataTable dtCliente = new DataTable();
        public FrmVentaGeneral()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void cargar_datoscliente(string parametro)
        {

            objEnt = Negocio.NegBuscarCliente(parametro);
            if(objEnt != null)
            {
                txtnombre.Text = objEnt.nomCliente;
                txtdireccion.Text = objEnt.dirCliente;
            }
            
        }
        public void limpiar_controles()
        {
            txtpesototal.Clear();
            txtphventa.Clear();
            txtvalunitarioventa.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtdnioruc.Clear();
            txtdnioruc.Focus();
        }
        public void habilitar_controles()
        {
            txtpesototal.Enabled = true;
            txtvalunitarioventa.Enabled = true;
            txtphventa.Enabled = true;
            btnnuevo.Enabled = false;
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
        }
        public void deshabilitar_controles()
        {
            txtpesototal.Enabled = false;
            txtvalunitarioventa.Enabled = false;
            txtphventa.Enabled = false;
            btnnuevo.Enabled = true;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
        }
        public void cargar_tipomoneda()
        {
            cmbmoneda.Items.Add("Dolares Americanos");
            cmbmoneda.Items.Add("Soles Peruanos");
            cmbmoneda.SelectedIndex = 0;
        }
        public void cargar_tipoproducto()
        {
            cmbtipoproducto.DataSource = Negocio.NegMostrarTipoProducto();
            cmbtipoproducto.ValueMember = "CodTipoProdcuto";
            cmbtipoproducto.DisplayMember = "desTipoProducto";
        }
        private void txtdnioruc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //cargar_datoscliente(txtdnioruc.Text);
                buscar_cliente(txtdnioruc.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void tipo_moneda()
        {
            if (cmbmoneda.Text == "Dolares Americanos") tipomoneda = true;
            if (cmbmoneda.Text == "Soles Peruanos") tipomoneda = false;
        }
        public void cargar_almacengeneral()
        {
            dtalmGeneral = Negocio.NegMostrarAlmacenGeneral();
        }
        public void carga_temporal_cliente()
        {
            dtCliente = Negocio.NegMostrarCliente();
        }
        public void buscar_cliente(string dniruccliente)
        {
            for(int i = 0; i< dtCliente.Rows.Count; i++)
            {
                if (dtCliente.Rows[i][2].ToString().Trim() == dniruccliente)
                {
                    objEnt.CodCliente = dtCliente.Rows[i][0].ToString();
                    txtnombre.Text = dtCliente.Rows[i][1].ToString();
                    txtdireccion.Text = dtCliente.Rows[i][3].ToString();
                    //MessageBox.Show(dtCliente.Rows[i][1].ToString());
                    break;
                }
                //MessageBox.Show(dtCliente.Rows[i][2].ToString());
            }
        }
        private void FrmVentaGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                carga_temporal_cliente();
                cargar_tipomoneda();
                cargar_tipoproducto();
                cargar_almacengeneral();
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

                //buscar_cliente(txtdnioruc.Text);
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
        public bool validar_vacios(TextBox txtnom, TextBox txtdir, TextBox txtpeso, TextBox txtvalor, TextBox txtph)
        {
            if(txtnom.Text == "")
            {
                err.Clear();
                err.SetError(txtnom, "Campo Nombre Vacio");
                return false;
            }else if (txtdir.Text == "")
            {
                err.Clear();
                err.SetError(txtdir, "Campo Direccion Vacio");
                return false;
            }else if (txtpeso.Text == "")
            {
                err.Clear();
                err.SetError(txtpeso, "Campo Peso Vacio");
                return false;
            }else if(txtvalor.Text == "")
            {
                err.Clear();
                err.SetError(txtvalor, "Campo Valor Unitario Vacio");
                return false;
            }else if(txtph.Text == "")
            {
                err.Clear();
                err.SetError(txtph, "Campo PH Vacio");
                return false;
            }else
            {
                err.Clear();
                return true;
            }
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                tipo_moneda();
                
                
                if (validar_vacios(txtnombre, txtdireccion, txtpesototal, txtvalunitarioventa, txtphventa) && dtalmGeneral.Rows.Count>0)
                {
                    objEnt.CodVenta = "";
                    objEnt.tipoMoneda = tipomoneda;
                    objEnt.CodTipoProductoFKVentaGeneral = cmbtipoproducto.SelectedValue.ToString();
                    objEnt.pesoTotalVenta = Convert.ToDouble(txtpesototal.Text);
                    objEnt.precioUnitarioVenta = Convert.ToDouble(txtvalunitarioventa.Text);
                    objEnt.phVenta = Convert.ToDouble(txtphventa.Text);
                    objEnt.CodClienteFKVentaGeneral = objEnt.CodCliente;
                    objEnt.CodPersonalFKVentaGeneral = Acesso.FrmPorxLogin.CodPersonal;
                    objEnt.CodSucursalFKVentaGeneral = Acesso.FrmPorxLogin.CodSucursal;
                    int rpta = Negocio.NegMantenerVentaGeneral(objEnt);
                    if (rpta == 1)
                    {
                        MessageBox.Show("Se ha registrado una Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_controles();
                        deshabilitar_controles();
                    } else
                    {
                        MessageBox.Show("Error al registrar Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else
                {
                    MessageBox.Show("No hay Cantidad en Almacen General", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtpesototal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtvalunitarioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtphventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
