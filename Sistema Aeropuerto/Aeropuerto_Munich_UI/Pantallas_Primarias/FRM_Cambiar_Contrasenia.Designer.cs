namespace Aeropuerto_Munich_UI.Pantallas_Primarias
{
    partial class FRM_Cambiar_Contrasenia
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
            this.grp_Password = new System.Windows.Forms.GroupBox();
            this.lbl_coinfirm_new_password = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.txt_coinfirm_new_password = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grp_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // grp_Password
            // 
            this.grp_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Password.Controls.Add(this.txt_coinfirm_new_password);
            this.grp_Password.Controls.Add(this.lbl_coinfirm_new_password);
            this.grp_Password.Controls.Add(this.txt_new_password);
            this.grp_Password.Controls.Add(this.lbl_new_password);
            this.grp_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Password.Location = new System.Drawing.Point(3, 1);
            this.grp_Password.Name = "grp_Password";
            this.grp_Password.Size = new System.Drawing.Size(492, 140);
            this.grp_Password.TabIndex = 10;
            this.grp_Password.TabStop = false;
            this.grp_Password.Text = "Contraseña";
            // 
            // lbl_coinfirm_new_password
            // 
            this.lbl_coinfirm_new_password.AutoSize = true;
            this.lbl_coinfirm_new_password.Location = new System.Drawing.Point(25, 86);
            this.lbl_coinfirm_new_password.Name = "lbl_coinfirm_new_password";
            this.lbl_coinfirm_new_password.Size = new System.Drawing.Size(210, 16);
            this.lbl_coinfirm_new_password.TabIndex = 8;
            this.lbl_coinfirm_new_password.Text = "Confirmar Nueva Contraseña:";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_new_password.Location = new System.Drawing.Point(242, 50);
            this.txt_new_password.MaxLength = 8;
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.PasswordChar = '*';
            this.txt_new_password.Size = new System.Drawing.Size(191, 21);
            this.txt_new_password.TabIndex = 2;
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Location = new System.Drawing.Point(25, 50);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(140, 16);
            this.lbl_new_password.TabIndex = 0;
            this.lbl_new_password.Text = "Nueva Contraseña:";
            // 
            // txt_coinfirm_new_password
            // 
            this.txt_coinfirm_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_coinfirm_new_password.Location = new System.Drawing.Point(241, 86);
            this.txt_coinfirm_new_password.MaxLength = 8;
            this.txt_coinfirm_new_password.Name = "txt_coinfirm_new_password";
            this.txt_coinfirm_new_password.PasswordChar = '*';
            this.txt_coinfirm_new_password.Size = new System.Drawing.Size(192, 21);
            this.txt_coinfirm_new_password.TabIndex = 9;
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
            // FRM_Cambiar_Contrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Cambiar_Contrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Aviones";
            this.groupBox2.ResumeLayout(false);
            this.grp_Password.ResumeLayout(false);
            this.grp_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox grp_Password;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.Label lbl_coinfirm_new_password;
        private System.Windows.Forms.TextBox txt_coinfirm_new_password;
    }
}