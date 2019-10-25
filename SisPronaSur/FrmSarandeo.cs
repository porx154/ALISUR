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
    public partial class FrmSarandeoAlmacen : MetroFramework.Forms.MetroForm
    {
        //Negocio objnegocio = new Negocio();
        double cantactual=0;
        double cantSarandeada=0;
        double cantResiduo=0;
        double sinprocesar = 0;
        public static double CantASarandear=0;
        Entidad objentidad = new Entidad();
        public FrmSarandeoAlmacen()
        {
            InitializeComponent();
        }

        private void FrmSarandeo_Load(object sender, EventArgs e)
        {
            try
            {
                listarAlmacen();
                txtsarandear.Focus();
                cargar_cantactual();
                cargar_cantSarando();
                cargar_sinprocesar();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_cantactual()
        {
            try
            {
                for (int i = 0; i < dgalmacengeneral.Rows.Count; i++)
                {
                    cantactual += Convert.ToDouble(dgalmacengeneral.Rows[i].Cells[3].Value);
                    //MessageBox.Show(cantactual.ToString());
                }
                txtcantactual.Text = Convert.ToString(cantactual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_cantSarando()
        {
            try
            {
                cantSarandeada = Negocio.NegCantTotSarandeo();
                txtcantsarandeo.Text = Convert.ToString(cantSarandeada);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_sinprocesar()
        {
            try
            {
                sinprocesar = cantactual - cantSarandeada;
                txtsinprocesar.Text = Convert.ToString(sinprocesar);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void listarAlmacen()
        {
            try
            {
                dgalmacengeneral.DataSource = Negocio.NegListarAlmGeneral();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtsarandear.Clear();
                txtsarandear.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cantResiduo = cantactual - cantSarandeada;
                if (txtsarandear.Text == "")
                {
                    MessageBox.Show("Campo Invalido o Vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                CantASarandear = Convert.ToDouble(txtsarandear.Text);
                
                if(CantASarandear > cantResiduo)
                {
                    MessageBox.Show("La cantida a SARANDEAR es superior a la CANTIDAD en el ALMACEN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    FrmAlmacenGeneral frmalgen = new FrmAlmacenGeneral();
                    frmalgen.Show();
                  
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtsarandear_Validating(object sender, CancelEventArgs e)
        {
            //if (txtsarandear.Text == "")
            //{
            //    err.SetError(txtsarandear, "Campo vacio");
            //    e.Cancel = true;
            //    return;
            //}
        }

        private void txtsarandear_KeyPress(object sender, KeyPressEventArgs e)
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
