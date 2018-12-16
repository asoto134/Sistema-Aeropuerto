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
    public partial class FRM_TAB_Tipos_Aviones : Form
    {
        public FRM_TAB_Tipos_Aviones()
        {
            InitializeComponent();
        }

        cls_tipos_aviones_DAL OBJ_Tipos_Aviones_DAL = new cls_tipos_aviones_DAL();
        cls_tipos_aviones_BLL OBJ_Tipo_Aviones_BLL = new cls_tipos_aviones_BLL();



        // Métodos del proceso

        private void FRM_TAB_Tipos_Aviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {

            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Tipo_Aviones_BLL.Listar(ref OBJ_Tipos_Aviones_DAL);
            }
            else
            {
                OBJ_Tipo_Aviones_BLL.Filtrar(ref OBJ_Tipos_Aviones_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Tipos_Aviones_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Tipos_Aviones_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Tipos_Aviones_DAL.SError + " ]");
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Tipos_Aviones OBJ_Editar_TiposAviones = new Pantallas_Terciarias.FRM_Editar_Tipos_Aviones();

                OBJ_Tipos_Aviones_DAL.CAccion = 'U';
                OBJ_Tipos_Aviones_DAL.SIdTipoAvion = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();
                OBJ_Tipos_Aviones_DAL.SNombreAvion = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Tipos_Aviones_DAL.SDescTipoAvion = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                OBJ_Tipos_Aviones_DAL.ICapacidadPasajeros = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[3].Value.ToString());
                OBJ_Tipos_Aviones_DAL.DCapacidad_peso = Convert.ToDecimal(dgv_Datos.SelectedRows[0].Cells[4].Value.ToString());

                OBJ_Editar_TiposAviones.OBJ_Tipos_Aviones_DAL = OBJ_Tipos_Aviones_DAL;

                OBJ_Editar_TiposAviones.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener una aerolínea seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                OBJ_Tipo_Aviones_BLL.Eliminar(ref OBJ_Tipos_Aviones_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("Se ha eliminado exitósamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El dato que ha seleccionado no pudo ser borrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Tipos_Aviones OBJ_Editar_TiposAviones = new Pantallas_Terciarias.FRM_Editar_Tipos_Aviones();

            OBJ_Tipos_Aviones_DAL.CAccion = 'I';

            OBJ_Editar_TiposAviones.OBJ_Tipos_Aviones_DAL = OBJ_Tipos_Aviones_DAL;

            OBJ_Editar_TiposAviones.ShowDialog();

            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Pantallas_Primarias.FRM_Menu OBJ_Menu = new Pantallas_Primarias.FRM_Menu();
            OBJ_Menu.Show();
            this.Close();
        }

    }
}
