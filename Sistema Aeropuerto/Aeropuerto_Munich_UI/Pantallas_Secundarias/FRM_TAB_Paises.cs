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
    public partial class FRM_TAB_Paises : Form
    {
        public FRM_TAB_Paises()
        {
            InitializeComponent();
        }


        cls_Paises_DAL OBJ_Paises_DAL = new cls_Paises_DAL();
        cls_Paises_BLL OBJ_Paises_BLL = new cls_Paises_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Paises OBJ_Editar_Paises = new Pantallas_Terciarias.FRM_Editar_Paises();

                OBJ_Paises_DAL.CAccion = 'U';
                OBJ_Paises_DAL.IIdPais = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                OBJ_Paises_DAL.SNombrePais = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Paises_DAL.SCodigoISOPais = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                OBJ_Paises_DAL.SCodigoAreaPais = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString();
                OBJ_Paises_DAL.CIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[4].Value.ToString());

                OBJ_Editar_Paises.OBJ_Editar_Paises = OBJ_Paises_DAL;

                OBJ_Editar_Paises.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener una aerolínea seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Paises OBJ_Editar_Paises = new Pantallas_Terciarias.FRM_Editar_Paises();

            OBJ_Paises_DAL.CAccion = 'I';

            OBJ_Editar_Paises.OBJ_Editar_Paises = OBJ_Paises_DAL;

            OBJ_Editar_Paises.ShowDialog();

            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            txt_Filtrar.Text = string.Empty;
            CargarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                OBJ_Paises_BLL.Eliminar(ref OBJ_Paises_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                if (OBJ_Paises_DAL.SError == string.Empty)
                {
                    MessageBox.Show("Se ha eliminado exitósamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El dato que ha seleccionado no pudo ser borrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CargarDatos();
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


        private void FRM_TAB_Paises_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Paises_BLL.Listar(ref OBJ_Paises_DAL);
            }
            else
            {
                OBJ_Paises_BLL.Filtrar(ref OBJ_Paises_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Paises_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Paises_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Paises_DAL.SError + " ]");
            }
        }



    }
}

