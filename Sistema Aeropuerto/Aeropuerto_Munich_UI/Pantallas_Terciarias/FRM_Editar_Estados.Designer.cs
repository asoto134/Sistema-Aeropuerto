namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Estados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Editar_Estados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.grp_Informacion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.grp_Informacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ID.Location = new System.Drawing.Point(98, 19);
            this.txt_ID.MaxLength = 1;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 31);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNumericos_KeyPress);
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Descrip.Location = new System.Drawing.Point(98, 61);
            this.txt_Descrip.MaxLength = 25;
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(100, 31);
            this.txt_Descrip.TabIndex = 3;
            this.txt_Descrip.TextChanged += new System.EventHandler(this.txt_Descrip_TextChanged);
            this.txt_Descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNoNumericos_KeyPress);
            // 
            // grp_Informacion
            // 
            this.grp_Informacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Informacion.Controls.Add(this.txt_ID);
            this.grp_Informacion.Controls.Add(this.txt_Descrip);
            this.grp_Informacion.Controls.Add(this.label1);
            this.grp_Informacion.Controls.Add(this.label2);
            this.grp_Informacion.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(12, 12);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(213, 100);
            this.grp_Informacion.TabIndex = 6;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 88);
            this.groupBox2.TabIndex = 4;
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
            this.btn_Salir.Location = new System.Drawing.Point(131, 32);
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
            this.btn_Guardar.Location = new System.Drawing.Point(27, 34);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(47, 41);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // FRM_Editar_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(234, 218);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Editar_Estados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Estados";
            this.Load += new System.EventHandler(this.FRM_Editar_Estados_Load);
            this.grp_Informacion.ResumeLayout(false);
            this.grp_Informacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox grp_Informacion;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}