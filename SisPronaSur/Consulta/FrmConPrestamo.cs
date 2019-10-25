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
    public partial class FrmConPrestamo : MetroFramework.Forms.MetroForm
    {
        public static string codigoprestamo;
        public static string datosNomApe;
        public static string fechPrestamo;
        public static string montoprestado;
        public static string interesPrestamo;
        public static bool status;
        public static string cantidadproducto;
        public static string estadoprestamo;
        Entidad objEntidad = new Entidad();
        public FrmConPrestamo()
        {
            InitializeComponent();
        }

        private void FrmConPrestamo_Load(object sender, EventArgs e)
        {
            objEntidad.estPrestamo = false;
            cargar_prestamo(objEntidad);
            cargar_combo();
        }
        public void cargar_combo()
        {
            cmbprestamo.Items.Add("Pendiente");
            cmbprestamo.Items.Add("Cancelado");
            cmbprestamo.SelectedIndex = 0;
        }
        public void cargar_prestamo(Entidad objEntidad)
        {
            
            dgvprestamo.DataSource = Negocio.NegListarPrestamo(objEntidad);
        }

        private void cmbprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbprestamo.Text == "Pendiente")
            {
                objEntidad.estPrestamo = false;
                
            }else
            {
                objEntidad.estPrestamo = true;
            }
            cargar_prestamo(objEntidad);
        }

        private void dgvprestamo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvprestamo.SelectedRows.Count > 0)
                {
                    DataRowView datarow = dgvprestamo.SelectedRows[0].DataBoundItem as DataRowView;
                    //dgvprestamo.Text = datarow.Row["CodCargo"].ToString();
                    //dgvprestamo.Text = datarow.Row["desCargo"].ToString();
                    //MessageBox.Show(datarow.Row["Tipo Operacion"].ToString());
                    codigoprestamo = datarow.Row["codPrestamo"].ToString();
                    datosNomApe = datarow.Row["Nombre y Apellido"].ToString();
                    fechPrestamo = datarow.Row["fechInicio"].ToString();
                    montoprestado = datarow.Row["montoPrestamo"].ToString();
                    interesPrestamo = datarow.Row["interesPrestamo"].ToString();
                    estadoprestamo = datarow.Row["Estado"].ToString();
                    FrmDetPrestamo frmdetpresta = new FrmDetPrestamo();
                    if(estadoprestamo== "Cancelado") frmdetpresta.deshabilitar_controles(); 
                    frmdetpresta.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
