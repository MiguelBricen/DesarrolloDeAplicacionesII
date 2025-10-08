using app.Biblioteca.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
          
            InitializeComponent();
        }
        #region 0 METODOS
        private void ListarRegistro()
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"SELECT L.idLibro, L.titulo, 
                                   L.idAutor, A.nombre AS AutorNombre, 
                                   L.idCategoria, C.nombre AS CategoriaNombre, 
                                                                   L.anioPublicacion
                                 FROM TblLibro L
                                 INNER JOIN TblAutor A ON L.idAutor = A.idAutor
                                 INNER JOIN TblCategoria C ON L.idCategoria = C.idCategoria;";

                    //Datossensibles como la clave del usuario no los pasamos 

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvLibro.DataSource = dt;
                    // dgvListado.Columns[0].Visible = false;
                    FormatoGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string texto = txtBuscar.Text.Trim();
                    string consultaSQL = $@"
                                        SELECT L.idLibro, L.titulo,
                                               L.idAutor, A.nombre AS AutorNombre,
                                               L.idCategoria, C.nombre AS CategoriaNombre,
                                               L.anioPublicacion
                                        FROM TblLibro L
                                        INNER JOIN TblAutor A ON L.idAutor = A.idAutor
                                        INNER JOIN TblCategoria C ON L.idCategoria = C.idCategoria
                                        WHERE L.titulo LIKE '%{texto}%'
                                           OR A.nombre LIKE '%{texto}%'
                                           OR C.nombre LIKE '%{texto}%'
                                           OR CAST(L.anioPublicacion AS NVARCHAR) LIKE '%{texto}%'
                                                                                                   ";


                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvLibro.DataSource = dt;
                        FormatoGridView();



                    }
                    else
                    {
                        dgvLibro.DataSource = null;
                        MessageBox.Show("No se encontraron registros con ese criterio.",
                                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
        private void FormatoGridView()
        {
            // 🔹 Ocultar columnas de ID
            dgvLibro.Columns["idLibro"].Visible = false;
            dgvLibro.Columns["idAutor"].Visible = false;
            dgvLibro.Columns["idCategoria"].Visible = false;

            // 🔹 Ajustar columnas visibles
            dgvLibro.Columns["titulo"].HeaderText = "TÍTULO";
            dgvLibro.Columns["AutorNombre"].HeaderText = "AUTOR";
            dgvLibro.Columns["CategoriaNombre"].HeaderText = "CATEGORÍA";
            dgvLibro.Columns["anioPublicacion"].HeaderText = "AÑO DE PUBLICACIÓN";
        }
        #endregion

        #region 1 BOTONES DE COMANDO
        private void iconAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarLibro frm = new FrmAgregarLibro();
            frm.registroAgregado += ListarRegistro;
            MostrarModal.MostrarConCapa(this, frm);
        }
        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.CurrentCell != null)
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvLibro.CurrentRow.Cells["IdLibro"].Value.ToString(), out int idLibro);
                        string connetionString = conexionDB.ObtenerConexion();

                        using (SqlConnection conexion = new SqlConnection(connetionString))
                        {
                            string consulta = "DELETE FROM TblLibro WHERE idLibro = @idLibro";


                            SqlCommand command = new SqlCommand(consulta, conexion);
                            command.Parameters.AddWithValue("@idLibro", idLibro);


                            conexion.Open();

                            int resultado = command.ExecuteNonQuery();
                            if (resultado > 0)
                            {
                                MessageBox.Show("Registro Eliminado correctamente", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el registro ", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            ListarRegistro();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al eliminar: " + ex.Message);
                }
            }
        }
        #endregion

        #region  2 EVENTOS DEL FORMULARIO
        private void FrmLibro_Load(object sender, EventArgs e)
        {

            ListarRegistro();
        }
        #endregion

        #region 3 EVENTO DEL DATAGRIDVIEW
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtenemos la fila seleccionada
                    DataGridViewRow fila = dgvLibro.Rows[e.RowIndex];

                    // Extraemos los valores del registro
                    int idLibro = Convert.ToInt32(fila.Cells["idLibro"].Value);
                    string titulo = fila.Cells["titulo"].Value.ToString();
                    int idAutor = Convert.ToInt32(fila.Cells["idAutor"].Value);
                    int idCategoria = Convert.ToInt32(fila.Cells["idCategoria"].Value);
                    int anio = Convert.ToInt32(fila.Cells["anioPublicacion"].Value);
                    DateTime anioPublicacion = new DateTime(anio, 1, 1); // Creamos fecha con solo el año


                    // Abrimos el formulario FrmAgregarLibro en modo edición
                    FrmAgregarLibro frm = new FrmAgregarLibro(idLibro, titulo, idAutor, idCategoria, anioPublicacion);
                    frm.registroAgregado += ListarRegistro; // Actualiza el listado al guardar
                    MostrarModal.MostrarConCapa(this, frm); // Mostrar con fondo oscuro
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del libro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
