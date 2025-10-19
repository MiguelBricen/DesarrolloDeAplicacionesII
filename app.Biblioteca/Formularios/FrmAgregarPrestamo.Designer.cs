namespace app.Biblioteca.Formularios
{
    partial class FrmAgregarPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIdPrestamo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLibro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconDevolver = new FontAwesome.Sharp.IconButton();
            this.iconGuardar = new FontAwesome.Sharp.IconButton();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtIdPrestamo, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboLibro, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numCantidad, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaPrestamo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaDevolucion, 0, 9);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.124087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.759124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 419);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtIdPrestamo.BorderColor = System.Drawing.Color.Transparent;
            this.txtIdPrestamo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPrestamo.DefaultText = "";
            this.txtIdPrestamo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPrestamo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPrestamo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPrestamo.DisabledState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPrestamo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.txtIdPrestamo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPrestamo.FocusedState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPrestamo.HoverState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.Location = new System.Drawing.Point(5, 386);
            this.txtIdPrestamo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.PasswordChar = '\0';
            this.txtIdPrestamo.PlaceholderText = "";
            this.txtIdPrestamo.SelectedText = "";
            this.txtIdPrestamo.ShadowDecoration.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.Size = new System.Drawing.Size(377, 27);
            this.txtIdPrestamo.TabIndex = 14;
            this.txtIdPrestamo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(3, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha devolución";
            // 
            // cboLibro
            // 
            this.cboLibro.BackColor = System.Drawing.Color.Transparent;
            this.cboLibro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibro.FocusedColor = System.Drawing.Color.Empty;
            this.cboLibro.FocusedState.Parent = this.cboLibro;
            this.cboLibro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLibro.FormattingEnabled = true;
            this.cboLibro.HoverState.Parent = this.cboLibro;
            this.cboLibro.ItemHeight = 30;
            this.cboLibro.ItemsAppearance.Parent = this.cboLibro;
            this.cboLibro.Location = new System.Drawing.Point(3, 117);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.ShadowDecoration.Parent = this.cboLibro;
            this.cboLibro.Size = new System.Drawing.Size(379, 36);
            this.cboLibro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha préstamo";
            // 
            // cboUsuario
            // 
            this.cboUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cboUsuario.FocusedState.Parent = this.cboUsuario;
            this.cboUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.HoverState.Parent = this.cboUsuario;
            this.cboUsuario.ItemHeight = 30;
            this.cboUsuario.ItemsAppearance.Parent = this.cboUsuario;
            this.cboUsuario.Location = new System.Drawing.Point(3, 41);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.ShadowDecoration.Parent = this.cboUsuario;
            this.cboUsuario.Size = new System.Drawing.Size(379, 36);
            this.cboUsuario.TabIndex = 1;
            // 
            // numCantidad
            // 
            this.numCantidad.BackColor = System.Drawing.Color.White;
            this.numCantidad.Location = new System.Drawing.Point(3, 193);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 31);
            this.numCantidad.TabIndex = 3;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(3, 269);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(379, 31);
            this.dtpFechaPrestamo.TabIndex = 4;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(3, 345);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(379, 31);
            this.dtpFechaDevolucion.TabIndex = 5;
            this.dtpFechaDevolucion.ValueChanged += new System.EventHandler(this.dtpFechaDevolucion_ValueChanged);
            // 
            // iconDevolver
            // 
            this.iconDevolver.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDevolver.FlatAppearance.BorderSize = 0;
            this.iconDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDevolver.ForeColor = System.Drawing.Color.White;
            this.iconDevolver.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconDevolver.IconColor = System.Drawing.Color.White;
            this.iconDevolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDevolver.IconSize = 30;
            this.iconDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDevolver.Location = new System.Drawing.Point(265, 3);
            this.iconDevolver.Name = "iconDevolver";
            this.iconDevolver.Padding = new System.Windows.Forms.Padding(5);
            this.iconDevolver.Size = new System.Drawing.Size(138, 46);
            this.iconDevolver.TabIndex = 8;
            this.iconDevolver.Text = "Devolver";
            this.iconDevolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconDevolver, "Cerrar ventana");
            this.iconDevolver.UseVisualStyleBackColor = false;
            this.iconDevolver.Click += new System.EventHandler(this.iconDevolver_Click);
            // 
            // iconGuardar
            // 
            this.iconGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(106)))));
            this.iconGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGuardar.FlatAppearance.BorderSize = 0;
            this.iconGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGuardar.ForeColor = System.Drawing.Color.White;
            this.iconGuardar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconGuardar.IconColor = System.Drawing.Color.White;
            this.iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardar.IconSize = 30;
            this.iconGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGuardar.Location = new System.Drawing.Point(3, 3);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Padding = new System.Windows.Forms.Padding(5);
            this.iconGuardar.Size = new System.Drawing.Size(126, 46);
            this.iconGuardar.TabIndex = 6;
            this.iconGuardar.Text = "Guardar";
            this.iconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconGuardar, "Guardar registro");
            this.iconGuardar.UseVisualStyleBackColor = false;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(87)))), ((int)(((byte)(21)))));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.FlatAppearance.BorderSize = 0;
            this.iconCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCerrar.ForeColor = System.Drawing.Color.White;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconCerrar.IconColor = System.Drawing.Color.White;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 30;
            this.iconCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCerrar.Location = new System.Drawing.Point(135, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Padding = new System.Windows.Forms.Padding(5);
            this.iconCerrar.Size = new System.Drawing.Size(124, 46);
            this.iconCerrar.TabIndex = 7;
            this.iconCerrar.Text = "Cerrar";
            this.iconCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconCerrar, "Cerrar ventana");
            this.iconCerrar.UseVisualStyleBackColor = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.38168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.61832F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel3.Controls.Add(this.iconDevolver, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconCerrar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 481);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(406, 52);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(111)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registro de Prestamo";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(111)))), ((int)(((byte)(53)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::app.Biblioteca.Properties.Resources.Préstamo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(454, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPrestamo";
            this.Load += new System.EventHandler(this.FrmAgregarPrestamo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private FontAwesome.Sharp.IconButton iconCerrar;
        private Guna.UI2.WinForms.Guna2ComboBox cboLibro;
        private Guna.UI2.WinForms.Guna2ComboBox cboUsuario;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private FontAwesome.Sharp.IconButton iconDevolver;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPrestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}