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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxBuscarCP = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarCP = new System.Windows.Forms.Button();
            this.buttonActualizarCP = new System.Windows.Forms.Button();
            this.buttonDarBajaCP = new System.Windows.Forms.Button();
            this.buttonDarAltaCP = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 462);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBoxBuscarCP
            // 
            this.comboBoxBuscarCP.FormattingEnabled = true;
            this.comboBoxBuscarCP.Items.AddRange(new object[] {
            "Nombre",
            "Cédula",
            "Pasaporte"});
            this.comboBoxBuscarCP.Location = new System.Drawing.Point(236, 12);
            this.comboBoxBuscarCP.Name = "comboBoxBuscarCP";
            this.comboBoxBuscarCP.Size = new System.Drawing.Size(174, 21);
            this.comboBoxBuscarCP.TabIndex = 2;
            // 
            // buttonRegistrarCP
            // 
            this.buttonRegistrarCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarCP.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRegistrarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrarCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarCP.Location = new System.Drawing.Point(12, 548);
            this.buttonRegistrarCP.Name = "buttonRegistrarCP";
            this.buttonRegistrarCP.Size = new System.Drawing.Size(200, 45);
            this.buttonRegistrarCP.TabIndex = 3;
            this.buttonRegistrarCP.Text = "Registrar";
            this.buttonRegistrarCP.UseVisualStyleBackColor = true;
            this.buttonRegistrarCP.Click += new System.EventHandler(this.ButtonRegistrarCP_Click);
            // 
            // buttonActualizarCP
            // 
            this.buttonActualizarCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarCP.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonActualizarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizarCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarCP.Location = new System.Drawing.Point(218, 548);
            this.buttonActualizarCP.Name = "buttonActualizarCP";
            this.buttonActualizarCP.Size = new System.Drawing.Size(200, 45);
            this.buttonActualizarCP.TabIndex = 4;
            this.buttonActualizarCP.Text = "Actualizar";
            this.buttonActualizarCP.UseVisualStyleBackColor = true;
            // 
            // buttonDarBajaCP
            // 
            this.buttonDarBajaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarBajaCP.FlatAppearance.BorderSize = 0;
            this.buttonDarBajaCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDarBajaCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarBajaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDarBajaCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDarBajaCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarBajaCP.Location = new System.Drawing.Point(424, 548);
            this.buttonDarBajaCP.Name = "buttonDarBajaCP";
            this.buttonDarBajaCP.Size = new System.Drawing.Size(200, 45);
            this.buttonDarBajaCP.TabIndex = 5;
            this.buttonDarBajaCP.Text = "Dar Baja";
            this.buttonDarBajaCP.UseVisualStyleBackColor = true;
            // 
            // buttonDarAltaCP
            // 
            this.buttonDarAltaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarAltaCP.FlatAppearance.BorderSize = 0;
            this.buttonDarAltaCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDarAltaCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarAltaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDarAltaCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDarAltaCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarAltaCP.Location = new System.Drawing.Point(630, 548);
            this.buttonDarAltaCP.Name = "buttonDarAltaCP";
            this.buttonDarAltaCP.Size = new System.Drawing.Size(200, 45);
            this.buttonDarAltaCP.TabIndex = 6;
            this.buttonDarAltaCP.Text = "Dar Alta";
            this.buttonDarAltaCP.UseVisualStyleBackColor = true;
            this.buttonDarAltaCP.Click += new System.EventHandler(this.ButtonDarAltaCP_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(836, 548);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(200, 45);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar Cliente por";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonDarAltaCP);
            this.Controls.Add(this.buttonDarBajaCP);
            this.Controls.Add(this.buttonActualizarCP);
            this.Controls.Add(this.buttonRegistrarCP);
            this.Controls.Add(this.comboBoxBuscarCP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientePrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxBuscarCP;
        private System.Windows.Forms.Button buttonRegistrarCP;
        private System.Windows.Forms.Button buttonActualizarCP;
        private System.Windows.Forms.Button buttonDarBajaCP;
        private System.Windows.Forms.Button buttonDarAltaCP;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button button1;
    }
}