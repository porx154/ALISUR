using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisPronaSur
{
    public partial class FrmConfirmacion : MetroFramework.Forms.MetroForm
    {
        public FrmConfirmacion()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            //printDialogCodigo.Dispose();
            //printDialogCodigo.Document = printDocumentCodigo;
            //printDialogCodigo.Show();
            
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No se encontro impresora", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            printDocumentCodigo.Print();

        }

        private void FrmConfirmacion_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_datos();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_datos()
        {
            mttxtcondigo.Text = FrmAlmacen.globcodconfi;
            mttxtmonto.Text = Convert.ToString(FrmAlmacen.globmonto);
        }

        private void printDocumentCodigo_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.logo;
            Image nuevaImagen = bmp;
            e.Graphics.DrawImage(nuevaImagen, 310, 95, nuevaImagen.Width, nuevaImagen.Height);
            e.Graphics.DrawString(lblmargen.Text, new Font("Arial", 14), Brushes.Black, new Point(185, 100));
            e.Graphics.DrawString("Sucursal: "+Acesso.FrmPorxLogin.NomSucursal, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(185, 130));
            e.Graphics.DrawString("Codigo de Confirmación: "+mttxtcondigo.Text, new Font("Arial", 11,FontStyle.Bold), Brushes.Black, new Point(185, 160));
            e.Graphics.DrawString("Monto: "+mttxtmonto.Text+" KILOGRAMOS", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(185, 190));
            e.Graphics.DrawString(lblmargen.Text, new Font("Arial", 14), Brushes.Black, new Point(185, 220));
        }

        private void mtbtnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtbtnimprimir_Click(object sender, EventArgs e)
        {
            printDocumentCodigo.Print();
        }
    }
}
