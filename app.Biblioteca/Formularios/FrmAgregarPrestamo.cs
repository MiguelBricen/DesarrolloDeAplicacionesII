using app.Biblioteca.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmAgregarPrestamo : Form
    {
        public event Action registroAgregado;
        private int idPrestamo = 0; // 0 = nuevo, >0 = edición

        #region 0 INICIALIZACIÓN (CONSTRUCTOR Y EVENTO)
        public FrmAgregarPrestamo()
        {
            InitializeComponent();
            InicializarFormulario();


        }

        public FrmAgregarPrestamo(int idPrestamo, string usuario, string libro, int cantidad, DateTime fechaPrestamo, DateTime fechaDevolucion, string estado)
        {
            InitializeComponent();
            InicializarFormulario(); // ✅ misma lógica para ambos constructores
            this.idPrestamo = idPrestamo;
           
            // Asigna el texto de los combos de forma segura
            if (!string.IsNullOrEmpty(usuario))
            {
                DataRowView usuarioEncontrado = cboUsuario.Items.Cast<DataRowView>()
                    .FirstOrDefault(row => row["Usuario"].ToString() == usuario);
                if (usuarioEncontrado != null)
                    cboUsuario.SelectedValue = usuarioEncontrado["idUsuario"];
            }

            if (!string.IsNullOrEmpty(libro))
            {
                DataRowView libroEncontrado = cboLibro.Items.Cast<DataRowView>()
                    .FirstOrDefault(row => row["titulo"].ToString() == libro);
                if (libroEncontrado != null)
                    cboLibro.SelectedValue = libroEncontrado["idLibro"];
            }
            numCantidad.Value = cantidad;
            dtpFechaPrestamo.Value = fechaPrestamo;
            dtpFechaDevolucion.Value = fechaDevolucion;
        }
        #endregion

        #region 1 MÉTODOS PRINCIPALES

        private void InicializarFormulario()
        {
            CargarCombos();
            cboUsuario.SelectedIndex = -1; // sin selección por defecto
            cboLibro.SelectedIndex = -1;
            numCantidad.Value = 0;
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now.AddDays(7);
        }

        private void GuardarPrestamo()
        {
            if (!ValidarCampos()) return;

            // 🔒 Evita doble clic (muy importante)
            iconGuardar.Enabled = false;

            int idUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            int idLibro = Convert.ToInt32(cboLibro.SelectedValue);
            int cantidad = (int)numCantidad.Value;
            DateTime fechaPrestamo = dtpFechaPrestamo.Value.Date;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value.Date;
            string estado = VerificarEstado();

            string conexionString = conexionDB.ObtenerConexion();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    if (idPrestamo == 0)
                    {
                        // ➕ NUEVO PRÉSTAMO
                        SqlCommand cmdInsert = new SqlCommand(@"
                    INSERT INTO TblPrestamo (idUsuario, idLibro, cantidad, fechaPrestamo, fechaDevolucion, estado)
                    VALUES (@idUsuario, @idLibro, @cantidad, @fechaPrestamo, @fechaDevolucion, @estado)", conexion, trans);

                        cmdInsert.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmdInsert.Parameters.AddWithValue("@idLibro", idLibro);
                        cmdInsert.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdInsert.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                        cmdInsert.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                        cmdInsert.Parameters.AddWithValue("@estado", estado);
                        cmdInsert.ExecuteNonQuery();

                        // 🔻 Descontar stock SOLO una vez
                        SqlCommand cmdStock = new SqlCommand(
                            "UPDATE TblLibro SET cantidad = cantidad - @cantidad WHERE idLibro = @idLibro", conexion, trans);
                        cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdStock.Parameters.AddWithValue("@idLibro", idLibro);
                        cmdStock.ExecuteNonQuery();
                    }
                    else
                    {
                        // ✏️ ACTUALIZAR PRÉSTAMO EXISTENTE
                        int cantidadAnterior = 0;
                        int idLibroAnterior = 0;

                        SqlCommand cmdPrev = new SqlCommand(
                            "SELECT idLibro, cantidad FROM TblPrestamo WHERE idPrestamo = @idPrestamo", conexion, trans);
                        cmdPrev.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                        using (SqlDataReader r = cmdPrev.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                idLibroAnterior = r.GetInt32(0);
                                cantidadAnterior = r.GetInt32(1);
                            }
                        }

                        // Revertir solo si cambió el libro o la cantidad
                        if (idLibroAnterior != idLibro || cantidadAnterior != cantidad)
                        {
                            // Revertir stock anterior
                            SqlCommand cmdRevert = new SqlCommand(
                                "UPDATE TblLibro SET cantidad = cantidad + @cantidad WHERE idLibro = @idLibro", conexion, trans);
                            cmdRevert.Parameters.AddWithValue("@cantidad", cantidadAnterior);
                            cmdRevert.Parameters.AddWithValue("@idLibro", idLibroAnterior);
                            cmdRevert.ExecuteNonQuery();

                            // Descontar nueva cantidad
                            SqlCommand cmdRestar = new SqlCommand(
                                "UPDATE TblLibro SET cantidad = cantidad - @cantidad WHERE idLibro = @idLibro", conexion, trans);
                            cmdRestar.Parameters.AddWithValue("@cantidad", cantidad);
                            cmdRestar.Parameters.AddWithValue("@idLibro", idLibro);
                            cmdRestar.ExecuteNonQuery();
                        }

                        // Actualizar préstamo
                        SqlCommand cmdUpdate = new SqlCommand(@"
                    UPDATE TblPrestamo
                    SET idUsuario = @idUsuario,
                        idLibro = @idLibro,
                        cantidad = @cantidad,
                        fechaPrestamo = @fechaPrestamo,
                        fechaDevolucion = @fechaDevolucion,
                        estado = @estado
                    WHERE idPrestamo = @idPrestamo", conexion, trans);

                        cmdUpdate.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                        cmdUpdate.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmdUpdate.Parameters.AddWithValue("@idLibro", idLibro);
                        cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdUpdate.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                        cmdUpdate.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                        cmdUpdate.Parameters.AddWithValue("@estado", estado);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    trans.Commit();

                    MessageBox.Show(
                        idPrestamo == 0 ? "Préstamo registrado correctamente." : "Préstamo actualizado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    registroAgregado?.Invoke();
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al guardar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Rehabilitar el botón al terminar
                    iconGuardar.Enabled = true;
                }
            }
        }

        private void CargarCombos()
        {
            string conexionString = conexionDB.ObtenerConexion();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                // Usuarios
                SqlCommand cmdUsuarios = new SqlCommand("SELECT idUsuario, nombre + ' ' + apellido AS Usuario FROM TblUsuario", conexion);
                DataTable dtUsuarios = new DataTable();
                dtUsuarios.Load(cmdUsuarios.ExecuteReader());
                cboUsuario.DataSource = dtUsuarios;
                cboUsuario.DisplayMember = "Usuario";
                cboUsuario.ValueMember = "idUsuario";
               
                // Libros
                SqlCommand cmdLibros = new SqlCommand("SELECT idLibro, titulo FROM TblLibro WHERE cantidad > 0", conexion);
                DataTable dtLibros = new DataTable();
                dtLibros.Load(cmdLibros.ExecuteReader());
                cboLibro.DataSource = dtLibros;
                cboLibro.DisplayMember = "titulo";
                cboLibro.ValueMember = "idLibro";
                
            }
        }

        private string VerificarEstado()
        {
            return dtpFechaDevolucion.Value.Date < DateTime.Now.Date ? "Devuelto" : "Pendiente";
        }

        private bool ValidarCampos()
        {
            if (cboUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaDevolucion.Value <= dtpFechaPrestamo.Value)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de préstamo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Validar que haya suficientes libros disponibles
            if (cboLibro.SelectedIndex != -1)
            {
                int idLibroSeleccionado = Convert.ToInt32(cboLibro.SelectedValue);

                string conexionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT cantidad FROM TblLibro WHERE idLibro = @idLibro", conexion))
                    {
                        cmd.Parameters.AddWithValue("@idLibro", idLibroSeleccionado);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int cantidadDisponible = Convert.ToInt32(result);

                            if (numCantidad.Value > cantidadDisponible)
                            {
                                MessageBox.Show($"Libros insuficientes para su préstamo.\nCantidad disponible: {cantidadDisponible}",
                                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        private void DevolverPrestamo()
        {
            int id = idPrestamo; // Usamos el campo interno directamente

            if (id == 0)
            {
                MessageBox.Show("Seleccione el préstamo que desea devolver.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexionString = conexionDB.ObtenerConexion();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlTransaction trx = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1) Obtener la cantidad y el idLibro del préstamo
                        int cantidadPrestada = 1;
                        int idLibro = 0;
                        using (SqlCommand cmd = new SqlCommand("SELECT idLibro, cantidad, estado FROM TblPrestamo WHERE idPrestamo = @idPrestamo", conexion, trx))
                        {
                            cmd.Parameters.AddWithValue("@idPrestamo", id);
                            using (SqlDataReader r = cmd.ExecuteReader())
                            {
                                if (r.Read())
                                {
                                    idLibro = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                                    cantidadPrestada = r.IsDBNull(1) ? 1 : r.GetInt32(1);
                                    string estadoActual = r.IsDBNull(2) ? "Pendiente" : r.GetString(2);

                                    if (string.Equals(estadoActual, "Devuelto", StringComparison.OrdinalIgnoreCase))
                                    {
                                        // Ya devuelto
                                        MessageBox.Show("Este préstamo ya está marcado como devuelto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        r.Close();
                                        trx.Rollback();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    trx.Rollback();
                                    return;
                                }
                            }
                        }

                        // 2) Actualizar TblPrestamo -> estado = 'Devuelto'
                        using (SqlCommand cmdUpd = new SqlCommand("UPDATE TblPrestamo SET estado = 'Devuelto' WHERE idPrestamo = @idPrestamo", conexion, trx))
                        {
                            cmdUpd.Parameters.AddWithValue("@idPrestamo", id);
                            cmdUpd.ExecuteNonQuery();
                        }

                        // 3) Sumar la cantidad devuelta al stock del libro
                        using (SqlCommand cmdStock = new SqlCommand("UPDATE TblLibro SET cantidad = cantidad + @cantidad WHERE idLibro = @idLibro", conexion, trx))
                        {
                            cmdStock.Parameters.AddWithValue("@cantidad", cantidadPrestada);
                            cmdStock.Parameters.AddWithValue("@idLibro", idLibro);
                            int filas = cmdStock.ExecuteNonQuery();
                            if (filas == 0)
                                throw new Exception("No se pudo actualizar el stock del libro (libro no encontrado).");
                        }

                        trx.Commit();
                        MessageBox.Show("Préstamo marcado como 'Devuelto' y stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Notificar y cerrar/recargar
                        registroAgregado?.Invoke();
                        this.Close(); // o refrescar controles si prefieres quedarte en el formulario
                    }
                    catch (Exception ex)
                    {
                        try { trx.Rollback(); } catch { }
                        MessageBox.Show("Error al devolver el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        #endregion



        private void iconGuardar_Click(object sender, EventArgs e)
        {
            GuardarPrestamo();
        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        private void iconDevolver_Click(object sender, EventArgs e)
        {
            // Confirmación
            if (MessageBox.Show("¿Confirmar devolución del préstamo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DevolverPrestamo();
            }

        }

      
    }
}
