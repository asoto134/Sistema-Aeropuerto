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

namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    public partial class FRM_Editar_Estados : Form
    {
        public FRM_Editar_Estados()
        {
            InitializeComponent();
        }

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();

        public cls_Estados_DAL OBJ_Editar_Estados;

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            OBJ_Estados_BLL = new cls_Estados_BLL();

            OBJ_Editar_Estados.CIDEstado = Convert.ToChar(txt_ID.Text.ToString());
            OBJ_Editar_Estados.SDescripcion = txt_Descrip.Text;

            if (OBJ_Editar_Estados.CAccion == 'I')
            {
                OBJ_Estados_BLL.Insertar(ref OBJ_Editar_Estados);

                if (OBJ_Editar_Estados.SError == string.Empty)
                {
                    MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ "+ OBJ_Editar_Estados.SError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                OBJ_Estados_BLL.Modificar(ref OBJ_Editar_Estados);

                if (OBJ_Editar_Estados.SError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar el nuevo estado. \n \n Error [ "+ OBJ_Editar_Estados.SError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CargarDatosForm();
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Editar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        private void CargarDatosForm()
        {
            if (OBJ_Editar_Estados.CAccion == 'I')
            {
                txt_ID.Enabled = true;
                txt_ID.Text = string.Empty;
                txt_Descrip.Text = string.Empty;
                grp_Informacion.Text = "Insertar Estado";
            }
            else
            {
                txt_ID.Enabled = false;
                txt_ID.Text = OBJ_Editar_Estados.CIDEstado.ToString();
                txt_Descrip.Text = string.Empty;
                grp_Informacion.Text = "Modificar Estado";
            }
        }

        private void CamposNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void CamposNoNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txt_Descrip_TextChanged(object sender, EventArgs e)
        {
            if (txt_Descrip.Text == string.Empty || txt_ID.Text == string.Empty)
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
