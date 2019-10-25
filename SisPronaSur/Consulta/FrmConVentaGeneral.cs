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
    public partial class FrmConVentaGeneral : Form
    {
        Entidad objEnt = new Entidad();
        public FrmConVentaGeneral()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Black);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);
                
                g.Clear(this.BackColor);
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
                
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
               
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox boxcontenedor = sender as GroupBox;
            DrawGroupBox(boxcontenedor, e.Graphics, Color.Red, Color.Black);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox boxdetalle = sender as GroupBox;
            DrawGroupBox(boxdetalle, e.Graphics, Color.Red, Color.Black);
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GroupBox boxtotal = sender as GroupBox;
            DrawGroupBox(boxtotal, e.Graphics, Color.Red, Color.Black);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void cargar_datos()
        {
            objEnt.CodVenta = Consulta.FrmBusVentaGeneral.codigoventa;
            Negocio.NegVerFacturaElectronica(objEnt);
            txtdirsucursal.Text = objEnt.dirSucursal;
            txtrucsucursal.Text = objEnt.rucSucursal;
            txtfechventa.Text = objEnt.fechVenta.ToShortDateString();
            txtnombre.Text = objEnt.nomCliente;
            txtrucventa.Text = objEnt.rucCliente;
            txtdirventa.Text = objEnt.dirCliente;
            txttipomoneda.Text = objEnt.destipomoneda;
            txtpesoventa.Text = Convert.ToString(objEnt.pesoTotalVenta);
            txtdestipoproducto.Text = objEnt.desTipoProducto;
            txtpreciounitario.Text = Convert.ToString(objEnt.precioUnitarioVenta);
            txtphventa.Text = Convert.ToString(objEnt.phVenta);
            txttotventa.Text = Convert.ToString(objEnt.TotVentaGeneral);
            txtusuario.Text = Acesso.FrmPorxLogin.NomUsuario;
        }
        private void FrmConVentaGeneral_Load(object sender, EventArgs e)
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
    }
}
