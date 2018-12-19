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
    public partial class FRM_TAB_Aerolineas : Form
    {
        public FRM_TAB_Aerolineas()
        {
            InitializeComponent();
        }

        cls_Aerolineas_DAL OBJ_Aereolineas_DAL = new cls_Aerolineas_DAL();
        cls_Aerolineas_BLL OBJ_Aereolineas_BLL = new cls_Aerolineas_BLL();

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.Rows.Count >= 1)
            {
                Pantallas_Terciarias.FRM_Editar_Aerolineas OBJ_Editar_Aerolineas = new Pantallas_Terciarias.FRM_Editar_Aerolineas();

                OBJ_Aereolineas_DAL.CAccion = 'U';
                OBJ_Aereolineas_DAL.IIdAerolinea = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());
                OBJ_Aereolineas_DAL.SNombreAerolinea = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString();
                OBJ_Aereolineas_DAL.CIdEstado = Convert.ToChar(dgv_Datos.SelectedRows[0].Cells[2].Value.ToString());

                OBJ_Editar_Aerolineas.OBJ_Editar_Aerolineas = OBJ_Aereolineas_DAL;

                OBJ_Editar_Aerolineas.ShowDialog();
                
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe tener una aerolínea seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            Pantallas_Terciarias.FRM_Editar_Aerolineas OBJ_Editar_Aerolineas = new Pantallas_Terciarias.FRM_Editar_Aerolineas();

            
            OBJ_Aereolineas_DAL.CAccion = 'I';

            OBJ_Editar_Aerolineas.OBJ_Editar_Aerolineas = OBJ_Aereolineas_DAL;

            OBJ_Editar_Aerolineas.ShowDialog();

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
                OBJ_Aereolineas_BLL.Eliminar(ref OBJ_Aereolineas_DAL, dgv_Datos.SelectedRows[0].Cells[0].Value.ToString());

                if (OBJ_Aereolineas_DAL.SError == string.Empty)
                {
                    MessageBox.Show("¿Esta seguro de eliminar los datos seleccionados?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else
                {
                    MessageBox.Show("El dato que ha seleccionado no pudo ser borrado. \n\n ERROR" + OBJ_Aereolineas_DAL.SError + " ].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                OBJ_Aereolineas_BLL.Listar(ref OBJ_Aereolineas_DAL);
            }
            else
            {
                OBJ_Aereolineas_BLL.Filtrar(ref OBJ_Aereolineas_DAL, txt_Filtrar.Text);
            }

            if (OBJ_Aereolineas_DAL.SError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = OBJ_Aereolineas_DAL.OBJ_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + OBJ_Aereolineas_DAL.SError + " ]");
            }
        }

        private void FRM_TAB_Aerolineas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        
    }
}

