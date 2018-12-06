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

namespace Aeropuerto_Munich_UI.Pantallas_Primarias
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();
        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();

        private void btn_Aerolineas_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Aerolineas OBJ_TAB_Aerolineas = new Pantallas_Secundarias.FRM_TAB_Aerolineas();

            this.Hide();

            OBJ_TAB_Aerolineas.ShowDialog();
            
        }

        private void btn_Aviones_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Aviones OBJ_TAB_Aviones = new Pantallas_Secundarias.FRM_TAB_Aviones();

            this.Hide();

            OBJ_TAB_Aviones.ShowDialog();
        }

        private void btn_CategoriasVuelos_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Categorias_Vuelos OBJ_TAB_Categorias_Vuelos = new Pantallas_Secundarias.FRM_TAB_Categorias_Vuelos();

            this.Hide();

            OBJ_TAB_Categorias_Vuelos.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Cliente OBJ_TAB_Cliente = new Pantallas_Secundarias.FRM_TAB_Cliente();

            this.Hide();

            OBJ_TAB_Cliente.ShowDialog();
        }

        private void btn_Destinos_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Destinos OBJ_TAB_Destinos = new Pantallas_Secundarias.FRM_TAB_Destinos();

            this.Hide();

            OBJ_TAB_Destinos.ShowDialog();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Empleados OBJ_TAB_Empleados = new Pantallas_Secundarias.FRM_TAB_Empleados();

            this.Hide();

            OBJ_TAB_Empleados.ShowDialog();
        }

        private void btn_Estados_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Estados OBJ_TAB_Estados = new Pantallas_Secundarias.FRM_TAB_Estados();

            this.Hide();
            OBJ_TAB_Estados.ShowDialog();
            
        }

        private void btn_Paises_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Paises OBJ_TAB_Paises = new Pantallas_Secundarias.FRM_TAB_Paises();

            this.Hide();

            OBJ_TAB_Paises.ShowDialog();
        }

        private void btn_Tip_Aviones_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Aviones OBJ_TAB_Aviones = new Pantallas_Secundarias.FRM_TAB_Aviones();

            this.Hide();

            OBJ_TAB_Aviones.ShowDialog();
        }

        private void btn_Tip_Clientes_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Tipos_Clientes OBJ_TAB_Tipos_Clientes = new Pantallas_Secundarias.FRM_TAB_Tipos_Clientes();

            this.Hide();

            OBJ_TAB_Tipos_Clientes.ShowDialog();
        }

        private void btn_Tip_Empleados_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Tipos_Empleados OBJ_TAB_Tipos_Empleados = new Pantallas_Secundarias.FRM_TAB_Tipos_Empleados();

            this.Hide();

            OBJ_TAB_Tipos_Empleados.ShowDialog();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Usuarios OBJ_TAB_Usuarios = new Pantallas_Secundarias.FRM_TAB_Usuarios();

            this.Hide();

            OBJ_TAB_Usuarios.ShowDialog();
        }

        private void btn_Vuelos_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.FRM_TAB_Vuelos OBJ_TAB_Vuelos = new Pantallas_Secundarias.FRM_TAB_Vuelos();

            this.Hide();

            OBJ_TAB_Vuelos.ShowDialog();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar algúna categoría para poder visualizar las tablas","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
