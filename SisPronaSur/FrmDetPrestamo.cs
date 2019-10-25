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
    public partial class FrmDetPrestamo : MetroFramework.Forms.MetroForm
    {
        Entidad objEntidad = new Entidad();
        string codigo;
        string codigoDetalle="";
        double total = 0;
        string estadopredet;
        double saldo;
        public FrmDetPrestamo()
        {
            InitializeComponent();
        }

        private void FrmDetPrestamo_Load(object sender, EventArgs e)
        {
            cargar_datos();
            cargar_total();
            cargar_saldo();
            calcular_interes();
            //cargar_total_adelanto();
            //cargar_producto();
        }
        
        public void cargar_saldo()
        {
            if (dgprestamo.Rows.Count > 0)
            {
                saldo = 0;
                for (int i = 0; i < dgprestamo.Rows.Count; i++)
                {
                    saldo= Convert.ToDouble(dgprestamo.Rows[i].Cells[5].Value.ToString());
                }
               txtsaldo.Text = Convert.ToString(saldo);
            }
            else
            {
                txttotal.Text = Convert.ToString(0);
            }
        }
        public void calcular_interes()
        {
            txtinteresSoles.Text = Convert.ToString(Convert.ToDouble(txtsaldo.Text)*0.01);
        }
        public void cargar_adelanto()
        {
            dgadelanto.DataSource = Negocio.NegListarDetAdelanto();
        }
        public void cargar_producto()
        {
            cmbproducto.DataSource = Negocio.NegListarProducto();
            cmbproducto.DisplayMember = "nomProducto";
            cmbproducto.ValueMember = "CodProducto";
            cargar_tipoproducto(cmbproducto.SelectedValue.ToString());
        }
        public void cargar_tipoproducto(string codigoProducto)
        {
            objEntidad.CodProductoFKTipo = codigoProducto;
            cmbtipoproducto.DataSource = Negocio.NegListarTipoProducto(objEntidad);
            cmbtipoproducto.DisplayMember = "desTipoProducto";
            cmbtipoproducto.ValueMember = "CodTipoProdcuto";
        }
        public void cargar_datos()
        {

            //adelanto
            codigo = Consulta.FrmConPrestamo.codigoprestamo;
            //txttipocambio.Text = codigo;
            objEntidad.codPrestamoFKDetall = codigo;
            txtdatos.Text = Consulta.FrmConPrestamo.datosNomApe;
            //txtfechdevolucion.Text = Consulta.FrmConPrestamo.fechdevolucion;
            txtmontoprestado.Text = Consulta.FrmConPrestamo.montoprestado;
            txtfechIniPrestamo.Text = Convert.ToDateTime(Consulta.FrmConPrestamo.fechPrestamo).ToShortDateString();
            txtdetInteres.Text = Consulta.FrmConPrestamo.interesPrestamo;
            //cargar_prestamo();
            estadopredet = Consulta.FrmConPrestamo.estadoprestamo;
            //if (estadopredet == "Cancelado") btncancelprestamo.Enabled = false;
            cargar_lista_detalle(objEntidad);
            tabControl1.SelectedTab = tabPage1;
            
        }
        public void cargar_lista_detalle(Entidad objEntidad)
        {
            dgprestamo.DataSource = Negocio.NegListarDetPrestamo(objEntidad);
        }
        public void limpiar_controles()
        {
            //txttipocambio.Text = Convert.ToString(0);
            //txtinteresSoles.Text = Convert.ToString(0);
            txtaumento.Text = Convert.ToString(0);
            txtmontoprestamo.Text = Convert.ToString(0);
            txtdescprest.Clear();
            
        }
        public void habilitar_controles()
        {
            //txttipocambio.Enabled = true;
            //txtinteresSoles.Enabled = true;
            txtaumento.Enabled = true;
            txtmontoprestamo.Enabled = true;
            txtdescprest.Enabled = true;
           
        }
        public void deshabilitar_controles()
        {
            txtaumento.Enabled = false;
            txtmontoprestamo.Enabled = false;
            txtdescprest.Enabled = false;
            btnagregar.Enabled = false;
            btnnuevo.Enabled = false;
            btnsumar.Enabled = false;
        }
     
        public void limpiar_controles_adelanto()
        {
            txtdescadd.Clear();
            txtmontoproducto.Clear();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //cargamos total de intereses
        public void cargar_total()
        {
            if (dgprestamo.Rows.Count > 0)
            {
                total = 0;
                for (int i = 0; i < dgprestamo.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgprestamo.Rows[i].Cells[3].Value.ToString());
                }
                txttotal.Text = Convert.ToString(total);
            }
            else
            {
                txttotal.Text = Convert.ToString(0);
            }
        }
        public void cargar_total_adelanto()
        {
            if (dgadelanto.Rows.Count > 0)
            {
                total = 0;
                for (int i = 0; i < dgadelanto.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgadelanto.Rows[i].Cells[1].Value.ToString());
                }
                txttotaladd.Text = Convert.ToString(total);
            }else
            {
                txttotaladd.Text = Convert.ToString(0);
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //string tcambio;
            string tmonto;
            string tinteres;
            try
            {
                
                if(txtdescprest.Text == "")
                {
                    MessageBox.Show("NECESITA DESCRIPCION", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (txtinteresSoles.Text == "")
                {
                    MessageBox.Show("NECESITA MONTO DE INTERES", "INTERES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtmontoprestamo.Text == "")
                {
                    MessageBox.Show("NECESITA MONTO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(Convert.ToDouble(txtmontoprestamo.Text) > Convert.ToDouble(txtmontoprestado.Text))
                {
                    MessageBox.Show("MONTO NO PUEDE SER MAYOR A LO PRESTADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar_controles();
                }else if (Convert.ToDouble(txtmontoprestamo.Text) > Convert.ToDouble(txtsaldo.Text))
                {
                    MessageBox.Show("MONTO NO PUEDE SER MAYOR A LO SALDADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar_controles();
                }
                else
                {
                    
                        objEntidad.codDetPrestamo = codigoDetalle;
                        objEntidad.codPrestamoFKDetall = codigo;
                        tmonto = txtmontoprestamo.Text;
                        objEntidad.montodetPrestamo = Convert.ToDouble(tmonto.Replace(".", ","));
                        //tinteres = txtinteresSoles.Text;
                        //objEntidad.montodetInteres = Convert.ToDouble(tinteres.Replace(".",","));
                        //tcambio = txttipocambio.Text;
                        //objEntidad.tipoCambio = Convert.ToDouble(tcambio.Replace(".",","));
                        //objEntidad.cantProductoPrestamo = 0;
                        objEntidad.desDetPrestamo = txtdescprest.Text;

                        int rpta = Negocio.NegRegistrarDetPrestamo(objEntidad);
                        if (rpta == 1)
                        {

                            MessageBox.Show("PRESTAMO PAGADO", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar_datos();
                            cargar_total();
                            cargar_saldo();
                            calcular_interes();
                            limpiar_controles();
                            if (txtsaldo.Text == Convert.ToString(0))
                            {
                                int rptu = Negocio.NegCancelarDeudaPrestamo(objEntidad);
                                limpiar_controles();
                                deshabilitar_controles();
                                cargar_total();
                            //objetos de gastos
                            objEntidad.codgastogeneral = "";
                            objEntidad.desgasto = "INTERES PAGO CAMBISTA";
                            objEntidad.montogasto = Convert.ToDouble(txttotal.Text);
                            objEntidad.codPersonalFKGasto = Acesso.FrmPorxLogin.CodPersonal;
                            objEntidad.codTipoGastoFKGasto = "TG00001";
                                int rptg = Negocio.NegMantenerGasto(objEntidad);
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("ERROR EN EL REGISTRO DE PRESTAMO", "ERROR - PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmbtipoproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_tipoproducto(cmbproducto.SelectedValue.ToString());
        }

        private void cmbproducto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar_controles();
                habilitar_controles();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btncancelprestamo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            string tmonto;
            try
            {
                if(txtaumento.Text == "")
                {
                    MessageBox.Show("ES NECESARIO UN MONTO DE AUMENTO A LA DEUDA", "AUMENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    objEntidad.codDetPrestamo = codigoDetalle;
                    objEntidad.codPrestamoFKDetall = codigo;
                    tmonto = txtaumento.Text;
                    objEntidad.montodetPrestamo = Convert.ToDouble(tmonto.Replace(".", ","));
                    //tinteres = txtinteresSoles.Text;
                    //objEntidad.montodetInteres = Convert.ToDouble(tinteres.Replace(".",","));
                    //tcambio = txttipocambio.Text;
                    //objEntidad.tipoCambio = Convert.ToDouble(tcambio.Replace(".",","));
                    //objEntidad.cantProductoPrestamo = 0;
                    //objEntidad.desDetPrestamo = txtdescprest.Text;

                    int rpta = Negocio.NegRegistrarDetAumentoPrestamo(objEntidad);
                    if (rpta == 1)
                    {

                        MessageBox.Show("SE REALIZO UN AUMENTO A LA DEUDA", "AUMENTO - DEUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        cargar_datos();
                        cargar_total();
                        cargar_saldo();
                        calcular_interes();
                        limpiar_controles();
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN EL REGISTRO DE PRESTAMO", "ERROR - PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtmontoprestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void txtaumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
