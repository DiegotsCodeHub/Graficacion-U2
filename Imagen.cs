using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    public partial class frm_imagen : Form
    {
        private Bitmap originalImage;
        private Bitmap transformedImage;
        private Matrix transformationMatrix;
        private float scaleFactor = 1.1f; // Ajusta este valor según tu preferencia

        public frm_imagen()
        {
            InitializeComponent();
            Initialize();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cargarimagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen seleccionada
                    LoadImage(openFileDialog.FileName);
                }
            }
        }

        private void btn_trasladar_Click(object sender, EventArgs e)
        {
            // Obtener las dimensiones del PictureBox
            int pbWidth = Portaretrato.Width;
            int pbHeight = Portaretrato.Height;

            // Generar valores aleatorios para las coordenadas de traslación
            Random rnd = new Random();
            int dx = rnd.Next(-50, 50); // Rango de traslación en el eje x
            int dy = rnd.Next(-50, 50); // Rango de traslación en el eje y

            // Ajustar las coordenadas de traslación si la imagen se sale de los límites del PictureBox
            if (Portaretrato.Location.X + dx < 0 || Portaretrato.Location.X + dx >= pbWidth || Portaretrato.Location.Y + dy < 0 || Portaretrato.Location.Y + dy >= pbHeight)
            {
                // Si la imagen se sale de los límites, reducimos las coordenadas de traslación
                dx = Math.Max(-Portaretrato.Location.X, Math.Min(pbWidth - Portaretrato.Location.X - Portaretrato.Width, dx));
                dy = Math.Max(-Portaretrato.Location.Y, Math.Min(pbHeight - Portaretrato.Location.Y - Portaretrato.Height, dy));
            }

            // Aplicar la traslación a la posición de la imagen
            Portaretrato.Location = new Point(Portaretrato.Location.X + dx, Portaretrato.Location.Y + dy);
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            // Aplicar la rotación alrededor del centro de la imagen
            transformationMatrix.Multiply(MatrixForRotation(5));

            ApplyTransformation();
        }

        private void btni_escalarmas_Click(object sender, EventArgs e)
        {
            // Aplicar el escalado alrededor del centro de la imagen
            transformationMatrix.Multiply(MatrixForScaling(scaleFactor, scaleFactor));

            ApplyTransformation();
        }
        private void btni_escalarmenos_Click(object sender, EventArgs e)
        {
            transformationMatrix.Multiply(MatrixForScaling(1.0f / scaleFactor, 1.0f / scaleFactor));

            ApplyTransformation();
        }

        private void Initialize()
        {
            transformationMatrix = new Matrix();
        }

        private void LoadImage(string imagePath)
        {
            // Cargar la imagen original desde la ruta proporcionada
            originalImage = new Bitmap(imagePath);

            // Crear una copia de la imagen original para aplicar transformaciones
            transformedImage = new Bitmap(originalImage);

            // Mostrar la imagen original en el PictureBox
            Portaretrato.Image = originalImage;
        }

        private void ApplyTransformation()
        {
            // Aplicar la transformación a la imagen transformada
            using (Graphics g = Graphics.FromImage(transformedImage))
            {
                g.Clear(Color.White); // Limpiar la imagen
                g.Transform = transformationMatrix;
                g.DrawImage(originalImage, 0, 0);
            }

            // Mostrar la imagen transformada en el PictureBox
            Portaretrato.Image = transformedImage;
        }

        private Matrix MatrixForTranslation(float dx, float dy)
        {
            Matrix translationMatrix = new Matrix();
            translationMatrix.Translate(dx, dy);
            return translationMatrix;
        }

        private Matrix MatrixForScaling(float scaleX, float scaleY)
        {
            // Escala alrededor del punto central de la imagen
            Matrix scalingMatrix = new Matrix();
            scalingMatrix.Translate(originalImage.Width / 2, originalImage.Height / 2);
            scalingMatrix.Scale(scaleX, scaleY);
            scalingMatrix.Translate(-originalImage.Width / 2, -originalImage.Height / 2);
            return scalingMatrix;
        }

        private Matrix MatrixForRotation(float angle)
        {
            // Rota alrededor del punto central de la imagen
            Matrix rotationMatrix = new Matrix();
            rotationMatrix.Translate(originalImage.Width / 2, originalImage.Height / 2);
            rotationMatrix.Rotate(angle);
            rotationMatrix.Translate(-originalImage.Width / 2, -originalImage.Height / 2);
            return rotationMatrix;
        }





    }
}
