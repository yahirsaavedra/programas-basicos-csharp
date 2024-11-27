using System;
using System.Windows.Forms;

namespace ProyectoFinal_TAP
{
    internal class Valida
    {
        public void numeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                // IsNumber nos permite pasar un char y que nos devuelva si es true 
                // si es realmente un NUMERO, se captura mediante
                // e.KeyChar. LA e ES UN TIPO keyPress VA A PERMITIR CAPTURAR
                {
                    e.Handled = false;
                    //VA HACER QUE SE ESCRIBA EN EL textbox  
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("SOLO NUMEROS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        public void letras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                // IsLetter nos permite pasar un char y que nos devuelva si es true 
                // si es realmente una letra, esa letra se captura mediante
                // e.KeyChar. LA e ES UN TIPO keyPress VA A PERMITIR CAPTURAR
                {
                    e.Handled = false;
                    //que se ha controlado o no el evento
                    //VA HACER QUE SE ESCRIBA EN EL textbox  
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("SOLO LETRAS");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: " + ex);
            }

        }
    }
}
