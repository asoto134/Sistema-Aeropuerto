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
    public partial class FRM_Editar_Aerolineas : Form
    {
        public FRM_Editar_Aerolineas()
        {
            InitializeComponent();
        }

        cls_Aerolineas_BLL OBJ_Aerolineas_BLL = new cls_Aerolineas_BLL();
        public cls_Aerolineas_DAL OBJ_Editar_Aerolineas;

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            OBJ_Aerolineas_BLL = new cls_Aerolineas_BLL();

            OBJ_Editar_Aerolineas.CIDAerolinea = Convert.ToChar(txt_ID.Text.ToString());
            OBJ_Editar_Aerolineas.SNombreAerolinea = txt_Nombre.Text;

            if (OBJ_Editar_Aerolineas.CAccion == 'I')
            {
                OBJ_Aerolineas_BLL.Insertar(ref OBJ_Editar_Aerolineas);

                if (OBJ_Editar_Aerolineas.SError == string.Empty)
                {
                    MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ "+ OBJ_Editar_Aerolineas.SError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                OBJ_Aerolineas_BLL.Modificar(ref OBJ_Editar_Aerolineas);

                if (OBJ_Editar_Aerolineas.SError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente la aerolínea", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar la nueva aerolínea. \n \n Error [ "+ OBJ_Editar_Aerolineas.SError + " ].", "ERROR",
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
            if (OBJ_Editar_Aerolineas.CAccion == 'I')
            {
                txt_ID.Enabled = true;
                txt_ID.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                grp_Informacion.Text = "Insertar Aerolínea";
            }
            else
            {
                txt_ID.Enabled = false;
                txt_ID.Text = OBJ_Editar_Aerolineas.CIDAerolinea.ToString();
                txt_Nombre.Text = OBJ_Editar_Aerolineas.CIDAerolinea.ToString();
                grp_Informacion.Text = "Modificar Aerolínea";
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
            if (txt_Nombre.Text == string.Empty || txt_ID.Text == string.Empty)
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
