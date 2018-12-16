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
    public partial class FRM_TAB_Destinos : Form
    {
        public FRM_TAB_Destinos()
        {
            InitializeComponent();
        }

        //INSTANCIAR EL OBJETO DE LA TABLA CREADA
        cls_Destinos_BLL Obj_Destinos_BLL = new cls_Destinos_BLL();
        cls_Destinos_DAL Obj_Destinos_DAL = new cls_Destinos_DAL();

        //CREACION METODO CARGAR DATOS PARA LA TABLA
        private void CargarDatos()
        {
            if (txt_Filtrar.Text == string.Empty)
            {
                Obj_Destinos_BLL.ListarDestinos(ref Obj_Destinos_DAL);

            }
            else
            {
                Obj_Destinos_BLL.FiltrarDestinos(ref Obj_Destinos_DAL, txt_Filtrar.Text);
            }

            if (Obj_Destinos_DAL.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = Obj_Destinos_DAL.Obj_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n ERROR : [ " + Obj_Destinos_DAL.sMsjError + " ]");

            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Destinos Obj_Editar_Destinos = new Pantallas_Terciarias.FRM_Editar_Destinos();

                Obj_Destinos_DAL.cAccion = 'U';
                Obj_Destinos_DAL.cIdDestino = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Destinos_DAL.cIdAerolinea = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[1].Value.ToString());
                Obj_Destinos_DAL.sNombreDestino = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString();
                Obj_Destinos_DAL.cPaisSalida = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[3].Value.ToString());
                Obj_Destinos_DAL.cPaisEntrada = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[4].Value.ToString());
                Obj_Destinos_DAL.cIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[5].Value.ToString());

                Obj_Editar_Destinos.Obj_Editar_Destino = Obj_Destinos_DAL;

                Obj_Editar_Destinos.ShowDialog();

                CargarDatos();

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN DESTINO PARA EDITARLA",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Destinos Obj_Editar_Destinos = new Pantallas_Terciarias.FRM_Editar_Destinos();

            Obj_Destinos_DAL.cAccion = 'I';
            Obj_Editar_Destinos.Obj_Editar_Destino = Obj_Destinos_DAL;
            Obj_Editar_Destinos.ShowDialog();
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

        private void FRM_TAB_Destinos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Pantallas_Primarias.FRM_Menu Obj_Menu = new Pantallas_Primarias.FRM_Menu();
            Obj_Menu.Show();
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count > 0)
            {
                Obj_Destinos_BLL.EliminarDestinos(ref Obj_Destinos_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("se ha eliminado exitosamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El dato que ha seleccionado no pudo ser borrado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatos();
        }
    }
}
