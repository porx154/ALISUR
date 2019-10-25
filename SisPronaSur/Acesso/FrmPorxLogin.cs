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
    public partial class FrmPorxLogin : Form
    {
        Entidad objentidad = new Entidad();
        public static string CodPersonal;
        public static string CodSucursal;
        public static string Cargo;
        public static string NomPersonal;
        public static string ApePersonal;
        public static string NomUsuario;
        public static string NomSucursal;
        public static string DirSurcursal;
        public static string RucSucursal;
        int NroIntentos;
        public FrmPorxLogin()
        {
            InitializeComponent();
            pictureBox2.Image =  Properties.Resources._lock;
            pictureBox2.Enabled = false;
        }
        public void Accesar_Sistema()
        {
            DataTable DtbLogin = new DataTable();
            objentidad.nomUsuarioPersonal = txtnomusuario.Text;
            objentidad.passPersonal = txtpassusuario.Text;
            DtbLogin = Negocio.NegAccesoAlSistema(objentidad);
            if (txtnomusuario.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar su usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpassusuario.Text.Length == 0)
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
                DirSurcursal = DtbLogin.Rows[0][8].ToString();
                RucSucursal = DtbLogin.Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomusuario.Clear();
                txtpassusuario.Clear();
                txtnomusuario.Focus();
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
        private void FrmPorxLogin_Load(object sender, EventArgs e)
        {

        }
        void Enter1(object sender, EventArgs e)
        {
            if (txtnomusuario.Text == "Nombre Usuario")
            {
                txtnomusuario.Text = string.Empty;
            }
        }
        void limpiar1(object sender, EventArgs e)
        {
            if (txtnomusuario.Text == string.Empty)
            {
                txtnomusuario.Text = "Nombre Usuario";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (txtpassusuario.Text == "Contraseña")
            {
                txtpassusuario.PasswordChar = '•';
                pictureBox2.Enabled = true;
                txtpassusuario.Text = string.Empty;
            }
        }
        void limpiar2(object sender, EventArgs e)
        {
            if (txtpassusuario.Text == string.Empty)
            {
                txtpassusuario.PasswordChar = '\0';
                pictureBox2.Enabled = false;
                txtpassusuario.Text = "Contraseña";
            }
        }
        void desbloquear()
        {
            if (txtpassusuario.PasswordChar == '•')
            {
                txtpassusuario.PasswordChar = '\0';
                pictureBox2.Image = Properties.Resources.show;
            }
            else
            {
                txtpassusuario.PasswordChar = '•';
                pictureBox2.Image = Properties.Resources._lock;
            }
        }
        private void ver(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
