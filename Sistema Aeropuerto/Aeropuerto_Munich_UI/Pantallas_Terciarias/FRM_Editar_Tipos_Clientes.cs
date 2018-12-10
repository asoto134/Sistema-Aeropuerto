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
    public partial class FRM_Editar_Tipos_Clientes : Form
    {
        public FRM_Editar_Tipos_Clientes()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

        cls_Tipo_Clientes_BLL OBJ_Tipo_Clientes_BLL = new cls_Tipo_Clientes_BLL();
        public cls_Tipo_Clientes_DAL OBJ_Editar_Tipo_Clientes_DAL;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();

        #endregion

        #region EVENTOS


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_TipoCliente.Text == string.Empty || txt_ID.Text == string.Empty)
            {
                MessageBox.Show("Debe completar los datos antes de continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO PARA GUARDAR LA INFORMACIÓN","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {

                OBJ_Tipo_Clientes_BLL = new cls_Tipo_Clientes_BLL();

                OBJ_Editar_Tipo_Clientes_DAL.IIdTipoCliente = Convert.ToChar(txt_ID.Text.ToString());
                OBJ_Editar_Tipo_Clientes_DAL.STipoCliente = txt_TipoCliente.Text;
                OBJ_Editar_Tipo_Clientes_DAL.SDescripcion = txt_Descripcion.Text;
                OBJ_Editar_Tipo_Clientes_DAL.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Tipo_Clientes_DAL.CAccion == 'I')
                {
                    OBJ_Tipo_Clientes_BLL.Insertar(ref OBJ_Editar_Tipo_Clientes_DAL);

                    if (OBJ_Editar_Tipo_Clientes_DAL.SError == string.Empty)
                    {
                        MessageBox.Show("Se guardó exitosamente el tipo de cliente", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de guardar el tipo de cliente. \n \n Error [ " + OBJ_Editar_Tipo_Clientes_DAL.SError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Tipo_Clientes_BLL.Modificar(ref OBJ_Editar_Tipo_Clientes_DAL);

                    if (OBJ_Editar_Tipo_Clientes_DAL.SError == string.Empty)
                    {
                        MessageBox.Show("Se modificó exitosamente el tipo de cliente", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de modificar el tipo de cliente. \n \n Error [ " + OBJ_Editar_Tipo_Clientes_DAL.SError + " ].", "ERROR",
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

        private void FRM_Editar_Tipo_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }
        

        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarCombos();

            if (OBJ_Editar_Tipo_Clientes_DAL.CAccion == 'I')
            {
                txt_ID.Enabled = true;
                txt_ID.Text = string.Empty;
                txt_TipoCliente.Text = string.Empty;
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar un Tipo de Cliente:";
            }
            else
            {
                txt_ID.Enabled = false;
                txt_ID.Text = OBJ_Editar_Tipo_Clientes_DAL.IIdTipoCliente.ToString();
                txt_TipoCliente.Text = OBJ_Editar_Tipo_Clientes_DAL.STipoCliente.ToString();
                txt_Descripcion.Text = OBJ_Editar_Tipo_Clientes_DAL.SDescripcion.ToString();
                cmb_Estados.SelectedValue = OBJ_Editar_Tipo_Clientes_DAL.CIdEstado.ToString();
                grp_Informacion.Text = "Modificar un Tipo de Cliente";
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
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE ESTADOS.\n\nERROR: [ " + OBJ_Estados_DAL.SError + " ].", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}

        #endregion
