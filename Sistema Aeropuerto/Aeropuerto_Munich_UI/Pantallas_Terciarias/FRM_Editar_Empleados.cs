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
    public partial class FRM_Editar_Empleados : Form
    {
        public FRM_Editar_Empleados()
        {
            InitializeComponent();
        }

        //INSTANCIAR OBJ DE EMPLEADO
        cls_Empleados_BLL Obj_Empleado_BLL = new cls_Empleados_BLL();
        public cls_Empleados_DAL Obj_Editar_Empleados;

        //INSTANCEAR PARA LA INFO DE LOS COMBO BOX

        //ESTADOS
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL Obj_Estados_Dal = new cls_Estados_DAL();

        //TIPO EMPLEADO
        cls_Tipo_Empleados_BLL Obj_TipoEmpleados_BLL = new cls_Tipo_Empleados_BLL();
        cls_Tipo_Empleados_DAL Obj_TipoEmpleados_DAL = new cls_Tipo_Empleados_DAL();

        //AEROLINEAS
        cls_Aerolineas_BLL Obj_Aerolineas_BLL = new cls_Aerolineas_BLL();
        cls_Aerolineas_DAL Obj_Aerolineas_DAL = new cls_Aerolineas_DAL();

        //CREACION DE METODOS PARA LOS COMBOS

        //METODO CB ESTADOS

        private void CargarComboEstado()
        {
            Obj_Estados_BLL.Listar(ref Obj_Estados_Dal);
            if (Obj_Estados_Dal.SError == string.Empty)
            {
                cb_Estado.DataSource = null;
                cb_Estado.DataSource = Obj_Estados_Dal.OBJ_DataTable;

                Obj_Estados_Dal.OBJ_DataTable.Rows.Add("-", "-- SELECIONE UN ESTADO --");

                cb_Estado.DisplayMember = "Descripcion";
                cb_Estado.ValueMember = "IdEstado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARAR EL COMBO DE ESTADOS. \n\n ERROR: [ " + Obj_Estados_Dal.SError + " ]. ",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //METODO CB AEROLINEA
        private void CargarComboAerolinea()
        {
            Obj_Aerolineas_BLL.Listar(ref Obj_Aerolineas_DAL);
            if (Obj_Aerolineas_DAL.SError == string.Empty)
            {
                cb_Aerolinea.DataSource = null;
                cb_Aerolinea.DataSource = Obj_Aerolineas_DAL.OBJ_DataTable;

                Obj_Aerolineas_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONE UNA AEROLINEA --");

                cb_Aerolinea.DisplayMember = "NombreAerolinea";
                cb_Aerolinea.ValueMember = "IdAerolinea";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA. \n\n ERROR: [ " + Obj_Aerolineas_DAL.SError + " ]. ",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //METODO CB TIPO EMPLEADOS
        private void CargarComboTipoEmpleado()
        {
            Obj_TipoEmpleados_BLL.Listar(ref Obj_TipoEmpleados_DAL);

            if (Obj_TipoEmpleados_DAL.SError == string.Empty)
            {
                cb_TipoEmpleado.DataSource = null;
                cb_TipoEmpleado.DataSource = Obj_TipoEmpleados_DAL.OBJ_DataTable;

                Obj_TipoEmpleados_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONE UN TIPO DE EMPLEADO --");

                cb_TipoEmpleado.DisplayMember = "DescTipo";
                cb_TipoEmpleado.ValueMember = "IdTipoEmpleado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO TIPO DE EMPLEADOS.\n\n [ " + Obj_TipoEmpleados_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //METODO PARA CARGAR DE DATOS
        private void CargarDatos()
        {
            CargarComboAerolinea();
            CargarComboEstado();
            CargarComboTipoEmpleado();

            if (Obj_Editar_Empleados.cAccion == 'I')
            {
                txt_ID_Empleado.Enabled = true;
                txt_ID_Empleado.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Direccion.Text = string.Empty;
                txt_Edad.Text = string.Empty;
                txt_Tel_Casa.Text = string.Empty;
                txt_Tel_Ref.Text = string.Empty;
                txt_Celular.Text = string.Empty;
                txt_Salario.Text = string.Empty;
                cb_TipoEmpleado.SelectedValue = "0";
                cb_Aerolinea.SelectedValue = "0";
                cb_Estado.SelectedValue = "-";
                grp_Informacion.Text = "Insertar Datos de Empleados";
            }
            else
            {
                txt_ID_Empleado.Enabled = false;
                txt_ID_Empleado.Text = Obj_Editar_Empleados.cIdEmpleado.ToString();
                txt_Cedula.Text = Obj_Editar_Empleados.cCedula.ToString();
                txt_Nombre.Text = Obj_Editar_Empleados.cNombreEmpleado.ToString();
                txt_Apellidos.Text = Obj_Editar_Empleados.cApellidoEmpleado.ToString();
                txt_Direccion.Text = Obj_Editar_Empleados.cDireccion.ToString();
                txt_Edad.Text = Obj_Editar_Empleados.cEdad.ToString();
                txt_Tel_Casa.Text = Obj_Editar_Empleados.cTelCasa.ToString();
                txt_Tel_Ref.Text = Obj_Editar_Empleados.cTelRef.ToString();
                txt_Celular.Text = Obj_Editar_Empleados.cCelular.ToString();
                txt_Salario.Text = Obj_Editar_Empleados.dSalario.ToString();
                cb_TipoEmpleado.SelectedValue = Obj_Editar_Empleados.cIdTipoEmpleado.ToString();
                cb_Aerolinea.SelectedValue = Obj_Editar_Empleados.cIdAerolinea.ToString();
                cb_Estado.SelectedValue = Obj_Editar_Empleados.cIdEstado.ToString();
                grp_Informacion.Text = "Modificar Datos de Empleados";
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cb_Aerolinea.SelectedValue.ToString() == "0" || cb_TipoEmpleado.SelectedValue.ToString() == "-"
                || cb_Estado.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE DE SELECIONAR ESTADO, TIPO DE CLIENTE Y AEROLINEA PARA GUARDAR LA INFORMACION",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                Obj_Empleado_BLL = new cls_Empleados_BLL();

                Obj_Editar_Empleados.cIdEmpleado = txt_ID_Empleado.Text.ToString();
                Obj_Editar_Empleados.cCedula = txt_Cedula.Text.ToString();
                Obj_Editar_Empleados.cNombreEmpleado = txt_Nombre.Text.ToString();
                Obj_Editar_Empleados.cApellidoEmpleado = txt_Apellidos.Text.ToString();
                Obj_Editar_Empleados.cDireccion = txt_Direccion.Text.ToString();
                Obj_Editar_Empleados.cEdad = txt_Edad.Text.ToString();
                Obj_Editar_Empleados.cTelCasa = txt_Tel_Casa.Text.ToString();
                Obj_Editar_Empleados.cTelRef = txt_Tel_Ref.Text.ToString();
                Obj_Editar_Empleados.cCelular = txt_Celular.Text.ToString();
                Obj_Editar_Empleados.dSalario = Convert.ToDecimal(txt_Salario.Text.ToString());
                Obj_Editar_Empleados.cIdTipoEmpleado = cb_TipoEmpleado.SelectedValue.ToString();
                Obj_Editar_Empleados.cIdAerolinea = cb_Aerolinea.SelectedValue.ToString();
                Obj_Editar_Empleados.cIdEstado = cb_Estado.SelectedValue.ToString();

                //LLAMADO DEL METODO DE INSERTAR O MODIFICAR DEPENDIENDO DE LA ACCION
                if (Obj_Editar_Empleados.cAccion == 'I')
                {
                    Obj_Empleado_BLL.InsertarEmpleados(ref Obj_Editar_Empleados);

                    if (Obj_Editar_Empleados.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo empleado.", "EXITO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo empleado. \n\n Error [ " + Obj_Editar_Empleados.sMsjError + " ].",
                                        "ERROR",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Obj_Empleado_BLL.ModificarEmpleados(ref Obj_Editar_Empleados);

                    if (Obj_Editar_Empleados.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente los datos", "EXITO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar los datos del empleado. \n\n Error [ " + Obj_Editar_Empleados.sMsjError + " ].",
                                        "ERROR",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                CargarDatos();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Editar_Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
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

        private void txt_ID_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
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

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
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
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Tel_Casa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Tel_Ref_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == ',')
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
    }
}
