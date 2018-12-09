﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeropuerto_Munich_UI.Pantallas_Primarias
{
    public partial class FRM_Inicio_Sesion : Form
    {
        public FRM_Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            FRM_Menu OBJ_Visualizador = new FRM_Menu();

            this.Hide();

            OBJ_Visualizador.ShowDialog();

            
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            FRM_Crear_Usuario OBJ_Visualizador = new FRM_Crear_Usuario();

            this.Hide();
                
            OBJ_Visualizador.ShowDialog();
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
            }
            else
            {
                btn_Entrar.Enabled = true;
            }
        }
    }
}
