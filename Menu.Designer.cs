namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    partial class frm_menu
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_poligono = new System.Windows.Forms.Button();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minecraft Fifty Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(436, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Proyecto Graficacion Unidad 2";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(184, 94);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(127, 23);
            this.btn_salir.TabIndex = 17;
            this.btn_salir.Text = "Salir de la Aplicacion";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_poligono
            // 
            this.btn_poligono.Location = new System.Drawing.Point(164, 65);
            this.btn_poligono.Name = "btn_poligono";
            this.btn_poligono.Size = new System.Drawing.Size(75, 23);
            this.btn_poligono.TabIndex = 18;
            this.btn_poligono.Text = "Poligono";
            this.btn_poligono.UseVisualStyleBackColor = true;
            this.btn_poligono.Click += new System.EventHandler(this.btn_poligono_Click);
            // 
            // btn_imagen
            // 
            this.btn_imagen.Location = new System.Drawing.Point(256, 65);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(75, 23);
            this.btn_imagen.TabIndex = 19;
            this.btn_imagen.Text = "Imagen";
            this.btn_imagen.UseVisualStyleBackColor = true;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 164);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.btn_poligono);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frm_menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_poligono;
        private System.Windows.Forms.Button btn_imagen;
    }
}