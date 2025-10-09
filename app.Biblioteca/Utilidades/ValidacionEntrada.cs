using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Biblioteca.Utilidades
{
    public class ValidacionEntrada
    {

        // MANEJAR LA TECLA ENTER COMO TAB
        
        public static  void PasarFocus(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al pasar el focus: " + ex.Message);
            }
        }

        // MANEJAR LA TECLA ESC
        public static void ControlesEsc(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                   if(sender is Form formulario)
                    {
                        formulario.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el control ESC: " + ex.Message);
            }
        }
    }
}
