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
    public partial class FrmConsultaAdelanto : MetroFramework.Forms.MetroForm
    {
        Entidad objEntidad = new Entidad();
        public static string codadelanto;
        public static string nombApe;
        public static string fechInicio;
        public static string fechFin;
        public static string montoInicial;
        public static string usuario;
        public static string estado;
        public FrmConsultaAdelanto()
        {
            InitializeComponent();
        }

        private void FrmConsultaAdelanto_Load(object sender, EventArgs e)
        {
            cargar_combo();
        }
        public void cargar_combo()
        {
            cbadelanto.Items.Add("Pendiente");
            cbadelanto.Items.Add("Cancelado");
            cbadelanto.SelectedIndex = 0;
        }
        public void cargar_lista(bool estlista)
        {
            objEntidad.estAdelanto = estlista;
            dgconadelanto.DataSource = Negocio.NegListarAdelanto(objEntidad);
        }

        private void cbadelanto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbadelanto.Text == "Pendiente")
                {
                    cargar_lista(false);
                }
                else
                {
                    cargar_lista(true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvprestamo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvprestamo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgconadelanto.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgconadelanto.SelectedRows[0].DataBoundItem as DataRowView;
                    //dgvprestamo.Text = datarow.Row["CodCargo"].ToString();
                    //dgvprestamo.Text = datarow.Row["desCargo"].ToString();
                    //MessageBox.Show(datarow.Row["Tipo Operacion"].ToString());
                    codadelanto = datarow.Row["codAdelanto"].ToString();
                    nombApe = datarow.Row["Nombre y Apellido"].ToString();
                    fechInicio = datarow.Row["fechIniAdelanto"].ToString();
                    fechFin = datarow.Row["fechFinAdelanto"].ToString();
                    montoInicial = datarow.Row["montoAdelanto"].ToString();
                    usuario = datarow.Row["nomUsuarioPersonal"].ToString();
                    estado = datarow.Row["Estado"].ToString();
                    FrmDetAdelanto frmdetAdelanto = new FrmDetAdelanto();
                    if (estado == "Cancelado") frmdetAdelanto.deshabilitar_grupo_datos();
                    frmdetAdelanto.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
