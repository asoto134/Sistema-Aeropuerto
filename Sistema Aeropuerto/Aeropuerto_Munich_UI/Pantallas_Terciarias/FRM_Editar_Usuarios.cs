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
    public partial class FRM_Editar_Usuarios : Form
    {
        #region VARIABLES GLOBALES

        cls_Usuarios_BLL OBJ_Usuarios_BLL = new cls_Usuarios_BLL();
        public cls_Usuarios_DAL OBJ_Editar_Usuarios;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();

        cls_Empleados_BLL OBJ_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL OBJ_Empleados_DAL = new cls_Empleados_DAL();

        #endregion

        #region EVENTOS
        public FRM_Editar_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_IdEmpleado.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN IDENTIFICADOR DE EMPLEADO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

            else if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

            else
            {

                OBJ_Usuarios_BLL = new cls_Usuarios_BLL();

                OBJ_Editar_Usuarios.sUsername = txt_Username.Text;
                OBJ_Editar_Usuarios.sIdEmpleado = cmb_IdEmpleado.SelectedValue.ToString();
                OBJ_Editar_Usuarios.cIDEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Usuarios.CAccion == 'I')
                {
                    OBJ_Editar_Usuarios.sPassword = "1234";

                    OBJ_Usuarios_BLL.Insertar(ref OBJ_Editar_Usuarios);

                    if (OBJ_Editar_Usuarios.sError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo usuario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo usuario. \n \n Error [ " + OBJ_Editar_Usuarios.sError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Usuarios_BLL.Modificar(ref OBJ_Editar_Usuarios);

                    if (OBJ_Editar_Usuarios.sError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente el usuario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar el usuario. \n \n Error [ " + OBJ_Editar_Usuarios.sError + " ].", "ERROR",
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

        private void txt_Descrip_TextChanged(object sender, EventArgs e)
        {
            if (txt_Username.Text == string.Empty)
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;
            }
        }

        private void FRM_Editar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        
        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarCombos();

            if (OBJ_Editar_Usuarios.CAccion == 'I')
            {
                txt_Username.Enabled = true;
                txt_Username.Text = string.Empty;
                cmb_IdEmpleado.SelectedValue = "-";
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar Aviones";
            }
            else
            {
                txt_Username.Enabled = false;
                txt_Username.Text = OBJ_Editar_Usuarios.sUsername.ToString();
                cmb_IdEmpleado.Enabled = false;
                cmb_IdEmpleado.SelectedValue = OBJ_Editar_Usuarios.sIdEmpleado.ToString();
                cmb_Estados.SelectedValue = OBJ_Editar_Usuarios.cIDEstado.ToString();
                grp_Informacion.Text = "Modificar Aviones";
            }
        }

        private void CargarCombos()
        {

            //ESTADOS
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

            //EMPLEADOS

            OBJ_Empleados_BLL.ListarEmpleados(ref OBJ_Empleados_DAL);

            if (OBJ_Empleados_DAL.sMsjError == string.Empty)
            {
                cmb_IdEmpleado.DataSource = null;
                cmb_IdEmpleado.DataSource = OBJ_Empleados_DAL.Obj_DataTable;

        OBJ_Empleados_DAL.Obj_DataTable.Rows.Add("-", "-","-- SELECCIONAR UN EMPLEADO --");

                cmb_IdEmpleado.DisplayMember = "Nombre";
                cmb_IdEmpleado.ValueMember = "IdEmpleado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE EMPLEADOS.\n\nERROR: [ " + OBJ_Estados_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        #endregion
    }
}
