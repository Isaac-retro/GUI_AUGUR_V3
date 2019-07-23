namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    partial class PlatosPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatosPrincipal));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.textBoxNombrePlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRefrescarLista = new System.Windows.Forms.PictureBox();
            this.labelListaPlatos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPlatos = new System.Windows.Forms.DataGridView();
            this.idPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePlatoDataSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPlatoDataSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPlatoDataSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.White;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(539, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(262, 45);
            this.buttonEliminar.TabIndex = 44;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.White;
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrar.Location = new System.Drawing.Point(3, 3);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(262, 45);
            this.buttonRegistrar.TabIndex = 43;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(807, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(243, 45);
            this.buttonCancelar.TabIndex = 42;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.White;
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(271, 3);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(262, 45);
            this.buttonActualizar.TabIndex = 41;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(271, 11);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(530, 20);
            this.textBoxNombrePlato.TabIndex = 38;
            this.textBoxNombrePlato.TextChanged += new System.EventHandler(this.TextBoxNombrePlato_TextChanged);
            this.textBoxNombrePlato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNombrePlato_KeyDown);
            this.textBoxNombrePlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCaracteres);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Buscar plato por nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxRefrescarLista);
            this.panel1.Controls.Add(this.labelListaPlatos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNombrePlato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 74);
            this.panel1.TabIndex = 48;
            // 
            // pictureBoxRefrescarLista
            // 
            this.pictureBoxRefrescarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarLista.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarLista.Image")));
            this.pictureBoxRefrescarLista.Location = new System.Drawing.Point(271, 46);
            this.pictureBoxRefrescarLista.Name = "pictureBoxRefrescarLista";
            this.pictureBoxRefrescarLista.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxRefrescarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescarLista.TabIndex = 49;
            this.pictureBoxRefrescarLista.TabStop = false;
            this.pictureBoxRefrescarLista.Click += new System.EventHandler(this.PictureBoxRefrescarLista_Click);
            // 
            // labelListaPlatos
            // 
            this.labelListaPlatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListaPlatos.AutoSize = true;
            this.labelListaPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelListaPlatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListaPlatos.Location = new System.Drawing.Point(12, 50);
            this.labelListaPlatos.Name = "labelListaPlatos";
            this.labelListaPlatos.Size = new System.Drawing.Size(215, 20);
            this.labelListaPlatos.TabIndex = 48;
            this.labelListaPlatos.Text = "Lista de Platos de comida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.buttonActualizar);
            this.panel2.Controls.Add(this.buttonCancelar);
            this.panel2.Controls.Add(this.buttonRegistrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 50);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewPlatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 526);
            this.panel3.TabIndex = 50;
            // 
            // dataGridViewPlatos
            // 
            this.dataGridViewPlatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlato,
            this.nombrePlatoDataSet,
            this.precioPlatoDataSet,
            this.tipoPlatoDataSet});
            this.dataGridViewPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlatos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPlatos.Name = "dataGridViewPlatos";
            this.dataGridViewPlatos.Size = new System.Drawing.Size(1050, 526);
            this.dataGridViewPlatos.TabIndex = 46;
            // 
            // idPlato
            // 
            this.idPlato.Frozen = true;
            this.idPlato.HeaderText = "ID Plato";
            this.idPlato.Name = "idPlato";
            this.idPlato.ReadOnly = true;
            this.idPlato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombrePlatoDataSet
            // 
            this.nombrePlatoDataSet.Frozen = true;
            this.nombrePlatoDataSet.HeaderText = "Nombre del Plato";
            this.nombrePlatoDataSet.Name = "nombrePlatoDataSet";
            this.nombrePlatoDataSet.ReadOnly = true;
            this.nombrePlatoDataSet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombrePlatoDataSet.Width = 400;
            // 
            // precioPlatoDataSet
            // 
            this.precioPlatoDataSet.Frozen = true;
            this.precioPlatoDataSet.HeaderText = "Precio $";
            this.precioPlatoDataSet.Name = "precioPlatoDataSet";
            this.precioPlatoDataSet.ReadOnly = true;
            this.precioPlatoDataSet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioPlatoDataSet.Width = 150;
            // 
            // tipoPlatoDataSet
            // 
            this.tipoPlatoDataSet.Frozen = true;
            this.tipoPlatoDataSet.HeaderText = "Tipo";
            this.tipoPlatoDataSet.Name = "tipoPlatoDataSet";
            this.tipoPlatoDataSet.ReadOnly = true;
            this.tipoPlatoDataSet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipoPlatoDataSet.Width = 250;
            // 
            // PlatosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlatosPrincipal";
            this.Text = "PlatosIngredientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.TextBox textBoxNombrePlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarLista;
        private System.Windows.Forms.Label labelListaPlatos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewPlatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePlatoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPlatoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPlatoDataSet;
    }
}