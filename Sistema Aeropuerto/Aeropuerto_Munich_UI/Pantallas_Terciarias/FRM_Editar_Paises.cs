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
        public cls_Paises_DAL OBJ_Paises_DAL;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();


        public cls_Paises_DAL OBJ_Editar_Paises;

        #endregion

        #region EVENTOS


        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            // Validación de los campos a incluir

            if (txt_Nombre.Text == string.Empty ||
                txt_Codigo_Area.Text == string.Empty ||
                txt_Codigo_Pais.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los campos antes de continuar", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                return;

            }


            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("Debe seleccionar un estado antes de continuar",
                                "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                return;
            }
            else
            {

                OBJ_Paises_BLL = new cls_Paises_BLL();

                OBJ_Editar_Paises.IIdPais = Convert.ToInt16(txt_ID.Text.ToString());
                OBJ_Editar_Paises.SNombrePais = txt_Nombre.Text;
                OBJ_Editar_Paises.SCodigoISOPais = txt_Codigo_Pais.Text.ToString();
                OBJ_Editar_Paises.SCodigoAreaPais = txt_Codigo_Area.Text.ToString();
                OBJ_Editar_Paises.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Paises.CAccion == 'I')
                {
                    OBJ_Paises_BLL.Insertar(ref OBJ_Editar_Paises);

                    if (OBJ_Editar_Paises.SError == string.Empty)
                    {
                        MessageBox.Show("El país se guardó exitosamente ", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de guardar el nuevo país. \n \n Error [ " + OBJ_Editar_Paises.SError + " ].", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Paises_BLL.Modificar(ref OBJ_Editar_Paises);

                    if (OBJ_Editar_Paises.SError == string.Empty)
                    {
                        MessageBox.Show("Se modificó exitosamente información del país", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de modificar información del país. \n \n Error [ " + OBJ_Editar_Paises.SError + " ].", "Error",
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
                txt_ID.Text = OBJ_Editar_Paises.IIdPais.ToString();
                txt_Nombre.Text = OBJ_Editar_Paises.SNombrePais;
                txt_Codigo_Pais.Text = OBJ_Editar_Paises.SCodigoISOPais;
                txt_Codigo_Area.Text = OBJ_Editar_Paises.SCodigoAreaPais;

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

                OBJ_Estados_DAL.OBJ_DataTable.Rows.Add("-", "-- Debe seleccionar un estado --");

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
        private void txt_Codigo_Pais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion


    }
}
    