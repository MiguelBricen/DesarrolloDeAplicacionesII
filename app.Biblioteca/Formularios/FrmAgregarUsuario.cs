using app.Biblioteca.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmAgregarUsuario : Form
    {
        public event Action registroAgregado;

        #region 0 INICIALIZACÓN (CONTRUCTOR Y EVENTO)
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            txtNombre.Focus();
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlesEsc;
        }
        public FrmAgregarUsuario(int idUsuario, string nombre, string apellido, string telefono, string email)
        {
            InitializeComponent();

            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlesEsc;

            txtId.Text = idUsuario.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;          
            txtTelefono.Text = telefono;  
            txtEmail.Text = email;  

            txtNombre.Focus();
        }
        #endregion

        #region 1 METODOS
        private void Guardar(string nombre, string apellido, string telefono, string email)
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                               INSERT INTO TblUsuario(nombre, apellido, telefono, email)
                                            VALUES(@Nombre,
                                                    @Apellido,
                                                    @Telefono,
                                                    @Email)";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    conexion.Open();

                    int resultado = command.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro almacenado correctamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el registro", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarControles(tlpAgregarUsuario);

        }
        private void Actualizar(int id, string nombre, string apellido, string telefono, string email)
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                               UPDATE Tblusuario
                               SET nombre = @Nombre,
                                   apellido = @Apellido,
                                   telefono = @Telefono,
                                   email = @Email
                                 
                               WHERE idUsuario = @idUsuario";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.AddWithValue("@idUsuario", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                   
                    conexion.Open();

                    int resultado = command.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarControles(tlpAgregarUsuario);

        }
        private void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // 🔹 Si el control es un Guna2TextBox
                if (control is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    txt.Clear();
                }

                // 🔹 Si es un ComboBox (autor o categoría)
                else if (control is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1;
                }

                // 🔹 Si es un DateTimePicker (reinicia al año actual)
                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }

                // 🔹 Si el control contiene otros controles (como TableLayoutPanel o Panel)
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }

                txtNombre.Focus();
            }
        }
        #endregion

        #region 2 BOTONES DE COMANDO
       
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



        #endregion

        private void iconGuardar_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            bool datosValidos = true;

            // 🔹 Función recursiva para recorrer TODOS los controles del formulario
            void Validar(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2TextBox txt)
                    {
                        if (string.IsNullOrWhiteSpace(txt.Text))
                        {
                            errorIcono.SetError(txt, "Este campo es obligatorio.");
                            datosValidos = false;
                        }
                    }
                    else if (control is Guna.UI2.WinForms.Guna2ComboBox combo)
                    {
                        if (combo.SelectedIndex == -1 || combo.SelectedValue == null)
                        {
                            errorIcono.SetError(combo, "Debe seleccionar una opción.");
                            datosValidos = false;
                        }
                    }
                    else if (control is Guna.UI2.WinForms.Guna2NumericUpDown num)
                    {
                        if (num.Value <= 0)
                        {
                            errorIcono.SetError(num, "Ingrese una cantidad válida.");
                            datosValidos = false;
                        }
                    }
                    else if (control is Guna.UI2.WinForms.Guna2DateTimePicker date)
                    {
                        if (date.Value == DateTime.MinValue)
                        {
                            errorIcono.SetError(date, "Seleccione una fecha válida.");
                            datosValidos = false;
                        }
                    }

                    // 🔁 Recorre los controles hijos (por si hay paneles dentro del tablelayout)
                    if (control.HasChildren)
                        Validar(control);
                }
            }

            // 🔹 Inicia la validación desde el TableLayoutPanel principal
            Validar(tlpAgregarUsuario);

            if (!datosValidos)
            {
                MessageBox.Show("Información incompleta, se marcarán los campos que faltan.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // ✅ Si los datos son válidos, capturamos la información
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
           

            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    Guardar(nombre, apellido, telefono, email);
                }
                else
                {
                    if (!int.TryParse(txtId.Text.Trim(), out int idUsuario))
                    {
                        MessageBox.Show("El ID no es válido.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Actualizar(idUsuario, nombre, apellido, telefono, email);
                }

                registroAgregado?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarControles(tlpAgregarUsuario);
        }
    }
}
