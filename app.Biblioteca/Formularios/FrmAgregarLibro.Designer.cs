namespace app.Biblioteca.Formularios
{
    partial class FrmAgregarLibro
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconGuardar = new FontAwesome.Sharp.IconButton();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboAutor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFechaPublicacion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconNuevaCategoria = new FontAwesome.Sharp.IconButton();
            this.iconNuevoActor = new FontAwesome.Sharp.IconButton();
            this.pnlNuevaCategoria = new System.Windows.Forms.Panel();
            this.txtIdCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconCancelarCategoria = new FontAwesome.Sharp.IconButton();
            this.iconEliminarCategoria = new FontAwesome.Sharp.IconButton();
            this.iconGuardarCategoria = new FontAwesome.Sharp.IconButton();
            this.txtNombreCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlNuevoAutor = new System.Windows.Forms.Panel();
            this.txtIdAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconCancelarAutor = new FontAwesome.Sharp.IconButton();
            this.iconEliminarAutor = new FontAwesome.Sharp.IconButton();
            this.iconGuardarAutor = new FontAwesome.Sharp.IconButton();
            this.txtNombreAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtApellidoAutor = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNuevaCategoria.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNuevoAutor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconGuardar
            // 
            this.iconGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconGuardar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardar.IconSize = 30;
            this.iconGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGuardar.Location = new System.Drawing.Point(108, 3);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Padding = new System.Windows.Forms.Padding(5);
            this.iconGuardar.Size = new System.Drawing.Size(142, 46);
            this.iconGuardar.TabIndex = 0;
            this.iconGuardar.Text = "Guardar";
            this.iconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconGuardar, "Guardar registro");
            this.iconGuardar.UseVisualStyleBackColor = true;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 30;
            this.iconCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCerrar.Location = new System.Drawing.Point(258, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Padding = new System.Windows.Forms.Padding(5);
            this.iconCerrar.Size = new System.Drawing.Size(130, 46);
            this.iconCerrar.TabIndex = 2;
            this.iconCerrar.Text = "Cerrar";
            this.iconCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconCerrar, "Cerrar ventana");
            this.iconCerrar.UseVisualStyleBackColor = true;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cboCategoria, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboAutor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaPublicacion, 0, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 308);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cboCategoria.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboCategoria.BorderRadius = 15;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategoria.FocusedState.Parent = this.cboCategoria;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.HoverState.Parent = this.cboCategoria;
            this.cboCategoria.ItemHeight = 30;
            this.cboCategoria.ItemsAppearance.Parent = this.cboCategoria;
            this.cboCategoria.Location = new System.Drawing.Point(3, 258);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.ShadowDecoration.Parent = this.cboCategoria;
            this.cboCategoria.Size = new System.Drawing.Size(379, 36);
            this.cboCategoria.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de publicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Categoría";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderRadius = 8;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.Parent = this.txtTitulo;
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.FocusedState.Parent = this.txtTitulo;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.HoverState.Parent = this.txtTitulo;
            this.txtTitulo.Location = new System.Drawing.Point(5, 33);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.ShadowDecoration.Parent = this.txtTitulo;
            this.txtTitulo.Size = new System.Drawing.Size(377, 36);
            this.txtTitulo.TabIndex = 4;
            // 
            // cboAutor
            // 
            this.cboAutor.BackColor = System.Drawing.Color.Transparent;
            this.cboAutor.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboAutor.BorderRadius = 15;
            this.cboAutor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FocusedColor = System.Drawing.Color.Empty;
            this.cboAutor.FocusedState.Parent = this.cboAutor;
            this.cboAutor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.HoverState.Parent = this.cboAutor;
            this.cboAutor.ItemHeight = 30;
            this.cboAutor.ItemsAppearance.Parent = this.cboAutor;
            this.cboAutor.Location = new System.Drawing.Point(3, 106);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.ShadowDecoration.Parent = this.cboAutor;
            this.cboAutor.Size = new System.Drawing.Size(379, 36);
            this.cboAutor.TabIndex = 9;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaPublicacion.BorderRadius = 15;
            this.dtpFechaPublicacion.CheckedState.Parent = this.dtpFechaPublicacion;
            this.dtpFechaPublicacion.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaPublicacion.HoverState.Parent = this.dtpFechaPublicacion;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(3, 182);
            this.dtpFechaPublicacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPublicacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.ShadowDecoration.Parent = this.dtpFechaPublicacion;
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(379, 36);
            this.dtpFechaPublicacion.TabIndex = 11;
            this.dtpFechaPublicacion.Value = new System.DateTime(2025, 10, 6, 9, 52, 42, 14);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51546F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.34021F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.iconGuardar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconCerrar, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 383);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(393, 52);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(4, 4);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(91, 44);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 50);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de libros";
            // 
            // iconNuevaCategoria
            // 
            this.iconNuevaCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconNuevaCategoria.IconColor = System.Drawing.Color.Black;
            this.iconNuevaCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNuevaCategoria.Location = new System.Drawing.Point(423, 328);
            this.iconNuevaCategoria.Name = "iconNuevaCategoria";
            this.iconNuevaCategoria.Size = new System.Drawing.Size(35, 35);
            this.iconNuevaCategoria.TabIndex = 8;
            this.iconNuevaCategoria.UseVisualStyleBackColor = true;
            this.iconNuevaCategoria.Click += new System.EventHandler(this.iconNuevaCategoria_Click);
            // 
            // iconNuevoActor
            // 
            this.iconNuevoActor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconNuevoActor.IconColor = System.Drawing.Color.Black;
            this.iconNuevoActor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNuevoActor.Location = new System.Drawing.Point(423, 176);
            this.iconNuevoActor.Name = "iconNuevoActor";
            this.iconNuevoActor.Size = new System.Drawing.Size(35, 35);
            this.iconNuevoActor.TabIndex = 9;
            this.iconNuevoActor.UseVisualStyleBackColor = true;
            this.iconNuevoActor.Click += new System.EventHandler(this.iconNuevoActor_Click);
            // 
            // pnlNuevaCategoria
            // 
            this.pnlNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.pnlNuevaCategoria.Controls.Add(this.txtIdCategoria);
            this.pnlNuevaCategoria.Controls.Add(this.iconCancelarCategoria);
            this.pnlNuevaCategoria.Controls.Add(this.iconEliminarCategoria);
            this.pnlNuevaCategoria.Controls.Add(this.iconGuardarCategoria);
            this.pnlNuevaCategoria.Controls.Add(this.txtNombreCategoria);
            this.pnlNuevaCategoria.Controls.Add(this.label6);
            this.pnlNuevaCategoria.Controls.Add(this.panel3);
            this.pnlNuevaCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.pnlNuevaCategoria.Location = new System.Drawing.Point(482, 69);
            this.pnlNuevaCategoria.Name = "pnlNuevaCategoria";
            this.pnlNuevaCategoria.Size = new System.Drawing.Size(228, 362);
            this.pnlNuevaCategoria.TabIndex = 10;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.BorderRadius = 8;
            this.txtIdCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCategoria.DefaultText = "";
            this.txtIdCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategoria.DisabledState.Parent = this.txtIdCategoria;
            this.txtIdCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategoria.FocusedState.Parent = this.txtIdCategoria;
            this.txtIdCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategoria.HoverState.Parent = this.txtIdCategoria;
            this.txtIdCategoria.Location = new System.Drawing.Point(5, 225);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.PasswordChar = '\0';
            this.txtIdCategoria.PlaceholderText = "";
            this.txtIdCategoria.SelectedText = "";
            this.txtIdCategoria.ShadowDecoration.Parent = this.txtIdCategoria;
            this.txtIdCategoria.Size = new System.Drawing.Size(35, 35);
            this.txtIdCategoria.TabIndex = 6;
            // 
            // iconCancelarCategoria
            // 
            this.iconCancelarCategoria.BackColor = System.Drawing.Color.Gray;
            this.iconCancelarCategoria.FlatAppearance.BorderSize = 0;
            this.iconCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCancelarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCancelarCategoria.IconColor = System.Drawing.Color.Black;
            this.iconCancelarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelarCategoria.Location = new System.Drawing.Point(104, 225);
            this.iconCancelarCategoria.Name = "iconCancelarCategoria";
            this.iconCancelarCategoria.Size = new System.Drawing.Size(119, 40);
            this.iconCancelarCategoria.TabIndex = 5;
            this.iconCancelarCategoria.Text = "Cancelar";
            this.iconCancelarCategoria.UseVisualStyleBackColor = false;
            this.iconCancelarCategoria.Click += new System.EventHandler(this.iconCancelarCategoria_Click);
            // 
            // iconEliminarCategoria
            // 
            this.iconEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.iconEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEliminarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconEliminarCategoria.IconColor = System.Drawing.Color.Black;
            this.iconEliminarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminarCategoria.Location = new System.Drawing.Point(104, 174);
            this.iconEliminarCategoria.Name = "iconEliminarCategoria";
            this.iconEliminarCategoria.Size = new System.Drawing.Size(119, 40);
            this.iconEliminarCategoria.TabIndex = 4;
            this.iconEliminarCategoria.Text = "Eliminar";
            this.iconEliminarCategoria.UseVisualStyleBackColor = false;
            this.iconEliminarCategoria.Click += new System.EventHandler(this.iconEliminarCategoria_Click);
            // 
            // iconGuardarCategoria
            // 
            this.iconGuardarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconGuardarCategoria.FlatAppearance.BorderSize = 0;
            this.iconGuardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGuardarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconGuardarCategoria.IconColor = System.Drawing.Color.Black;
            this.iconGuardarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardarCategoria.Location = new System.Drawing.Point(104, 124);
            this.iconGuardarCategoria.Name = "iconGuardarCategoria";
            this.iconGuardarCategoria.Size = new System.Drawing.Size(119, 40);
            this.iconGuardarCategoria.TabIndex = 3;
            this.iconGuardarCategoria.Text = "Guardar";
            this.iconGuardarCategoria.UseVisualStyleBackColor = false;
            this.iconGuardarCategoria.Click += new System.EventHandler(this.iconGuardarCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BorderRadius = 15;
            this.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.DefaultText = "";
            this.txtNombreCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCategoria.DisabledState.Parent = this.txtNombreCategoria;
            this.txtNombreCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCategoria.FocusedState.Parent = this.txtNombreCategoria;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCategoria.HoverState.Parent = this.txtNombreCategoria;
            this.txtNombreCategoria.Location = new System.Drawing.Point(5, 84);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.PlaceholderText = "Categoría";
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.ShadowDecoration.Parent = this.txtNombreCategoria;
            this.txtNombreCategoria.Size = new System.Drawing.Size(218, 31);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 50);
            this.panel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(57)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(57, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Categoria";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.pnlNuevaCategoria;
            // 
            // pnlNuevoAutor
            // 
            this.pnlNuevoAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.pnlNuevoAutor.Controls.Add(this.txtApellidoAutor);
            this.pnlNuevoAutor.Controls.Add(this.txtIdAutor);
            this.pnlNuevoAutor.Controls.Add(this.iconCancelarAutor);
            this.pnlNuevoAutor.Controls.Add(this.iconEliminarAutor);
            this.pnlNuevoAutor.Controls.Add(this.iconGuardarAutor);
            this.pnlNuevoAutor.Controls.Add(this.txtNombreAutor);
            this.pnlNuevoAutor.Controls.Add(this.label7);
            this.pnlNuevoAutor.Controls.Add(this.panel4);
            this.pnlNuevoAutor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNuevoAutor.ForeColor = System.Drawing.Color.White;
            this.pnlNuevoAutor.Location = new System.Drawing.Point(482, 69);
            this.pnlNuevoAutor.Name = "pnlNuevoAutor";
            this.pnlNuevoAutor.Size = new System.Drawing.Size(228, 193);
            this.pnlNuevoAutor.TabIndex = 11;
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.BorderRadius = 8;
            this.txtIdAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAutor.DefaultText = "";
            this.txtIdAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAutor.DisabledState.Parent = this.txtIdAutor;
            this.txtIdAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAutor.FocusedState.Parent = this.txtIdAutor;
            this.txtIdAutor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAutor.HoverState.Parent = this.txtIdAutor;
            this.txtIdAutor.Location = new System.Drawing.Point(5, 225);
            this.txtIdAutor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.PasswordChar = '\0';
            this.txtIdAutor.PlaceholderText = "";
            this.txtIdAutor.SelectedText = "";
            this.txtIdAutor.ShadowDecoration.Parent = this.txtIdAutor;
            this.txtIdAutor.Size = new System.Drawing.Size(35, 35);
            this.txtIdAutor.TabIndex = 6;
            // 
            // iconCancelarAutor
            // 
            this.iconCancelarAutor.BackColor = System.Drawing.Color.Gray;
            this.iconCancelarAutor.FlatAppearance.BorderSize = 0;
            this.iconCancelarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCancelarAutor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCancelarAutor.IconColor = System.Drawing.Color.Black;
            this.iconCancelarAutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelarAutor.Location = new System.Drawing.Point(104, 293);
            this.iconCancelarAutor.Name = "iconCancelarAutor";
            this.iconCancelarAutor.Size = new System.Drawing.Size(119, 40);
            this.iconCancelarAutor.TabIndex = 5;
            this.iconCancelarAutor.Text = "Cancelar";
            this.iconCancelarAutor.UseVisualStyleBackColor = false;
            this.iconCancelarAutor.Click += new System.EventHandler(this.iconCancelarAutor_Click);
            // 
            // iconEliminarAutor
            // 
            this.iconEliminarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconEliminarAutor.FlatAppearance.BorderSize = 0;
            this.iconEliminarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEliminarAutor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconEliminarAutor.IconColor = System.Drawing.Color.Black;
            this.iconEliminarAutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminarAutor.Location = new System.Drawing.Point(104, 247);
            this.iconEliminarAutor.Name = "iconEliminarAutor";
            this.iconEliminarAutor.Size = new System.Drawing.Size(119, 40);
            this.iconEliminarAutor.TabIndex = 4;
            this.iconEliminarAutor.Text = "Eliminar";
            this.iconEliminarAutor.UseVisualStyleBackColor = false;
            this.iconEliminarAutor.Click += new System.EventHandler(this.iconEliminarAutor_Click);
            // 
            // iconGuardarAutor
            // 
            this.iconGuardarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconGuardarAutor.FlatAppearance.BorderSize = 0;
            this.iconGuardarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGuardarAutor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconGuardarAutor.IconColor = System.Drawing.Color.Black;
            this.iconGuardarAutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardarAutor.Location = new System.Drawing.Point(104, 201);
            this.iconGuardarAutor.Name = "iconGuardarAutor";
            this.iconGuardarAutor.Size = new System.Drawing.Size(119, 40);
            this.iconGuardarAutor.TabIndex = 3;
            this.iconGuardarAutor.Text = "Guardar";
            this.iconGuardarAutor.UseVisualStyleBackColor = false;
            this.iconGuardarAutor.Click += new System.EventHandler(this.iconGuardarAutor_Click);
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BorderRadius = 15;
            this.txtNombreAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreAutor.DefaultText = "";
            this.txtNombreAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreAutor.DisabledState.Parent = this.txtNombreAutor;
            this.txtNombreAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreAutor.FocusedState.Parent = this.txtNombreAutor;
            this.txtNombreAutor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreAutor.HoverState.Parent = this.txtNombreAutor;
            this.txtNombreAutor.Location = new System.Drawing.Point(5, 84);
            this.txtNombreAutor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.PasswordChar = '\0';
            this.txtNombreAutor.PlaceholderText = "Categoría";
            this.txtNombreAutor.SelectedText = "";
            this.txtNombreAutor.ShadowDecoration.Parent = this.txtNombreAutor;
            this.txtNombreAutor.Size = new System.Drawing.Size(218, 31);
            this.txtNombreAutor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(57)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 50);
            this.panel4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(57)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(78, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Autor";
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.pnlNuevoAutor;
            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.BorderRadius = 15;
            this.txtApellidoAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoAutor.DefaultText = "";
            this.txtApellidoAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoAutor.DisabledState.Parent = this.txtApellidoAutor;
            this.txtApellidoAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoAutor.FocusedState.Parent = this.txtApellidoAutor;
            this.txtApellidoAutor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoAutor.HoverState.Parent = this.txtApellidoAutor;
            this.txtApellidoAutor.Location = new System.Drawing.Point(5, 127);
            this.txtApellidoAutor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.PasswordChar = '\0';
            this.txtApellidoAutor.PlaceholderText = "Categoría";
            this.txtApellidoAutor.SelectedText = "";
            this.txtApellidoAutor.ShadowDecoration.Parent = this.txtApellidoAutor;
            this.txtApellidoAutor.Size = new System.Drawing.Size(218, 31);
            this.txtApellidoAutor.TabIndex = 7;
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.pnlNuevoAutor);
            this.Controls.Add(this.pnlNuevaCategoria);
            this.Controls.Add(this.iconNuevoActor);
            this.Controls.Add(this.iconNuevaCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNuevaCategoria.ResumeLayout(false);
            this.pnlNuevaCategoria.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNuevoAutor.ResumeLayout(false);
            this.pnlNuevoAutor.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private FontAwesome.Sharp.IconButton iconCerrar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboAutor;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategoria;
        private FontAwesome.Sharp.IconButton iconNuevaCategoria;
        private System.Windows.Forms.Panel pnlNuevaCategoria;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconNuevoActor;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private FontAwesome.Sharp.IconButton iconGuardarCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconCancelarCategoria;
        private FontAwesome.Sharp.IconButton iconEliminarCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCategoria;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Panel pnlNuevoAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtIdAutor;
        private FontAwesome.Sharp.IconButton iconCancelarAutor;
        private FontAwesome.Sharp.IconButton iconEliminarAutor;
        private FontAwesome.Sharp.IconButton iconGuardarAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoAutor;
    }
}