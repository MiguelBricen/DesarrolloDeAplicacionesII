using app.Biblioteca.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
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
                    string consulta = @"
                                SELECT
                                    idUsuario AS Id,
                                    nombre AS Nombre,
                                    apellido AS Apellido,
                                    telefono As Teléfono,
                                    email AS Email
                                FROM TblUsuario";

                    //Datossensibles como la clave del usuario no los pasamos 

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;
                    FormatoGridView();
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void FormatoGridView()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns["nombre"].HeaderText = "NOMBRE";
            dgvListado.Columns["apellido"].HeaderText = "APELLIDO";
            dgvListado.Columns["Teléfono"].HeaderText = "TELÉFONO";
            dgvListado.Columns["email"].HeaderText = "EMAIL";
        }

        // Guarda el color original temporalmente
        private Color colorOriginal;
        // Evento MouseDown (cuando el botón se presiona)
        private void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is FontAwesome.Sharp.IconButton boton)
            {
                colorOriginal = boton.BackColor;

                // Efecto presionado - oscurecer color
                boton.BackColor = ControlPaint.Dark(boton.BackColor, 0.2f);
                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = Color.Black;

                // Efecto visual sutil
                boton.Padding = new Padding(boton.Padding.Left, boton.Padding.Top + 1, boton.Padding.Right, boton.Padding.Bottom - 1);

                boton.BackColor = Color.FromArgb(
                    Math.Max(0, boton.BackColor.R - 20),
                    Math.Max(0, boton.BackColor.G - 20),
                    Math.Max(0, boton.BackColor.B - 20)
                );

            }
        }
        // Evento MouseUp (cuando se suelta el botón)
        private void Boton_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is FontAwesome.Sharp.IconButton boton)
            {
                // Restaura color original
                boton.BackColor = colorOriginal;
                boton.FlatAppearance.BorderSize = 0;

                // Restaura padding
                boton.Padding = new Padding(boton.Padding.Left, boton.Padding.Top - 1, boton.Padding.Right, boton.Padding.Bottom + 1);
            }
        }

        #endregion

        #region 2 BOTONES DE COMANDO
        private void iconAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frm = new FrmAgregarUsuario();
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
                        int.TryParse(dgvListado.CurrentRow.Cells["Id"].Value.ToString(), out int idUsuario);
                        string connetionString = conexionDB.ObtenerConexion();

                        using (SqlConnection conexion = new SqlConnection(connetionString))
                        {
                            string consulta = "DELETE FROM TblUsuario WHERE idUsuario = @Id";


                            SqlCommand command = new SqlCommand(consulta, conexion);
                            command.Parameters.AddWithValue("@Id", idUsuario);


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
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarRegistro();

            // Asignar eventos de click dinámicamente
            iconAgregar.MouseDown += Boton_MouseDown;
            iconAgregar.MouseUp += Boton_MouseUp;

            iconEliminar.MouseDown += Boton_MouseDown;
            iconEliminar.MouseUp += Boton_MouseUp;

            iconCerrar.MouseDown += Boton_MouseDown;
            iconCerrar.MouseUp += Boton_MouseUp;
        }
        #endregion

        #region 4 EVENTO DEL DATAGRIDVIEW
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dgvListado.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    string nombre = dgvListado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    string apellido = dgvListado.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    string telefono = dgvListado.Rows[e.RowIndex].Cells["Teléfono"].Value.ToString();
                    string email = dgvListado.Rows[e.RowIndex].Cells["Email"].Value.ToString();


                    FrmAgregarUsuario frm = new FrmAgregarUsuario(id, nombre, apellido, telefono, email);
                    frm.registroAgregado += ListarRegistro;
                    MostrarModal.MostrarConCapa(this, frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connetionString = conexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string texto = txtBuscar.Text.Trim();
                    string consultaSQL = $@"
                                   SELECT 
                                        idUsuario AS Id,
                                        nombre AS Nombre,
                                        apellido AS Apellido,
                                        telefono As Teléfono,
                                        email AS Email
                                   FROM TblUsuario
                                   WHERE nombre LIKE '%{texto}%'
                                   OR apellido LIKE '%{texto}%'
                                   OR telefono LIKE '%{texto}%'
                                   OR email LIKE '%{texto}%'";


                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvListado.DataSource = dt;
                        FormatoGridView();
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
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
