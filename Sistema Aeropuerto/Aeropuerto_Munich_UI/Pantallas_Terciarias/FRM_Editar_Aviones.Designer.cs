namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Aviones
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
            this.cmb_IdTip_Avion = new System.Windows.Forms.ComboBox();
            this.cmb_id_Aerolinea = new System.Windows.Forms.ComboBox();
            this.txt_Desc_Avion = new System.Windows.Forms.TextBox();
            this.lbl_id_Tip_Avion = new System.Windows.Forms.Label();
            this.lbl_Id_Estado = new System.Windows.Forms.Label();
            this.lbl_id_Aerolinea = new System.Windows.Forms.Label();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
            this.lbl_Desc_Avion = new System.Windows.Forms.Label();
            this.txt_ID_avion = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Avion = new System.Windows.Forms.TextBox();
            this.lbl_id_avion = new System.Windows.Forms.Label();
            this.lbl_Nom_Avion = new System.Windows.Forms.Label();
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
            this.groupBox2.Location = new System.Drawing.Point(3, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 105);
            this.groupBox2.TabIndex = 0;
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
            this.btn_Salir.TabIndex = 2;
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
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // grp_Informacion
            // 
            this.grp_Informacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Informacion.Controls.Add(this.cmb_IdTip_Avion);
            this.grp_Informacion.Controls.Add(this.cmb_id_Aerolinea);
            this.grp_Informacion.Controls.Add(this.txt_Desc_Avion);
            this.grp_Informacion.Controls.Add(this.lbl_id_Tip_Avion);
            this.grp_Informacion.Controls.Add(this.lbl_Id_Estado);
            this.grp_Informacion.Controls.Add(this.lbl_id_Aerolinea);
            this.grp_Informacion.Controls.Add(this.cmb_Estados);
            this.grp_Informacion.Controls.Add(this.lbl_Desc_Avion);
            this.grp_Informacion.Controls.Add(this.txt_ID_avion);
            this.grp_Informacion.Controls.Add(this.txt_Nombre_Avion);
            this.grp_Informacion.Controls.Add(this.lbl_id_avion);
            this.grp_Informacion.Controls.Add(this.lbl_Nom_Avion);
            this.grp_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(3, 1);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(492, 315);
            this.grp_Informacion.TabIndex = 0;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";
            // 
            // cmb_IdTip_Avion
            // 
            this.cmb_IdTip_Avion.FormattingEnabled = true;
            this.cmb_IdTip_Avion.Location = new System.Drawing.Point(184, 182);
            this.cmb_IdTip_Avion.Name = "cmb_IdTip_Avion";
            this.cmb_IdTip_Avion.Size = new System.Drawing.Size(249, 24);
            this.cmb_IdTip_Avion.TabIndex = 5;
            // 
            // cmb_id_Aerolinea
            // 
            this.cmb_id_Aerolinea.FormattingEnabled = true;
            this.cmb_id_Aerolinea.Location = new System.Drawing.Point(184, 149);
            this.cmb_id_Aerolinea.Name = "cmb_id_Aerolinea";
            this.cmb_id_Aerolinea.Size = new System.Drawing.Size(249, 24);
            this.cmb_id_Aerolinea.TabIndex = 4;
            // 
            // txt_Desc_Avion
            // 
            this.txt_Desc_Avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Desc_Avion.Location = new System.Drawing.Point(184, 121);
            this.txt_Desc_Avion.MaxLength = 120;
            this.txt_Desc_Avion.Name = "txt_Desc_Avion";
            this.txt_Desc_Avion.Size = new System.Drawing.Size(231, 21);
            this.txt_Desc_Avion.TabIndex = 3;
            this.txt_Desc_Avion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Desc_Avion_KeyPress);
            // 
            // lbl_id_Tip_Avion
            // 
            this.lbl_id_Tip_Avion.AutoSize = true;
            this.lbl_id_Tip_Avion.Location = new System.Drawing.Point(63, 182);
            this.lbl_id_Tip_Avion.Name = "lbl_id_Tip_Avion";
            this.lbl_id_Tip_Avion.Size = new System.Drawing.Size(106, 16);
            this.lbl_id_Tip_Avion.TabIndex = 0;
            this.lbl_id_Tip_Avion.Text = "ID Tipo Avión:";
            // 
            // lbl_Id_Estado
            // 
            this.lbl_Id_Estado.AutoSize = true;
            this.lbl_Id_Estado.Location = new System.Drawing.Point(89, 219);
            this.lbl_Id_Estado.Name = "lbl_Id_Estado";
            this.lbl_Id_Estado.Size = new System.Drawing.Size(80, 16);
            this.lbl_Id_Estado.TabIndex = 0;
            this.lbl_Id_Estado.Text = "ID Estado:";
            // 
            // lbl_id_Aerolinea
            // 
            this.lbl_id_Aerolinea.AutoSize = true;
            this.lbl_id_Aerolinea.Location = new System.Drawing.Point(71, 149);
            this.lbl_id_Aerolinea.Name = "lbl_id_Aerolinea";
            this.lbl_id_Aerolinea.Size = new System.Drawing.Size(98, 16);
            this.lbl_id_Aerolinea.TabIndex = 0;
            this.lbl_id_Aerolinea.Text = "ID Aerolínea:";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(184, 216);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(249, 24);
            this.cmb_Estados.TabIndex = 6;
            // 
            // lbl_Desc_Avion
            // 
            this.lbl_Desc_Avion.AutoSize = true;
            this.lbl_Desc_Avion.Location = new System.Drawing.Point(9, 121);
            this.lbl_Desc_Avion.Name = "lbl_Desc_Avion";
            this.lbl_Desc_Avion.Size = new System.Drawing.Size(160, 16);
            this.lbl_Desc_Avion.TabIndex = 0;
            this.lbl_Desc_Avion.Text = "Descripción de Avión:";
            // 
            // txt_ID_avion
            // 
            this.txt_ID_avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ID_avion.Location = new System.Drawing.Point(184, 50);
            this.txt_ID_avion.MaxLength = 7;
            this.txt_ID_avion.Name = "txt_ID_avion";
            this.txt_ID_avion.Size = new System.Drawing.Size(100, 21);
            this.txt_ID_avion.TabIndex = 1;
            this.txt_ID_avion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_avion_KeyPress);
            // 
            // txt_Nombre_Avion
            // 
            this.txt_Nombre_Avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Nombre_Avion.Location = new System.Drawing.Point(184, 82);
            this.txt_Nombre_Avion.MaxLength = 57;
            this.txt_Nombre_Avion.Name = "txt_Nombre_Avion";
            this.txt_Nombre_Avion.Size = new System.Drawing.Size(231, 21);
            this.txt_Nombre_Avion.TabIndex = 2;
            this.txt_Nombre_Avion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Avion_KeyPress);
            // 
            // lbl_id_avion
            // 
            this.lbl_id_avion.AutoSize = true;
            this.lbl_id_avion.Location = new System.Drawing.Point(99, 53);
            this.lbl_id_avion.Name = "lbl_id_avion";
            this.lbl_id_avion.Size = new System.Drawing.Size(70, 16);
            this.lbl_id_avion.TabIndex = 0;
            this.lbl_id_avion.Text = "ID Avión:";
            // 
            // lbl_Nom_Avion
            // 
            this.lbl_Nom_Avion.AutoSize = true;
            this.lbl_Nom_Avion.Location = new System.Drawing.Point(37, 85);
            this.lbl_Nom_Avion.Name = "lbl_Nom_Avion";
            this.lbl_Nom_Avion.Size = new System.Drawing.Size(132, 16);
            this.lbl_Nom_Avion.TabIndex = 0;
            this.lbl_Nom_Avion.Text = "Nombre de Avión:";
            // 
            // FRM_Editar_Aviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Editar_Aviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Aviones";
            this.Load += new System.EventHandler(this.FRM_Editar_Aviones_Load);
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
        private System.Windows.Forms.Label lbl_Desc_Avion;
        private System.Windows.Forms.TextBox txt_ID_avion;
        private System.Windows.Forms.TextBox txt_Nombre_Avion;
        private System.Windows.Forms.Label lbl_id_avion;
        private System.Windows.Forms.Label lbl_Nom_Avion;
        private System.Windows.Forms.Label lbl_id_Aerolinea;
        private System.Windows.Forms.Label lbl_id_Tip_Avion;
        private System.Windows.Forms.Label lbl_Id_Estado;
        private System.Windows.Forms.TextBox txt_Desc_Avion;
        private System.Windows.Forms.ComboBox cmb_IdTip_Avion;
        private System.Windows.Forms.ComboBox cmb_id_Aerolinea;
    }
}