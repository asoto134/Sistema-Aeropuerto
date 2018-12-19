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

namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    public partial class FRM_Editar_Cliente : Form
    {
        public FRM_Editar_Cliente()
        {
            InitializeComponent();
        }

        cls_Cliente_BLL Obj_Cliente_BLL = new cls_Cliente_BLL();
        public cls_Cliente_DAL Obj_Editar_Cliente;

        //INSTANCIAR PARA COMBO ESTADOS
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL Obj_Estados_DAL = new cls_Estados_DAL();

        //iNSTANCIAR PARA EL COMBO TIPO_CLIENTE
        cls_Tipo_Clientes_BLL Obj_TipoClientes_BLL = new cls_Tipo_Clientes_BLL();
        cls_Tipo_Clientes_DAL Obj_TipoClientes_DAL = new cls_Tipo_Clientes_DAL();

        //Cargar combos ESTADO
        private void CargarCombos()
        {
            Obj_Estados_BLL.Listar(ref Obj_Estados_DAL);

            if (Obj_Estados_DAL.SError == string.Empty)
            {
                cb_Estado.DataSource = null;
                cb_Estado.DataSource = Obj_Estados_DAL.OBJ_DataTable;

                Obj_Estados_DAL.OBJ_DataTable.Rows.Add("-", "-- SELECCIONAR UN ESTADO --");

                cb_Estado.DisplayMember = "Descripcion";
                cb_Estado.ValueMember = "IdEstado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE ESTADOS.\n\nERROR: [ " + Obj_Estados_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        //CARGAR COMBO ID_TIPO_CLIENTE

        private void CargarComboTP()
        {
            Obj_TipoClientes_BLL.Listar(ref Obj_TipoClientes_DAL);

            if (Obj_TipoClientes_DAL.SError == string.Empty)
            {
                cb_TipoCliente.DataSource = null;
                cb_TipoCliente.DataSource = Obj_TipoClientes_DAL.OBJ_DataTable;

                Obj_TipoClientes_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECIONE UN TIPO DE CLIENTE --");

                cb_TipoCliente.DisplayMember = "TipoCliente";
                cb_TipoCliente.ValueMember = "IdTipoCliente";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE TIPO CLIENTE.\n\n ERROR: [ " + Obj_TipoClientes_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CargarDatosFrm()
        {
            CargarCombos();
            CargarComboTP();

            if (Obj_Editar_Cliente.cAccion == 'I')
            {
                txt_ID_Cliente.Enabled = true;
                txt_ID_Cliente.Text = string.Empty;
                txt_Cedula_cliente.Text = string.Empty;
                txt_Nombre_Cliente.Text = string.Empty;
                txt_Apellidos_Cliente.Text = string.Empty;
                txt_Tel_Cliente.Text = string.Empty;
                cb_Estado.SelectedValue = "-";
                cb_TipoCliente.SelectedValue = "0";
                grp_Informacion.Text = "Insertar Datos Cliente";
            }
            else
            {
                txt_ID_Cliente.Enabled = false;
                txt_ID_Cliente.Text = Obj_Editar_Cliente.cIdCliente.ToString();
                txt_Cedula_cliente.Text = Obj_Editar_Cliente.sCedula.ToString();
                txt_Nombre_Cliente.Text = Obj_Editar_Cliente.sNombreCliente.ToString();
                txt_Apellidos_Cliente.Text = Obj_Editar_Cliente.sApellidoCliente.ToString();
                txt_Tel_Cliente.Text = Obj_Editar_Cliente.sTel.ToString();
                cb_Estado.SelectedValue = Obj_Editar_Cliente.cIdEstado.ToString();
                cb_TipoCliente.SelectedValue = Obj_Editar_Cliente.cIdTipoCliente.ToString();
                grp_Informacion.Text = "Modificar Datos del Cliente";
            }
        }

       

        

        private void FRM_Editar_Cliente_Load(object sender, EventArgs e)
        {
            CargarDatosFrm();
        }

        private void txt_ID_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Cedula_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Nombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Apellidos_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Tel_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_ID_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Cedula_cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }

            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Nombre_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Apellidos_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_Tel_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (cb_Estado.SelectedValue.ToString() == "-" || cb_TipoCliente.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO Y ID TIPO CLIENTE PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                Obj_Cliente_BLL = new cls_Cliente_BLL();

                Obj_Editar_Cliente.cIdCliente = Convert.ToChar(txt_ID_Cliente.Text.ToString());
                Obj_Editar_Cliente.sCedula = txt_Cedula_cliente.Text;
                Obj_Editar_Cliente.sNombreCliente = txt_Nombre_Cliente.Text;
                Obj_Editar_Cliente.sApellidoCliente = txt_Apellidos_Cliente.Text;
                Obj_Editar_Cliente.sTel = txt_Tel_Cliente.Text;
                Obj_Editar_Cliente.cIdEstado = Convert.ToChar(cb_Estado.SelectedValue.ToString());
                Obj_Editar_Cliente.cIdTipoCliente = Convert.ToChar(cb_TipoCliente.SelectedValue.ToString());

                if (Obj_Editar_Cliente.cAccion == 'I')
                {
                    Obj_Cliente_BLL.InsertarCliente(ref Obj_Editar_Cliente);

                    if (Obj_Editar_Cliente.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo Cliente", "EXITO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo Cliente. \n \n Error [ " + Obj_Editar_Cliente.sMsjError + " ].", "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Obj_Cliente_BLL.ModificarCliente(ref Obj_Editar_Cliente);

                    if (Obj_Editar_Cliente.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente los Datos Cliente", "EXITO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar los Datos Cliente. \n \n Error [ " + Obj_Editar_Cliente.sMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                CargarDatosFrm();
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Editar_Cliente_Load_1(object sender, EventArgs e)
        {
            CargarDatosFrm();
        }
    }
}
