using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_U1
{
    public partial class cambiarImagen : Form
    {
        public cambiarImagen()
        {
            InitializeComponent();
        }

        private void btnPerro_Click(object sender, EventArgs e)
        {
            imagen.ImageLocation = "D:\\Escuela\\visualstudio\\Practica3_U1\\Perro.jpg";
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            imagen.ImageLocation = "D:\\Escuela\\visualstudio\\Practica3_U1\\Gato.jpg";
        }
    }
}
