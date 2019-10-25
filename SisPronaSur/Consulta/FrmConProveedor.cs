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
namespace SisPronaSur.Consulta
{
    public partial class FrmConProveedor : MetroFramework.Forms.MetroForm
    {
        public static string CodProveedor;
        public static string nomProveedor;
        public static string apeProveedor;
        public static string dniProveedor;
        public static string rucProveedor;
        public static string dirProveedor;
        public static string telProveedor;
        public FrmConProveedor()
        {
            InitializeComponent();
        }
        public void listar_proveedor()
        {
            //dgvConPro.DataSource = Negocio.NegConsultarProveedor("");
            mtdgproveedor.DataSource = Negocio.NegConsultarProveedor("");
        }
        public void consultar_proveedor(string parametro)
        {
            //.DataSource = Negocio.NegConsultarProveedor(parametro);
            mtdgproveedor.DataSource = Negocio.NegConsultarProveedor(parametro);
        }
        private void FrmConProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                listar_proveedor();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtbuscar_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //consultar_proveedor(txtbuscar.Text);
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

        private void dgvConPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    CodProveedor = dgvConPro.CurrentRow.Cells[0].Value.ToString();
            //    nomProveedor = dgvConPro.CurrentRow.Cells[1].Value.ToString();
            //    apeProveedor = dgvConPro.CurrentRow.Cells[2].Value.ToString();
            //    dniProveedor = dgvConPro.CurrentRow.Cells[3].Value.ToString();
            //    telProveedor = dgvConPro.CurrentRow.Cells[4].Value.ToString();
            //    rucProveedor = dgvConPro.CurrentRow.Cells[5].Value.ToString();
            //    dirProveedor = dgvConPro.CurrentRow.Cells[6].Value.ToString();

                
            //    Mantenimiento.FrmManProveedor frmpro = new Mantenimiento.FrmManProveedor();
            //    frmpro.habilitar_controles();
                
            //    frmpro.ShowDialog();
                
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void mtbtnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mttxtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                consultar_proveedor(mttxtbuscar.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtdgproveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CodProveedor = mtdgproveedor.CurrentRow.Cells[0].Value.ToString();
                nomProveedor = mtdgproveedor.CurrentRow.Cells[1].Value.ToString();
                apeProveedor = mtdgproveedor.CurrentRow.Cells[2].Value.ToString();
                dniProveedor = mtdgproveedor.CurrentRow.Cells[3].Value.ToString();
                telProveedor = mtdgproveedor.CurrentRow.Cells[4].Value.ToString();
                rucProveedor = mtdgproveedor.CurrentRow.Cells[5].Value.ToString();
                dirProveedor = mtdgproveedor.CurrentRow.Cells[6].Value.ToString();


                Mantenimiento.FrmManProveedor frmpro = new Mantenimiento.FrmManProveedor();
                frmpro.habilitar_controles();

                frmpro.ShowDialog();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
