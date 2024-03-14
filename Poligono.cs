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
using Timer = System.Windows.Forms.Timer;

namespace Cruz_Patiño_Diego___Proyecto_Graficacion_U2
{
    public enum ShapeType
    {
        Polygon
    }

    public partial class frmPoligono : Form
    {

        private Graphics graphics;
        private Point center;
        private int sideLength;
        private PointF[] originalPoints;
        private PointF[] transformedPoints;
        private ShapeType currentShape;
        private Timer timer;
        private Matrix transformationMatrix;
        private int numLados = 20; // Número predeterminado de lados
        private float factorEscala = 1.1f; // Ajusta este valor según tu preferencia
        private Color colorSeleccionado = Color.Black; // Color predeterminado
        private Point lastLocation;

        public frmPoligono()
        {
            InitializeComponent();
            Initialize();
        }

        private void btn_dibujar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLados.Text, out int nuevoNumeroLados) && nuevoNumeroLados > 2)
            {
                numLados = nuevoNumeroLados;
                InitializeShapes();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de lados (mínimo 3).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_escalarmas_Click(object sender, EventArgs e)
        {
            ApplyTransformation(MatrixForScaling(factorEscala, factorEscala));
        }

        private void btn_escalarmenos_Click(object sender, EventArgs e)
        {
            ApplyTransformation(MatrixForScaling(1.0f / factorEscala, 1.0f / factorEscala));
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            ApplyTransformation(MatrixForRotation(5));
        }

        private void btn_trasladar_Click(object sender, EventArgs e)
        {
            /*
            ApplyTransformation(MatrixForTranslation(5, 5));
            ApplyTransformation(transformationMatrix);
            */

            // Obtener las dimensiones del PictureBox
            int pbWidth = Lienzo.Width;
            int pbHeight = Lienzo.Height;

            // Generar valores aleatorios para las coordenadas de traslación
            Random rnd = new Random();
            int dx = rnd.Next(-50, 50); // Rango de traslación en el eje x
            int dy = rnd.Next(-50, 50); // Rango de traslación en el eje y

            // Ajustar las coordenadas de traslación si el polígono sale de los límites del PictureBox
            if (transformedPoints.Any(p => p.X + dx < 0 || p.X + dx >= pbWidth || p.Y + dy < 0 || p.Y + dy >= pbHeight))
            {
                // Si el polígono se sale de los límites, reducimos las coordenadas de traslación
                dx = (int)Math.Max(-transformedPoints.Min(p => p.X), Math.Min(pbWidth - transformedPoints.Max(p => p.X), dx));
                dy = (int)Math.Max(-transformedPoints.Min(p => p.Y), Math.Min(pbHeight - transformedPoints.Max(p => p.Y), dy));
            }

            // Aplicar la traslación a la matriz de transformación
            transformationMatrix.Multiply(MatrixForTranslation(dx, dy));

            ApplyTransformation(transformationMatrix); // Pasar la matriz de transformación al método
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // FUNCIONES Y METODOS

        private void Initialize()
        {
            graphics = Lienzo.CreateGraphics();
            center = new Point(Lienzo.Width / 2, Lienzo.Height / 2);
            sideLength = 50;
            currentShape = ShapeType.Polygon;
            InitializeShapes();

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;

            transformationMatrix = new Matrix();
        }

        private void InitializeShapes()
        {
            originalPoints = new PointF[numLados];
            transformedPoints = new PointF[numLados];

            for (int i = 0; i < numLados; i++)
            {
                double angle = 2 * Math.PI * i / numLados;
                originalPoints[i] = new PointF(center.X + (float)(sideLength * Math.Cos(angle)), center.Y + (float)(sideLength * Math.Sin(angle)));
            }

            Array.Copy(originalPoints, transformedPoints, numLados);
            DrawShape();
        }

        private void DrawShape()
        {
            graphics.Clear(Color.White);
            graphics.DrawPolygon(Pens.Black, transformedPoints);

            using (Pen pen = new Pen(colorSeleccionado, 1.0f))
            {
                graphics.DrawPolygon(pen, transformedPoints);
            }
            graphics.FillPolygon(new SolidBrush(colorSeleccionado), transformedPoints);

        }

        private void ApplyTransformation(Matrix matrix)
        {
            matrix.TransformPoints(transformedPoints);
            DrawShape();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ApplyTransformation(MatrixForTranslation(1, 1));
            ApplyTransformation(MatrixForRotation(1));
        }

        private Matrix MatrixForTranslation(float dx, float dy)
        {
            Matrix translationMatrix = new Matrix();
            translationMatrix.Translate(dx, dy);
            return translationMatrix;
        }

        private Matrix MatrixForScaling(float scaleX, float scaleY)
        {
            // Escala alrededor del punto central del polígono
            Matrix scalingMatrix = new Matrix();
            scalingMatrix.Translate(center.X, center.Y);        // Traslada al centro
            scalingMatrix.Scale(scaleX, scaleY);                 // Aplica la escala
            scalingMatrix.Translate(-center.X, -center.Y);      // Traslada de vuelta

            return scalingMatrix;
        }

        private Matrix MatrixForRotation(float angle)
        {
            // Rota alrededor del punto central del polígono
            Matrix rotationMatrix = new Matrix();
            rotationMatrix.Translate(center.X, center.Y);  // Traslada al centro
            rotationMatrix.Rotate(angle);                   // Aplica la rotación
            rotationMatrix.Translate(-center.X, -center.Y); // Traslada de vuelta

            return rotationMatrix;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            // Abre el diálogo de selección de color
            ColorDialog colorDialog = new ColorDialog();

            // Establece el color inicial en el diálogo
            colorDialog.Color = colorSeleccionado;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Si se selecciona un color, actualiza el color y vuelve a dibujar el polígono
                colorSeleccionado = colorDialog.Color;
                DrawShape();
            }
        }

        private void Lienzo_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

    }
}
