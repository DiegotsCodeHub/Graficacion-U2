namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    partial class frmPrincipal
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
            this.btn_escalar = new System.Windows.Forms.Button();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btn_trasladar = new System.Windows.Forms.Button();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.txtescala = new System.Windows.Forms.TextBox();
            this.txtrotacion = new System.Windows.Forms.TextBox();
            this.lblcantidadlados = new System.Windows.Forms.Label();
            this.lblescala = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lienzo = new System.Windows.Forms.PictureBox();
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
            this.btn_dibujar.Location = new System.Drawing.Point(823, 113);
            this.btn_dibujar.Name = "btn_dibujar";
            this.btn_dibujar.Size = new System.Drawing.Size(100, 23);
            this.btn_dibujar.TabIndex = 2;
            this.btn_dibujar.Text = "Dibujar Poligono";
            this.btn_dibujar.UseVisualStyleBackColor = true;
            this.btn_dibujar.Click += new System.EventHandler(this.btn_dibujar_Click);
            // 
            // btn_escalar
            // 
            this.btn_escalar.Location = new System.Drawing.Point(929, 172);
            this.btn_escalar.Name = "btn_escalar";
            this.btn_escalar.Size = new System.Drawing.Size(108, 23);
            this.btn_escalar.TabIndex = 3;
            this.btn_escalar.Text = "Escalar Poligono";
            this.btn_escalar.UseVisualStyleBackColor = true;
            this.btn_escalar.Click += new System.EventHandler(this.btn_escalar_Click);
            // 
            // btn_rotar
            // 
            this.btn_rotar.Location = new System.Drawing.Point(1144, 170);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(108, 23);
            this.btn_rotar.TabIndex = 4;
            this.btn_rotar.Text = "Rotar Poligono";
            this.btn_rotar.UseVisualStyleBackColor = true;
            // 
            // btn_trasladar
            // 
            this.btn_trasladar.Location = new System.Drawing.Point(987, 230);
            this.btn_trasladar.Name = "btn_trasladar";
            this.btn_trasladar.Size = new System.Drawing.Size(108, 23);
            this.btn_trasladar.TabIndex = 5;
            this.btn_trasladar.Text = "Trasladar Poligono";
            this.btn_trasladar.UseVisualStyleBackColor = true;
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(823, 87);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(100, 20);
            this.txtLados.TabIndex = 6;
            // 
            // txtescala
            // 
            this.txtescala.Location = new System.Drawing.Point(823, 174);
            this.txtescala.Name = "txtescala";
            this.txtescala.Size = new System.Drawing.Size(100, 20);
            this.txtescala.TabIndex = 7;
            // 
            // txtrotacion
            // 
            this.txtrotacion.Location = new System.Drawing.Point(1043, 172);
            this.txtrotacion.Name = "txtrotacion";
            this.txtrotacion.Size = new System.Drawing.Size(100, 20);
            this.txtrotacion.TabIndex = 8;
            // 
            // lblcantidadlados
            // 
            this.lblcantidadlados.AutoSize = true;
            this.lblcantidadlados.Location = new System.Drawing.Point(820, 68);
            this.lblcantidadlados.Name = "lblcantidadlados";
            this.lblcantidadlados.Size = new System.Drawing.Size(157, 13);
            this.lblcantidadlados.TabIndex = 10;
            this.lblcantidadlados.Text = "Cantidad de Lados del Poligono";
            // 
            // lblescala
            // 
            this.lblescala.AutoSize = true;
            this.lblescala.Location = new System.Drawing.Point(822, 156);
            this.lblescala.Name = "lblescala";
            this.lblescala.Size = new System.Drawing.Size(212, 13);
            this.lblescala.TabIndex = 11;
            this.lblescala.Text = "Cuantas veces quieres escalar el poligono?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cuantos grados quieres rotar el poligono?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usa este boton para que se traslade aleatoriamente el poligono";
            // 
            // Lienzo
            // 
            this.Lienzo.Location = new System.Drawing.Point(12, 11);
            this.Lienzo.Name = "Lienzo";
            this.Lienzo.Size = new System.Drawing.Size(791, 658);
            this.Lienzo.TabIndex = 14;
            this.Lienzo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Lienzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblescala);
            this.Controls.Add(this.lblcantidadlados);
            this.Controls.Add(this.txtrotacion);
            this.Controls.Add(this.txtescala);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.btn_trasladar);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.btn_escalar);
            this.Controls.Add(this.btn_dibujar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Graficacion Unidad 2";
            ((System.ComponentModel.ISupportInitialize)(this.Lienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_dibujar;
        private System.Windows.Forms.Button btn_escalar;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btn_trasladar;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.TextBox txtescala;
        private System.Windows.Forms.TextBox txtrotacion;
        private System.Windows.Forms.Label lblcantidadlados;
        private System.Windows.Forms.Label lblescala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Lienzo;
    }
}

