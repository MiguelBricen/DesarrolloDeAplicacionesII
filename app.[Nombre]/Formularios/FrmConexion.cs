using System;
using System.Windows.Forms;
using app._Nombre_.Utilidades;

namespace app._Nombre_.Formularios
{
    public partial class FrmConexion : Form
    {
        public FrmConexion()
        {
            InitializeComponent();
        }
        private void iconAceptar_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            bool datosValidos = true;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)
                {
                    if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                    {
                        errorIcono.SetError(gunaTextBox, "este campo es obligatorio.");
                        datosValidos = false;
                    }
                }
            }

            if (!datosValidos)
            {
                MessageBox.Show("Información incompleta, seran remarcados los campos que faltan", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Crear objeto de conexión
            var parametros = new ParametrosDeConexion
            {
                servidor = txtServidor.Text.Trim(),
                baseDatos = txtBaseDatos.Text.Trim(),
            };

            if (!Administrarconexion.probarConexion(parametros, out string error))
            {
                MessageBox.Show($"No se pudo establecer la conexión con la base de datos.\n\nDetalles: {error}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                Administrarconexion.Guardar(parametros);
                MessageBox.Show("Datos de conexión registrados con éxito.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
