using System;
using System.Windows.Forms;

namespace WF_Practica2
{
    public partial class AppCalculadora : Form
    {
        double num1, num2, res;
        
        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = (Double.Parse(campoOperando1.Text));
                num2 = (Double.Parse(campoOperando2.Text));
                res = num1 + num2;
                campoResultado.Text = res.ToString();
            } catch (FormatException) {
                MessageBox.Show("Debes ingresar solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = (Double.Parse(campoOperando1.Text));
                num2 = (Double.Parse(campoOperando2.Text));
                res = num1 - num2;
                campoResultado.Text = res.ToString();
            } catch (FormatException) {
                MessageBox.Show("Debes ingresar solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = (Double.Parse(campoOperando1.Text));
                num2 = (Double.Parse(campoOperando2.Text));
                res = num1 * num2;
                campoResultado.Text = res.ToString();
            } catch (FormatException) {
                MessageBox.Show("Debes ingresar solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            res = 0;
            campoOperando1.Text = "";
            campoOperando2.Text = "";
            campoResultado.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = (Double.Parse(campoOperando1.Text));
                num2 = (Double.Parse(campoOperando2.Text));
                res = num1 / num2;
                if (num2 == 0) {
                    campoResultado.Text = "";
                    MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    campoResultado.Text = res.ToString();
                }
            } catch (FormatException) {
                MessageBox.Show("Debes ingresar solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AppCalculadora()
        {
            InitializeComponent();
        }

        
    }
}
