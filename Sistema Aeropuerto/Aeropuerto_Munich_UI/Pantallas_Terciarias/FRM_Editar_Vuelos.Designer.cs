namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Vuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.grp_Informacion = new System.Windows.Forms.GroupBox();
            this.lbl_FechaHoraLlegada = new System.Windows.Forms.Label();
            this.lbl_FechaHoraSalida = new System.Windows.Forms.Label();
            this.lbl_IdAvion = new System.Windows.Forms.Label();
            this.cmb_IdAvion = new System.Windows.Forms.ComboBox();
            this.lbl_IdAerolinea = new System.Windows.Forms.Label();
            this.cmb_IdAerolinea = new System.Windows.Forms.ComboBox();
            this.lbl_IdDestino = new System.Windows.Forms.Label();
            this.cmb_IdDestino = new System.Windows.Forms.ComboBox();
            this.lbl_Id_Estado = new System.Windows.Forms.Label();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
            this.txt_IdVuelo = new System.Windows.Forms.TextBox();
            this.lbl_IdVuelo = new System.Windows.Forms.Label();
            this.dt_FechaHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dt_FechaHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.grp_Informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.BackgroundImage = global::Aeropuerto_Munich_UI.Properties.Resources.img_btn_Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Location = new System.Drawing.Point(217, 30);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(52, 45);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImage = global::Aeropuerto_Munich_UI.Properties.Resources.img_btn_Guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Location = new System.Drawing.Point(113, 32);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(47, 41);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // grp_Informacion
            // 
            this.grp_Informacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Informacion.Controls.Add(this.dt_FechaHoraLlegada);
            this.grp_Informacion.Controls.Add(this.dt_FechaHoraSalida);
            this.grp_Informacion.Controls.Add(this.lbl_FechaHoraLlegada);
            this.grp_Informacion.Controls.Add(this.lbl_FechaHoraSalida);
            this.grp_Informacion.Controls.Add(this.lbl_IdAvion);
            this.grp_Informacion.Controls.Add(this.cmb_IdAvion);
            this.grp_Informacion.Controls.Add(this.lbl_IdAerolinea);
            this.grp_Informacion.Controls.Add(this.cmb_IdAerolinea);
            this.grp_Informacion.Controls.Add(this.lbl_IdDestino);
            this.grp_Informacion.Controls.Add(this.cmb_IdDestino);
            this.grp_Informacion.Controls.Add(this.lbl_Id_Estado);
            this.grp_Informacion.Controls.Add(this.cmb_Estados);
            this.grp_Informacion.Controls.Add(this.txt_IdVuelo);
            this.grp_Informacion.Controls.Add(this.lbl_IdVuelo);
            this.grp_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(3, 1);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(492, 361);
            this.grp_Informacion.TabIndex = 10;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";
            // 
            // lbl_FechaHoraLlegada
            // 
            this.lbl_FechaHoraLlegada.AutoSize = true;
            this.lbl_FechaHoraLlegada.Location = new System.Drawing.Point(36, 264);
            this.lbl_FechaHoraLlegada.Name = "lbl_FechaHoraLlegada";
            this.lbl_FechaHoraLlegada.Size = new System.Drawing.Size(154, 16);
            this.lbl_FechaHoraLlegada.TabIndex = 20;
            this.lbl_FechaHoraLlegada.Text = "Fecha Hora Llegada:";
            // 
            // lbl_FechaHoraSalida
            // 
            this.lbl_FechaHoraSalida.AutoSize = true;
            this.lbl_FechaHoraSalida.Location = new System.Drawing.Point(36, 221);
            this.lbl_FechaHoraSalida.Name = "lbl_FechaHoraSalida";
            this.lbl_FechaHoraSalida.Size = new System.Drawing.Size(142, 16);
            this.lbl_FechaHoraSalida.TabIndex = 18;
            this.lbl_FechaHoraSalida.Text = "Fecha Hora Salida:";
            // 
            // lbl_IdAvion
            // 
            this.lbl_IdAvion.AutoSize = true;
            this.lbl_IdAvion.Location = new System.Drawing.Point(36, 174);
            this.lbl_IdAvion.Name = "lbl_IdAvion";
            this.lbl_IdAvion.Size = new System.Drawing.Size(70, 16);
            this.lbl_IdAvion.TabIndex = 17;
            this.lbl_IdAvion.Text = "ID Avion:";
            // 
            // cmb_IdAvion
            // 
            this.cmb_IdAvion.FormattingEnabled = true;
            this.cmb_IdAvion.Location = new System.Drawing.Point(196, 174);
            this.cmb_IdAvion.Name = "cmb_IdAvion";
            this.cmb_IdAvion.Size = new System.Drawing.Size(237, 24);
            this.cmb_IdAvion.TabIndex = 16;
            // 
            // lbl_IdAerolinea
            // 
            this.lbl_IdAerolinea.AutoSize = true;
            this.lbl_IdAerolinea.Location = new System.Drawing.Point(36, 132);
            this.lbl_IdAerolinea.Name = "lbl_IdAerolinea";
            this.lbl_IdAerolinea.Size = new System.Drawing.Size(98, 16);
            this.lbl_IdAerolinea.TabIndex = 15;
            this.lbl_IdAerolinea.Text = "ID Aerolinea:";
            // 
            // cmb_IdAerolinea
            // 
            this.cmb_IdAerolinea.FormattingEnabled = true;
            this.cmb_IdAerolinea.Location = new System.Drawing.Point(196, 132);
            this.cmb_IdAerolinea.Name = "cmb_IdAerolinea";
            this.cmb_IdAerolinea.Size = new System.Drawing.Size(237, 24);
            this.cmb_IdAerolinea.TabIndex = 14;
            // 
            // lbl_IdDestino
            // 
            this.lbl_IdDestino.AutoSize = true;
            this.lbl_IdDestino.Location = new System.Drawing.Point(36, 91);
            this.lbl_IdDestino.Name = "lbl_IdDestino";
            this.lbl_IdDestino.Size = new System.Drawing.Size(84, 16);
            this.lbl_IdDestino.TabIndex = 13;
            this.lbl_IdDestino.Text = "ID Destino:";
            // 
            // cmb_IdDestino
            // 
            this.cmb_IdDestino.FormattingEnabled = true;
            this.cmb_IdDestino.Location = new System.Drawing.Point(196, 91);
            this.cmb_IdDestino.Name = "cmb_IdDestino";
            this.cmb_IdDestino.Size = new System.Drawing.Size(237, 24);
            this.cmb_IdDestino.TabIndex = 12;
            // 
            // lbl_Id_Estado
            // 
            this.lbl_Id_Estado.AutoSize = true;
            this.lbl_Id_Estado.Location = new System.Drawing.Point(36, 305);
            this.lbl_Id_Estado.Name = "lbl_Id_Estado";
            this.lbl_Id_Estado.Size = new System.Drawing.Size(80, 16);
            this.lbl_Id_Estado.TabIndex = 7;
            this.lbl_Id_Estado.Text = "ID Estado:";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(196, 308);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(237, 24);
            this.cmb_Estados.TabIndex = 5;
            // 
            // txt_IdVuelo
            // 
            this.txt_IdVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_IdVuelo.Location = new System.Drawing.Point(196, 50);
            this.txt_IdVuelo.MaxLength = 15;
            this.txt_IdVuelo.Name = "txt_IdVuelo";
            this.txt_IdVuelo.Size = new System.Drawing.Size(237, 21);
            this.txt_IdVuelo.TabIndex = 2;
            // 
            // lbl_IdVuelo
            // 
            this.lbl_IdVuelo.AutoSize = true;
            this.lbl_IdVuelo.Location = new System.Drawing.Point(36, 50);
            this.lbl_IdVuelo.Name = "lbl_IdVuelo";
            this.lbl_IdVuelo.Size = new System.Drawing.Size(71, 16);
            this.lbl_IdVuelo.TabIndex = 0;
            this.lbl_IdVuelo.Text = "ID Vuelo:";
            // 
            // dt_FechaHoraSalida
            // 
            this.dt_FechaHoraSalida.Location = new System.Drawing.Point(196, 216);
            this.dt_FechaHoraSalida.Name = "dt_FechaHoraSalida";
            this.dt_FechaHoraSalida.Size = new System.Drawing.Size(237, 22);
            this.dt_FechaHoraSalida.TabIndex = 22;
            // 
            // dt_FechaHoraLlegada
            // 
            this.dt_FechaHoraLlegada.Location = new System.Drawing.Point(196, 258);
            this.dt_FechaHoraLlegada.Name = "dt_FechaHoraLlegada";
            this.dt_FechaHoraLlegada.Size = new System.Drawing.Size(237, 22);
            this.dt_FechaHoraLlegada.TabIndex = 23;
            // 
            // FRM_Editar_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Editar_Vuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Aviones";
            this.Load += new System.EventHandler(this.FRM_Editar_Usuarios_Load);
            this.groupBox2.ResumeLayout(false);
            this.grp_Informacion.ResumeLayout(false);
            this.grp_Informacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox grp_Informacion;
        private System.Windows.Forms.ComboBox cmb_Estados;
        private System.Windows.Forms.TextBox txt_IdVuelo;
        private System.Windows.Forms.Label lbl_IdVuelo;
        private System.Windows.Forms.Label lbl_Id_Estado;
        private System.Windows.Forms.Label lbl_FechaHoraLlegada;
        private System.Windows.Forms.Label lbl_FechaHoraSalida;
        private System.Windows.Forms.Label lbl_IdAvion;
        private System.Windows.Forms.ComboBox cmb_IdAvion;
        private System.Windows.Forms.Label lbl_IdAerolinea;
        private System.Windows.Forms.ComboBox cmb_IdAerolinea;
        private System.Windows.Forms.Label lbl_IdDestino;
        private System.Windows.Forms.ComboBox cmb_IdDestino;
        private System.Windows.Forms.DateTimePicker dt_FechaHoraLlegada;
        private System.Windows.Forms.DateTimePicker dt_FechaHoraSalida;
    }
}