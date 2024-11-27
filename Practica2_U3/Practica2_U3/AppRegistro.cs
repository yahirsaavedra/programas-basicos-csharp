using System;
using System.Windows.Forms;

namespace Practica2_U3
{
    public partial class AppRegistro : Form
    {
        private Valida validacion = new Valida();

        public AppRegistro()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            registros.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtvalida.Text = "";
            txtvalida.Focus();
            txtnombre.Text = "";
            txtnombre.Focus();
            txtap.Text = "";
            txtap.Focus();
            txtam.Text = "";
            txtam.Focus();
            mail.Text = "";
            mail.Focus();
            escuela.Text = "";
            escuela.Focus();
            hombre.Checked = false;
            mujer.Checked = false;
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            TablaRegistro T = new TablaRegistro();
            T.tb1.Text = txtvalida.Text;
            T.tb2.Text = txtnombre.Text;
            T.tb3.Text = txtap.Text;
            T.tb4.Text = txtam.Text;

            this.Hide();

            T.FormClosed += (s, args) => this.Close();
            T.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (SALIDA.Items.Count >= 8) SALIDA.Items.Add("");
            SALIDA.Items.Add("MATRICULA: " + txtvalida.Text);
            SALIDA.Items.Add("NOMBRE: " + txtnombre.Text);
            SALIDA.Items.Add("AP. PATERNO: " + txtap.Text);
            SALIDA.Items.Add("AP. MATERNO: " + txtam.Text);
            SALIDA.Items.Add("CORREO: " + mail.Text);
            SALIDA.Items.Add("ESCUELA: " + escuela.Text);
            
            if (hombre.Checked) SALIDA.Items.Add("GÉNERO: Hombre");
            if (mujer.Checked) SALIDA.Items.Add("GÉNERO: Mujer");

            SALIDA.Items.Add("IMAGEN: " + cbImagen.Text);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            for (int i = 8; i >= 0; i--) {
                if (SALIDA.Items.Count == i || SALIDA.Items.Count == 0) continue;
                else SALIDA.Items.RemoveAt(i);
            }
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SALIDA.Items.Count; i += 8) {
                if (SALIDA.Items[i].ToString() == "MATRICULA: " + txtvalida.Text) {
                    SALIDA.Items[i + 1] = "NOMBRE: " + txtnombre.Text;
                    SALIDA.Items[i + 2] = "AP. PATERNO: " + txtap.Text;
                    SALIDA.Items[i + 3] = "AP. MATERNO: " + txtam.Text;
                    SALIDA.Items[i + 4] = "CORREO: " + mail.Text;
                    SALIDA.Items[i + 5] = "ESCUELA: " + escuela.Text;

                    if (hombre.Checked) SALIDA.Items[i + 6] = "GÉNERO: Hombre";
                    if (mujer.Checked) SALIDA.Items[i + 6] = "GÉNERO: Mujer";

                    SALIDA.Items[i + 7] = "IMAGEN: " + cbImagen.Text;
                }
            }
        }

        private void txtvalida_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.numeros(e);
        }

        private void txtnombre_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.letras(e);
        }

        private void txtap_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.letras(e);
        }

        private void txtam_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.letras(e);
        }

        private void mail_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void escuela_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.letras(e);
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = "D:\\Escuela\\visualstudio\\WF_Practica3\\";
            if (cbImagen.SelectedIndex == 0) {
                imagen.ImageLocation = path + "Perro.jpg";
            }
            if (cbImagen.SelectedIndex == 1)
            {
                imagen.ImageLocation = path + "Gato.jpg";
            }
            if (cbImagen.SelectedIndex == 2)
            {
                imagen.ImageLocation = path + "Hamster.jpg";
            }
        }
    }
}
