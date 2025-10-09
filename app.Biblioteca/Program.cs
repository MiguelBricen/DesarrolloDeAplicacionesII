using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using app.Biblioteca.Formularios;
using app.Biblioteca.Utilidades;

namespace app.Biblioteca
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilitar DPI Awareness para mejorar la calidad visual en pantallas modernas
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Intentar cargar los parámetros de conexión
            var conexion = Administrarconexion.Cargar();

            // Si no hay conexión configurada, abrir el formulario FrmConexion
            if (string.IsNullOrWhiteSpace(conexion.servidor) || string.IsNullOrWhiteSpace(conexion.baseDatos))
            {
                using (var frm = new FrmConexion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show(
                            "No se configuró la conexión. La aplicación se cerrará.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        return;
                    }
                }
            }

            // Si la conexión existe, iniciar el menú principal
            Application.Run(new MDIMenu());
        }

        // Importar la función de la API de Windows para DPI Awareness
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
