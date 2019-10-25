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
    public partial class FrmConAdelanto : MetroFramework.Forms.MetroForm
    {
        DataTable dtProveedor = new DataTable();
        Entidad objEntidad = new Entidad();
        string codadelanto = "";
        public FrmConAdelanto()
        {
            InitializeComponent();
        }
        public void habilitar_controles()
        {
            txtdni.Enabled = true;
            txtmontosoles.Enabled = true;
            dtpfechdevolucion.Enabled = true;
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
        }
        public void limpiar_controles()
        {
            txtdni.Clear();
            txtmontosoles.Clear();
            txtdni.Focus();
        }
        public void deshabilitar_controles()
        {
            txtdni.Enabled = false;
            txtmontosoles.Enabled = false;
            dtpfechdevolucion.Enabled = false;
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
        }
       
        public void cargar_proveedor(string dniProveedor)
        {
            objEntidad.dniProveedor = dniProveedor;
            dtProveedor = Negocio.NegBuscarProveedorDniTemporal(objEntidad);

            for (int i = 0; i < dtProveedor.Rows.Count; i++)
            {
                if (dtProveedor.Rows[i][3].ToString().Trim() == dniProveedor)
                {

                    txtnomape.Text = dtProveedor.Rows[i][1].ToString();
                    objEntidad.CodProveedorFKVenta = dtProveedor.Rows[i][0].ToString();
                    break;
                }
                //MessageBox.Show(dtCliente.Rows[i][2].ToString());
            }

            //Negocio.NegBuscarProveedorDni(objEntidad);
            //txtnombape.Text = objEntidad.NombreyApellidoProveedor;

        }
        private void FrmConAdelanto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            habilitar_controles();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtdni.Text == "" || txtnomape.Text == "")
                {
                    MessageBox.Show("NECESITA DATOS DEL PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (txtmontosoles.Text == "" || txtmontosoles.Text == Convert.ToString(0))
                {
                    MessageBox.Show("NECESITA UN MONTO/NO PUEDE SER 0", "MONTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objEntidad.codAdelanto = codadelanto;
                    objEntidad.montoadelanto = Convert.ToDouble(txtmontosoles.Text);
                    objEntidad.CodPersonalFKAdelanto = "US00001";//FrmPorxLogin.CodPersonal
                    objEntidad.fechFinAdelanto = dtpfechdevolucion.Value;
                    objEntidad.estAdelanto = false;
                    objEntidad.CodProveedorFKAdelanto = "PR00001";
                    int rpta = Negocio.NegMantenerAdelanto(objEntidad);
                    if(rpta == 1)
                    {
                        MessageBox.Show("SE REGISTRO UN ADELANTO", "ADELANTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_controles();
                    } else
                    {
                        limpiar_controles();
                        deshabilitar_controles();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            cargar_proveedor(txtdni.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            deshabilitar_controles();
        }

        private void txtmontosoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
