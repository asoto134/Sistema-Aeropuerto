
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
    public partial class FRM_Editar_Tipos_Aviones : Form
    {
        public FRM_Editar_Tipos_Aviones()
        {
            InitializeComponent();
        }

        // Variables e instanciaciones

        cls_Tipo_Aviones_BLL OBJ_Tipos_Aviones_BLL = new cls_Tipo_Aviones_BLL();
        public cls_tipos_aviones_DAL OBJ_Tipos_Aviones_DAL;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();


        // Métodos

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == string.Empty || txt_TipoAvion.Text == string.Empty ||
                txt_DescrAvion.Text == string.Empty || txt_CantidadPasa.Text == string.Empty ||
                txt_CantidadPeso.Text == string.Empty)
            {
                MessageBox.Show("Debe completar los datos antes de continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("Debe seleccionar un estado antes de continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                OBJ_Tipos_Aviones_BLL = new cls_Tipo_Aviones_BLL();

                OBJ_Tipos_Aviones_DAL.SIdTipoAvion = txt_ID.Text.ToString();
                OBJ_Tipos_Aviones_DAL.SNombreAvion = txt_TipoAvion.Text;
                OBJ_Tipos_Aviones_DAL.SDescTipoAvion = txt_DescrAvion.Text;
                OBJ_Tipos_Aviones_DAL.ICapacidadPasajeros = Convert.ToInt32(txt_CantidadPasa.Text);
                OBJ_Tipos_Aviones_DAL.DCapacidad_peso = Convert.ToDecimal(txt_CantidadPeso.Text);
                OBJ_Tipos_Aviones_DAL.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Tipos_Aviones_DAL.CAccion == 'I')
                {
                    OBJ_Tipos_Aviones_BLL.Insertar(ref OBJ_Tipos_Aviones_DAL);

                    if (OBJ_Tipos_Aviones_DAL.SError == string.Empty)
                    {
                        MessageBox.Show("Se guardó exitosamente el tipo de avión", "Guardado de Tipo de Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de guardar el tipo de avión. \n \n Error [ " + OBJ_Tipos_Aviones_DAL.SError + " ].", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Tipos_Aviones_BLL.Modificar(ref OBJ_Tipos_Aviones_DAL);

                    if (OBJ_Tipos_Aviones_DAL.SError == string.Empty)
                    {
                        MessageBox.Show("Se modificó exitosamente el tipo de avión", "Modificación de Tipo de Avión",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error a la hora de modificar el tipo de avión. \n \n Error [ " + OBJ_Tipos_Aviones_DAL.SError + " ].", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CargarDatos();
            }

        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Editar_Tipos_Aviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            CargarCombos();

            if (OBJ_Tipos_Aviones_DAL.CAccion == 'I')
            {
                txt_ID.Enabled = true;
                txt_ID.Text = string.Empty;
                txt_TipoAvion.Text = string.Empty;
                txt_DescrAvion.Text = string.Empty;
                txt_CantidadPasa.Text = string.Empty;
                txt_CantidadPeso.Text = string.Empty;
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar un Tipo de Avión:";
            }
            else
            {
                txt_ID.Enabled = false;
                txt_ID.Text = OBJ_Tipos_Aviones_DAL.SIdTipoAvion.ToString();
                txt_TipoAvion.Text = OBJ_Tipos_Aviones_DAL.SNombreAvion.ToString();
                txt_DescrAvion.Text = OBJ_Tipos_Aviones_DAL.SDescTipoAvion.ToString();
                txt_CantidadPasa.Text = OBJ_Tipos_Aviones_DAL.SDescTipoAvion.ToString();
                txt_CantidadPeso.Text = OBJ_Tipos_Aviones_DAL.DCapacidad_peso.ToString();
                cmb_Estados.SelectedValue = OBJ_Tipos_Aviones_DAL.CIdEstado.ToString();
                grp_Informacion.Text = "Modificar un Tipo de Avión";
            }
        }

        private void CargarCombos()
        {
            OBJ_Estados_BLL.Listar(ref OBJ_Estados_DAL);

            if (OBJ_Estados_DAL.SError == string.Empty)
            {
                cmb_Estados.DataSource = null;
                cmb_Estados.DataSource = OBJ_Estados_DAL.OBJ_DataTable;

                OBJ_Estados_DAL.OBJ_DataTable.Rows.Add("-", "-- No se ha seleccionado un estado --");

                cmb_Estados.DisplayMember = "Descripcion";
                cmb_Estados.ValueMember = "IdEstado";
            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los estados.\n\n Error: [ " + OBJ_Estados_DAL.SError + " ].", "Error al cargar Estados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
