using System;
using System.Windows.Forms;

namespace ProyectoFinal_TAP
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
            SALIDA.Items.Add("ID DEL PEDIDO: " + txtvalida.Text);
            SALIDA.Items.Add("NOMBRE: " + txtnombre.Text);
            SALIDA.Items.Add("AP. PATERNO: " + txtap.Text);
            SALIDA.Items.Add("AP. MATERNO: " + txtam.Text);
            SALIDA.Items.Add("CORREO: " + mail.Text);
            SALIDA.Items.Add("TELÉFONO: " + escuela.Text);
            
            if (hombre.Checked) SALIDA.Items.Add("GÉNERO: Hombre");
            if (mujer.Checked) SALIDA.Items.Add("GÉNERO: Mujer");

            SALIDA.Items.Add("PRODUCTO: " + cbImagen.Text);
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
                if (SALIDA.Items[i].ToString() == "ID DEL PEDIDO: " + txtvalida.Text) {
                    SALIDA.Items[i + 1] = "NOMBRE: " + txtnombre.Text;
                    SALIDA.Items[i + 2] = "AP. PATERNO: " + txtap.Text;
                    SALIDA.Items[i + 3] = "AP. MATERNO: " + txtam.Text;
                    SALIDA.Items[i + 4] = "CORREO: " + mail.Text;
                    SALIDA.Items[i + 5] = "TELÉFONO: " + escuela.Text;

                    if (hombre.Checked) SALIDA.Items[i + 6] = "GÉNERO: Hombre";
                    if (mujer.Checked) SALIDA.Items[i + 6] = "GÉNERO: Mujer";

                    SALIDA.Items[i + 7] = "PRODUCTO: " + cbImagen.Text;
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

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = "D:\\Escuela\\visualstudio\\ProyectoFinal_TAP\\";
            if (cbImagen.SelectedIndex == 0) {
                imagen.ImageLocation = path + "MokaCafe.jpg";
            }
            if (cbImagen.SelectedIndex == 1)
            {
                imagen.ImageLocation = path + "RedVelvet.jpg";
            }
            if (cbImagen.SelectedIndex == 2)
            {
                imagen.ImageLocation = path + "Capuccino.jpg";
            }
            if (cbImagen.SelectedIndex == 3)
            {
                imagen.ImageLocation = path + "Cuernitos.jpg";
            }
            if (cbImagen.SelectedIndex == 4)
            {
                imagen.ImageLocation = path + "Cheesecake.jpg";
            }
            if (cbImagen.SelectedIndex == 5)
            {
                imagen.ImageLocation = path + "Sandwich.jpg";
            }
        }

        private void escuela_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion.numeros(e);
        }
    }
}
