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


namespace Aeropuerto_Munich_UI.Pantallas_Secundarias
{
    public partial class FRM_TAB_Empleados : Form
    {
        public FRM_TAB_Empleados()
        {
            InitializeComponent();
        }
        //INSTANCEAR EL OBJ DE LA TABLA CREADA
        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();

        //CREACION METODO PARA CARGAR LOS DATOS EN LA TABLA
        private void CargarDatos()
        {
            if (txt_Filtrar.Text == string.Empty)
            {
                Obj_Empleados_BLL.ListarEmpleados(ref Obj_Empleados_DAL);
            }
            else
            {
                Obj_Empleados_BLL.FiltrarEmpleados(ref Obj_Empleados_DAL, txt_Filtrar.Text);
            }

            //VERIFICACION DE MSJ DE ERROR
            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = Obj_Empleados_DAL.Obj_DataTable;
            }
            else
            {
                MessageBox.Show("No se a podido cargar los datos. \n\n Error [ " + Obj_Empleados_DAL.sMsjError + " ].",
                                "ERROr",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Empleados Obj_Editar_Empleados = new Pantallas_Terciarias.FRM_Editar_Empleados();

                Obj_Empleados_DAL.cAccion = 'U';
                Obj_Empleados_DAL.cIdEmpleado = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();
                Obj_Empleados_DAL.cCedula = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Empleados_DAL.cNombreEmpleado = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                Obj_Empleados_DAL.cApellidoEmpleado = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString();
                Obj_Empleados_DAL.cDireccion = dgv_Datos.SelectedRows[0].Cells[4].Value.ToString();
                Obj_Empleados_DAL.cEdad = dgv_Datos.SelectedRows[0].Cells[5].Value.ToString();
                Obj_Empleados_DAL.cTelCasa = dgv_Datos.SelectedRows[0].Cells[6].Value.ToString();
                Obj_Empleados_DAL.cTelRef = dgv_Datos.SelectedRows[0].Cells[7].Value.ToString();
                Obj_Empleados_DAL.cCelular = dgv_Datos.SelectedRows[0].Cells[8].Value.ToString();
                Obj_Empleados_DAL.dSalario = Convert.ToDecimal(dgv_Datos.SelectedRows[0].Cells[9].Value.ToString());
                Obj_Empleados_DAL.cIdTipoEmpleado = dgv_Datos.SelectedRows[0].Cells[10].Value.ToString();
                Obj_Empleados_DAL.cIdAerolinea = dgv_Datos.SelectedRows[0].Cells[11].Value.ToString();
                Obj_Empleados_DAL.cIdEstado = dgv_Datos.SelectedRows[0].Cells[12].Value.ToString();

                Obj_Editar_Empleados.Obj_Editar_Empleados = Obj_Empleados_DAL;

                Obj_Editar_Empleados.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("DEBE DE SELECCIONAR UN ESTADO, AEROLINEA Y TIPO DE EMPLEADO ",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Empleados Obj_Editar_Empleados = new Pantallas_Terciarias.FRM_Editar_Empleados();

            Obj_Empleados_DAL.cAccion = 'I';
            Obj_Editar_Empleados.Obj_Editar_Empleados = Obj_Empleados_DAL;
            Obj_Editar_Empleados.ShowDialog();
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FRM_TAB_Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Pantallas_Primarias.FRM_Menu Obj_Menu = new Pantallas_Primarias.FRM_Menu();
            Obj_Menu.ShowDialog();
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                Obj_Empleados_BLL.EliminarEmpleados(ref Obj_Empleados_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Se ha eliminado exitosamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("El dato seleccionado no puede ser eliminado.", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatos();
        }
    }
}
