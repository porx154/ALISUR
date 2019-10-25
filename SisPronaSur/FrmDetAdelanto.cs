using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisPronaSur
{
    public partial class FrmDetAdelanto : MetroFramework.Forms.MetroForm
    {
        string codigo;
        string estado;

        public FrmDetAdelanto()
        {
            InitializeComponent();
        }

        private void FrmDetAdelanto_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }
        public void cargar_datos()
        {
            txtnomape.Text = Consulta.FrmConsultaAdelanto.nombApe;
            txtfechinicio.Text = Convert.ToDateTime(Consulta.FrmConsultaAdelanto.fechInicio).ToShortDateString();
            txtfechfin.Text = Convert.ToDateTime(Consulta.FrmConsultaAdelanto.fechFin).ToShortDateString();
            txtmontoinicial.Text = Consulta.FrmConsultaAdelanto.montoInicial;
            codigo = Consulta.FrmConsultaAdelanto.codadelanto;
            estado = Consulta.FrmConsultaAdelanto.estado;
        }
        public void deshabilitar_grupo_datos()
        {
            gpdatosadelanto.Enabled = false;
        }
        public void cargar_mensaje()
        {

        }
    }
}
