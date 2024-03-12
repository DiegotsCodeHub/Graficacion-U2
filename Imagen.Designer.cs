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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblescala = new System.Windows.Forms.Label();
            this.txtrotacion = new System.Windows.Forms.TextBox();
            this.txtescala = new System.Windows.Forms.TextBox();
            this.btn_trasladar = new System.Windows.Forms.Button();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btn_escalar = new System.Windows.Forms.Button();
            this.btn_cargarimagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Portaretrato)).BeginInit();
            this.SuspendLayout();
            // 
            // Portaretrato
            // 
            this.Portaretrato.Location = new System.Drawing.Point(12, 12);
            this.Portaretrato.Name = "Portaretrato";
            this.Portaretrato.Size = new System.Drawing.Size(791, 657);
            this.Portaretrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Portaretrato.TabIndex = 15;
            this.Portaretrato.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minecraft Fifty Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(816, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(436, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Proyecto Graficacion Unidad 2";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1125, 646);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(127, 23);
            this.btn_salir.TabIndex = 28;
            this.btn_salir.Text = "Volver al menu";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Usa este boton para que se traslade aleatoriamente el poligono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cuantos grados quieres rotar el poligono?";
            // 
            // lblescala
            // 
            this.lblescala.AutoSize = true;
            this.lblescala.Location = new System.Drawing.Point(822, 156);
            this.lblescala.Name = "lblescala";
            this.lblescala.Size = new System.Drawing.Size(212, 13);
            this.lblescala.TabIndex = 25;
            this.lblescala.Text = "Cuantas veces quieres escalar el poligono?";
            // 
            // txtrotacion
            // 
            this.txtrotacion.Location = new System.Drawing.Point(1043, 172);
            this.txtrotacion.Name = "txtrotacion";
            this.txtrotacion.Size = new System.Drawing.Size(100, 20);
            this.txtrotacion.TabIndex = 23;
            // 
            // txtescala
            // 
            this.txtescala.Location = new System.Drawing.Point(823, 174);
            this.txtescala.Name = "txtescala";
            this.txtescala.Size = new System.Drawing.Size(100, 20);
            this.txtescala.TabIndex = 22;
            // 
            // btn_trasladar
            // 
            this.btn_trasladar.Location = new System.Drawing.Point(987, 230);
            this.btn_trasladar.Name = "btn_trasladar";
            this.btn_trasladar.Size = new System.Drawing.Size(108, 23);
            this.btn_trasladar.TabIndex = 20;
            this.btn_trasladar.Text = "Trasladar Imagen";
            this.btn_trasladar.UseVisualStyleBackColor = true;
            this.btn_trasladar.Click += new System.EventHandler(this.btn_trasladar_Click);
            // 
            // btn_rotar
            // 
            this.btn_rotar.Location = new System.Drawing.Point(1144, 170);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(108, 23);
            this.btn_rotar.TabIndex = 19;
            this.btn_rotar.Text = "Rotar Imagen";
            this.btn_rotar.UseVisualStyleBackColor = true;
            this.btn_rotar.Click += new System.EventHandler(this.btn_rotar_Click);
            // 
            // btn_escalar
            // 
            this.btn_escalar.Location = new System.Drawing.Point(929, 172);
            this.btn_escalar.Name = "btn_escalar";
            this.btn_escalar.Size = new System.Drawing.Size(108, 23);
            this.btn_escalar.TabIndex = 18;
            this.btn_escalar.Text = "Escalar Imagen";
            this.btn_escalar.UseVisualStyleBackColor = true;
            this.btn_escalar.Click += new System.EventHandler(this.btn_escalar_Click);
            // 
            // btn_cargarimagen
            // 
            this.btn_cargarimagen.Location = new System.Drawing.Point(825, 56);
            this.btn_cargarimagen.Name = "btn_cargarimagen";
            this.btn_cargarimagen.Size = new System.Drawing.Size(144, 23);
            this.btn_cargarimagen.TabIndex = 17;
            this.btn_cargarimagen.Text = "Cargar una imagen";
            this.btn_cargarimagen.UseVisualStyleBackColor = true;
            this.btn_cargarimagen.Click += new System.EventHandler(this.btn_cargarimagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblescala);
            this.Controls.Add(this.txtrotacion);
            this.Controls.Add(this.txtescala);
            this.Controls.Add(this.btn_trasladar);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.btn_escalar);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblescala;
        private System.Windows.Forms.TextBox txtrotacion;
        private System.Windows.Forms.TextBox txtescala;
        private System.Windows.Forms.Button btn_trasladar;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btn_escalar;
        private System.Windows.Forms.Button btn_cargarimagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}