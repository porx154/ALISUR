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
    public partial class FrmAlmGenConfirm : MetroFramework.Forms.MetroForm
    {
        Entidad objEnt = new Entidad();
        public FrmAlmGenConfirm()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlmGenConfirm_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_almacen();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void cargar_almacen()
        {
            try
            {
                dgalmacengeneral.DataSource = Negocio.NegListarAlmGeneral();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtcodconfirmacion.Text == "")
                {
                    MessageBox.Show("El campo de CONFIRMACION esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                objEnt.codigoConfirmacion = txtcodconfirmacion.Text;
                if (Negocio.NegBuscarConfirmacionConfirmacion(objEnt))
                {
                    //validar codigo repetido
                    //MessageBox.Show(objEnt.cantidadConfirmacion.ToString());
                    objEnt.CodSucuralFKAlmacenGeneral = Acesso.FrmPorxLogin.CodSucursal;
                    objEnt.CantKilo = objEnt.cantidadConfirmacion;
                    int rptconfi = Negocio.NegAfirmarConfirmacion(objEnt);
                    int rpta = Negocio.NegRegistrarAlmacenGeneral(objEnt);
                    if(rpta == 1 && rptconfi == 1)
                    {
                        MessageBox.Show("Se añadio un Registro en el Almacen General", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar_almacen();
                    } else
                    {
                        MessageBox.Show("Error al registrar en el almacen general","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else
                {
                    MessageBox.Show("No se encontro CODIGO o YA EXISTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
