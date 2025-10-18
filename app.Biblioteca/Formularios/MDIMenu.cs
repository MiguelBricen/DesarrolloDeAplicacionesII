using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Biblioteca.Formularios
{
    public partial class MDIMenu : Form
    {

        private Form formularioActivo = null;
        public MDIMenu()
        {
            InitializeComponent();
        }

        #region MÉTODOS MEJORADOS
        //private void AbrirFormulario(Form childForm)
        //{
        //    // Eliminar solo formularios hijos, no otros controles como el PictureBox
        //    foreach (Control ctrl in panelContendor.Controls)
        //    {
        //        if (ctrl is Form frm)
        //            frm.Close();
        //    }


        //    // Configurar formulario hijo
        //    childForm.TopLevel = false;

        //    // Insertar el formulario en el panel
        //    panelContendor.Controls.Add(childForm);
        //    childForm.BringToFront();
        //    childForm.Show();
        //}


        private void AbrirFormulario(Form formularioHijo, bool esHijoDelPanelContenedor = true)
        {
            try
            {
                if (esHijoDelPanelContenedor)
                {
                    // Cerrar y liberar el formulario activo anterior, si existe
                    if (formularioActivo != null)
                    {
                        formularioActivo.Close();
                        formularioActivo.Dispose();
                    }

                    formularioActivo = formularioHijo;

                    // Configuración del formulario hijo
                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;

                    // ✅ Aseguramos que el PictureBox esté dentro del panel y detrás
                    if (!panelContendor.Controls.Contains(picImagen))
                    {
                        panelContendor.Controls.Add(picImagen);
                        picImagen.Dock = DockStyle.Fill;
                        picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    // Siempre enviar el PictureBox al fondo
                    picImagen.SendToBack();

                    // ✅ Agregamos el formulario hijo si no está en el panel
                    if (!panelContendor.Controls.Contains(formularioHijo))
                    {
                        panelContendor.Controls.Add(formularioHijo);
                    }

                    // Traer el formulario al frente y mostrarlo
                    formularioHijo.BringToFront();
                    formularioHijo.Show();

                   
                }
                else
                {
                    formularioHijo.TopLevel = true;
                    formularioHijo.FormBorderStyle = FormBorderStyle.Sizable;
                    formularioHijo.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error inesperado al cargar el formulario:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

       
        #endregion

        #region OPCIONES DEL MENU
        private void toolStripUsuario_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario(new FrmUsuario(), true);
        }

        private void toolStripLibro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibro(), true);
        }

        private void toolCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        private void toolStripPrestamo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamo(), true);
        }
    }

}
