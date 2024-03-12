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
    public partial class frm_imagen : Form
    {
        public frm_imagen()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cargarimagen_Click(object sender, EventArgs e)
        {
            // Configurar el diálogo para que solo muestre archivos de imagen
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Mostrar el diálogo y esperar a que el usuario seleccione un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaImagen = openFileDialog1.FileName;

                // Cargar la imagen en el PictureBox
                CargarImagen(rutaImagen);
            }
        }

        private void btn_trasladar_Click(object sender, EventArgs e)
        {
            TrasladarImagenAleatoriamente();
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtrotacion.Text, out int gradosrotacion))
            {
                // Llama a la función para escalar el polígono
                RotarImagen(gradosrotacion);
            }
            else
            {
                MessageBox.Show("Ingresa grados válidos para la rotacion del poligono.");
            }
        }

        private void btn_escalar_Click(object sender, EventArgs e)
        {

        }


        private void CargarImagen(string rutaImagen)
        {
            // Intentar cargar la imagen
            try
            {
                // Cargar la imagen desde el archivo
                Image imagen = Image.FromFile(rutaImagen);

                // Asignar la imagen al PictureBox
                Portaretrato.Image = imagen;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al cargar la imagen
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private Random random = new Random();

        private void TrasladarImagenAleatoriamente()
        {
            if (Portaretrato.Image != null)
            {
                // Definir la cantidad máxima de traslación en píxeles (ajústala según tus necesidades)
                int maxTraslacionX = Portaretrato.Width / 4;
                int maxTraslacionY = Portaretrato.Height / 4;

                int traslacionX = random.Next(-maxTraslacionX, maxTraslacionX + 1);
                int traslacionY = random.Next(-maxTraslacionY, maxTraslacionY + 1);

                Portaretrato.Location = new Point(Portaretrato.Location.X + traslacionX, Portaretrato.Location.Y + traslacionY);
            }
        }

        private void RotarImagen(float grados)
        {
            if (Portaretrato.Image != null)
            {
                Bitmap imagenRotada = new Bitmap(Portaretrato.Image.Width, Portaretrato.Image.Height);
                using (Graphics g = Graphics.FromImage(imagenRotada))
                {
                    g.TranslateTransform((float)imagenRotada.Width / 2, (float)imagenRotada.Height / 2);
                    g.RotateTransform(grados);
                    g.TranslateTransform(-(float)imagenRotada.Width / 2, -(float)imagenRotada.Height / 2);
                    g.DrawImage(Portaretrato.Image, new Point(0, 0));
                }
                Portaretrato.Image = imagenRotada;
            }
        }

        private void EscalarImagen(float factorEscala)
        {
            if (Portaretrato.Image != null)
            {
                int nuevaAnchura = (int)(Portaretrato.Image.Width * factorEscala);
                int nuevaAltura = (int)(Portaretrato.Image.Height * factorEscala);
                Portaretrato.Image = new Bitmap(Portaretrato.Image, nuevaAnchura, nuevaAltura);
            }
        }


    }
}
