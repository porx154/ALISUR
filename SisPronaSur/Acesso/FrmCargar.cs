using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisPronaSur.Acesso
{
    public partial class FrmCargar : Form
    {
        int contador = 0;
        public FrmCargar()
        {
            InitializeComponent();
        }

        private void tmpcarga_Tick(object sender, EventArgs e)
        {
            try
            {
                contador += 1;
                pgrcargar.Value = contador;
                lblcargar.Text = "El sistema está cargando al " + contador + "%";
                bcprogreso.Value = contador;
                if (contador == 100)
                {
                    tmpcarga.Enabled = false;
                    Hide();
                    MessageBox.Show("Bienvenido(a) " + FrmPorxLogin.NomPersonal, "Empresa PronaSur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string MenuAcceso = FrmPorxLogin.Cargo;
                    switch (MenuAcceso)
                    {
                        case "Administrador":
                            //MDIPrincipal menuadmin = new MDIPrincipal();
                            Menu.FrmMenuAdministrador menuadmin = new Menu.FrmMenuAdministrador();
                            menuadmin.Show();
                            Close();
                            break;
                        case "Usuario":
                            Menu.FrmMenuUsuario menuusuario = new Menu.FrmMenuUsuario();
                            menuusuario.Show();
                            Close();
                            break;
                        case "Usuario-Administrador":
                            Menu.FrmMenuUAdmin menuusadmin = new Menu.FrmMenuUAdmin();
                            menuusadmin.Show();
                            Close();
                            break;
                        case "Almacenero":
                            Menu.FrmMenuAlmacenero menualmacen = new Menu.FrmMenuAlmacenero();
                            menualmacen.Show();
                            Close();
                            break;
                    }
                }
            }
            catch
            {
            }
        }

        private void FrmCargar_Load(object sender, EventArgs e)
        {

        }
    }
}
