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
    public partial class FrmMezclarProducto : MetroFramework.Forms.MetroForm
    {
        Entidad objEntidad = new Entidad();
        public FrmMezclarProducto()
        {
            InitializeComponent();
        }

        private void FrmMezclarProducto_Load(object sender, EventArgs e)
        {
            cargar_producto(cmbprobase);
            cargar_tipo_producto(cmbprobase.SelectedValue.ToString(), cmbtipoprobase);

        }
        public void cargar_producto(ComboBox cmbproducto)
        {
            cmbproducto.DataSource = Negocio.NegListarProducto();
            cmbproducto.DisplayMember = "nomProducto";
            cmbproducto.ValueMember = "CodProducto";
        }
        public void cargar_tipo_producto(string codproducto, ComboBox cmbtipo)
        {
            objEntidad.CodProductoFKTipo = codproducto;
            cmbtipo.DataSource = Negocio.NegListarTipoProducto(objEntidad);
            cmbtipo.DisplayMember = "desTipoProducto";
            cmbtipo.ValueMember = "CodTipoProdcuto";
        }
        public void limpiar_controles()
        {
            txtcantprobase.Enabled = true;
            txtcantproania.Enabled = true;
            txtcantprobase.Clear();
            txtcantproania.Clear();
            txtcantprobase.Focus();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void cmbprobase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_tipo_producto(cmbprobase.SelectedValue.ToString(), cmbtipoprobase);
        }
    }
}
