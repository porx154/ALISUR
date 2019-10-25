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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;
        public static int saldoTienda = 0;
        public MDIPrincipal()
        {
            InitializeComponent();
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
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                tssnomusuario.Text = Acesso.FrmPorxLogin.NomPersonal;
                tssfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tmrmenu_Tick(object sender, EventArgs e)
        {
            try
            {
                tsshora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tssnomusuario_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVentas frmventcompra = new FrmVentas();
                if (ActivarForm(frmventcompra) == true)
                {
                    frmventcompra = null;
                }else
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
                Consulta.FrmConAlmTiendaAdmin frmalmadm = new Consulta.FrmConAlmTiendaAdmin();
                if (ActivarForm(frmalmadm) == true)
                {
                    frmalmadm = null;
                }
                else
                {
                    frmalmadm.MdiParent = this;
                    frmalmadm.WindowState = FormWindowState.Normal;
                    frmalmadm.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManCargo frmcargo = new Mantenimiento.FrmManCargo();
                if (ActivarForm(frmcargo) == true)
                {
                    frmcargo = null;
                }
                else
                {
                    frmcargo.MdiParent = this;
                    frmcargo.WindowState = FormWindowState.Normal;
                    frmcargo.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManProducto frmproducto = new Mantenimiento.FrmManProducto();
                if (ActivarForm(frmproducto) == true)
                {
                    frmproducto = null;
                }
                else
                {
                    frmproducto.MdiParent = this;
                    frmproducto.WindowState = FormWindowState.Normal;
                    frmproducto.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManTipoProducto frmtipopro = new Mantenimiento.FrmManTipoProducto();
                if (ActivarForm(frmtipopro) == true)
                {
                    frmtipopro = null;
                }
                else
                {
                    frmtipopro.MdiParent = this;
                    frmtipopro.WindowState = FormWindowState.Normal;
                    frmtipopro.Show();
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

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManPersonal frmpersonal = new Mantenimiento.FrmManPersonal();
                if (ActivarForm(frmpersonal) == true)
                {
                    frmpersonal = null;
                }
                else
                {
                    frmpersonal.MdiParent = this;
                    frmpersonal.WindowState = FormWindowState.Normal;
                    frmpersonal.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                
                Consulta.FrmConSarandeo frmsa = new Consulta.FrmConSarandeo();
                if (ActivarForm(frmsa) == true)
                {
                    frmsa = null;
                }
                else
                {
                    frmsa.MdiParent = this;
                    frmsa.WindowState = FormWindowState.Normal;
                    frmsa.Show();
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
                FrmCaja frmcaja = new FrmCaja();
                if (ActivarForm(frmcaja) == true)
                {
                    frmcaja = null;
                }
                else
                {
                    frmcaja.MdiParent = this;
                    frmcaja.WindowState = FormWindowState.Normal;
                    frmcaja.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mantenimientoSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmSucursal frmsucursal = new Mantenimiento.FrmSucursal();
                if (ActivarForm(frmsucursal) == true)
                {
                    frmsucursal = null;
                }
                else
                {
                    frmsucursal.MdiParent = this;
                    frmsucursal.WindowState = FormWindowState.Normal;
                    frmsucursal.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
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
    }
}
