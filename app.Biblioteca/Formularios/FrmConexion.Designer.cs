namespace app.Biblioteca.Formularios
{
    partial class FrmConexion
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBaseDatos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServidor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.iconAceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Beige;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtBaseDatos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtServidor, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 156);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBaseDatos.BorderRadius = 8;
            this.txtBaseDatos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBaseDatos.DefaultText = "";
            this.txtBaseDatos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBaseDatos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBaseDatos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaseDatos.DisabledState.Parent = this.txtBaseDatos;
            this.txtBaseDatos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaseDatos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBaseDatos.FocusedState.Parent = this.txtBaseDatos;
            this.txtBaseDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBaseDatos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBaseDatos.HoverState.Parent = this.txtBaseDatos;
            this.txtBaseDatos.Location = new System.Drawing.Point(6, 114);
            this.txtBaseDatos.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.PasswordChar = '\0';
            this.txtBaseDatos.PlaceholderText = "";
            this.txtBaseDatos.SelectedText = "";
            this.txtBaseDatos.ShadowDecoration.Parent = this.txtBaseDatos;
            this.txtBaseDatos.Size = new System.Drawing.Size(351, 33);
            this.txtBaseDatos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP/ Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base de Datos";
            // 
            // txtServidor
            // 
            this.txtServidor.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtServidor.BorderRadius = 8;
            this.txtServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidor.DefaultText = "";
            this.txtServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.DisabledState.Parent = this.txtServidor;
            this.txtServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.FocusedState.Parent = this.txtServidor;
            this.txtServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServidor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.HoverState.Parent = this.txtServidor;
            this.txtServidor.Location = new System.Drawing.Point(5, 34);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.PlaceholderText = "";
            this.txtServidor.SelectedText = "";
            this.txtServidor.ShadowDecoration.Parent = this.txtServidor;
            this.txtServidor.Size = new System.Drawing.Size(351, 35);
            this.txtServidor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(466, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conexion a Base de Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.96907F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.03093F));
            this.tableLayoutPanel3.Controls.Add(this.iconCerrar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconAceptar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(45, 231);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 52);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.Color.Gray;
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCerrar.ForeColor = System.Drawing.Color.White;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconCerrar.IconColor = System.Drawing.Color.White;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 30;
            this.iconCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCerrar.Location = new System.Drawing.Point(193, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Padding = new System.Windows.Forms.Padding(5);
            this.iconCerrar.Size = new System.Drawing.Size(192, 46);
            this.iconCerrar.TabIndex = 2;
            this.iconCerrar.Text = "Cerrar";
            this.iconCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconCerrar, "Cerrar");
            this.iconCerrar.UseVisualStyleBackColor = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconAceptar
            // 
            this.iconAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAceptar.ForeColor = System.Drawing.Color.White;
            this.iconAceptar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconAceptar.IconColor = System.Drawing.Color.White;
            this.iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAceptar.IconSize = 30;
            this.iconAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAceptar.Location = new System.Drawing.Point(3, 3);
            this.iconAceptar.Name = "iconAceptar";
            this.iconAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.iconAceptar.Size = new System.Drawing.Size(184, 46);
            this.iconAceptar.TabIndex = 0;
            this.iconAceptar.Text = "Aceptar";
            this.iconAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconAceptar, "Guardar registro");
            this.iconAceptar.UseVisualStyleBackColor = false;
            this.iconAceptar.Click += new System.EventHandler(this.iconAceptar_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 311);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConexion";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton iconAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBaseDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtServidor;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}