using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_TAP
{
    public partial class AppMenu : Form
    {
        public AppMenu()
        {
            InitializeComponent();
        }
        private void menúDeAlimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppAlimentos a = new AppAlimentos();
            a.Show();
        }
        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppHistoria h = new AppHistoria();
            h.Show();
        }
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppRegistro r = new AppRegistro();
            r.Show();
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaRegistro t = new TablaRegistro();
            t.Show();
        }

        private void presentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInicio p = new AppInicio();
            p.Show();
        }

        private void descripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDescripcion d = new AppDescripcion();
            d.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salidaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
