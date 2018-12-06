using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeropuerto_BLL.Cat_Man;
using Aeropuerto_DAL.Cat_Man;

namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    public partial class FRM_Editar_Paises : Form
    {
        public FRM_Editar_Paises()
        {
            InitializeComponent();
        }



        #region VARIABLES GLOBALES

        cls_Paises_BLL OBJ_Paises_BLL = new cls_Paises_BLL();

        public cls_Paises_DAL OBJ_Editar_Paises;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();

        #endregion

        #region EVENTOS


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

                OBJ_Paises_BLL = new cls_Paises_BLL();

                OBJ_Editar_Paises.IPaises = Convert.ToInt16(txt_ID.Text.ToString());
                OBJ_Editar_Paises.SNombrePais = txt_Nombre.Text;
                OBJ_Editar_Paises.CCodigoISOPais = Convert.ToChar(txt_Codigo_Pais.Text.ToString());
                OBJ_Editar_Paises.CCodigoAreaPais = Convert.ToChar(txt_Codigo_Area.Text.ToString());
                OBJ_Editar_Paises.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Paises.CAccion == 'I')
                {
                    OBJ_Paises_BLL.Insertar(ref OBJ_Editar_Paises);

                    if (OBJ_Editar_Paises.SError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ " + OBJ_Editar_Paises.SError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Paises_BLL.Modificar(ref OBJ_Editar_Paises);

                    if (OBJ_Editar_Paises.SError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente la aerolínea", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar la nueva aerolínea. \n \n Error [ " + OBJ_Editar_Paises.SError + " ].", "ERROR",
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

        private void FRM_Editar_Paises_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        private void txt_Descrip_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == string.Empty || txt_ID.Text == string.Empty)
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarCombos();

            if (OBJ_Editar_Paises.CAccion == 'I')
            {
                txt_ID.Enabled = true;
                txt_ID.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar País";
            }
            else
            {
                txt_ID.Enabled = false;
                txt_ID.Text = OBJ_Editar_Paises.IPaises.ToString();
                txt_Nombre.Text = OBJ_Editar_Paises.SNombrePais.ToString();
                
                cmb_Estados.SelectedValue = OBJ_Editar_Paises.CIdEstado.ToString();
                grp_Informacion.Text = "Modificar País";
            }
        }

        private void CargarCombos()
        {
            OBJ_Estados_BLL.Listar(ref OBJ_Estados_DAL);

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