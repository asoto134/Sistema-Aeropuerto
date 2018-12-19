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
    public partial class FRM_TAB_Cliente : Form
    {
        public FRM_TAB_Cliente()
        {
            InitializeComponent();
        }

        cls_Cliente_BLL Obj_Cliente_BLL = new cls_Cliente_BLL();
        cls_Cliente_DAL Obj_Cliente_DAL = new cls_Cliente_DAL();

        private void CargarDatos()
        {
            if (txt_Filtrar.Text == string.Empty)
            {
                Obj_Cliente_BLL.ListarCliente(ref Obj_Cliente_DAL);
            }
            else
            {
                Obj_Cliente_BLL.FiltrarCliente(ref Obj_Cliente_DAL, txt_Filtrar.Text);
            }

            if (Obj_Cliente_DAL.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = Obj_Cliente_DAL.Obj_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [" + Obj_Cliente_DAL.sMsjError + "]");
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Cliente Obj_Editar_Cliente = new Pantallas_Terciarias.FRM_Editar_Cliente();

            Obj_Cliente_DAL.cAccion = 'I';

            Obj_Editar_Cliente.Obj_Editar_Cliente = Obj_Cliente_DAL;

            Obj_Editar_Cliente.ShowDialog();

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

        private void FRM_TAB_Cliente_Load(object sender, EventArgs e)
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
                Obj_Cliente_BLL.EliminarCliente(ref Obj_Cliente_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Se ha eliminado exitósamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El dato que ha seleccionado no pudo ser borrado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Cliente Obj_Editar_Cliente = new Pantallas_Terciarias.FRM_Editar_Cliente();

                Obj_Cliente_DAL.cAccion = 'U';
                Obj_Cliente_DAL.cIdCliente = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Cliente_DAL.sCedula = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Cliente_DAL.sNombreCliente = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                Obj_Cliente_DAL.sApellidoCliente = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString();
                Obj_Cliente_DAL.sTel = dgv_Datos.SelectedRows[0].Cells[4].Value.ToString();
                Obj_Cliente_DAL.cIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[5].Value.ToString());
                Obj_Cliente_DAL.cIdTipoCliente = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[6].Value.ToString());

                Obj_Editar_Cliente.Obj_Editar_Cliente = Obj_Cliente_DAL;

                Obj_Editar_Cliente.ShowDialog();

                CargarDatos();

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN ESTADO Y TIPO CLIENTE PARA EDITARLA",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

        }
    }
}
