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
namespace SisPronaSur.Consulta
{
    public partial class FrmConAlmTiendaAdmin : MetroFramework.Forms.MetroForm
    {
        private double total;
        private double saldo;
        private double retirar;
        private string codigoProducto;
        Entidad objentidad = new Entidad();
        public FrmConAlmTiendaAdmin()
        {
            InitializeComponent();
        }
        public void cargar_sucursal()
        {
            try
            {
                cmbsucursal.DataSource = Negocio.NegListarSucursal();
                cmbsucursal.DisplayMember = "nomSucursal";
                cmbsucursal.ValueMember = "CodSucursal";
            }
            catch (Exception)
            {

                throw;
            }
        }
        public double cargar_total()
        {
            if (dgvalmacen.Rows.Count > 0)
            {
                for (int i = 0; i < dgvalmacen.Rows.Count; i++)
                {
                    total = Convert.ToDouble(dgvalmacen.Rows[i].Cells[3].Value.ToString());
                    codigoProducto = dgvalmacen.Rows[i].Cells[5].Value.ToString();
                }
            }
            else
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
        private void FrmConAlmTiendaAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal();
                listar_almacen(cmbsucursal.SelectedValue.ToString());
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

        private void cmbsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listar_almacen(cmbsucursal.SelectedValue.ToString());
                cargar_total();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
