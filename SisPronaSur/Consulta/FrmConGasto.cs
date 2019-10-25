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
using System.Globalization;

namespace SisPronaSur.Consulta
{
    public partial class FrmConGasto : MetroFramework.Forms.MetroForm
    {
        
        Entidad objEntidad = new Entidad();
        double montoTotal = 0;
        string cmes = "";
        public FrmConGasto()
        {
            InitializeComponent();
        }

        private void FrmConGasto_Load(object sender, EventArgs e)
        {
            cargar_mes();
            listarGasto();
            
            
        }
        public void listarGasto()
        {
            dgvcargo.DataSource = Negocio.NegListarGasto();
            for (int i = 0; i < dgvcargo.Rows.Count; i++)
            {
                montoTotal += Convert.ToDouble(dgvcargo.Rows[i].Cells[2].Value.ToString());
            }
            txtgastotot.Text = Convert.ToString(montoTotal);
        }
        public void cargar_mes()
        {
            cmbmes.Items.Add("Enero");
            cmbmes.Items.Add("Febrero");
            cmbmes.Items.Add("Marzo");
            cmbmes.Items.Add("Abril");
            cmbmes.Items.Add("Mayo");
            cmbmes.Items.Add("Junio");
            cmbmes.Items.Add("Julio");
            cmbmes.Items.Add("Agosto");
            cmbmes.Items.Add("Septiembre");
            cmbmes.Items.Add("Octurbre");
            cmbmes.Items.Add("Noviembre");
            cmbmes.Items.Add("Diciembre");
            cmbmes.SelectedIndex = 0;
        }
        public void convertir_mes(string mes)
        {
            switch(mes)
            {
                case "Enero":
                    cmes = "January";
                    break;
                case "Febrero":
                    cmes = "February";
                    break;
                case "Marzo":
                    cmes = "March";
                    break;
                case "Abril":
                    cmes = "April";
                    break;
                case "Mayo":
                    cmes = "May";
                    break;
                case "Junio":
                    cmes = "June";
                    break;
                case "Julio":
                    cmes = "July";
                    break;
                case "Agosto":
                    cmes = "August";
                    break;
                case "Septiembre":
                    cmes = "September";
                    break;
                case "Octubre":
                    cmes = "October";
                    break;
                case "Noviembre":
                    cmes = "November";
                    break;
                case "Diciembre":
                    cmes = "December";
                    break;
              
            }
        }
        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                //convertir_mes(cmbmes.Text);
                dgvcargo.DataSource = Negocio.NegFiltrarGastoPorMes(cmbmes.Text);
                montoTotal = 0;
                for (int i = 0; i < dgvcargo.Rows.Count; i++)
                {
                    montoTotal += Convert.ToDouble(dgvcargo.Rows[i].Cells[2].Value.ToString());
                }
                txtgastotot.Text = Convert.ToString(montoTotal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                cmbmes.Visible = true;
                btnfiltrar.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                cmbmes.Visible = false;
                btnfiltrar.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label2.Visible = true;
                label3.Visible = true;
                dtinicial.Visible = true;
                dtfinal.Visible = true;
                checkBox1.Checked = false;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                dtinicial.Visible = false;
                dtfinal.Visible = false;
                
            }

        }

        private void dtfinal_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtfinal.Value.ToShortDateString());
            //DateTime dtinicio = Convert.ToDateTime(dtinicial.Value.ToShortDateString());
            objEntidad.fechInicialGasto = Convert.ToDateTime(dtinicial.Value.ToShortDateString());
            objEntidad.fechFinGasto = Convert.ToDateTime(dtfinal.Value.ToShortDateString());
            montoTotal = 0;
            if (dtinicial.Value.Date > dtfinal.Value.Date)
            {
                MessageBox.Show("LA FECHA INICIAL DEBE SER MENOR A LA FECHA FINAL","MENSAJE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                dgvcargo.DataSource = Negocio.NegFiltrarGastoPorFecha(objEntidad);
                for (int i = 0; i < dgvcargo.Rows.Count; i++)
                {
                    montoTotal += Convert.ToDouble(dgvcargo.Rows[i].Cells[2].Value.ToString());
                }
                txtgastotot.Text = Convert.ToString(montoTotal);
            }
            
        }

        private void dgvcargo_DoubleClick(object sender, EventArgs e)
        {
            FrmRegGasto objfrmgasto = new FrmRegGasto();
            if (dgvcargo.SelectedRows.Count > 0)
            {
                DataRowView datarow = dgvcargo.SelectedRows[0].DataBoundItem as DataRowView;
                objfrmgasto.codigoGasto = datarow.Row["codGastoGeneral"].ToString();
                objfrmgasto.montoGasto = Convert.ToDouble(datarow.Row["montoGasto"].ToString());
                objfrmgasto.tipoGasto = datarow.Row["desTipoGasto"].ToString();
                objfrmgasto.desGasto = datarow.Row["desGasto"].ToString();      
            }
            objfrmgasto.Show();
        }
    }
}
