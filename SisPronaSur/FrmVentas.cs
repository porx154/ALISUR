using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using SisPronaSur.Menu;

namespace SisPronaSur
{
    public partial class FrmVentas : MetroFramework.Forms.MetroForm
    {
        Entidad objentidad = new Entidad();
        private string serie;
        private string numero;
        private double Total = 0;
        private double Totalquitar = 0;
        DataRow dr;
        public static DataTable deta = new DataTable();
        
        public FrmVentas()
        {
            InitializeComponent();

        }
        public void cargarSerie()
        {
            objentidad.CodSucursalFKVenta = Acesso.FrmPorxLogin.CodSucursal;
            Negocio.NegSerieNumeroCompra(objentidad);

            if (Convert.ToString(objentidad.serieCompra).Length == 1)
            {
                serie = "00" + Convert.ToString(objentidad.serieCompra);
            }
            else if (Convert.ToString(objentidad.serieCompra).Length == 2)
            {
                serie = "0" + Convert.ToString(objentidad.serieCompra);
            }
            else
            {
                serie = Convert.ToString(objentidad.serieCompra);
            }
            //numero
            if (Convert.ToString(objentidad.numCompra).Length == 1)
            {
                numero = "0000" + Convert.ToString(objentidad.numCompra);
            }
            else if (Convert.ToString(objentidad.numCompra).Length == 2)
            {
                numero = "000" + Convert.ToString(objentidad.numCompra);
            }
            else if (Convert.ToString(objentidad.numCompra).Length == 3)
            {
                numero = "00" + Convert.ToString(objentidad.numCompra);
            }
            else if (Convert.ToString(objentidad.numCompra).Length == 4)
            {
                numero = "0" + Convert.ToString(objentidad.numCompra);
            }
            else
            {
                numero = Convert.ToString(objentidad.numCompra);
            }
            txtseriecomp.Text = serie;
            txtnumcomp.Text = numero;
        }
        public void cargar_dato_proveedor(string dniproveedor)
        {
            
            objentidad.dniProveedor = dniproveedor;
            Negocio.NegBuscarProveedorDni(objentidad);
            txtnomapepro.Text = objentidad.NombreyApellidoProveedor;
            txtrucproven.Text = objentidad.rucProveedor;
            objentidad.CodProveedorFKVenta = objentidad.CodProveedorFKVenta;
            
        }
        public void cargar_cmbproducto()
        {
            cmbproductoventa.DataSource = Negocio.NegListarProducto();
            cmbproductoventa.DisplayMember = "nomProducto";
            cmbproductoventa.ValueMember = "CodProducto";

        }
        public void cargar_estado()
        {
            cmbestado.DataSource = Negocio.NegListarEstado();
            cmbestado.DisplayMember = "DesEstado";
            cmbestado.ValueMember = "CodEstado";
        }
        public void cargar_cmbtipoproducto(string codproducto)
        {
            objentidad.CodProductoFKTipo = codproducto;
            cmbtippro.DataSource = Negocio.NegListarTipoProducto(objentidad);
            cmbtippro.DisplayMember = "desTipoProducto";
            cmbtippro.ValueMember = "CodTipoProdcuto";
        }
        public void cargar_precio_producto(string nomproducto)
        {
            objentidad.nomProducto = nomproducto;
            Negocio.NegPrecioProducto(objentidad);
            txtpreproducto.Text = Convert.ToString(objentidad.preProducto);
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                cargarSerie();
                cargar_cmbproducto();
                cargar_estado();
                cargar_cmbtipoproducto(cmbproductoventa.SelectedValue.ToString());
                cargar_precio_producto(cmbproductoventa.Text);
                btnquitar.Enabled = false;
                deta.Columns.Clear();
                deta.Columns.Add("Codigo");
                deta.Columns.Add("Peso");
                deta.Columns.Add("Descripcion");
                deta.Columns.Add("CodTipo");
                deta.Columns.Add("PrecioUnitario");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdniprovent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cargar_dato_proveedor(txtdniprovent.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            //MDIPrincipalUsuario.cargar_saldo("HOLAA");
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento.FrmManProveedor frmprove = new Mantenimiento.FrmManProveedor();
                frmprove.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGenerarCompra frmcom = new FrmGenerarCompra();
            try
            {
                if (txtpreproducto.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el PRECIO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtpeso.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el PESO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //dr = deta.Rows.Find(txtdniprovent.Text);
                    //if(dr == null)
                    //{
                    //    dr = deta.NewRow();
                    //    dr["PESO"] = txtpeso.Text;
                    //    dr["DESCRIPCION"] = cmbproducto.Text + ", " + cmbtippro.Text;
                    //    dr["P. UNITARIO"] = txtpreproducto.Text;
                    //    deta.Rows.Add(dr);
                    //}else
                    //{
                    //    //
                    //}
                    //deta.AcceptChanges();

                    dgvdetallecompra.Rows.Add(cmbproductoventa.SelectedValue.ToString(),txtpeso.Text, cmbproductoventa.Text+'-'+cmbtippro.Text, cmbtippro.SelectedValue.ToString(), txtpredetprod.Text);

                    Total += Convert.ToDouble(txtpredetprod.Text) * Convert.ToDouble(txtpeso.Text);

                    //totalcompra = Convert.ToDouble(txtpeso.Text) * Convert.ToDouble(txtpredetprod.Text);
                    //totalcompra = preciounitario * peso;
                    //txttotpro.Text = Convert.ToString(totalcompra);
                    //btnagregar.Enabled = false;
                    
                }
                txttotpro.Text = Convert.ToString(Total);
                //DataRow row = deta.NewRow();
                //row["Codigo"] = cmbproductoventa.SelectedValue.ToString();
                //row["Peso"] = txtpeso.Text;
                //row["Descripcion"] = cmbproductoventa.Text+'-'+cmbtippro.Text;
                //row["CodTipo"] = cmbtippro.SelectedValue.ToString();
                //row["PrecioUnitario"] = txtpredetprod.Text;
                //deta.Rows.Add(row);
                //frmcom.dtgenerar = deta;
                txtpeso.Clear();
                txtpredetprod.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtpredetprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvdetallecompra.Rows.Count > 0)
                {
                    dgvdetallecompra.Rows.RemoveAt(dgvdetallecompra.CurrentRow.Index);
                    btnagregar.Enabled = true;
                    Total = Total - Totalquitar;
                    txttotpro.Text = Convert.ToString(Total);
                    txtpredetprod.Clear();
                    txtpeso.Clear();
                    //dgvordatencion_SelectionChanged(sender, e);
                }
                //txttotpro.Text = Convert.ToString(Total); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtdniprovent.Clear();
            txtnomapepro.Clear();
            txtrucproven.Clear();
            txtpredetprod.Clear();
            txtpeso.Clear();
            txttotpro.Clear();
            dgvdetallecompra.Rows.Clear();
        }

        private void cmbproductoventa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                double saldo = 0;
                deta.Clear();
                FrmGenerarCompra frmgencompra = new FrmGenerarCompra();
                //MessageBox.Show(objentidad.CodProveedorFKVenta);
                if(txtnomapepro.Text == "")
                {
                    MessageBox.Show("El campo nombre y apellidos esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvdetallecompra.Rows.Count == 0)
                {
                    MessageBox.Show("NO EXISTE DETALLE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                frmgencompra.serie = txtseriecomp.Text;
                frmgencompra.numero = txtnumcomp.Text;
                frmgencompra.dni = txtdniprovent.Text;
                frmgencompra.nombreyapellido = txtnomapepro.Text;
                frmgencompra.ruc = txtrucproven.Text;
                frmgencompra.producto = cmbproductoventa.Text;
                frmgencompra.tipoproducto = cmbtippro.Text;
                frmgencompra.precioproducto = txtpreproducto.Text;
                frmgencompra.preciodetalle = txtpredetprod.Text;
                frmgencompra.peso = txtpeso.Text;
                frmgencompra.total = txttotpro.Text;
                frmgencompra.CodProveedor = objentidad.CodProveedorFKVenta;
                frmgencompra.DesEstado = cmbestado.Text;
                frmgencompra.CodEstado = cmbestado.SelectedValue.ToString();
                //cargando datos
                
                for (int i = 0; i<dgvdetallecompra.Rows.Count;i++ )
                {
                    //MessageBox.Show(dgvdetallecompra.Rows[i].Cells[0].Value.ToString());
                    DataRow row = deta.NewRow();
                    row["Codigo"] = dgvdetallecompra.Rows[i].Cells[0].Value.ToString();
                    row["Peso"] = dgvdetallecompra.Rows[i].Cells[1].Value.ToString();
                    row["Descripcion"] = dgvdetallecompra.Rows[i].Cells[2].Value.ToString();
                    row["CodTipo"] = dgvdetallecompra.Rows[i].Cells[3].Value.ToString();
                    row["PrecioUnitario"] = dgvdetallecompra.Rows[i].Cells[4].Value.ToString();
                    deta.Rows.Add(row);
                }
                //deta.Rows.Add(row);

                if(Acesso.FrmPorxLogin.Cargo == "Usuario")
                {
                    saldo = FrmMenuUsuario.saldoTienda;
                }
                if (Acesso.FrmPorxLogin.Cargo == "Usuario-Administrador")
                {
                    saldo = FrmMenuUAdmin.saldoTienda;
                     
                }
                if (Convert.ToDouble(txttotpro.Text)>saldo)
                {
                    MessageBox.Show("El saldo es INSUFICIENTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmgencompra.ShowDialog();
                }
                
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cmbproductoventa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cargar_cmbtipoproducto(cmbproductoventa.SelectedValue.ToString());
                cargar_precio_producto(cmbproductoventa.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvdetallecompra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dgvdetallecompra.SelectedRows.Count > 0)
                //{
                //    DataRowView dataRow = dgvdetallecompra.SelectedRows[0].DataBoundItem as DataRowView;
                //    txtpeso.Text = dataRow.Row["PESO"].ToString();

                //    //txtdespro.Text = dataRow.Row["nomProducto"].ToString();
                //    //txtpreproducto.Text = Convert.ToDouble(dataRow.Row["preProducto"]).ToString("#0.00");
                //    //btneliminar.Enabled = true;
                //}
                
            }
            catch
            {
            }
        }

        private void dgvdetallecompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvdetallecompra_Click(object sender, EventArgs e)
        {
            try
            {
                txtpeso.Text = dgvdetallecompra.Rows[dgvdetallecompra.CurrentRow.Index].Cells[1].Value.ToString();
                txtpredetprod.Text = dgvdetallecompra.Rows[dgvdetallecompra.CurrentRow.Index].Cells[4].Value.ToString();
                Totalquitar =Convert.ToDouble(dgvdetallecompra.Rows[dgvdetallecompra.CurrentRow.Index].Cells[4].Value.ToString()) * Convert.ToDouble(dgvdetallecompra.Rows[dgvdetallecompra.CurrentRow.Index].Cells[1].Value.ToString());
                
            }
            catch (Exception)
            {
                Total = 0;
            }
        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 46 || Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtdniprovent_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Debe ingresar sólo números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        private void dgvdetallecompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnquitar.Enabled = true;
        }
    }
}
