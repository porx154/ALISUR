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
    public partial class MDIAlmacenero : Form
    {
        private int childFormNumber = 0;

        public MDIAlmacenero()
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

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlmGenConfirm frmconfirm = new FrmAlmGenConfirm();
                if (ActivarForm(frmconfirm) == true)
                {
                    frmconfirm = null;
                }
                else
                {
                    frmconfirm.MdiParent = this;
                    frmconfirm.WindowState = FormWindowState.Normal;
                    frmconfirm.Show();
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
                FrmSarandeoAlmacen frmsaalgen = new FrmSarandeoAlmacen();
                if (ActivarForm(frmsaalgen) == true)
                {
                    frmsaalgen = null;
                }
                else
                {
                    frmsaalgen.MdiParent = this;
                    frmsaalgen.WindowState = FormWindowState.Normal;
                    frmsaalgen.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MDIAlmacenero_Load(object sender, EventArgs e)
        {
            try
            {

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
