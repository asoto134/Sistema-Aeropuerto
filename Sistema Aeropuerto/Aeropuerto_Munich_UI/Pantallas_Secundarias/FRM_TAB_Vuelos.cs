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
    public partial class FRM_TAB_Vuelos : Form
    {
        public FRM_TAB_Vuelos()
        {
            InitializeComponent();
        }


        cls_Vuelos_DAL OBJ_Vuelos_DAL = new cls_Vuelos_DAL();
        cls_Vuelos_BLL OBJ_Vuelos_BLL = new cls_Vuelos_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Vuelos OBJ_Editar_Vuelos = new Pantallas_Terciarias.FRM_Editar_Vuelos();

                OBJ_Vuelos_DAL.cAccion = 'U';
                OBJ_Vuelos_DAL.sIdVuelo =dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();
                OBJ_Vuelos_DAL.sIdDestino = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Vuelos_DAL.iIdAerolinea = Convert.ToInt16(dgv_Datos.SelectedRows[0].Cells[2].Value);
                OBJ_Vuelos_DAL.sIdAvion = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString();
                OBJ_Vuelos_DAL.dtFechaHoraSalida = Convert.ToDateTime(dgv_Datos.SelectedRows[0].Cells[4].Value);
                OBJ_Vuelos_DAL.dtFechaHoraLlegada = Convert.ToDateTime(dgv_Datos.SelectedRows[0].Cells[5].Value);
                OBJ_Vuelos_DAL.cIDEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[6].Value);

                OBJ_Editar_Vuelos.OBJ_Editar_Vuelos = OBJ_Vuelos_DAL;

                OBJ_Editar_Vuelos.ShowDialog();

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
            Pantallas_Terciarias.FRM_Editar_Vuelos OBJ_Editar_Vuelos = new Pantallas_Terciarias.FRM_Editar_Vuelos();

            OBJ_Vuelos_DAL.cAccion = 'I';

            OBJ_Editar_Vuelos.OBJ_Editar_Vuelos = OBJ_Vuelos_DAL;

            OBJ_Editar_Vuelos.ShowDialog();

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
                OBJ_Vuelos_BLL.Eliminar(ref OBJ_Vuelos_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

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

        private void FRM_TAB_Vuelos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (txt_Filtrar.Text == string.Empty)
            {
                OBJ_Vuelos_BLL.Listar(ref OBJ_Vuelos_DAL);
            }
            else
            {
                OBJ_Vuelos_BLL.Filtrar(ref OBJ_Vuelos_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Vuelos_DAL.sError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Vuelos_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Vuelos_DAL.sError + " ]");
            }
        }

    }
}
