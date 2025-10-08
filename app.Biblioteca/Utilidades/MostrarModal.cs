using System.Drawing;
using System.Windows.Forms;

namespace app.Biblioteca.Utilidades
{
    public static class MostrarModal
    {

        public static void MostrarConCapa(Form formularioPrincipal, Form formularioModal)
        {
            // Crear una capa oscura - semi trasnparente
            Form capa = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.3,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = formularioPrincipal.PointToScreen(Point.Empty),
                Size = formularioPrincipal.ClientSize,
                TopMost = false,
                Owner = formularioPrincipal,
            };
            capa.Show();

            formularioModal.ShowInTaskbar = false;
            formularioModal.ShowDialog();

            capa.Close();
        }
    }
}
