namespace app._Nombre_.Formularios
{
    partial class MDIMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.toolMenuSuperior = new System.Windows.Forms.ToolStrip();
            this.toolUsuari = new FontAwesome.Sharp.IconDropDownButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCerrarSesion = new FontAwesome.Sharp.IconToolStripButton();
            this.panelContendor = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.toolMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(71)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1262, 100);
            this.panelSuperior.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(71)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(366, 45);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "[Nombre del proyecto]";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(71)))));
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 573);
            this.panelSidebar.TabIndex = 5;
            // 
            // toolMenuSuperior
            // 
            this.toolMenuSuperior.BackColor = System.Drawing.Color.White;
            this.toolMenuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuari,
            this.toolStripSeparator3,
            this.toolStripSeparator8,
            this.toolCerrarSesion});
            this.toolMenuSuperior.Location = new System.Drawing.Point(200, 100);
            this.toolMenuSuperior.Name = "toolMenuSuperior";
            this.toolMenuSuperior.Size = new System.Drawing.Size(1062, 38);
            this.toolMenuSuperior.TabIndex = 7;
            this.toolMenuSuperior.Text = "toolStrip1";
            // 
            // toolUsuari
            // 
            this.toolUsuari.AutoSize = false;
            this.toolUsuari.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.toolStripUsuario});
            this.toolUsuari.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.toolUsuari.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolUsuari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toolUsuari.IconSize = 30;
            this.toolUsuari.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolUsuari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUsuari.Name = "toolUsuari";
            this.toolUsuari.Size = new System.Drawing.Size(130, 35);
            this.toolUsuari.Text = "Usuario";
            this.toolUsuari.Click += new System.EventHandler(this.toolUsuari_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripUsuario
            // 
            this.toolStripUsuario.Name = "toolStripUsuario";
            this.toolStripUsuario.Size = new System.Drawing.Size(224, 26);
            this.toolStripUsuario.Text = "Listado de Usuarios";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // toolCerrarSesion
            // 
            this.toolCerrarSesion.AutoSize = false;
            this.toolCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.toolCerrarSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toolCerrarSesion.IconSize = 30;
            this.toolCerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrarSesion.Name = "toolCerrarSesion";
            this.toolCerrarSesion.Size = new System.Drawing.Size(170, 35);
            this.toolCerrarSesion.Text = "Cerrar sesión";
            this.toolCerrarSesion.Click += new System.EventHandler(this.toolCerrarSesion_Click);
            // 
            // panelContendor
            // 
            this.panelContendor.BackColor = System.Drawing.Color.White;
            this.panelContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContendor.Location = new System.Drawing.Point(200, 138);
            this.panelContendor.Name = "panelContendor";
            this.panelContendor.Size = new System.Drawing.Size(1062, 535);
            this.panelContendor.TabIndex = 9;
            // 
            // MDIMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelContendor);
            this.Controls.Add(this.toolMenuSuperior);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.Name = "MDIMenu";
            this.Text = "MDIMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.toolMenuSuperior.ResumeLayout(false);
            this.toolMenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.ToolStrip toolMenuSuperior;
        private FontAwesome.Sharp.IconDropDownButton toolUsuari;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private FontAwesome.Sharp.IconToolStripButton toolCerrarSesion;
        private System.Windows.Forms.Panel panelContendor;
    }
}



