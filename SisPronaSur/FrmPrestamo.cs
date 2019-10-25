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
    public partial class FrmPrestamo : MetroFramework.Forms.MetroForm
    {
        Entidad objEntidad = new Entidad();
        DataTable dtProveedor = new DataTable();
        string CodigoPrestamo = "";
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkadelanto_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

        }
        public void cargar_proveedor(string dniProveedor)
        {
            objEntidad.dniProveedor = dniProveedor;
            dtProveedor = Negocio.NegBuscarProveedorDniTemporal(objEntidad);

            for (int i = 0; i < dtProveedor.Rows.Count; i++)
            {
                if (dtProveedor.Rows[i][3].ToString().Trim() == dniProveedor)
                {
                   
                    txtnombape.Text = dtProveedor.Rows[i][1].ToString();
                    objEntidad.CodProveedorFKVenta = dtProveedor.Rows[i][0].ToString();
                    break;
                }
                //MessageBox.Show(dtCliente.Rows[i][2].ToString());
            }

            //Negocio.NegBuscarProveedorDni(objEntidad);
            //txtnombape.Text = objEntidad.NombreyApellidoProveedor;
            
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            cargar_proveedor(txtdni.Text);
        }
        public void habilitar_controles()
        {
            txtdni.Enabled = true;
            dtfin.Enabled = true;
            txtmonto.Enabled = true;
            txtinteres.Enabled = true;
            txtdni.Focus();
        }
        public void deshabilitar_controles()
        {
            txtdni.Enabled = false;
            dtfin.Enabled = false;
            txtmonto.Enabled = false;
            txtinteres.Enabled = false;
        }
        public void limpiar_controles()
        {
            txtdni.Clear();
            txtmonto.Clear();
            txtdias.Clear();
            txtinteres.Clear();
            txtnombape.Clear();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            habilitar_controles();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            deshabilitar_controles();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombape.Text == "")
            {
                MessageBox.Show("NECESITA UN PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtmonto.Text == "" || txtnombape.Text == Convert.ToString(0))
            {
                MessageBox.Show("NECESITA UN MONTO/MONTO NO PUEDE SER 0", "MONTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txtinteres.Text == "" || txtinteres.Text == Convert.ToString(0))
            {
                MessageBox.Show("NECESITA UN INTERES/INTERES NO PUEDE SER 0","INTERES",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string montopre;
                objEntidad.codPrestamo = CodigoPrestamo;
                objEntidad.codProveedorFKPrestamo = objEntidad.CodProveedorFKVenta;
                objEntidad.fechDevPrestamo = Convert.ToDateTime(dtfin.Value.ToShortDateString());
                montopre = txtmonto.Text;
                objEntidad.montoPrestamo = Convert.ToDouble(montopre.Replace(".", ","));
                objEntidad.interesPrestamo = Convert.ToInt32(txtinteres.Text);
                objEntidad.codPersonalFKPrestamo = Acesso.FrmPorxLogin.CodPersonal;
                //----
                //objEntidad.codPrestamo = "";
                //objEntidad.codProveedorFKPrestamo = "PR00001";
                //objEntidad.fechDevPrestamo = Convert.ToDateTime("30/09/2019");
                //objEntidad.montoPrestamo = Convert.ToDouble("1203");
                //objEntidad.interesPrestamo = Convert.ToInt32("1");
                //objEntidad.codPersonalFKPrestamo = "US00003";
                int rpta = Negocio.NegMantenerPrestamo(objEntidad);
                if (rpta == 2)
                {
                    MessageBox.Show("REGISTRO COMPLETO", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_controles();
                } else
                {
                    MessageBox.Show("ERROR EN EL REGISTRO", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtinteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
