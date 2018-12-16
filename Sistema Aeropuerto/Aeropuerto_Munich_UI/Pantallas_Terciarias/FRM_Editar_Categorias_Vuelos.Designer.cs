namespace Aeropuerto_Munich_UI.Pantallas_Terciarias
{
    partial class FRM_Editar_Categorias_Vuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Editar_Categorias_Vuelos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.grp_Informacion = new System.Windows.Forms.GroupBox();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txt_ID_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Desc_Categoria = new System.Windows.Forms.TextBox();
            this.lbl_Id_Categoria = new System.Windows.Forms.Label();
            this.lbl_Desc_Categoria = new System.Windows.Forms.Label();
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
            this.groupBox2.Location = new System.Drawing.Point(9, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 105);
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
            this.btn_Salir.Location = new System.Drawing.Point(281, 32);
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
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Location = new System.Drawing.Point(151, 34);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(47, 41);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // grp_Informacion
            // 
            this.grp_Informacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Informacion.Controls.Add(this.cmb_Estados);
            this.grp_Informacion.Controls.Add(this.lbl_Estado);
            this.grp_Informacion.Controls.Add(this.txt_ID_Categoria);
            this.grp_Informacion.Controls.Add(this.txt_Desc_Categoria);
            this.grp_Informacion.Controls.Add(this.lbl_Id_Categoria);
            this.grp_Informacion.Controls.Add(this.lbl_Desc_Categoria);
            this.grp_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Informacion.Location = new System.Drawing.Point(9, 12);
            this.grp_Informacion.Name = "grp_Informacion";
            this.grp_Informacion.Size = new System.Drawing.Size(491, 189);
            this.grp_Informacion.TabIndex = 10;
            this.grp_Informacion.TabStop = false;
            this.grp_Informacion.Text = "Datos";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(215, 113);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(249, 24);
            this.cmb_Estados.TabIndex = 5;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(148, 121);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(61, 16);
            this.lbl_Estado.TabIndex = 4;
            this.lbl_Estado.Text = "Estado:";
            // 
            // txt_ID_Categoria
            // 
            this.txt_ID_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ID_Categoria.Location = new System.Drawing.Point(215, 46);
            this.txt_ID_Categoria.MaxLength = 1;
            this.txt_ID_Categoria.Name = "txt_ID_Categoria";
            this.txt_ID_Categoria.Size = new System.Drawing.Size(100, 21);
            this.txt_ID_Categoria.TabIndex = 2;
            // 
            // txt_Desc_Categoria
            // 
            this.txt_Desc_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Desc_Categoria.Location = new System.Drawing.Point(215, 80);
            this.txt_Desc_Categoria.MaxLength = 90;
            this.txt_Desc_Categoria.Name = "txt_Desc_Categoria";
            this.txt_Desc_Categoria.Size = new System.Drawing.Size(249, 21);
            this.txt_Desc_Categoria.TabIndex = 3;
            // 
            // lbl_Id_Categoria
            // 
            this.lbl_Id_Categoria.AutoSize = true;
            this.lbl_Id_Categoria.Location = new System.Drawing.Point(110, 49);
            this.lbl_Id_Categoria.Name = "lbl_Id_Categoria";
            this.lbl_Id_Categoria.Size = new System.Drawing.Size(99, 16);
            this.lbl_Id_Categoria.TabIndex = 0;
            this.lbl_Id_Categoria.Text = "ID Categoria:";
            // 
            // lbl_Desc_Categoria
            // 
            this.lbl_Desc_Categoria.AutoSize = true;
            this.lbl_Desc_Categoria.Location = new System.Drawing.Point(20, 83);
            this.lbl_Desc_Categoria.Name = "lbl_Desc_Categoria";
            this.lbl_Desc_Categoria.Size = new System.Drawing.Size(189, 16);
            this.lbl_Desc_Categoria.TabIndex = 1;
            this.lbl_Desc_Categoria.Text = "Descripción de Categoria:";
            // 
            // FRM_Editar_Categorias_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Editar_Categorias_Vuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Editar_Categorias_Vuelos";
            this.Load += new System.EventHandler(this.FRM_Editar_Categorias_Vuelos_Load);
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
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox txt_ID_Categoria;
        private System.Windows.Forms.TextBox txt_Desc_Categoria;
        private System.Windows.Forms.Label lbl_Id_Categoria;
        private System.Windows.Forms.Label lbl_Desc_Categoria;
    }
}