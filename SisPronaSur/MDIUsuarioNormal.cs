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
    public partial class MDIUsuarioNormal : Form
    {
        private int childFormNumber = 0;
        Entidad objEnt = new Entidad();
        public static double saldoTienda = 0;
        public static MDIUsuarioNormal mdi;
        public MDIUsuarioNormal()
        {
            InitializeComponent();
            MDIUsuarioNormal.mdi = this;
        }
        public static bool listarsaldo(string codigo, TextBox txt)
        {
            saldoTienda = Negocio.NegListarSaldoTienda(codigo);
            txt.Text = Convert.ToString(saldoTienda);
            if (saldoTienda <= 1000) MessageBox.Show("Queda poco saldo en la CAJA","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return true;
        }
        public static void cargar_saldo(string codSucursal)
        {
            try
            {

                listarsaldo(codSucursal, mdi.txtsaldotienda);
                //saldo.txtsaldotienda.Text = Convert.ToString(listarsaldo(codSucursal));



            }
            catch (Exception)
            {

                throw;
            }
        }
        private Boolean ActivarForm(Form Formulario)
        {
            foreach (Control control in this.Controls)
            {
                if (control.HasChildren)//Porque el MDI es un contenedor
                {
                    foreach (Control controlChild in control.Controls)
                    {
                        if (controlChild.GetType() == Formulario.GetType())
                        {
                            if (((Form)controlChild).WindowState == FormWindowState.Minimized)
                            {
                                ((Form)controlChild).WindowState = FormWindowState.Normal;
                            }
                            ((Form)controlChild).BringToFront();
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIUsuarioNormal_Load(object sender, EventArgs e)
        {
            try
            {
                tssnomusuario.Text = Acesso.FrmPorxLogin.NomPersonal;
                tssfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                FrmVentas frmventcompra = new FrmVentas();
                if (ActivarForm(frmventcompra) == true)
                {
                    frmventcompra = null;
                }
                else
                {
                    frmventcompra.MdiParent = this;
                    frmventcompra.WindowState = FormWindowState.Normal;
                    frmventcompra.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                FrmAlmacen frmalmacen = new FrmAlmacen();
                if (ActivarForm(frmalmacen) == true)
                {
                    frmalmacen = null;
                }
                else
                {
                    frmalmacen.MdiParent = this;
                    frmalmacen.WindowState = FormWindowState.Normal;
                    frmalmacen.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                Mantenimiento.FrmManProveedor frmproveedor = new Mantenimiento.FrmManProveedor();
                if (ActivarForm(frmproveedor) == true)
                {
                    frmproveedor = null;
                }
                else
                {
                    frmproveedor.MdiParent = this;
                    frmproveedor.WindowState = FormWindowState.Normal;
                    frmproveedor.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                Consulta.FrmConProveedor frmconproveedor = new Consulta.FrmConProveedor();
                if (ActivarForm(frmconproveedor) == true)
                {
                    frmconproveedor = null;
                }
                else
                {
                    frmconproveedor.MdiParent = this;
                    frmconproveedor.WindowState = FormWindowState.Normal;
                    frmconproveedor.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManCliente frmcliente = new Mantenimiento.FrmManCliente();
                if (ActivarForm(frmcliente) == true)
                {
                    frmcliente = null;
                }
                else
                {
                    frmcliente.MdiParent = this;
                    frmcliente.WindowState = FormWindowState.Normal;
                    frmcliente.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVentaGeneral frmventa = new FrmVentaGeneral();
                if (ActivarForm(frmventa) == true)
                {
                    frmventa = null;
                }
                else
                {
                    frmventa.MdiParent = this;
                    frmventa.WindowState = FormWindowState.Normal;
                    frmventa.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta.FrmBusVentaGeneral frmbusventa = new Consulta.FrmBusVentaGeneral();
                if (ActivarForm(frmbusventa) == true)
                {
                    frmbusventa = null;
                }
                else
                {
                    frmbusventa.MdiParent = this;
                    frmbusventa.WindowState = FormWindowState.Normal;
                    frmbusventa.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
