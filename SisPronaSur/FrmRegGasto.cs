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
    public partial class FrmRegGasto : MetroFramework.Forms.MetroForm
    {
        Entidad objEntidad = new Entidad();
        public string codigoGasto = "";
        public double montoGasto = 0;
        public string tipoGasto = "";
        public string desGasto = "";
        public FrmRegGasto()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRegGasto_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_tipogasto();
                cargar_datos_modificar();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_datos_modificar()
        {
            //obteniendo datos de gastos
            txtmontogasto.Text = Convert.ToString(montoGasto);
            cmbgasto.Text = tipoGasto;
            txtdesgasto.Text = desGasto;
            habilitar_control();
        }
        public void cargar_tipogasto()
        {
            try
            {
                cmbgasto.DataSource = Negocio.NegMostrarTipoGasto();
                cmbgasto.DisplayMember = "desTipoGasto";
                cmbgasto.ValueMember = "codTipoGasto";
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void limpiar_control()
        {
            try
            {
                txtmontogasto.Text = Convert.ToString(0);
                txtdesgasto.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void habilitar_control()
        {
            try
            {
                txtdesgasto.Enabled = true;
                txtmontogasto.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deshabilitar_control()
        {
            try
            {
                txtdesgasto.Enabled = false;
                txtmontogasto.Enabled = false;
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
                habilitar_control();
                limpiar_control();

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
                limpiar_control();
                deshabilitar_control();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string convertMonto;
            
            try
            {
                objEntidad.codgastogeneral = codigoGasto;
                //replace
                convertMonto = txtmontogasto.Text;
                
                objEntidad.montogasto = Convert.ToDouble(convertMonto.Replace(".",","));
                objEntidad.desgasto = txtdesgasto.Text;
                objEntidad.codPersonalFKGasto = Acesso.FrmPorxLogin.CodPersonal;
                objEntidad.codTipoGastoFKGasto = cmbgasto.SelectedValue.ToString();
                if(txtmontogasto.Text == "" || txtmontogasto.Text == "0")
                {
                    MessageBox.Show("Debe ingresar el monto/el monto debe ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (txtdesgasto.Text == "")
                {
                    MessageBox.Show("Debe ingresar la descripcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    int rpta = Negocio.NegMantenerGasto(objEntidad);
                    if(rpta == 1)
                    {
                        MessageBox.Show("Registro Completo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_control();
                    } else
                    {
                        MessageBox.Show("Se produjo un error al registrar dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtmontogasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cambiar el , por el .
            //e.KeyChar == 46 ||
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')> -1))
            {
                e.Handled = true;
            }
        }
    }
}
