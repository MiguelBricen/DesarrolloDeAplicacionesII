using app.Biblioteca.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }
        #region 1 METODOS
        private void ListarRegistro()
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"SELECT 
                                    P.idPrestamo,
                                    U.nombre + ' ' + U.apellido AS Usuario,
                                    L.titulo AS Libro,
                                    P.cantidad,
                                    P.fechaPrestamo,
                                    P.fechaDevolucion,
                                    P.estado
                                FROM TblPrestamo P
                                INNER JOIN TblUsuario U ON P.idUsuario = U.idUsuario
                                INNER JOIN TblLibro L ON P.idLibro = L.idLibro";

                    //Datossensibles como la clave del usuario no los pasamos 

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;
                    dgvListado.Columns[0].Visible = false;

                    dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvListado.Columns["Usuario"].HeaderText = "USUARIO";
                    dgvListado.Columns["Libro"].HeaderText = "LIBRO";
                    dgvListado.Columns["cantidad"].HeaderText = "CANTIDAD";
                    dgvListado.Columns["fechaPrestamo"].HeaderText = "FECHA PRÉSTAMO";
                    dgvListado.Columns["fechaDevolucion"].HeaderText = "FECHA DEVOLUCIÓN";
                    dgvListado.Columns["estado"].HeaderText = "ESTADO";



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       



        #endregion

        #region BOTONES DE COMANDO
        private void iconAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarPrestamo frm = new FrmAgregarPrestamo();
            frm.registroAgregado += ListarRegistro;
            MostrarModal.MostrarConCapa(this, frm);
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListado.CurrentCell != null)
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvListado.CurrentRow.Cells["idPrestamo"].Value.ToString(), out int idPrestamo);
                        string connetionString = conexionDB.ObtenerConexion();

                        using (SqlConnection conexion = new SqlConnection(connetionString))
                        {
                            string consulta = "DELETE FROM TblPrestamo WHERE idPrestamo = @idPrestamo";


                            SqlCommand command = new SqlCommand(consulta, conexion);
                            command.Parameters.AddWithValue("@idPrestamo", idPrestamo);


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

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 3 EVENTOS DEL FORMULARIO
        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            ListarRegistro();
        }
        #endregion

        #region 4 EVENTO DEL DATAGRIDVIEW

        #endregion

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvListado.Rows[e.RowIndex];

                    int idPrestamo = Convert.ToInt32(fila.Cells["idPrestamo"].Value);
                    string usuario = fila.Cells["Usuario"].Value.ToString();
                    string libro = fila.Cells["Libro"].Value.ToString();
                    int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                    DateTime fechaPrestamo = Convert.ToDateTime(fila.Cells["fechaPrestamo"].Value);
                    DateTime fechaDevolucion = Convert.ToDateTime(fila.Cells["fechaDevolucion"].Value);
                    string estado = fila.Cells["estado"].Value.ToString();

                    FrmAgregarPrestamo frm = new FrmAgregarPrestamo(
                        idPrestamo, usuario, libro, cantidad, fechaPrestamo, fechaDevolucion, estado);
                    frm.registroAgregado += ListarRegistro;
                    MostrarModal.MostrarConCapa(this, frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el préstamo: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string texto = txtBuscar.Text.Trim();

                    string consultaSQL = $@"
                SELECT 
                    P.idPrestamo,
                    U.nombre + ' ' + U.apellido AS Usuario,
                    L.titulo AS Libro,
                    P.cantidad,
                    P.fechaPrestamo,
                    P.fechaDevolucion,
                    P.estado
                FROM TblPrestamo P
                INNER JOIN TblUsuario U ON P.idUsuario = U.idUsuario
                INNER JOIN TblLibro L ON P.idLibro = L.idLibro
                WHERE 
                    CAST(P.idPrestamo AS NVARCHAR) LIKE '%{texto}%' OR
                    U.nombre LIKE '%{texto}%' OR
                    U.apellido LIKE '%{texto}%' OR
                    L.titulo LIKE '%{texto}%' OR
                    CONVERT(VARCHAR, P.fechaPrestamo, 103) LIKE '%{texto}%' OR
                    CONVERT(VARCHAR, P.fechaDevolucion, 103) LIKE '%{texto}%' OR
                    P.estado LIKE '%{texto}%';";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvListado.DataSource = dt;
                        dgvListado.Columns[0].Visible=false;
                    }
                    else
                    {
                        dgvListado.DataSource = null;
                        MessageBox.Show("No se encontraron registros con ese criterio.",
                                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
