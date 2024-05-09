namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    partial class frmPoligono
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_dibujar = new System.Windows.Forms.Button();
            this.btn_escalarmas = new System.Windows.Forms.Button();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btn_trasladar = new System.Windows.Forms.Button();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.lblcantidadlados = new System.Windows.Forms.Label();
            this.Lienzo = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_escalarmenos = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_gradientcolor = new System.Windows.Forms.Button();
            this.btn_material = new System.Windows.Forms.Button();
            this.btn_texture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minecraft Fifty Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(809, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(436, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Proyecto Graficacion Unidad 2";
            // 
            // btn_dibujar
            // 
            this.btn_dibujar.Location = new System.Drawing.Point(823, 98);
            this.btn_dibujar.Name = "btn_dibujar";
            this.btn_dibujar.Size = new System.Drawing.Size(108, 52);
            this.btn_dibujar.TabIndex = 2;
            this.btn_dibujar.Text = "Dibujar Poligono";
            this.btn_dibujar.UseVisualStyleBackColor = true;
            this.btn_dibujar.Click += new System.EventHandler(this.btn_dibujar_Click);
            // 
            // btn_escalarmas
            // 
            this.btn_escalarmas.Location = new System.Drawing.Point(965, 98);
            this.btn_escalarmas.Name = "btn_escalarmas";
            this.btn_escalarmas.Size = new System.Drawing.Size(108, 52);
            this.btn_escalarmas.TabIndex = 3;
            this.btn_escalarmas.Text = "Escalar mas";
            this.btn_escalarmas.UseVisualStyleBackColor = true;
            this.btn_escalarmas.Click += new System.EventHandler(this.btn_escalarmas_Click);
            // 
            // btn_rotar
            // 
            this.btn_rotar.Location = new System.Drawing.Point(1113, 156);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(108, 52);
            this.btn_rotar.TabIndex = 4;
            this.btn_rotar.Text = "Rotar Poligono";
            this.btn_rotar.UseVisualStyleBackColor = true;
            this.btn_rotar.Click += new System.EventHandler(this.btn_rotar_Click);
            // 
            // btn_trasladar
            // 
            this.btn_trasladar.Location = new System.Drawing.Point(1113, 98);
            this.btn_trasladar.Name = "btn_trasladar";
            this.btn_trasladar.Size = new System.Drawing.Size(108, 52);
            this.btn_trasladar.TabIndex = 5;
            this.btn_trasladar.Text = "Trasladar Poligono";
            this.btn_trasladar.UseVisualStyleBackColor = true;
            this.btn_trasladar.Click += new System.EventHandler(this.btn_trasladar_Click);
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(1030, 55);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(108, 20);
            this.txtLados.TabIndex = 6;
            // 
            // lblcantidadlados
            // 
            this.lblcantidadlados.AutoSize = true;
            this.lblcantidadlados.Location = new System.Drawing.Point(867, 58);
            this.lblcantidadlados.Name = "lblcantidadlados";
            this.lblcantidadlados.Size = new System.Drawing.Size(157, 13);
            this.lblcantidadlados.TabIndex = 10;
            this.lblcantidadlados.Text = "Cantidad de Lados del Poligono";
            // 
            // Lienzo
            // 
            this.Lienzo.Location = new System.Drawing.Point(12, 11);
            this.Lienzo.Name = "Lienzo";
            this.Lienzo.Padding = new System.Windows.Forms.Padding(100);
            this.Lienzo.Size = new System.Drawing.Size(791, 658);
            this.Lienzo.TabIndex = 14;
            this.Lienzo.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(823, 276);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(398, 52);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Volver al menu";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_escalarmenos
            // 
            this.btn_escalarmenos.Location = new System.Drawing.Point(965, 156);
            this.btn_escalarmenos.Name = "btn_escalarmenos";
            this.btn_escalarmenos.Size = new System.Drawing.Size(108, 52);
            this.btn_escalarmenos.TabIndex = 17;
            this.btn_escalarmenos.Text = "Escalar menos";
            this.btn_escalarmenos.UseVisualStyleBackColor = true;
            this.btn_escalarmenos.Click += new System.EventHandler(this.btn_escalarmenos_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(823, 156);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(108, 52);
            this.btn_color.TabIndex = 18;
            this.btn_color.Text = "Cambia el color del poligono";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_gradientcolor
            // 
            this.btn_gradientcolor.Location = new System.Drawing.Point(823, 218);
            this.btn_gradientcolor.Name = "btn_gradientcolor";
            this.btn_gradientcolor.Size = new System.Drawing.Size(108, 52);
            this.btn_gradientcolor.TabIndex = 19;
            this.btn_gradientcolor.Text = "Degradado de Color\r\n";
            this.btn_gradientcolor.UseVisualStyleBackColor = true;
            this.btn_gradientcolor.Click += new System.EventHandler(this.btn_gradientcolor_Click);
            // 
            // btn_material
            // 
            this.btn_material.Location = new System.Drawing.Point(965, 214);
            this.btn_material.Name = "btn_material";
            this.btn_material.Size = new System.Drawing.Size(108, 52);
            this.btn_material.TabIndex = 20;
            this.btn_material.Text = "Cambia el material del poligono";
            this.btn_material.UseVisualStyleBackColor = true;
            this.btn_material.Click += new System.EventHandler(this.btn_material_Click);
            // 
            // btn_texture
            // 
            this.btn_texture.Location = new System.Drawing.Point(1113, 218);
            this.btn_texture.Name = "btn_texture";
            this.btn_texture.Size = new System.Drawing.Size(108, 52);
            this.btn_texture.TabIndex = 21;
            this.btn_texture.Text = "Cambia la textura del poligono";
            this.btn_texture.UseVisualStyleBackColor = true;
            this.btn_texture.Click += new System.EventHandler(this.btn_texture_Click);
            // 
            // frmPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 681);
            this.Controls.Add(this.btn_texture);
            this.Controls.Add(this.btn_material);
            this.Controls.Add(this.btn_gradientcolor);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_escalarmenos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Lienzo);
            this.Controls.Add(this.lblcantidadlados);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.btn_trasladar);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.btn_escalarmas);
            this.Controls.Add(this.btn_dibujar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPoligono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Graficacion Unidad 2";
            ((System.ComponentModel.ISupportInitialize)(this.Lienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_dibujar;
        private System.Windows.Forms.Button btn_escalarmas;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btn_trasladar;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.Label lblcantidadlados;
        private System.Windows.Forms.PictureBox Lienzo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_escalarmenos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_gradientcolor;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_texture;
    }
}

