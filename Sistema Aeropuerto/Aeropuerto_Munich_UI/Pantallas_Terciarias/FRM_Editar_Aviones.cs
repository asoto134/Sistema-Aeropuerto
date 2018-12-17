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
    public partial class FRM_Editar_Aviones : Form
    {
        #region VARIABLES GLOBALES

        cls_Aviones_BLL OBJ_Aviones_BLL = new cls_Aviones_BLL();
        public cls_Aviones_DAL OBJ_Editar_Aviones;

        cls_Estados_BLL OBJ_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL OBJ_Estados_DAL = new cls_Estados_DAL();

        cls_Aerolineas_BLL OBJ_Aerolineas_BLL = new cls_Aerolineas_BLL();
        cls_Aerolineas_DAL OBJ_Aerolineas_DAL = new cls_Aerolineas_DAL();

        cls_Tipo_Aviones_BLL OBJ_Tipo_Aviones_BLL = new cls_Tipo_Aviones_BLL();
        cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL = new cls_tipos_aviones_DAL();



        #endregion

        #region EVENTOS
        public FRM_Editar_Aviones()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO PARA GUARDAR LA INFORMACIÓN",
                                "ALERTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {

                OBJ_Aviones_BLL = new cls_Aviones_BLL();

                OBJ_Editar_Aviones.SIdAvion = txt_ID_avion.Text.ToString();
                OBJ_Editar_Aviones.SNomAvion = txt_Nombre_Avion.Text;
                OBJ_Editar_Aviones.SDescAvion = txt_Desc_Avion.Text;
                OBJ_Editar_Aviones.IIdAerolinea = Convert.ToInt32(cmb_id_Aerolinea.SelectedValue.ToString());
                OBJ_Editar_Aviones.SIdTipoAvion = cmb_IdTip_Avion.SelectedValue.ToString();
                OBJ_Editar_Aviones.CIdEstado = Convert.ToChar(cmb_Estados.SelectedValue.ToString());

                if (OBJ_Editar_Aviones.CAccion == 'I')
                {
                    OBJ_Aviones_BLL.Insertar(ref OBJ_Editar_Aviones);

                    if (OBJ_Editar_Aviones.SError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ " + OBJ_Editar_Aviones.SError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OBJ_Aviones_BLL.Modificar(ref OBJ_Editar_Aviones);

                    if (OBJ_Editar_Aviones.SError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente los aviones", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar los aviones. \n \n Error [ " + OBJ_Editar_Aviones.SError + " ].", "ERROR",
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
            if (txt_Nombre_Avion.Text == string.Empty || txt_ID_avion.Text == string.Empty || txt_Desc_Avion.Text == string.Empty)
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

        private void FRM_Editar_Aviones_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }
        private void FRM_Editar_Aerolineas_Load(object sender, EventArgs e)
        {
            CargarDatosForm();
        }

        
        #endregion

        #region METODOS

        private void CargarDatosForm()
        {
            CargarCombos();

            if (OBJ_Editar_Aviones.CAccion == 'I')
            {
                txt_ID_avion.Enabled = true;
                txt_ID_avion.Text = string.Empty;
                txt_Nombre_Avion.Text = string.Empty;
                txt_Desc_Avion.Text = string.Empty;
                cmb_id_Aerolinea.SelectedValue = "0";
                cmb_IdTip_Avion.SelectedValue = "-";
                cmb_Estados.SelectedValue = "-";
                grp_Informacion.Text = "Insertar Aviones";
            }
            else
            {
                txt_ID_avion.Enabled = false;
                txt_ID_avion.Text = OBJ_Editar_Aviones.SIdAvion.ToString();
                txt_Nombre_Avion.Text = OBJ_Editar_Aviones.SNomAvion.ToString();
                txt_Desc_Avion.Text = OBJ_Editar_Aviones.SDescAvion.ToString();
                cmb_id_Aerolinea.SelectedValue = OBJ_Editar_Aviones.IIdAerolinea.ToString();
                cmb_IdTip_Avion.SelectedValue = OBJ_Editar_Aviones.SIdTipoAvion.ToString();
                cmb_Estados.SelectedValue = OBJ_Editar_Aviones.CIdEstado.ToString();
                grp_Informacion.Text = "Modificar Aviones";
            }
        }

        private void CargarCombos()
        {
            #region Combo_Estados
            OBJ_Estados_BLL.Listar_Combo(ref OBJ_Estados_DAL);

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

            #endregion

            #region Combo_Tipo_Aviones


            OBJ_Tipo_Aviones_BLL.Listar_Combo(ref OBJ_Tipo_Aviones_DAL);

            if (OBJ_Tipo_Aviones_DAL.SError == string.Empty)
            {
                cmb_IdTip_Avion.DataSource = null;
                cmb_IdTip_Avion.DataSource = OBJ_Tipo_Aviones_DAL.OBJ_DataTable;

                OBJ_Tipo_Aviones_DAL.OBJ_DataTable.Rows.Add("-", "-- SELECCIONAR UN TIPO DE AVION --");

                cmb_IdTip_Avion.DisplayMember = "NombreTipoAvion";
                cmb_IdTip_Avion.ValueMember = "IdTipoAvion";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE ESTADOS.\n\nERROR: [ " + OBJ_Estados_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            #endregion

            #region Combo_Aerolines

            OBJ_Aerolineas_BLL.Listar_Combo(ref OBJ_Aerolineas_DAL);

            if (OBJ_Aerolineas_DAL.SError == string.Empty)
            {
                cmb_id_Aerolinea.DataSource = null;
                cmb_id_Aerolinea.DataSource = OBJ_Aerolineas_DAL.OBJ_DataTable;

                OBJ_Aerolineas_DAL.OBJ_DataTable.Rows.Add("0", "-- SELECCIONAR UNA AEROLINEA --");

                cmb_id_Aerolinea.DisplayMember = "NombreAerolinea";
                cmb_id_Aerolinea.ValueMember = "IdAerolinea";
            }
            else
            {
                MessageBox.Show("SE PRESENTO UN ERROR A LA HORA DE CARGAR EL COMBO DE AEROLINEA.\n\nERROR: [ " + OBJ_Aerolineas_DAL.SError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            #endregion

        }

#endregion


    }
}
