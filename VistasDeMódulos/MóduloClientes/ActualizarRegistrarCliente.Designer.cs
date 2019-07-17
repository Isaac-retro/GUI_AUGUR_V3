namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    partial class ActualizarRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarRegistrarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTeléfono = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxdirección = new System.Windows.Forms.TextBox();
            this.buttonRegistrarC = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.labelDeIdentificacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.pictureBoxSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 45);
            this.panel1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitulo.Location = new System.Drawing.Point(32, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(197, 33);
            this.labelTitulo.TabIndex = 13;
            this.labelTitulo.Text = "func Clientes";
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(370, 3);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 1;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.PictureBoxSalir_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(156, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(241, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxTeléfono
            // 
            this.textBoxTeléfono.Location = new System.Drawing.Point(156, 203);
            this.textBoxTeléfono.Name = "textBoxTeléfono";
            this.textBoxTeléfono.Size = new System.Drawing.Size(241, 20);
            this.textBoxTeléfono.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(156, 89);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(241, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(156, 136);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(241, 20);
            this.textBoxDocumento.TabIndex = 4;
            // 
            // comboBoxDocumento
            // 
            this.comboBoxDocumento.FormattingEnabled = true;
            this.comboBoxDocumento.Items.AddRange(new object[] {
            "cédula",
            "pasaporte"});
            this.comboBoxDocumento.Location = new System.Drawing.Point(220, 162);
            this.comboBoxDocumento.Name = "comboBoxDocumento";
            this.comboBoxDocumento.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDocumento.TabIndex = 12;
            // 
            // textBoxdirección
            // 
            this.textBoxdirección.Location = new System.Drawing.Point(156, 238);
            this.textBoxdirección.Name = "textBoxdirección";
            this.textBoxdirección.Size = new System.Drawing.Size(241, 20);
            this.textBoxdirección.TabIndex = 15;
            // 
            // buttonRegistrarC
            // 
            this.buttonRegistrarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarC.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRegistrarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarC.Location = new System.Drawing.Point(38, 315);
            this.buttonRegistrarC.Name = "buttonRegistrarC";
            this.buttonRegistrarC.Size = new System.Drawing.Size(170, 45);
            this.buttonRegistrarC.TabIndex = 16;
            this.buttonRegistrarC.Text = "Registrar";
            this.buttonRegistrarC.UseVisualStyleBackColor = true;
            this.buttonRegistrarC.Click += new System.EventHandler(this.ButtonRegistrarC_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(227, 315);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(170, 45);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelError.Location = new System.Drawing.Point(95, 288);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(232, 24);
            this.labelError.TabIndex = 14;
            this.labelError.Text = "Error al registrar Cliente";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(71, 20);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(12, 89);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(73, 20);
            this.labelApellido.TabIndex = 19;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.Location = new System.Drawing.Point(12, 136);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(101, 20);
            this.labelDocumento.TabIndex = 20;
            this.labelDocumento.Text = "Docmuento";
            // 
            // labelDeIdentificacion
            // 
            this.labelDeIdentificacion.AutoSize = true;
            this.labelDeIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeIdentificacion.Location = new System.Drawing.Point(12, 163);
            this.labelDeIdentificacion.Name = "labelDeIdentificacion";
            this.labelDeIdentificacion.Size = new System.Drawing.Size(142, 20);
            this.labelDeIdentificacion.TabIndex = 21;
            this.labelDeIdentificacion.Text = "de Identificación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Teléfono ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dirección";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(68, 315);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(170, 45);
            this.buttonActualizar.TabIndex = 24;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // ActualizarRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 375);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDeIdentificacion);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrarC);
            this.Controls.Add(this.textBoxdirección);
            this.Controls.Add(this.comboBoxDocumento);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxTeléfono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarRegistrarCliente";
            this.Text = "RegistrarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTeléfono;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.ComboBox comboBoxDocumento;
        private System.Windows.Forms.TextBox textBoxdirección;
        private System.Windows.Forms.Button buttonRegistrarC;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Label labelDeIdentificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonActualizar;
    }
}