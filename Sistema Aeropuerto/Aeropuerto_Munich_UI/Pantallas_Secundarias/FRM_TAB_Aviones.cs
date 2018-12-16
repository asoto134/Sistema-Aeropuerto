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
    public partial class FRM_TAB_Aviones : Form
    {
        public FRM_TAB_Aviones()
        {
            InitializeComponent();
        }

        cls_Aviones_DAL OBJ_Aviones_DAL = new cls_Aviones_DAL();
        cls_Aviones_BLL OBJ_Aviones_BLL = new cls_Aviones_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Aviones OBJ_Editar_Aviones = new Pantallas_Terciarias.FRM_Editar_Aviones();

                OBJ_Aviones_DAL.CAccion = 'U';
                OBJ_Aviones_DAL.SIdAvion = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();
                OBJ_Aviones_DAL.SNomAvion = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Aviones_DAL.SDescAvion = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                OBJ_Aviones_DAL.IIdAerolinea = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[3].Value.ToString());
                OBJ_Aviones_DAL.SIdTipoAvion = dgv_Datos.SelectedRows[0].Cells[4].Value.ToString();
                OBJ_Aviones_DAL.CIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[5].Value.ToString());

                OBJ_Editar_Aviones.OBJ_Editar_Aviones = OBJ_Aviones_DAL;

                OBJ_Editar_Aviones.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener un Avión seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Aviones OBJ_Editar_Aviones = new Pantallas_Terciarias.FRM_Editar_Aviones();

            OBJ_Aviones_DAL.CAccion = 'I';

            OBJ_Editar_Aviones.OBJ_Editar_Aviones = OBJ_Aviones_DAL;

            OBJ_Editar_Aviones.ShowDialog();

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
                OBJ_Aviones_BLL.Eliminar(ref OBJ_Aviones_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("¿Esta seguro de eliminar los datos seleccionados?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void FRM_TAB_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Aviones_BLL.Listar(ref OBJ_Aviones_DAL);
            }
            else
            {
                OBJ_Aviones_BLL.Filtrar(ref OBJ_Aviones_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Aviones_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Aviones_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Aviones_DAL.SError + " ]");
            }
        }

        private void FRM_TAB_Aviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

       
    }
}
