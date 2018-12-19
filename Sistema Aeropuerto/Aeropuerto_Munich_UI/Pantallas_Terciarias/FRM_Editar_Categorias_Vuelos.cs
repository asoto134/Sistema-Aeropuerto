using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeropuerto_DAL.Cat_Man;
using Aeropuerto_BLL.Cat_Man;

namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    public partial class FRM_Editar_Categorias_Vuelos : Form
    {
        #region VARIABLES GLOBALES

        cls_CategoriasVuelos_BLL OBJ_CategoriasVuelos_BLL = new cls_CategoriasVuelos_BLL();
        public cls_CategoriasVuelos_DAL OBJ_Editar_CategoriasVuelos;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();

        #endregion

        #region EVENTOS
        public FRM_Editar_Categorias_Vuelos()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {

                OBJ_CategoriasVuelos_BLL = new cls_CategoriasVuelos_BLL();

                OBJ_Editar_CategoriasVuelos.IIdCategoria = Convert.ToInt32(txt_ID_Categoria.Text.ToString());
                OBJ_Editar_CategoriasVuelos.SDescCategoria = txt_Desc_Categoria.Text;
                OBJ_Editar_CategoriasVuelos.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_CategoriasVuelos.CAccion == 'I')
                {
                    OBJ_CategoriasVuelos_BLL.Insertar(ref OBJ_Editar_CategoriasVuelos);

                    if (OBJ_Editar_CategoriasVuelos.SError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ " + OBJ_Editar_CategoriasVuelos.SError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_CategoriasVuelos_BLL.Modificar(ref OBJ_Editar_CategoriasVuelos);

                    if (OBJ_Editar_CategoriasVuelos.SError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente la aerolínea", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar la nueva aerolínea. \n \n Error [ " + OBJ_Editar_CategoriasVuelos.SError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CargarDatosForm();
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Editar_Categorias_Vuelos_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        private void txt_Desc_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;

            }
        }

        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarCombos();

            if (OBJ_Editar_CategoriasVuelos.CAccion == 'I')
            {
                txt_ID_Categoria.Enabled = true;
                txt_ID_Categoria.Text = string.Empty;
                txt_Desc_Categoria.Text = string.Empty;
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar Categoria";
            }
            else
            {
                txt_ID_Categoria.Enabled = false;
                txt_ID_Categoria.Text = OBJ_Editar_CategoriasVuelos.IIdCategoria.ToString();
                txt_Desc_Categoria.Text = OBJ_Editar_CategoriasVuelos.SDescCategoria.ToString();
                cmb_Estados.SelectedValue = OBJ_Editar_CategoriasVuelos.CIdEstado.ToString();
                grp_Informacion.Text = "Modificar Categoria";
            }
        }

        private void CargarCombos()
        {
            OBJ_Estados_BLL.Listar_Combo(ref OBJ_Estados_DAL);

            if (OBJ_Estados_DAL.SError == string.Empty)
            {
                cmb_Estados.DataSource = null;
                cmb_Estados.DataSource = OBJ_Estados_DAL.OBJ_DataTable;

                OBJ_Estados_DAL.OBJ_DataTable.Rows.Add("-", "-- SELECCIONAR UN ESTADO --");

                cmb_Estados.DisplayMember = "Descripcion";
                cmb_Estados.ValueMember = "IdEstado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE ESTADOS.\n\nERROR: [ " + OBJ_Estados_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }


        #endregion

      
    }
}
