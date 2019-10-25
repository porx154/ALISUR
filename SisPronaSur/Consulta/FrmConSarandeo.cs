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
namespace SisPronaSur.Consulta
{
    public partial class FrmConSarandeo : MetroFramework.Forms.MetroForm
    {
        double cantactual = 0;
        double cantSarandeada = 0;
        double cantResiduo = 0;
        double sinprocesar = 0;
        
        public FrmConSarandeo()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void cargar_cantactual()
        {
            cantactual = 0;
            try
            {
                if (dgalmacengeneral.Rows.Count > 0)
                {
                    for (int i = 0; i < dgalmacengeneral.Rows.Count; i++)
                    {
                        cantactual += Convert.ToDouble(dgalmacengeneral.Rows[i].Cells[3].Value);
                        //MessageBox.Show(cantactual.ToString());
                    }
                    txtcantactual.Text = Convert.ToString(cantactual);
                }
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
        public void actualizar_datos()
        {
            try
            {
                listarAlmacen();
                cargar_cantactual();
                cargar_cantSarando();
                cargar_sinprocesar();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmConSarandeo_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    listarAlmacen();
                    cargar_cantactual();
                    cargar_cantSarando();
                    cargar_sinprocesar();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizar_datos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnversarandeo_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta.FrmConSarandeoGeneral frmcongen = new FrmConSarandeoGeneral();
                frmcongen.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
