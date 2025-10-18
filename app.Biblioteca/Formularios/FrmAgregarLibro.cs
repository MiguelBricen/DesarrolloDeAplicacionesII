using app.Biblioteca.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmAgregarLibro : Form
    {
        public event Action registroAgregado;

        #region 0 INICIALIZACIÓN (CONSTRUCTOR Y EVENTO)
        public FrmAgregarLibro()
        {
            InitializeComponent();
            CargarAutores();
            CargarCategorias();
            txtTitulo.Focus(); // Enfoca el campo principal
        }
        public FrmAgregarLibro(int idLibro, string titulo, int idAutor, int idCategoria, DateTime anioPublicacion, int cantidad)
        {
            InitializeComponent();
            CargarAutores();
            CargarCategorias();

            txtIdLibro.Text = idLibro.ToString();
            txtTitulo.Text = titulo;
            cboAutor.SelectedValue = idAutor;
            cboCategoria.SelectedValue = idCategoria;
            dtpAnioPublicacion.Value = anioPublicacion;
            numCantidad.Value = cantidad; // ✅ Aquí pasamos la cantidad

            txtTitulo.Focus();
        }
        #endregion

        #region 1 METODOS
        private void Guardar(string titulo, int idAutor, int idCategoria, DateTime anioPublicacion, int cantidad)
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"INSERT INTO TblLibro(titulo, idAutor, idCategoria, anioPublicacion, cantidad)
                                           VALUES(@Titulo, @IdAutor, @IdCategoria, @AnioPublicacion, @Cantidad)";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.AddWithValue("@Titulo", titulo);
                    command.Parameters.AddWithValue("@IdAutor", idAutor);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    command.Parameters.AddWithValue("@AnioPublicacion", anioPublicacion.Year);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    conexion.Open();

                    int resultado = command.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro almacenado correctamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el registro", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Actualizar(int idLibro, string titulo, int idAutor, int idCategoria, DateTime anioPublicacion, int cantidad)
        {
            try
            {
                string connectionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = @"
                UPDATE TblLibro
                SET titulo = @Titulo,
                    idAutor = @IdAutor,
                    idCategoria = @IdCategoria,
                    anioPublicacion = @AnioPublicacion,
                    cantidad = @Cantidad
                WHERE idLibro = @IdLibro";

                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.AddWithValue("@IdLibro", idLibro);
                    command.Parameters.AddWithValue("@Titulo", titulo);
                    command.Parameters.AddWithValue("@IdAutor", idAutor);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    command.Parameters.AddWithValue("@AnioPublicacion", anioPublicacion.Year);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

                    conexion.Open();

                    int resultado = command.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Libro actualizado correctamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el libro", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarAutores()
        {
            try
            {
                // ✅ Verificar que el ComboBox existe antes de usarlo
                if (cboAutor == null)
                {
                    MessageBox.Show("El control 'cboAutor' no está inicializado. Verifica que su nombre coincida exactamente en el diseñador.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Obtener la conexión
                string connectionString = conexionDB.ObtenerConexion();

                // ✅ Proteger por si la conexión no está configurada
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    MessageBox.Show("No se encontró una conexión válida a la base de datos.",
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT idAutor, nombre + ' ' + apellido AS Autor FROM TblAutor";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // ✅ Enlazar los datos
                    cboAutor.DataSource = dt;
                    cboAutor.DisplayMember = "Autor";
                    cboAutor.ValueMember = "idAutor";
                    cboAutor.SelectedIndex = -1; // Inicia vacío
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los autores desde la base de datos:\n" + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCategorias()
        {
            try
            {
                // ✅ Verificar que el ComboBox existe antes de usarlo
                if (cboCategoria == null)
                {
                    MessageBox.Show("El control 'cboCategoria' no está inicializado. Verifica que el nombre coincida en el diseñador.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Obtener la cadena de conexión
                string connectionString = conexionDB.ObtenerConexion();

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    MessageBox.Show("No se encontró una conexión válida a la base de datos.",
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Conexión y consulta
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT idCategoria, nombre AS Categoria FROM TblCategoria";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // ✅ Enlazar datos
                    cboCategoria.DataSource = dt;
                    cboCategoria.DisplayMember = "Categoria";
                    cboCategoria.ValueMember = "idCategoria";
                    cboCategoria.SelectedIndex = -1; // Inicia vacío
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar las categorías desde la base de datos:\n" + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                else if (control is NumericUpDown num)
                {
                    num.Value = 0; // 🔹 Reinicia la cantidad
                }

                // 🔹 Si el control contiene otros controles (como TableLayoutPanel o Panel)
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }

                txtTitulo.Focus();
            }
        }
        #endregion

        #region 2 BOTONES DE COMANDO
        private void iconGuardar_Click(object sender, EventArgs e)
        {

            errorIcono.Clear();
            bool datosValidos = true;

            // 🔁 Validar de forma recursiva todos los controles dentro del contenedor
            ValidarControles(tlpAgregarLibro, ref datosValidos);

            if (!datosValidos)
            {
                MessageBox.Show("Información incompleta, se marcarán los campos que faltan.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // ✅ Obtener datos del formulario
            string titulo = txtTitulo.Text.Trim();
            int idAutor = Convert.ToInt32(cboAutor.SelectedValue);
            int idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
            DateTime anioPublicacion = dtpAnioPublicacion.Value;
            int cantidad = (int)numCantidad.Value;

            try
            {
                if (string.IsNullOrWhiteSpace(txtIdLibro.Text.Trim()))
                {
                    Guardar(titulo, idAutor, idCategoria, anioPublicacion, cantidad);
                }
                else
                {
                    if (!int.TryParse(txtIdLibro.Text.Trim(), out int idLibro))
                    {
                        MessageBox.Show("El ID no es válido.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Actualizar(idLibro, titulo, idAutor, idCategoria, anioPublicacion, cantidad);
                }

                registroAgregado?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarControles(tlpAgregarLibro);
        }
        private void ValidarControles(Control contenedor, ref bool datosValidos)
        {
            foreach (Control control in contenedor.Controls)
            {
                // 🔁 Si el control tiene hijos, seguir recorriendo
                if (control.HasChildren)
                    ValidarControles(control, ref datosValidos);

                if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)
                {
                    if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                    {
                        errorIcono.SetError(gunaTextBox, "Este campo es obligatorio.");
                        datosValidos = false;
                    }
                }
                else if (control is Guna.UI2.WinForms.Guna2ComboBox gunaCombo)
                {
                    if (gunaCombo.SelectedIndex == -1 || gunaCombo.SelectedValue == null)
                    {
                        errorIcono.SetError(gunaCombo, "Debe seleccionar una opción.");
                        datosValidos = false;
                    }
                }
                else if (control is Guna.UI2.WinForms.Guna2NumericUpDown gunaNumeric)
                {
                    if (gunaNumeric.Value <= 0)
                    {
                        errorIcono.SetError(gunaNumeric, "Ingrese una cantidad válida.");
                        datosValidos = false;
                    }
                }
                else if (control is Guna.UI2.WinForms.Guna2DateTimePicker gunaDate)
                {
                    if (gunaDate.Value == DateTime.MinValue)
                    {
                        errorIcono.SetError(gunaDate, "Seleccione una fecha válida.");
                        datosValidos = false;
                    }
                }
            }
        }


        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 3 CRUD PANAEL CATEGORIA Y AUTOR 
        private void iconNuevaCategoria_Click(object sender, EventArgs e)
        {
            // 🔹 Mostrar panel de categoría y ocultar el de autor
            pnlNuevaCategoria.Visible = true;
            pnlNuevoAutor.Visible = false;

            // 🔹 Redimensionar el formulario a la vista expandida
            this.Size = new Size(714, 556);
            pnlNuevaCategoria.Size = new Size(228, 362); // Ajuste visual dentro del formulario

            // 🔹 Limpiar campos
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();

            // 🔹 Si hay algo seleccionado en el combo, precargarlo
            if (cboCategoria.SelectedValue != null && cboCategoria.SelectedIndex >= 0)
            {
                txtIdCategoria.Text = cboCategoria.SelectedValue.ToString(); // ID actual
                txtNombreCategoria.Text = cboCategoria.Text;                 // Nombre actual
            }

            txtNombreCategoria.Focus();
        }
        private void iconNuevoActor_Click(object sender, EventArgs e)
        {
            // 🔹 Mostrar panel de autor y ocultar el de categoría
            pnlNuevoAutor.Visible = true;
            pnlNuevaCategoria.Visible = false;

            // 🔹 Redimensionar formulario
            this.Size = new Size(714,556);
            pnlNuevoAutor.Size = new Size(228, 362);

            // 🔹 Limpiar campos
            txtIdAutor.Clear();
            txtNombreAutor.Clear();

            // Si había algo seleccionado en el combo, precargarlo
            if (cboAutor.SelectedValue != null && cboAutor.SelectedIndex >= 0)
            {
                txtIdAutor.Text = cboAutor.SelectedValue.ToString(); // ID actual
                txtNombreAutor.Text = cboAutor.Text;

                string[] partes = cboAutor.Text.Split(' ');
                txtNombreAutor.Text = partes[0];
                if (partes.Length > 1)
                    txtApellidoAutor.Text = partes[1];
            }

            txtNombreAutor.Focus();
        }
        private void iconCancelarCategoria_Click(object sender, EventArgs e)
        {
            pnlNuevaCategoria.Visible = false;
            this.Size = new Size(442, 556); // 🔹 Volvemos al tamaño normal
        }
        private void iconCancelarAutor_Click(object sender, EventArgs e)
        {
            pnlNuevoAutor.Visible = false;
            this.Size = new Size(442, 556); // 🔹 Volvemos al tamaño normal
        }
        private void iconGuardarCategoria_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Ingrese un nombre de categoría válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCategoria.Focus();
                return;
            }

            try
            {
                string connectionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string sql;
                    SqlCommand command;

                    bool esNuevo = string.IsNullOrEmpty(txtIdCategoria.Text);
                    if (esNuevo)
                    {
                        sql = @"INSERT INTO TblCategoria (nombre)
                        OUTPUT INSERTED.idCategoria
                        VALUES (@nombre)";
                        command = new SqlCommand(sql, conexion);
                    }
                    else
                    {
                        sql = @"UPDATE TblCategoria
                        SET nombre = @nombre
                        WHERE idCategoria = @idCategoria";
                        command = new SqlCommand(sql, conexion);
                        command.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(txtIdCategoria.Text));
                    }

                    command.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text.Trim());

                    if (esNuevo)
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int nuevoId = Convert.ToInt32(result);
                            MessageBox.Show("Categoría agregada con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 🔹 Recargar ComboBox y seleccionar la nueva categoría
                            bloqueaEventos = true;
                            CargarCategorias();
                            cboCategoria.SelectedValue = nuevoId;
                            bloqueaEventos = false;
                        }
                    }
                    else
                    {
                        int filas = command.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Categoría actualizada con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron cambios en la categoría.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // 🔹 Recargar ComboBox y mantener la categoría seleccionada
                        bloqueaEventos = true;
                        CargarCategorias();
                        cboCategoria.SelectedValue = Convert.ToInt32(txtIdCategoria.Text);
                        bloqueaEventos = false;
                    }

                    // 🔹 Redireccionar al panel principal
                    RedireccionarCategoria();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Ya existe una categoría con el mismo nombre.", "Duplicado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //LimpiarControlesCategoria();

        }

        private bool bloqueaEventos = false;
        private void iconGuardarAutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text) || string.IsNullOrWhiteSpace(txtApellidoAutor.Text))
            {
                MessageBox.Show("Complete todos los campos del autor.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreAutor.Focus(); 
                return;
            }

            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    conexion.Open();
                    string sql;
                    SqlCommand command;

                    bool esNuevo = string.IsNullOrEmpty(txtIdAutor.Text);
                    if (esNuevo)
                    {
                        sql = @"INSERT INTO TblAutor (nombre, apellido)
                        OUTPUT INSERTED.idAutor
                        VALUES (@nombre, @apellido)";
                        command = new SqlCommand(sql, conexion);
                    }
                    else
                    {
                        sql = @"UPDATE TblAutor 
                        SET nombre = @nombre, apellido = @apellido
                        WHERE idAutor = @idAutor";
                        command = new SqlCommand(sql, conexion);
                        command.Parameters.AddWithValue("@idAutor", Convert.ToInt32(txtIdAutor.Text));
                    }

                    command.Parameters.AddWithValue("@nombre", txtNombreAutor.Text.Trim());
                    command.Parameters.AddWithValue("@apellido", txtApellidoAutor.Text.Trim());

                    if (esNuevo)
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int nuevoId = Convert.ToInt32(result);
                            MessageBox.Show("Autor agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 🔹 Recargar ComboBox y seleccionar el nuevo autor
                            bloqueaEventos = true;
                            CargarAutores();
                            cboAutor.SelectedValue = nuevoId;
                            bloqueaEventos = false;
                        }
                    }
                    else
                    {
                        int filas = command.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Autor actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // 🔹 Recargar ComboBox y mantener el autor seleccionado
                        bloqueaEventos = true;
                        CargarAutores();
                        cboAutor.SelectedValue = Convert.ToInt32(txtIdAutor.Text);
                        bloqueaEventos = false;
                    }

                    // 🔹 Redireccionar al panel principal
                    RedireccionarAutor();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Ya existe un autor con el mismo nombre y apellido.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //LimpiarControlesAutor();
        }
        private void RedireccionarAutor()
        {
            pnlNuevoAutor.Visible = false;
            this.Size = new Size(442, 556);
        }
        private void RedireccionarCategoria()
        {
            pnlNuevaCategoria.Visible = false;
            this.Size = new Size(442, 556);
        }
        private void iconEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una categoría seleccionada
                if (string.IsNullOrEmpty(txtIdCategoria.Text))
                {
                    MessageBox.Show("Seleccione o cree una categoría antes de eliminar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación
                if (MessageBox.Show("¿Está seguro de eliminar esta categoría?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Eliminar registro
                string conexionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    string query = "DELETE FROM TblCategoria WHERE idCategoria = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtIdCategoria.Text);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Categoría eliminada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar combo y limpiar campos
                        CargarCategorias();
                        cboCategoria.SelectedIndex = -1;
                        txtIdCategoria.Clear();
                        txtNombreCategoria.Clear();

                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la categoría para eliminar.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LimpiarControlesCategoria();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar la categoría porque está relacionada con uno o más libros.",
                        "Restricción de integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Volver al tamaño normal del formulario
            RedireccionarCategoria();
        }
        private void iconEliminarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdAutor.Text))
                {
                    MessageBox.Show("Seleccione o cree un autor antes de eliminar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este autor?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string conexionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    string query = "DELETE FROM TblAutor WHERE idAutor = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtIdAutor.Text);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Autor eliminado correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar combo y limpiar campos
                        CargarAutores();
                        cboAutor.SelectedIndex = -1;
                        txtIdAutor.Clear();
                        txtNombreAutor.Clear();

                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el autor para eliminar.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //LimpiarControlesAutor();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar el autor porque está relacionado con uno o más libros.",
                        "Restricción de integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el autor: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RedireccionarAutor();
        }
        private void LimpiarControlesCategoria()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            cboCategoria.SelectedIndex = -1;
            txtNombreCategoria.Focus();
        }
        private void LimpiarControlesAutor()
        {
            txtIdAutor.Clear();
            txtNombreAutor.Clear();
            txtApellidoAutor.Clear();
            cboAutor.SelectedIndex = -1;
            txtNombreAutor.Focus();
        }
        #endregion

       
    }
}
