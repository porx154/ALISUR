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
namespace SisPronaSur
{
    public partial class FrmAlmacenGeneral : MetroFramework.Forms.MetroForm
    {
        double primera = 0;
        double segunda = 0;
        double polvillo = 0;
        double merma = 0;
        Entidad objEnt = new Entidad();
        public FrmAlmacenGeneral()
        {
            InitializeComponent();
        }

        private void FrmAlmacenGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(cantidad.ToString());
                cargar_cantidad();
                listar_sarandeo();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void listar_sarandeo()
        {
            try
            {
                dgsarandeo.DataSource = Negocio.NegListarSarandeo();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_cantidad()
        {
            try
            {
                txtsarandear.Text = Convert.ToString(FrmSarandeoAlmacen.CantASarandear);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtmerma.Text) < 0)
                {
                    MessageBox.Show("Dato invalido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmerma.Text = Convert.ToString(0);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void calcularMerma()
        {
            try
            {
                primera = Convert.ToDouble(txtprimera.Text);
                segunda = Convert.ToDouble(txtsegunda.Text);
                polvillo = Convert.ToDouble(txtpolvillo.Text);
                validar_campo();
                merma = Convert.ToDouble(txtsarandear.Text) - (primera + segunda + polvillo);
                txtmerma.Text = Convert.ToString(merma);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void validar_campo()
        {
            if(txtprimera.Text == "")
            {
                primera = 0;
            }
            if (txtsegunda.Text == "")
            {
                primera = 0;
            }
            if (txtpolvillo.Text == "")
            {
                primera = 0;
            }
        }
        private void txtpolvillo_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //primera = Convert.ToDouble(txtprimera.Text);
                //segunda = Convert.ToDouble(txtsegunda.Text);
                //if (txtpolvillo.Text == "") return;
                //polvillo = Convert.ToDouble(txtpolvillo.Text);
                if (txtpolvillo.Text == "") return;
                calcularMerma();    
                //merma = FrmSarandeoAlmacen.CantASarandear - (primera + segunda + polvillo);
                //txtmerma.Text = Convert.ToString(merma);

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

        private void txtsegunda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsegunda.Text == "") return;
                calcularMerma();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtprimera_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprimera.Text == "") return;
                calcularMerma();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void habilitar_controles()
        {
            txtprimera.Enabled = true;
            txtsegunda.Enabled = true;
            txtpolvillo.Enabled = true;
            btnnuevo.Enabled = false;
            btnregistrar.Enabled = true;
            btncancelar.Enabled = true;
            
        }
        public void deshabilitar_controles()
        {
            txtprimera.Enabled = false;
            txtsegunda.Enabled = false;
            txtpolvillo.Enabled = false;
            btnnuevo.Enabled = true;
            btnregistrar.Enabled = false;
            btncancelar.Enabled = false;
        }
        public void limpiar_controles()
        {
            txtprimera.Text = Convert.ToString(0);
            txtsegunda.Text = Convert.ToString(0);
            txtpolvillo.Text = Convert.ToString(0);
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalirconsulta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
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

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtprimera.Text == "" || txtsegunda.Text == "" || txtpolvillo.Text == "")
                {
                    MessageBox.Show("Algun campo esta Vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                objEnt.CodSarandeo = "";
                objEnt.CantSarandeo = Convert.ToDouble(txtsarandear.Text);
                objEnt.SaPrimera = Convert.ToDouble(txtprimera.Text);
                objEnt.SaSegunda = Convert.ToDouble(txtsegunda.Text);
                objEnt.SaPolvillo = Convert.ToDouble(txtpolvillo.Text);
                objEnt.SaMerma = Convert.ToDouble(txtpolvillo.Text);
                objEnt.CodPersonalFKSarandeo = Acesso.FrmPorxLogin.CodPersonal;
                int rpta = Negocio.NegMantenerSarandeo(objEnt);
                if (rpta == 1)
                {
                    MessageBox.Show("Se inserto un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //listar_personal();
                    limpiar_controles();
                    deshabilitar_controles();
                    listar_sarandeo();
                    tabControl1.SelectedTab = tabPage2;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
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

        private void dgsarandeo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgsarandeo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgsarandeo.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgsarandeo.SelectedRows[0].DataBoundItem as DataRowView;
                    txtsarandear.Text = datarow.Row["CantSarandeo"].ToString();
                    txtprimera.Text = datarow.Row["SaPrimera"].ToString();
                    txtsegunda.Text = datarow.Row["SaSegunda"].ToString();
                    txtpolvillo.Text = datarow.Row["SaPolvillo"].ToString();
                    txtmerma.Text = datarow.Row["SaMerma"].ToString();
                    //solo administrador wa modificar
                    deshabilitar_controles();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtprimera_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsegunda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpolvillo_KeyPress(object sender, KeyPressEventArgs e)
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
