namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    partial class frm_imagen
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
            this.Portaretrato = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_trasladar = new System.Windows.Forms.Button();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btni_escalarmas = new System.Windows.Forms.Button();
            this.btn_cargarimagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btni_escalarmenos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Portaretrato)).BeginInit();
            this.SuspendLayout();
            // 
            // Portaretrato
            // 
            this.Portaretrato.Location = new System.Drawing.Point(12, 44);
            this.Portaretrato.Name = "Portaretrato";
            this.Portaretrato.Size = new System.Drawing.Size(1090, 625);
            this.Portaretrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Portaretrato.TabIndex = 15;
            this.Portaretrato.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minecraft Fifty Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(424, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(436, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Proyecto Graficacion Unidad 2";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1108, 277);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(144, 41);
            this.btn_salir.TabIndex = 28;
            this.btn_salir.Text = "Volver al menu";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_trasladar
            // 
            this.btn_trasladar.Location = new System.Drawing.Point(1108, 230);
            this.btn_trasladar.Name = "btn_trasladar";
            this.btn_trasladar.Size = new System.Drawing.Size(144, 41);
            this.btn_trasladar.TabIndex = 20;
            this.btn_trasladar.Text = "Trasladar Imagen";
            this.btn_trasladar.UseVisualStyleBackColor = true;
            this.btn_trasladar.Click += new System.EventHandler(this.btn_trasladar_Click);
            // 
            // btn_rotar
            // 
            this.btn_rotar.Location = new System.Drawing.Point(1108, 183);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(144, 41);
            this.btn_rotar.TabIndex = 19;
            this.btn_rotar.Text = "Rotar Imagen";
            this.btn_rotar.UseVisualStyleBackColor = true;
            this.btn_rotar.Click += new System.EventHandler(this.btn_rotar_Click);
            // 
            // btni_escalarmas
            // 
            this.btni_escalarmas.Location = new System.Drawing.Point(1108, 93);
            this.btni_escalarmas.Name = "btni_escalarmas";
            this.btni_escalarmas.Size = new System.Drawing.Size(144, 41);
            this.btni_escalarmas.TabIndex = 18;
            this.btni_escalarmas.Text = "Escalar mas";
            this.btni_escalarmas.UseVisualStyleBackColor = true;
            this.btni_escalarmas.Click += new System.EventHandler(this.btni_escalarmas_Click);
            // 
            // btn_cargarimagen
            // 
            this.btn_cargarimagen.Location = new System.Drawing.Point(1108, 44);
            this.btn_cargarimagen.Name = "btn_cargarimagen";
            this.btn_cargarimagen.Size = new System.Drawing.Size(144, 43);
            this.btn_cargarimagen.TabIndex = 17;
            this.btn_cargarimagen.Text = "Cargar una imagen";
            this.btn_cargarimagen.UseVisualStyleBackColor = true;
            this.btn_cargarimagen.Click += new System.EventHandler(this.btn_cargarimagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btni_escalarmenos
            // 
            this.btni_escalarmenos.Location = new System.Drawing.Point(1108, 140);
            this.btni_escalarmenos.Name = "btni_escalarmenos";
            this.btni_escalarmenos.Size = new System.Drawing.Size(144, 41);
            this.btni_escalarmenos.TabIndex = 29;
            this.btni_escalarmenos.Text = "Escalar menos";
            this.btni_escalarmenos.UseVisualStyleBackColor = true;
            this.btni_escalarmenos.Click += new System.EventHandler(this.btni_escalarmenos_Click);
            // 
            // frm_imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btni_escalarmenos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_trasladar);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.btni_escalarmas);
            this.Controls.Add(this.btn_cargarimagen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Portaretrato);
            this.Name = "frm_imagen";
            this.Text = "Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.Portaretrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Portaretrato;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_trasladar;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btni_escalarmas;
        private System.Windows.Forms.Button btn_cargarimagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btni_escalarmenos;
    }
}