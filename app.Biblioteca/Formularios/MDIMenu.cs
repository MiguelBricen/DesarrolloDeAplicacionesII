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
                    if (formularioActivo != null)
                    {
                        formularioActivo.Close();
                        formularioActivo.Dispose();
                    }

                    formularioActivo = formularioHijo;

                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;

                    panelContendor.Controls.Clear();
                    panelContendor.Controls.Add(formularioHijo);
                    panelContendor.Tag = formularioHijo;

                    formularioHijo.Show();
                    formularioHijo.BringToFront();
                }
                else
                {
                    formularioHijo.TopLevel = true;
                    formularioHijo.FormBorderStyle = FormBorderStyle.Sizable;

                    formularioHijo.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha generado un error inesperado al cargar el formulario.",
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
