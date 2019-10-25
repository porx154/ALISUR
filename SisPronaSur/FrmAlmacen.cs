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
using FlashControlV71;
namespace SisPronaSur
{
    public partial class FrmAlmacen : MetroFramework.Forms.MetroForm
    {
        ErrorProvider err = new ErrorProvider();
        Entidad objentidad = new Entidad();
        private double total;
        private double saldo;
        private double retirar;
        private string codigoProducto;
        public static string globcodconfi="";
        public static double globmonto=0;
        public FrmAlmacen()
        {
            InitializeComponent();
        }
        public void cargar_sucursal()
        {
            txtsucalm.Text = Acesso.FrmPorxLogin.NomSucursal;
        }
        public double cargar_total()
        {
            if (dgvalmacen.Rows.Count > 0)
            {
                for(int i = 0; i<dgvalmacen.Rows.Count; i++)
                {
                    total = Convert.ToDouble(dgvalmacen.Rows[i].Cells[3].Value.ToString());
                    codigoProducto = dgvalmacen.Rows[i].Cells[5].Value.ToString();
                }
            }else
            {
                total = 0;
            }
            txttotalmacen.Text = Convert.ToString(total);
            return total;
        }
        public void listar_almacen(string codalmacen)
        {
            try
            {
                objentidad.CodSucursalFKAlmacen = codalmacen;
                dgvalmacen.Columns[2].DefaultCellStyle.Format = "n2";
                dgvalmacen.Columns[3].DefaultCellStyle.Format = "n2";
                dgvalmacen.DataSource = Negocio.NegListarAlmacen(objentidad);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal();
                listar_almacen(Acesso.FrmPorxLogin.CodSucursal);
                cargar_total();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        public void prueba()
        {
            
        }
        public string generar_codigo_confirmacion()
        {
            string codigogenerado = "";
            do
            {
                int longitud = 6;
                Guid miGuid = Guid.NewGuid();
                string token = Convert.ToBase64String(miGuid.ToByteArray());
                token = token.Replace("=", "").Replace("+", "");
                codigogenerado =Convert.ToString(token.Substring(0, longitud));
                objentidad.codigoConfirmacion = codigogenerado;
                //MessageBox.Show(codigogenerado);
            } while (Negocio.NegBuscarConfirmacion(objentidad));
            return codigogenerado;
        }
        private void btnretirar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfirmacion frmcon = new FrmConfirmacion();
                if(txtretalm.Text == "")
                {
                    MessageBox.Show("El campo retirar esta vacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                retirar = Convert.ToDouble(txtretalm.Text);
                if (retirar > total)
                {
                    MessageBox.Show("La cantidad que desea retirar mayor al saldo del almacen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }else
                {
                    saldo = total - retirar;
                    objentidad.cantProAlmacen = retirar;
                    objentidad.CodProductoFKAlmacen = codigoProducto;
                    objentidad.CodSucursalFKAlmacen = Acesso.FrmPorxLogin.CodSucursal;
                    objentidad.cantTotAlmacen = saldo;
                    //al general cambiar
                    objentidad.CodSucuralFKAlmacenGeneral = Acesso.FrmPorxLogin.CodSucursal;
                    objentidad.CantKilo = retirar;
                    
                    //datos confirmacion
                    objentidad.CodSucursalFKConfirmacion = Acesso.FrmPorxLogin.CodSucursal;
                    objentidad.codigoConfirmacion = generar_codigo_confirmacion();
                    globcodconfi = objentidad.codigoConfirmacion;
                    objentidad.cantidadConfirmacion = retirar;
                    globmonto = retirar;
                    objentidad.CodPersonalFKConfirmacion = Acesso.FrmPorxLogin.CodPersonal;
                    int rpta = Negocio.NegRetirarAlmacen(objentidad);
                    //int rptgrl = Negocio.NegRegistrarAlmacenGeneral(objentidad);
                    int rptacon = Negocio.NegRegistrarConfirmacion(objentidad);
                    if(rpta == 1 && rptacon ==1)
                    {

                        MessageBox.Show("El retiro fue satisfactorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar_almacen(Acesso.FrmPorxLogin.CodSucursal);
                        total = 0;
                        cargar_total();
                        frmcon.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al retirar producto", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtretalm_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtretalm.Text) > 0)
                {
                    e.Cancel = false;
                    err.SetError(txtretalm, "");
                }
                else
                {
                    e.Cancel = true;
                    err.SetError(txtretalm, "Debe ingresar un precio válido");
                }
            }
            catch
            {
            }
        }

        private void txtretalm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
