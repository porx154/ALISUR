using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisPronaSur.Menu
{
    public partial class FrmMenuAlmacenero : MetroFramework.Forms.MetroForm
    {
        public FrmMenuAlmacenero()
        {
            InitializeComponent();
        }

        private void FrmMenuAlmacenero_Load(object sender, EventArgs e)
        {
            try
            {
                mtlblusuario.Text = Acesso.FrmPorxLogin.NomPersonal;
                mtlblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnalmacen_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmAlmGenConfirm frmconfirm = new FrmAlmGenConfirm())
                {
                    frmconfirm.ShowDialog();
                };

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsarandeo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSarandeoAlmacen frmsaalgen = new FrmSarandeoAlmacen())
                {
                    frmsaalgen.ShowDialog();
                };

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtbtnayuda_Click(object sender, EventArgs e)
        {
            try
            {
                using (Consulta.FrmAyuda frmayuda = new Consulta.FrmAyuda())
                {
                    frmayuda.ShowDialog();
                };

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
