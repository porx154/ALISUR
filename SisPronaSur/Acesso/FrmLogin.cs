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
namespace SisPronaSur.Acesso
{
    public partial class FrmLogin : Form
    {
        Entidad objentidad = new Entidad();
        public static string CodPersonal;
        public static string CodSucursal;
        public static string Cargo;
        public static string NomPersonal;
        public static string ApePersonal;
        public static string NomUsuario;
        public static string NomSucursal;
        int NroIntentos;
        public FrmLogin()
        {
            InitializeComponent();
        }
        public void Accesar_Sistema()
        {
            DataTable DtbLogin = new DataTable();
            objentidad.nomUsuarioPersonal = txtusu.Text;
            objentidad.passPersonal = txtpass.Text;
            DtbLogin = Negocio.NegAccesoAlSistema(objentidad);
            if (txtusu.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar su usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpass.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar su contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DtbLogin.Rows.Count > 0)
            {
                FrmCargar FrmCarga = new FrmCargar();
                FrmCarga.Show();
                Hide();
                CodPersonal = DtbLogin.Rows[0][0].ToString();
                NomPersonal = DtbLogin.Rows[0][1].ToString();
                ApePersonal = DtbLogin.Rows[0][2].ToString();
                NomUsuario = DtbLogin.Rows[0][3].ToString();
                Cargo = DtbLogin.Rows[0][5].ToString();
                CodSucursal = DtbLogin.Rows[0][6].ToString();
                NomSucursal = DtbLogin.Rows[0][7].ToString();
            }else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusu.Clear();
                txtpass.Clear();
                txtusu.Focus();
                NroIntentos += 1;
                if (NroIntentos < 3)
                {
                    MessageBox.Show("Le quedan " + (3 - NroIntentos) + " intentos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (NroIntentos == 3)
                {
                    Close();
                }
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Accesar_Sistema();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
