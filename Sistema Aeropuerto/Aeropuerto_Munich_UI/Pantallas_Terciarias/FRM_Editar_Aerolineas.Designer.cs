namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Aerolineas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Editar_Aerolineas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.grp_Informacion = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.Location = new System.Drawing.Point(10, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 105);
            this.groupBox2.TabIndex = 7;
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
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImage = global::Aeropuerto_Munich_UI.Properties.Resources.img_btn_Guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.Enabled = false;
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
            this.grp_Informacion.Controls.Add(this.cmb_Estados);
            this.grp_Informacion.Controls.Add(this.label3);
            this.grp_Informacion.Controls.Add(this.txt_ID);
            this.grp_Informacion.Controls.Add(this.txt_Nombre);
            this.grp_Informacion.Controls.Add(this.label1);
            this.grp_Informacion.Controls.Add(this.label2);
            this.grp_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(10, 12);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(415, 189);
            this.grp_Informacion.TabIndex = 8;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";            
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ID.Location = new System.Drawing.Point(127, 46);
            this.txt_ID.MaxLength = 1;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 21);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNumericos_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Nombre.Location = new System.Drawing.Point(127, 80);
            this.txt_Nombre.MaxLength = 90;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(249, 21);
            this.txt_Nombre.TabIndex = 3;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Descrip_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNoNumericos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Aerolínea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado:";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(127, 115);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(249, 24);
            this.cmb_Estados.TabIndex = 5;
            // 
            // FRM_Editar_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Editar_Aerolineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Aerolineas";
            this.Load += new System.EventHandler(this.FRM_Editar_Aerolineas_Load);
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
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Estados;
        private System.Windows.Forms.Label label3;
    }
}