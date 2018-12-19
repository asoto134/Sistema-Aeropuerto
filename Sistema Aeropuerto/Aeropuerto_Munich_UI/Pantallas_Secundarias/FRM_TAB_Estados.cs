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
    public partial class FRM_TAB_Estados : Form
    {
        public FRM_TAB_Estados()
        {
            InitializeComponent();
        }


        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();
        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Estados OBJ_Editar_Estados = new Pantallas_Terciarias.FRM_Editar_Estados();

                OBJ_Estados_DAL.CAccion = 'U';
                OBJ_Estados_DAL.CIDEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                OBJ_Estados_DAL.SDescripcion = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();

                OBJ_Editar_Estados.OBJ_Editar_Estados = OBJ_Estados_DAL;

                OBJ_Editar_Estados.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener un estado seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Estados OBJ_Editar_Estados = new Pantallas_Terciarias.FRM_Editar_Estados();

            OBJ_Estados_DAL.CAccion = 'I';

            OBJ_Editar_Estados.OBJ_Editar_Estados = OBJ_Estados_DAL;

            OBJ_Editar_Estados.ShowDialog();

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
                OBJ_Estados_BLL.Eliminar(ref OBJ_Estados_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                if (OBJ_Estados_DAL.SError == string.Empty)
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


        private void FRM_TAB_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Estados_BLL.Listar(ref OBJ_Estados_DAL);
            }
            else
            {
                OBJ_Estados_BLL.Filtrar(ref OBJ_Estados_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Estados_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Estados_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Estados_DAL.SError + " ]");
            }
        }



    }
}
