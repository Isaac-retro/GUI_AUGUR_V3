namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    partial class ClientePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientePrincipal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonDarAltaCP = new System.Windows.Forms.Button();
            this.buttonDarBajaCP = new System.Windows.Forms.Button();
            this.buttonActualizarCP = new System.Windows.Forms.Button();
            this.buttonRegistrarCP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxRefrescarListaUsuarios = new System.Windows.Forms.PictureBox();
            this.labelListaUsers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBuscarCP = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 605);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Controls.Add(this.buttonDarAltaCP);
            this.panel1.Controls.Add(this.buttonDarBajaCP);
            this.panel1.Controls.Add(this.buttonActualizarCP);
            this.panel1.Controls.Add(this.buttonRegistrarCP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 45);
            this.panel1.TabIndex = 9;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSalir.BackColor = System.Drawing.Color.White;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(835, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(212, 40);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonDarAltaCP
            // 
            this.buttonDarAltaCP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDarAltaCP.BackColor = System.Drawing.Color.White;
            this.buttonDarAltaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarAltaCP.FlatAppearance.BorderSize = 0;
            this.buttonDarAltaCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDarAltaCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarAltaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDarAltaCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDarAltaCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarAltaCP.Location = new System.Drawing.Point(629, 3);
            this.buttonDarAltaCP.Name = "buttonDarAltaCP";
            this.buttonDarAltaCP.Size = new System.Drawing.Size(200, 40);
            this.buttonDarAltaCP.TabIndex = 13;
            this.buttonDarAltaCP.Text = "Dar de alta";
            this.buttonDarAltaCP.UseVisualStyleBackColor = false;
            this.buttonDarAltaCP.Click += new System.EventHandler(this.ButtonDarAltaCP_Click_1);
            // 
            // buttonDarBajaCP
            // 
            this.buttonDarBajaCP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDarBajaCP.BackColor = System.Drawing.Color.White;
            this.buttonDarBajaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarBajaCP.FlatAppearance.BorderSize = 0;
            this.buttonDarBajaCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDarBajaCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarBajaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDarBajaCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDarBajaCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarBajaCP.Location = new System.Drawing.Point(423, 3);
            this.buttonDarBajaCP.Name = "buttonDarBajaCP";
            this.buttonDarBajaCP.Size = new System.Drawing.Size(200, 40);
            this.buttonDarBajaCP.TabIndex = 12;
            this.buttonDarBajaCP.Text = "Dar de baja";
            this.buttonDarBajaCP.UseVisualStyleBackColor = false;
            this.buttonDarBajaCP.Click += new System.EventHandler(this.ButtonDarBajaCP_Click);
            // 
            // buttonActualizarCP
            // 
            this.buttonActualizarCP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonActualizarCP.BackColor = System.Drawing.Color.White;
            this.buttonActualizarCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarCP.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonActualizarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizarCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarCP.Location = new System.Drawing.Point(217, 3);
            this.buttonActualizarCP.Name = "buttonActualizarCP";
            this.buttonActualizarCP.Size = new System.Drawing.Size(200, 40);
            this.buttonActualizarCP.TabIndex = 11;
            this.buttonActualizarCP.Text = "Actualizar";
            this.buttonActualizarCP.UseVisualStyleBackColor = false;
            this.buttonActualizarCP.Click += new System.EventHandler(this.ButtonActualizarCP_Click);
            // 
            // buttonRegistrarCP
            // 
            this.buttonRegistrarCP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRegistrarCP.BackColor = System.Drawing.Color.White;
            this.buttonRegistrarCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarCP.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRegistrarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrarCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarCP.Location = new System.Drawing.Point(12, 3);
            this.buttonRegistrarCP.Name = "buttonRegistrarCP";
            this.buttonRegistrarCP.Size = new System.Drawing.Size(199, 40);
            this.buttonRegistrarCP.TabIndex = 10;
            this.buttonRegistrarCP.Text = "Registrar";
            this.buttonRegistrarCP.UseVisualStyleBackColor = false;
            this.buttonRegistrarCP.Click += new System.EventHandler(this.ButtonRegistrarCP_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBoxRefrescarListaUsuarios);
            this.panel2.Controls.Add(this.labelListaUsers);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBoxBuscarCP);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 72);
            this.panel2.TabIndex = 10;
            // 
            // pictureBoxRefrescarListaUsuarios
            // 
            this.pictureBoxRefrescarListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarListaUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarListaUsuarios.Image")));
            this.pictureBoxRefrescarListaUsuarios.Location = new System.Drawing.Point(235, 48);
            this.pictureBoxRefrescarListaUsuarios.Name = "pictureBoxRefrescarListaUsuarios";
            this.pictureBoxRefrescarListaUsuarios.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxRefrescarListaUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescarListaUsuarios.TabIndex = 27;
            this.pictureBoxRefrescarListaUsuarios.TabStop = false;
            // 
            // labelListaUsers
            // 
            this.labelListaUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListaUsers.AutoSize = true;
            this.labelListaUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelListaUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListaUsers.Location = new System.Drawing.Point(42, 48);
            this.labelListaUsers.Name = "labelListaUsers";
            this.labelListaUsers.Size = new System.Drawing.Size(143, 20);
            this.labelListaUsers.TabIndex = 26;
            this.labelListaUsers.Text = "Lista de Clientes";
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
            this.button1.Location = new System.Drawing.Point(11, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar Cliente por";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuscarCP
            // 
            this.comboBoxBuscarCP.FormattingEnabled = true;
            this.comboBoxBuscarCP.Items.AddRange(new object[] {
            "Nombre",
            "Cédula",
            "Pasaporte"});
            this.comboBoxBuscarCP.Location = new System.Drawing.Point(235, 12);
            this.comboBoxBuscarCP.Name = "comboBoxBuscarCP";
            this.comboBoxBuscarCP.Size = new System.Drawing.Size(174, 21);
            this.comboBoxBuscarCP.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 20);
            this.textBox1.TabIndex = 9;
            // 
            // ClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientePrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonDarAltaCP;
        private System.Windows.Forms.Button buttonDarBajaCP;
        private System.Windows.Forms.Button buttonActualizarCP;
        private System.Windows.Forms.Button buttonRegistrarCP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBuscarCP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelListaUsers;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarListaUsuarios;
    }
}