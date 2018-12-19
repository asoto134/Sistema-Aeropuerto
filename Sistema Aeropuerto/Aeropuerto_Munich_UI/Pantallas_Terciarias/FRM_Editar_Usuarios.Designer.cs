namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Usuarios
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
            this.cmb_IdEmpleado = new System.Windows.Forms.ComboBox();
            this.lbl_IdEmpleado = new System.Windows.Forms.Label();
            this.lbl_Id_Estado = new System.Windows.Forms.Label();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
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
            this.groupBox2.Location = new System.Drawing.Point(3, 206);
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
            this.grp_Informacion.Controls.Add(this.cmb_IdEmpleado);
            this.grp_Informacion.Controls.Add(this.lbl_IdEmpleado);
            this.grp_Informacion.Controls.Add(this.lbl_Id_Estado);
            this.grp_Informacion.Controls.Add(this.cmb_Estados);
            this.grp_Informacion.Controls.Add(this.txt_Username);
            this.grp_Informacion.Controls.Add(this.lbl_Username);
            this.grp_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(3, 1);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(492, 188);
            this.grp_Informacion.TabIndex = 10;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";
            // 
            // cmb_IdEmpleado
            // 
            this.cmb_IdEmpleado.FormattingEnabled = true;
            this.cmb_IdEmpleado.Location = new System.Drawing.Point(184, 89);
            this.cmb_IdEmpleado.Name = "cmb_IdEmpleado";
            this.cmb_IdEmpleado.Size = new System.Drawing.Size(249, 24);
            this.cmb_IdEmpleado.TabIndex = 11;
            // 
            // lbl_IdEmpleado
            // 
            this.lbl_IdEmpleado.AutoSize = true;
            this.lbl_IdEmpleado.Location = new System.Drawing.Point(63, 89);
            this.lbl_IdEmpleado.Name = "lbl_IdEmpleado";
            this.lbl_IdEmpleado.Size = new System.Drawing.Size(102, 16);
            this.lbl_IdEmpleado.TabIndex = 8;
            this.lbl_IdEmpleado.Text = "ID Empleado:";
            // 
            // lbl_Id_Estado
            // 
            this.lbl_Id_Estado.AutoSize = true;
            this.lbl_Id_Estado.Location = new System.Drawing.Point(89, 126);
            this.lbl_Id_Estado.Name = "lbl_Id_Estado";
            this.lbl_Id_Estado.Size = new System.Drawing.Size(80, 16);
            this.lbl_Id_Estado.TabIndex = 7;
            this.lbl_Id_Estado.Text = "ID Estado:";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(184, 123);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(249, 24);
            this.cmb_Estados.TabIndex = 5;
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Username.Location = new System.Drawing.Point(184, 50);
            this.txt_Username.MaxLength = 15;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(249, 21);
            this.txt_Username.TabIndex = 2;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(79, 53);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(90, 16);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "User Name:";
            // 
            // FRM_Editar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Editar_Usuarios";
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
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_IdEmpleado;
        private System.Windows.Forms.Label lbl_Id_Estado;
        private System.Windows.Forms.ComboBox cmb_IdEmpleado;
    }
}