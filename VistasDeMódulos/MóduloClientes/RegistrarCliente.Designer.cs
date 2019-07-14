namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    partial class RegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTeléfono = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxDocumento = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxdirección = new System.Windows.Forms.TextBox();
            this.buttonRegistrarC = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.labelTitulo.Location = new System.Drawing.Point(38, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(255, 33);
            this.labelTitulo.TabIndex = 13;
            this.labelTitulo.Text = "Registro Clientes";
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
            this.textBoxTeléfono.Location = new System.Drawing.Point(156, 212);
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nombre";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Apellido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 51);
            this.button3.TabIndex = 11;
            this.button3.Text = "Documento Identificación";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxDocumento
            // 
            this.comboBoxDocumento.FormattingEnabled = true;
            this.comboBoxDocumento.Location = new System.Drawing.Point(220, 162);
            this.comboBoxDocumento.Name = "comboBoxDocumento";
            this.comboBoxDocumento.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDocumento.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Teléfono";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 32);
            this.button5.TabIndex = 14;
            this.button5.Text = "Dirección";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBoxdirección
            // 
            this.textBoxdirección.Location = new System.Drawing.Point(156, 250);
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
            this.buttonRegistrarC.Location = new System.Drawing.Point(12, 315);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(95, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Error al registrar Cliente";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrarC);
            this.Controls.Add(this.textBoxdirección);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxDocumento);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxTeléfono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCliente";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxDocumento;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxdirección;
        private System.Windows.Forms.Button buttonRegistrarC;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
    }
}