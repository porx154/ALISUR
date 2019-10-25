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
    public partial class FrmConCompras : MetroFramework.Forms.MetroForm
    {
        string codigoCompra = "";
        double totalCompra = 0;
        public FrmConCompras()
        {
            InitializeComponent();
        }
        public void cargar_sucursal()
        {
            mtcmbsucursal.DataSource = Negocio.NegListarSucursal();
            mtcmbsucursal.DisplayMember = "nomSucursal";
            mtcmbsucursal.ValueMember = "CodSucursal";
        }
        public void cargar_compra_actual()
        {
            mtdgcompra.DataSource = Negocio.NegListarCompraActual(mtcmbsucursal.SelectedValue.ToString());
        }
        private void FrmConVentas_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal();
                cargar_compra_actual();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtbtnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                mtdgcompra.DataSource = Negocio.NegListarCompraPorFechaSucursal(mtcmbsucursal.SelectedValue.ToString(), Convert.ToDateTime(mtdtfecha.Value.ToShortDateString()));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtdgcompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (mtdgcompra.SelectedRows.Count > 0)
                {
                    DataRowView datarow = mtdgcompra.SelectedRows[0].DataBoundItem as DataRowView;
                    codigoCompra = datarow.Row["CodCompra"].ToString();
                    mtdgdetcompra.DataSource = Negocio.NegListarDetalleCompra(codigoCompra);
                    for (int i = 0; i < mtdgdetcompra.Rows.Count; i++)
                    {
                        totalCompra += Convert.ToDouble(mtdgdetcompra.Rows[i].Cells[2].Value.ToString());
                    }
                    mttxttotcompra.Text = Convert.ToString(totalCompra);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
