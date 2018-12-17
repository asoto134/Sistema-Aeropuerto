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
    public partial class FRM_Cambiar_Contrasenia : Form
    {
        cls_Usuarios_BLL OBJ_Usuarios_BLL = new cls_Usuarios_BLL();
        public cls_Usuarios_DAL OBJ_Editar_Usuarios;

        public FRM_Cambiar_Contrasenia()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_new_password.Text == txt_coinfirm_new_password.Text)
            {
                OBJ_Usuarios_BLL = new cls_Usuarios_BLL();

                OBJ_Editar_Usuarios.sPassword = txt_new_password.Text;

                OBJ_Usuarios_BLL.cambiarContrasenia(ref OBJ_Editar_Usuarios);

                if (OBJ_Editar_Usuarios.sError == string.Empty)
                {
                    MessageBox.Show("Se cambio exitosamente la contraseña", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de cambiar la contraseña. \n \n Error [ " + OBJ_Editar_Usuarios.sError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegurese de que la contraseña y su confirmación sean identicas.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txt_new_password.Text == string.Empty || txt_coinfirm_new_password.Text == string.Empty)
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;
            }
        }
    }
}
