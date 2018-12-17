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
    public partial class FRM_Inicio_Sesion : Form
    {
        cls_Usuarios_BLL OBJ_Usuarios_BLL = new cls_Usuarios_BLL();

        public FRM_Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (OBJ_Usuarios_BLL.validarUsuario(txt_NombreUsuario.Text, txt_Contraseña.Text))
            {
                FRM_Menu OBJ_Visualizador = new FRM_Menu();

                this.Hide();

                OBJ_Visualizador.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Usuario o contraseña es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_NombreUsuario.Text == "" || txt_Contraseña.Text == "")
            {
                btn_Entrar.Enabled = false;
                btn_Cambiar_Contrasenia.Enabled = false;
            }
            else
            {
                btn_Entrar.Enabled = true;
                btn_Cambiar_Contrasenia.Enabled = true;
            }
        }

        private void btn_Cambiar_Contrasenia_Click(object sender, EventArgs e)
        {
            if (OBJ_Usuarios_BLL.validarUsuario(txt_NombreUsuario.Text, txt_Contraseña.Text))
            {
                cls_Usuarios_DAL OBJ_Usuarios_DAL = new cls_Usuarios_DAL();
                FRM_Cambiar_Contrasenia OBJ_Editar_Contrasenia = new FRM_Cambiar_Contrasenia();

                OBJ_Usuarios_DAL.sUsername = txt_NombreUsuario.Text;

                OBJ_Editar_Contrasenia.OBJ_Editar_Usuarios = OBJ_Usuarios_DAL;

                OBJ_Editar_Contrasenia.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Usuario o contraseña es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
