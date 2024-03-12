using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_dibujar_Click(object sender, EventArgs e)
        {
            // Llama a DibujarPoligono
            DibujarPoligono();
        }

        private void btn_escalar_Click(object sender, EventArgs e)
        {
            // Obtiene el número de veces de escalas desde la TextBox externa
            if (int.TryParse(txtescala.Text, out int vecesEscalas))
            {
                // Llama a la función para escalar el polígono
                EscalarPoligono(vecesEscalas);
            }
            else
            {
                MessageBox.Show("Ingresa un número válido de veces de escala del poligono.");
            }
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtrotacion.Text, out int gradosrotacion))
            {
                // Llama a la función para escalar el polígono
                RotarPoligono(gradosrotacion);
            }
            else
            {
                MessageBox.Show("Ingresa grados válidos para la rotacion del poligono.");
            }
        }

        private PointF[] puntosPoligono = Array.Empty<PointF>();

        private void DibujarPoligono()
        {
            if (int.TryParse(txtLados.Text, out int lados))
            {
                if (lados == 1)
                {
                    MessageBox.Show("Favor de ingresar un numero mayor a 1.");
                }
                else
                {
                    puntosPoligono = CalcularPuntosPoligono(lados);
                    DibujarEnPictureBox();
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número válido de lados.");
            }
        }
        private void DibujarEnPictureBox()
        {
            Lienzo.Image = new Bitmap(Lienzo.Width, Lienzo.Height);
            using (Graphics g = Graphics.FromImage(Lienzo.Image))
            {
                g.Clear(Lienzo.BackColor);
                g.DrawPolygon(Pens.Black, puntosPoligono);
            }
        }

        private PointF[] CalcularPuntosPoligono(int lados)
        {
            int centroX = Lienzo.Width / 2;
            int centroY = Lienzo.Height / 2;
            int radio = Math.Min(Lienzo.Width, Lienzo.Height) / 4;

            PointF[] puntos = new PointF[lados];
            for (int i = 0; i < lados; i++)
            {
                double angulo = 2 * Math.PI * i / lados;
                float x = centroX + (float)(radio * Math.Cos(angulo));
                float y = centroY + (float)(radio * Math.Sin(angulo));
                puntos[i] = new PointF(x, y);
            }

            return puntos;
        }

        private void EscalarPoligono(int veces)
        {
            if (puntosPoligono != null && puntosPoligono.Length > 0)
            {
                // Calcular el centro del polígono
                PointF centro = new PointF(Lienzo.Width / 2f, Lienzo.Height / 2f);

                // Centrar el polígono en el origen antes de escalar
                for (int i = 0; i < puntosPoligono.Length; i++)
                {
                    puntosPoligono[i] = new PointF(puntosPoligono[i].X - centro.X, puntosPoligono[i].Y - centro.Y);
                }

                // Escalar el polígono la cantidad de veces especificada
                for (int v = 0; v < veces; v++)
                {
                    for (int i = 0; i < puntosPoligono.Length; i++)
                    {
                        puntosPoligono[i] = new PointF(puntosPoligono[i].X * 1.2f, puntosPoligono[i].Y * 1.2f);
                    }
                }

                // Trasladar el polígono de vuelta a su posición original después de escalar
                for (int i = 0; i < puntosPoligono.Length; i++)
                {
                    puntosPoligono[i] = new PointF(puntosPoligono[i].X + centro.X, puntosPoligono[i].Y + centro.Y);
                }

                DibujarEnPictureBox();
            }
            else
            {
                MessageBox.Show("Primero dibuja un polígono antes de intentar escalarlo.");
            }
        }

        private void RotarPoligono(float grados)
        {
            if (puntosPoligono != null && puntosPoligono.Length > 0)
            {
                // Calcular el centro del polígono
                PointF centro = new PointF(Lienzo.Width / 2f, Lienzo.Height / 2f);

                // Centrar el polígono en el origen antes de rotar
                for (int i = 0; i < puntosPoligono.Length; i++)
                {
                    puntosPoligono[i] = new PointF(puntosPoligono[i].X - centro.X, puntosPoligono[i].Y - centro.Y);
                }

                // Rotar el polígono
                float radianes = grados * (float)Math.PI / 180.0f;
                for (int i = 0; i < puntosPoligono.Length; i++)
                {
                    float x = puntosPoligono[i].X * (float)Math.Cos(radianes) - puntosPoligono[i].Y * (float)Math.Sin(radianes);
                    float y = puntosPoligono[i].X * (float)Math.Sin(radianes) + puntosPoligono[i].Y * (float)Math.Cos(radianes);
                    puntosPoligono[i] = new PointF(x, y);
                }

                // Trasladar el polígono de vuelta a su posición original después de rotar
                for (int i = 0; i < puntosPoligono.Length; i++)
                {
                    puntosPoligono[i] = new PointF(puntosPoligono[i].X + centro.X, puntosPoligono[i].Y + centro.Y);
                }

                DibujarEnPictureBox();
            }
            else
            {
                MessageBox.Show("Primero dibuja un polígono antes de intentar rotarlo.");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            puntosPoligono = Array.Empty<PointF>();
            Lienzo.Image = new Bitmap(Lienzo.Width, Lienzo.Height);

            txtescala.Clear();
            txtLados.Clear();
            txtrotacion.Clear();
        }
    }
}
