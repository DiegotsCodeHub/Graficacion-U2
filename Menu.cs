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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_poligono_Click(object sender, EventArgs e)
        {
            frmPoligono poligono = new frmPoligono();
            poligono.Show();
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            frm_imagen imagen = new frm_imagen();
            imagen.Show();
        }
    }
}
