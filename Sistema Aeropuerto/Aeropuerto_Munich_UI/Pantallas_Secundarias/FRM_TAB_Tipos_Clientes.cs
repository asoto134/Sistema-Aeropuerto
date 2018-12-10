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
    public partial class FRM_TAB_Tipos_Clientes : Form
    {
        public FRM_TAB_Tipos_Clientes()
        {
            InitializeComponent();
        }

        cls_Tipo_Clientes_DAL OBJ_Tipo_Clientes_DAL = new cls_Tipo_Clientes_DAL();
        cls_Tipo_Clientes_BLL OBJ_Tipo_Clientes_BLL = new cls_Tipo_Clientes_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Tipos_Clientes OBJ_Editar_Tipo_Clientes = new Pantallas_Terciarias.FRM_Editar_Tipos_Clientes();

                OBJ_Tipo_Clientes_DAL.CAccion = 'U';
                OBJ_Tipo_Clientes_DAL.IIdTipoCliente = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                OBJ_Tipo_Clientes_DAL.STipoCliente = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Tipo_Clientes_DAL.SDescripcion = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                OBJ_Tipo_Clientes_DAL.CIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[3].Value.ToString());

                OBJ_Editar_Tipo_Clientes.OBJ_Editar_Tipo_Clientes_DAL = OBJ_Tipo_Clientes_DAL;

                OBJ_Editar_Tipo_Clientes.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener una aerolínea seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Tipos_Clientes OBJ_Editar_Tipo_Clientes = new Pantallas_Terciarias.FRM_Editar_Tipos_Clientes();

            OBJ_Tipo_Clientes_DAL.CAccion = 'I';

            OBJ_Editar_Tipo_Clientes.OBJ_Editar_Tipo_Clientes_DAL = OBJ_Tipo_Clientes_DAL;

            OBJ_Editar_Tipo_Clientes.ShowDialog();

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
                OBJ_Tipo_Clientes_BLL.Eliminar(ref OBJ_Tipo_Clientes_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("Se ha eliminado exitósamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void FRM_TAB_Paises_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Tipo_Clientes_BLL.Listar(ref OBJ_Tipo_Clientes_DAL);
            }
            else
            {
                OBJ_Tipo_Clientes_BLL.Filtrar(ref OBJ_Tipo_Clientes_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Tipo_Clientes_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Tipo_Clientes_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Tipo_Clientes_DAL.SError + " ]");
            }
        }

    }
}
