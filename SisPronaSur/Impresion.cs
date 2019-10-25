using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WL;

namespace SisPronaSur
{
    public partial class Impresion : Form
    {
        public Impresion()
        {
            InitializeComponent();
        }
        Tickets ticket1 = new Tickets();
        private void btnInicializar_Click(object sender, EventArgs e)
        {
            ticket1.Limpiar();
            ticket1.Logo("buy.png");
            ticket1.Titulo("PronaSUR");
            ticket1.Encabezado("Sucursal Arequipa");
            //ticket1.Encabezado("CIUDAD CODIGO POSTAL");
            ticket1.Encabezado("RFC: ABC12345678");
            ticket1.Encabezado("FECHA: " + DateTime.Now.ToShortDateString());
            int nArticulos = 5;
            for (int i = 0; i < nArticulos; i++)
            {
                ticket1.Articulo("123456789", "1 PZ", "ARTICULO DE PRUEBA NUMERO UNO", "10", "10");
            }
            //ticket1.Articulo("123456789", "1 PZ", "ARTICULO DE PRUEBA NUMERO UNO", "10", "10");
            //ticket1.Articulo("123453254", "2 PZ", "ARTICULO DE PRUEBA NUMERO DOS", "15", "30");
            
            ticket1.NumArticulos(nArticulos.ToString());
            ticket1.Total("40");
            ticket1.Pago("EFECTIVO:", "10");
            ticket1.Pago("DOLARES ($18.50) :", "0");
            //ticket1.Pago("TARJETA:", "10");
            //ticket1.Pago("VALES:", "20");
            ticket1.Pago("CAMBIO:", "0");
            ticket1.Pie("=================================================");
            ticket1.Pie("GRACIAS POR SU PREFERENCIA!!");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //ticket1.Imprimir("", true); //Ticket para impresora de 58mm
            ticket1.Imprimir();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ticket1.PDF();
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            ticket1.VistaPrevia();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ticket1.Limpiar();
        }

        private void Impresion_Load(object sender, EventArgs e)
        {

        }
    }
}
