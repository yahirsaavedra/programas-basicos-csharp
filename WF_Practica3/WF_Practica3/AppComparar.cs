using System;
using System.Windows.Forms;

namespace WF_Practica3
{
    public partial class AppComparar : Form
    {
        public AppComparar()
        {
            InitializeComponent();
        }
        private void btnComparar_Click(object sender, EventArgs e)
        {
            try {
                int a = int.Parse(campoDato1.Text),
                    b = int.Parse(campoDato2.Text),
                    c = int.Parse(campoDato3.Text),
                    mayor = 0,
                    menor = 0,
                    intermedio = 0;

                if (a == b || a == c || b == c) {
                    MessageBox.Show("Todos los números ingresados deben ser diferentes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    if (a > b) {
                        mayor = a;
                        menor = b;
                        intermedio = c;
                    }
                    if (a > c) {
                        mayor = a;
                        menor = c;
                        intermedio = b;
                    }
                    if (b > a) {
                        mayor = b;
                        menor = a;
                        intermedio = c;
                    }
                    if (b > c) {
                        mayor = b;
                        menor = c;
                        intermedio = a;
                    }
                    if (c > a) {
                        mayor = c;
                        menor = a;
                        intermedio = b;
                    }
                    if (c > b) {
                        mayor = c;
                        menor = b;
                        intermedio = a;
                    }

                    if (rbMayor.Checked) {
                        campoResultado.Text = mayor.ToString();
                    } else if (rbMenor.Checked) {
                        campoResultado.Text = menor.ToString();
                    } else if (rbIntermedio.Checked) {
                        campoResultado.Text = intermedio.ToString();
                    } else {
                        MessageBox.Show("Por favor, selecciona una opción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } catch (FormatException) {
                MessageBox.Show("Los datos ingresados deben ser números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
