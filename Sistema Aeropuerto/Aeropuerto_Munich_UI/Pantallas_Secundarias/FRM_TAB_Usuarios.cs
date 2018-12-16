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

namespace Aeropuerto_Munich_UI.Pantallas_Secundarias
{
    public partial class FRM_TAB_Usuarios : Form
    {
        public FRM_TAB_Usuarios()
        {
            InitializeComponent();
        }


        cls_Usuarios_DAL OBJ_Usuarios_DAL = new cls_Usuarios_DAL();
        cls_Usuarios_BLL OBJ_Usuarios_BLL = new cls_Usuarios_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Usuarios OBJ_Editar_Usuarios = new Pantallas_Terciarias.FRM_Editar_Usuarios();

                OBJ_Usuarios_DAL.CAccion = 'U';
                OBJ_Usuarios_DAL.sUsername = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();
                OBJ_Usuarios_DAL.sIdEmpleado = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Usuarios_DAL.cIDEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[2].Value.ToString());

                OBJ_Editar_Usuarios.OBJ_Editar_Usuarios = OBJ_Usuarios_DAL;

                OBJ_Editar_Usuarios.ShowDialog();

                txt_Filtrar.Text = string.Empty;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener un usuario seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Usuarios OBJ_Editar_Usuarios = new Pantallas_Terciarias.FRM_Editar_Usuarios();

            OBJ_Usuarios_DAL.CAccion = 'I';

            OBJ_Editar_Usuarios.OBJ_Editar_Usuarios = OBJ_Usuarios_DAL;

            OBJ_Editar_Usuarios.ShowDialog();

            txt_Filtrar.Text = string.Empty;
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                OBJ_Usuarios_BLL.Eliminar(ref OBJ_Usuarios_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("Se ha eliminado exitósamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Filtrar.Text = string.Empty;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("El dato que ha seleccionado no pudo ser borrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Pantallas_Primarias.FRM_Menu OBJ_Menu = new Pantallas_Primarias.FRM_Menu();
            OBJ_Menu.Show();
            this.Close();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FRM_TAB_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Usuarios_BLL.Listar(ref OBJ_Usuarios_DAL);
            }
            else
            {
                OBJ_Usuarios_BLL.Filtrar(ref OBJ_Usuarios_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Usuarios_DAL.sError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Usuarios_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Usuarios_DAL.sError + " ]");
            }
        }
    }
}
