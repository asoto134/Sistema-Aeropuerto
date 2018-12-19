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
    public partial class FRM_Editar_Destinos : Form
    {
        public FRM_Editar_Destinos()
        {
            InitializeComponent();
        }

        cls_Destinos_BLL Obj_Destinos_BLL = new cls_Destinos_BLL();
        public cls_Destinos_DAL Obj_Editar_Destino;

        //iNSTANCIAR PARA EL COMBO ESTADO
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL Obj_Estados_DAL = new cls_Estados_DAL();

        //INSTANCIAR PARA EL COMBO aEROLINEAS
        cls_Aerolineas_BLL Obj_Aerolineas_BLL = new cls_Aerolineas_BLL();
        cls_Aerolineas_DAL Obj_Aerolineas_DAL = new cls_Aerolineas_DAL();

        //INSTANCIAR PARA COMBO PAISES DE DESTINO
        cls_Paises_BLL Obj_Paises_BLL = new cls_Paises_BLL();
        cls_Paises_DAL Obj_Paises_DAL = new cls_Paises_DAL();

        //METODO PARA CARGAR COMBOS
        private void CargarCombosEstado()
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

        private void CargarCombosAerolineas()
        {
            Obj_Aerolineas_BLL.Listar(ref Obj_Aerolineas_DAL);

            if (Obj_Aerolineas_DAL.SError == string.Empty)
            {
                cb_Aerolinea.DataSource = null;
                cb_Aerolinea.DataSource = Obj_Aerolineas_DAL.OBJ_DataTable;

                Obj_Aerolineas_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UNA AEROLINEA --");

                cb_Aerolinea.DisplayMember = "NombreAerolinea";
                cb_Aerolinea.ValueMember = "IdAerolinea";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + Obj_Aerolineas_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void CargarCombosPaises()
        {
            Obj_Paises_BLL.Listar(ref Obj_Paises_DAL);

            if (Obj_Paises_DAL.SError == string.Empty)
            {

                cb_Pais_S.DataSource = null;
                cb_Pais_S.DataSource = Obj_Paises_DAL.OBJ_DataTable;

                Obj_Paises_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UN PAIS --");

                cb_Pais_S.DisplayMember = "Nombre País";
                cb_Pais_S.ValueMember = "IdPais";

            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + Obj_Paises_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void CargarCombosPaises2()
        {
            Obj_Paises_BLL.Listar(ref Obj_Paises_DAL);

            if (Obj_Paises_DAL.SError == string.Empty)
            {
                cb_Pais_Ll.DataSource = null;
                cb_Pais_Ll.DataSource = Obj_Paises_DAL.OBJ_DataTable;

                Obj_Paises_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UN PAIS --");

                cb_Pais_Ll.DisplayMember = "Nombre País";
                cb_Pais_Ll.ValueMember = "IdPais";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + Obj_Paises_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        //METODO PARA CARGAR DATOS
        private void CargarDatos()
        {
            CargarCombosAerolineas();
            CargarCombosEstado();
            CargarCombosPaises();
            CargarCombosPaises2();

            if (Obj_Editar_Destino.cAccion == 'I')
            {
                txt_ID_Destino.Enabled = true;
                txt_ID_Destino.Text = string.Empty;
                cb_Aerolinea.SelectedValue = "0";
                txt_Nombre_Destino.Text = string.Empty;
                cb_Pais_S.SelectedValue = "0";
                cb_Pais_Ll.SelectedValue = "0";
                cb_Estado.SelectedValue = "-";
                grp_Informacion.Text = "Insertar Datos de Destino";
            }
            else
            {
                txt_ID_Destino.Enabled = false;
                txt_ID_Destino.Text = Obj_Editar_Destino.cIdDestino.ToString();
                cb_Aerolinea.SelectedValue = Obj_Editar_Destino.cIdAerolinea.ToString();
                txt_Nombre_Destino.Text = Obj_Editar_Destino.sNombreDestino.ToString();
                cb_Pais_S.SelectedValue = Obj_Editar_Destino.cPaisSalida.ToString();
                cb_Pais_Ll.SelectedValue = Obj_Editar_Destino.cPaisEntrada;
                cb_Estado.SelectedValue = Obj_Editar_Destino.cIdEstado.ToString();
                grp_Informacion.Text = "Modifiecar Datos de Destino";
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cb_Aerolinea.SelectedValue.ToString() == "0" || cb_Pais_S.SelectedValue.ToString() == "0"
               || cb_Pais_Ll.SelectedValue.ToString() == "0" || cb_Estado.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR ESTADO, AEROLINEA, PAIS SALIDA Y LLEGADA PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                Obj_Destinos_BLL = new cls_Destinos_BLL();

                Obj_Editar_Destino.cIdDestino = Convert.ToChar(txt_ID_Destino.Text.ToString());
                Obj_Editar_Destino.cIdAerolinea = Convert.ToInt32(cb_Aerolinea.SelectedValue.ToString());
                Obj_Editar_Destino.sNombreDestino = txt_Nombre_Destino.Text;
                Obj_Editar_Destino.cPaisSalida = Convert.ToChar(cb_Pais_S.SelectedValue.ToString());
                Obj_Editar_Destino.cPaisEntrada = Convert.ToChar(cb_Pais_Ll.SelectedValue.ToString());
                Obj_Editar_Destino.cIdEstado = Convert.ToChar(cb_Estado.SelectedValue.ToString());

                if (Obj_Editar_Destino.cAccion == 'I')
                {
                    Obj_Destinos_BLL.InsertarDestinos(ref Obj_Editar_Destino);

                    if (Obj_Editar_Destino.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo Destino", "EXITO",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo Destino. \n \n Error [ " + Obj_Editar_Destino.sMsjError + " ].", "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Obj_Destinos_BLL.ModificarDestinos(ref Obj_Editar_Destino);

                    if (Obj_Editar_Destino.sMsjError == string.Empty)
                    {

                        MessageBox.Show("Se modifico exitosamente los Datos De Destino", "EXITO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar los Datos De Destino. \n \n Error [ " + Obj_Editar_Destino.sMsjError + " ].", "ERROR",
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

        private void FRM_Editar_Destinos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txt_ID_Destino_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Nombre_Destino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
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
    }
}
