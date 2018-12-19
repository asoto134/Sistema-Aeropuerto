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
    public partial class FRM_Editar_Vuelos : Form
    {
        #region VARIABLES GLOBALES

        cls_Vuelos_BLL OBJ_Vuelos_BLL = new cls_Vuelos_BLL();
        public cls_Vuelos_DAL OBJ_Editar_Vuelos;

        cls_Destinos_BLL OBJ_Destinos_BLL = new cls_Destinos_BLL();
        cls_Destinos_DAL OBJ_Destinos_DAL = new cls_Destinos_DAL();

        cls_Aerolineas_BLL OBJ_Aerolineas_BLL = new cls_Aerolineas_BLL();
        cls_Aerolineas_DAL OBJ_Aerolineas_DAL = new cls_Aerolineas_DAL();

        cls_Aviones_BLL OBJ_Aviones_BLL = new cls_Aviones_BLL();
        cls_Aviones_DAL OBJ_Aviones_DAL = new cls_Aviones_DAL();

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();


        #endregion

        #region EVENTOS
        public FRM_Editar_Vuelos()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_IdAerolinea.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("DEBE SELECCIONAR UNA AEROLINEA PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

            if (cmb_IdAvion.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("DEBE SELECCIONAR UN AVIÓN PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

            if (cmb_IdDestino.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN DESTINO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }



            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }

            else
            {

                OBJ_Vuelos_BLL = new cls_Vuelos_BLL();

                OBJ_Editar_Vuelos.sIdVuelo = txt_IdVuelo.Text;
                OBJ_Editar_Vuelos.sIdDestino = cmb_IdDestino.SelectedValue.ToString();
                OBJ_Editar_Vuelos.iIdAerolinea  = Convert.ToInt16(cmb_IdAerolinea.SelectedValue.ToString());
                OBJ_Editar_Vuelos.sIdAvion = cmb_IdAvion.SelectedValue.ToString();
                OBJ_Editar_Vuelos.dtFechaHoraSalida = dt_FechaHoraSalida.Value;
                OBJ_Editar_Vuelos.dtFechaHoraLlegada = dt_FechaHoraLlegada.Value;
                OBJ_Editar_Vuelos.cIDEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Vuelos.cAccion == 'I')
                {

                    OBJ_Vuelos_BLL.Insertar(ref OBJ_Editar_Vuelos);

                    if (OBJ_Editar_Vuelos.sError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo vuelo", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo vuelo. \n \n Error [ " + OBJ_Editar_Vuelos.sError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Vuelos_BLL.Modificar(ref OBJ_Editar_Vuelos);

                    if (OBJ_Editar_Vuelos.sError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente el vuelo", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar el vuelo. \n \n Error [ " + OBJ_Editar_Vuelos.sError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CargarDatosForm();
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Descrip_TextChanged(object sender, EventArgs e)
        {
            if (txt_IdVuelo.Text == string.Empty)
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;
            }
        }

        private void FRM_Editar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        
        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarComboDestinos();
            CargarComboAerolineas();
            CargarComboAviones();
            CargarComboEstados();

            if (OBJ_Editar_Vuelos.cAccion == 'I')
            {
                txt_IdVuelo.Enabled = true;
                cmb_IdAerolinea.SelectedValue = "0";
                cmb_IdAvion.SelectedValue = "0";
                cmb_IdDestino.SelectedValue = "-";
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar vuelos";
            }
            else
            {
                txt_IdVuelo.Enabled = false;
                txt_IdVuelo.Text = OBJ_Editar_Vuelos.sIdVuelo;
                cmb_IdDestino.SelectedValue = OBJ_Editar_Vuelos.sIdDestino;
                cmb_IdAerolinea.SelectedValue = OBJ_Editar_Vuelos.iIdAerolinea;
                cmb_IdAvion.SelectedValue = OBJ_Editar_Vuelos.sIdAvion;
                dt_FechaHoraSalida.Value = OBJ_Editar_Vuelos.dtFechaHoraSalida;
                dt_FechaHoraLlegada.Value = OBJ_Editar_Vuelos.dtFechaHoraLlegada;
                cmb_Estados.SelectedValue = OBJ_Editar_Vuelos.cIDEstado;
                grp_Informacion.Text = "Modificar vuelos";
            }
        }

        private void CargarComboDestinos()
        {
            OBJ_Destinos_BLL.ListarDestinos(ref OBJ_Destinos_DAL);

            if (OBJ_Destinos_DAL.sMsjError == string.Empty)
            {
                cmb_IdDestino.DataSource = null;
                cmb_IdDestino.DataSource = OBJ_Destinos_DAL.Obj_DataTable;

                OBJ_Destinos_DAL.Obj_DataTable.Rows.Add("-","0" ,"-- SELECCIONAR UN DESTINO --");

                cmb_IdDestino.DisplayMember = "NomDestino";
                cmb_IdDestino.ValueMember = "IdDestino";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + OBJ_Destinos_DAL.sMsjError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void CargarComboAerolineas()
        {
            OBJ_Aerolineas_BLL.Listar(ref OBJ_Aerolineas_DAL);

            if (OBJ_Aerolineas_DAL.SError == string.Empty)
            {
                cmb_IdAerolinea.DataSource = null;
                cmb_IdAerolinea.DataSource = OBJ_Aerolineas_DAL.OBJ_DataTable;

                OBJ_Aerolineas_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UNA AEROLINEA --");

                cmb_IdAerolinea.DisplayMember = "NombreAerolinea";
                cmb_IdAerolinea.ValueMember = "IdAerolinea";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + OBJ_Aerolineas_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void CargarComboAviones()
        {
            OBJ_Aviones_BLL.Listar(ref OBJ_Aviones_DAL);

            if (OBJ_Aviones_DAL.SError == string.Empty)
            {
                cmb_IdAvion.DataSource = null;
                cmb_IdAvion.DataSource = OBJ_Aviones_DAL.OBJ_DataTable;

                OBJ_Aviones_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UN AVIÓN --");

                cmb_IdAvion.DisplayMember = "NomAvion";
                cmb_IdAvion.ValueMember = "IdAvion";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AVIONES.\n\nERROR: [ " + OBJ_Aviones_DAL.SError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void CargarComboEstados()
        {
            OBJ_Estados_BLL.Listar(ref OBJ_Estados_DAL);

            if (OBJ_Estados_DAL.SError == string.Empty)
            {
                cmb_Estados.DataSource = null;
                cmb_Estados.DataSource = OBJ_Estados_DAL.OBJ_DataTable;

                OBJ_Estados_DAL.OBJ_DataTable.Rows.Add("-", "-- SELECCIONAR UN ESTADO --");

                cmb_Estados.DisplayMember = "Descripcion";
                cmb_Estados.ValueMember = "IdEstado";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE ESTADOS.\n\nERROR: [ " + OBJ_Estados_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        #endregion
    }
}
