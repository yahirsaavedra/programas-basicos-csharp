using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HilosGUI
{
    public partial class Practica4 : Form
    {
        public Practica4()
        {
            InitializeComponent();
        }

        private void Practica4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este mensaje no está dentro de un hilo.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Now;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("[" + i + "]" + " - Hilo primario");

                Thread.Sleep(1000);
            }
            DateTime fin = DateTime.Now;
            TimeSpan tiempo = (fin - inicio);
            MessageBox.Show("Este mensaje ESTÁ dentro de un hilo (tiempo: " + tiempo + " ms).");

        }
    }
}
