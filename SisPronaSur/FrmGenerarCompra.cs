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
using SisPronaSur.Menu;
using WL;
namespace SisPronaSur
{
    public partial class FrmGenerarCompra : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        public string CodProveedor;
        public string CodSucursal;
        public string CodPersonal;
        public string CodProducto;
        public string CodTipoProducto;
        public string serie;
        public string numero;
        public string dni;
        public string nombreyapellido;
        public string ruc;
        public string producto;
        public string tipoproducto;
        public string precioproducto;
        public string preciodetalle;
        public string peso;
        public string total;
        private double pestototal = 0;
        public string CodEstado;
        public string DesEstado;
        public DataTable dtgenerar = new DataTable();
        FrmVentas frmventa = new FrmVentas();
        Tickets ticket = new Tickets();
        public FrmGenerarCompra()
        {
            InitializeComponent();
        }
        public void cargarDatosCompra()
        {
            try
            {
                txtseriecomp.Text = serie;
                txtnumcomp.Text = numero;
                txtdniprovent.Text = dni;
                txtnomapepro.Text = nombreyapellido;
                txtrucproven.Text = ruc;
                //cmbproducto.Text = producto;
                //cmbtippro.Text = tipoproducto;
                //txtpreproducto.Text = precioproducto;
                //txtpredetprod.Text = preciodetalle;
                txttotpro.Text = total;
                //txtpeso.Text = peso;
                //dgvdetallecompra.Rows.Add(txtpeso.Text, cmbproducto.Text + ", " + cmbtippro.Text, txtpredetprod.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            //foreach (DataRow row in FrmVentas.deta.Rows)
            //{
            //    //MessageBox.Show(row[1].ToString());
            //    dgvdetallecompra.Rows.Add("1","2","3","4");
            //}
            //dgvdetallecompra.DataSource = FrmVentas.deta;
            //for (int i = 0; i < dgvdetallecompra.Rows.Count; i++)
            //{
            //    MessageBox.Show(dgvdetallecompra.Rows[i].Cells[0].Value.ToString());

            //}
            //MessageBox.Show(CodProveedor);
            objentidad.CodSucursalFKVenta = Acesso.FrmPorxLogin.CodSucursal;
            objentidad.serieCompra =Convert.ToDouble(txtseriecomp.Text);
            objentidad.numCompra = Convert.ToDouble(txtnumcomp.Text);
            objentidad.CodProveedorFKVenta = CodProveedor;
            objentidad.CodPersonalFKVenta = Acesso.FrmPorxLogin.CodPersonal;
            objentidad.CodEstadoFKVenta = CodEstado;
            int rptacab = Negocio.NegRegistrarCabCompra(objentidad);
            int rptadet = 0;
            for (int i = 0; i < dgvdetallecompra.Rows.Count; i++)
            {
                //MessageBox.Show(dgvdetallecompra.Rows[i].Cells[0].Value.ToString());
                objentidad.pesoDetCompra = Convert.ToDouble(dgvdetallecompra.Rows[i].Cells[2].Value.ToString());
                pestototal += Convert.ToDouble(dgvdetallecompra.Rows[i].Cells[2].Value.ToString());
                objentidad.preDetCompra = Convert.ToDouble(dgvdetallecompra.Rows[i].Cells[5].Value.ToString());
                objentidad.CodSucursalFKDetalle = Acesso.FrmPorxLogin.CodSucursal;
                objentidad.CodProductoFKDetalle = dgvdetallecompra.Rows[i].Cells[1].Value.ToString();
                objentidad.CodTipoProductoFKDetalle = dgvdetallecompra.Rows[i].Cells[4].Value.ToString();
                
                rptadet = Negocio.NegRegistrarDetCompra(objentidad);
            }
            objentidad.cantProAlmacen = pestototal;
            objentidad.CodProductoFKAlmacen = objentidad.CodProductoFKDetalle;
            objentidad.CodSucursalFKAlmacen = Acesso.FrmPorxLogin.CodSucursal;
            //datos retiro
            objentidad.montoCaja = Convert.ToDouble(total);
            objentidad.CodSucursalFKCaja = Acesso.FrmPorxLogin.CodSucursal;
            objentidad.CodPersonalFKCaja = Acesso.FrmPorxLogin.CodPersonal;
            objentidad.CodTipoProductoFKAlmacen = "TP00001";
            int rptalma = Negocio.NegRegistrarAlmacen(objentidad);
            int rptretiro = Negocio.NegRegistrarRetiroCaja(objentidad);
            if(rptacab == 1 && rptadet == 1 && rptalma == 1)
            {
                MessageBox.Show("Se registro una compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(Acesso.FrmPorxLogin.Cargo == "Usuario-Administrador") FrmMenuUAdmin.cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                if (Acesso.FrmPorxLogin.Cargo == "Usuario") FrmMenuUsuario.cargar_saldo(Acesso.FrmPorxLogin.CodSucursal);
                btnGuardarCompra.Enabled = false;
                btnImprimir.Enabled = true;
            }else
            {
                MessageBox.Show("Hubo un error o la No tiene saldo SUFICIENTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void cargar_subtotal()
        {
            if (dgvdetallecompra.Rows.Count > 0)
            {
                for (int i = 0; i < dgvdetallecompra.Rows.Count; i++)
                {
                    dgvdetallecompra.Rows[i].Cells["SUBTOTAL"].Value = ((Convert.ToDouble(dgvdetallecompra.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(dgvdetallecompra.Rows[i].Cells[5].Value.ToString()))) ;
                }
            }
        }
        private void FrmGenerarCompra_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatosCompra();
                btnImprimir.Enabled = false;
                dgvdetallecompra.DataSource = FrmVentas.deta;
                cargar_subtotal();
                lblfechacompra.Text = DateTime.Now.ToLongDateString();
                lblestado.Text = DesEstado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            printDialogCompra.Document = printDocumentCompra;
            //printDialogCompra.Show();
        }

        private void printDocumentCompra_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.logo;
            Bitmap bmpgrupo = Properties.Resources.rectangulos2;
            Bitmap bmptotal = Properties.Resources.total;
            Image nuevaImagen = bmp;
            Image imagenGrupo = bmpgrupo;
            Image imagentotal = bmptotal;
            e.Graphics.DrawString(lbltopimp.Text, new Font("Arial", 14), Brushes.Black, new Point(27, 40));
            e.Graphics.DrawImage(nuevaImagen, 25, 55, nuevaImagen.Width, nuevaImagen.Height);
            e.Graphics.DrawString("PronaSUR E.I.R.L", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(180, 90));
            e.Graphics.DrawString("Sucursal - "+Acesso.FrmPorxLogin.NomSucursal, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(185, 130));
            e.Graphics.DrawString(lblfechacompra.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(185, 150));
            e.Graphics.DrawImage(imagenGrupo, 470, 55, 330, 150);
            e.Graphics.DrawString("R.U.C. "+Acesso.FrmPorxLogin.RucSucursal, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(540, 80));
            e.Graphics.DrawString("BOLETA", new Font("Verdana", 14, FontStyle.Bold), Brushes.Black, new Point(590, 110));
            e.Graphics.DrawString("Nº "+txtseriecomp.Text+" - "+txtnumcomp.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(540, 140));
            e.Graphics.DrawString("Señor (es): "+txtnomapepro.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(68, 240));
            e.Graphics.DrawString(lblprintnombre.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(178, 255));
            e.Graphics.DrawString("DNI/RUC: "+txtdniprovent.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(520, 240));
            e.Graphics.DrawString(lblprintdni.Text, new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(618, 255));
            e.Graphics.DrawString(lbltopimp.Text, new Font("Arial", 14), Brushes.Black, new Point(27,282));
            e.Graphics.DrawString("PESO", new Font("Arial", 12,FontStyle.Bold), Brushes.Black, new Point(68, 302));
            e.Graphics.DrawString("DESCRIPCION", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(280, 302));
            e.Graphics.DrawString("P.UNITARIO", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 302));
            e.Graphics.DrawString("SUBTOTAL", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(680, 302));
            e.Graphics.DrawString(lbltopimp.Text, new Font("Arial", 14), Brushes.Black, new Point(27, 310));

            int posY = 340;
            for (int i = 0; i < dgvdetallecompra.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgvdetallecompra.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(78, posY));
                e.Graphics.DrawString(dgvdetallecompra.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, posY));
                e.Graphics.DrawString(dgvdetallecompra.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(555, posY));
                e.Graphics.DrawString(dgvdetallecompra.Rows[i].Cells["SUBTOTAL"].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(685, posY));
                posY += 30;
            }
            e.Graphics.DrawImage(imagentotal, 595, 652, 200, 50);
            e.Graphics.DrawString("TOTAL: 585", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(615, 670));

            e.Graphics.DrawString(lbltopimp.Text, new Font("Arial", 14), Brushes.Black, new Point(27, 707));
            e.Graphics.DrawString(lblimp.Text, new Font("Arial", 14), Brushes.Black, new Point(25, 50));
            e.Graphics.DrawString(lblimp.Text, new Font("Arial", 14), Brushes.Black, new Point(790, 50));
        }
        public void iniciar()
        {
            ticket.Limpiar();
            ticket.Logo("buy.png");
            ticket.Titulo("PRONASUR");
            ticket.Encabezado("Sucursal: " + Acesso.FrmPorxLogin.NomSucursal);
            //ticket1.Encabezado("CIUDAD CODIGO POSTAL");
            ticket.Encabezado("RUC: " + Acesso.FrmPorxLogin.RucSucursal);
            ticket.Encabezado("FECHA: " + DateTime.Now.ToShortDateString());
            int nArticulos = dgvdetallecompra.Rows.Count;
            for (int i = 0; i < dgvdetallecompra.Rows.Count; i++)
            {
                ticket.Articulo("", dgvdetallecompra.Rows[i].Cells[2].Value.ToString(), dgvdetallecompra.Rows[i].Cells[3].Value.ToString(), dgvdetallecompra.Rows[i].Cells[5].Value.ToString(), dgvdetallecompra.Rows[i].Cells["SUBTOTAL"].Value.ToString());
            }
            //ticket1.Articulo("123456789", "1 PZ", "ARTICULO DE PRUEBA NUMERO UNO", "10", "10");
            //ticket1.Articulo("123453254", "2 PZ", "ARTICULO DE PRUEBA NUMERO DOS", "15", "30");

            ticket.NumArticulos(nArticulos.ToString());
            ticket.Total(peso);
            ticket.Pago("EFECTIVO S/.:", total);
            ticket.Pago("DOLARES: ", "0");
            //ticket1.Pago("TARJETA:", "10");
            //ticket1.Pago("VALES:", "20");
            ticket.Pago("CAMBIO:", "0");
            ticket.Pie("GRACIAS POR SU PREFERENCIA!!");
            ticket.Pie("=========================================================================");
            
        }
        public void imprimirticket()
        {
            iniciar();
            ticket.Imprimir();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //printDocumentCompra.Print();
            imprimirticket();
        }
    }
}
