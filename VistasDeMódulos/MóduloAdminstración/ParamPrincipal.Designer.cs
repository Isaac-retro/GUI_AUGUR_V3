namespace GUI_AUGUR_V3.VistasDeMódulos.móduloAdminstración
{
    partial class ParamPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamPrincipal));
            this.panelParam = new System.Windows.Forms.Panel();
            this.dataGridViewParametros = new System.Windows.Forms.DataGridView();
            this.panelParamInferior = new System.Windows.Forms.Panel();
            this.buttonEliminarPr = new System.Windows.Forms.Button();
            this.buttonSalirAdmin = new System.Windows.Forms.Button();
            this.buttonActualizarPr = new System.Windows.Forms.Button();
            this.buttonRegistrarPr = new System.Windows.Forms.Button();
            this.panelParamSuperior = new System.Windows.Forms.Panel();
            this.pictureBoxRefrescarListaParametros = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarParam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idParamSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorparamSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametros)).BeginInit();
            this.panelParamInferior.SuspendLayout();
            this.panelParamSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.dataGridViewParametros);
            this.panelParam.Controls.Add(this.panelParamInferior);
            this.panelParam.Controls.Add(this.panelParamSuperior);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParam.Location = new System.Drawing.Point(0, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(1050, 650);
            this.panelParam.TabIndex = 2;
            // 
            // dataGridViewParametros
            // 
            this.dataGridViewParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParamSet,
            this.nombreParam,
            this.valorparamSet});
            this.dataGridViewParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParametros.Location = new System.Drawing.Point(0, 86);
            this.dataGridViewParametros.Name = "dataGridViewParametros";
            this.dataGridViewParametros.Size = new System.Drawing.Size(1050, 514);
            this.dataGridViewParametros.TabIndex = 2;
            // 
            // panelParamInferior
            // 
            this.panelParamInferior.Controls.Add(this.buttonEliminarPr);
            this.panelParamInferior.Controls.Add(this.buttonSalirAdmin);
            this.panelParamInferior.Controls.Add(this.buttonActualizarPr);
            this.panelParamInferior.Controls.Add(this.buttonRegistrarPr);
            this.panelParamInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelParamInferior.Location = new System.Drawing.Point(0, 600);
            this.panelParamInferior.Name = "panelParamInferior";
            this.panelParamInferior.Size = new System.Drawing.Size(1050, 50);
            this.panelParamInferior.TabIndex = 1;
            // 
            // buttonEliminarPr
            // 
            this.buttonEliminarPr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminarPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarPr.FlatAppearance.BorderSize = 0;
            this.buttonEliminarPr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonEliminarPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminarPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarPr.Location = new System.Drawing.Point(539, 3);
            this.buttonEliminarPr.Name = "buttonEliminarPr";
            this.buttonEliminarPr.Size = new System.Drawing.Size(262, 45);
            this.buttonEliminarPr.TabIndex = 13;
            this.buttonEliminarPr.Text = "Eliminar";
            this.buttonEliminarPr.UseVisualStyleBackColor = true;
            // 
            // buttonSalirAdmin
            // 
            this.buttonSalirAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSalirAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalirAdmin.FlatAppearance.BorderSize = 0;
            this.buttonSalirAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalirAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalirAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSalirAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalirAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalirAdmin.Location = new System.Drawing.Point(785, 3);
            this.buttonSalirAdmin.Name = "buttonSalirAdmin";
            this.buttonSalirAdmin.Size = new System.Drawing.Size(262, 45);
            this.buttonSalirAdmin.TabIndex = 14;
            this.buttonSalirAdmin.Text = "Salir";
            this.buttonSalirAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonActualizarPr
            // 
            this.buttonActualizarPr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonActualizarPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarPr.FlatAppearance.BorderSize = 0;
            this.buttonActualizarPr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonActualizarPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizarPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarPr.Location = new System.Drawing.Point(271, 2);
            this.buttonActualizarPr.Name = "buttonActualizarPr";
            this.buttonActualizarPr.Size = new System.Drawing.Size(262, 45);
            this.buttonActualizarPr.TabIndex = 12;
            this.buttonActualizarPr.Text = "Actualizar";
            this.buttonActualizarPr.UseVisualStyleBackColor = true;
            this.buttonActualizarPr.Click += new System.EventHandler(this.ButtonActualizarPr_Click);
            // 
            // buttonRegistrarPr
            // 
            this.buttonRegistrarPr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRegistrarPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarPr.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarPr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRegistrarPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrarPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarPr.Location = new System.Drawing.Point(3, 3);
            this.buttonRegistrarPr.Name = "buttonRegistrarPr";
            this.buttonRegistrarPr.Size = new System.Drawing.Size(262, 45);
            this.buttonRegistrarPr.TabIndex = 11;
            this.buttonRegistrarPr.Text = "Registrar";
            this.buttonRegistrarPr.UseVisualStyleBackColor = true;
            this.buttonRegistrarPr.Click += new System.EventHandler(this.ButtonRegistrarPr_Click);
            // 
            // panelParamSuperior
            // 
            this.panelParamSuperior.BackColor = System.Drawing.Color.White;
            this.panelParamSuperior.Controls.Add(this.pictureBoxRefrescarListaParametros);
            this.panelParamSuperior.Controls.Add(this.label3);
            this.panelParamSuperior.Controls.Add(this.textBoxBuscarParam);
            this.panelParamSuperior.Controls.Add(this.label2);
            this.panelParamSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParamSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelParamSuperior.Name = "panelParamSuperior";
            this.panelParamSuperior.Size = new System.Drawing.Size(1050, 86);
            this.panelParamSuperior.TabIndex = 0;
            // 
            // pictureBoxRefrescarListaParametros
            // 
            this.pictureBoxRefrescarListaParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarListaParametros.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarListaParametros.Image")));
            this.pictureBoxRefrescarListaParametros.Location = new System.Drawing.Point(198, 46);
            this.pictureBoxRefrescarListaParametros.Name = "pictureBoxRefrescarListaParametros";
            this.pictureBoxRefrescarListaParametros.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxRefrescarListaParametros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescarListaParametros.TabIndex = 27;
            this.pictureBoxRefrescarListaParametros.TabStop = false;
            this.pictureBoxRefrescarListaParametros.Click += new System.EventHandler(this.PictureBoxRefrescarListaParametros_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lista de  Parámetros";
            // 
            // textBoxBuscarParam
            // 
            this.textBoxBuscarParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarParam.Location = new System.Drawing.Point(171, 9);
            this.textBoxBuscarParam.Name = "textBoxBuscarParam";
            this.textBoxBuscarParam.Size = new System.Drawing.Size(525, 22);
            this.textBoxBuscarParam.TabIndex = 15;
            this.textBoxBuscarParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBuscarParam_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Parámetro";
            // 
            // idParamSet
            // 
            this.idParamSet.Frozen = true;
            this.idParamSet.HeaderText = "ID";
            this.idParamSet.Name = "idParamSet";
            this.idParamSet.ReadOnly = true;
            // 
            // nombreParam
            // 
            this.nombreParam.Frozen = true;
            this.nombreParam.HeaderText = "Nombre del Parametro";
            this.nombreParam.Name = "nombreParam";
            this.nombreParam.ReadOnly = true;
            // 
            // valorparamSet
            // 
            this.valorparamSet.Frozen = true;
            this.valorparamSet.HeaderText = "Valor del Parametro";
            this.valorparamSet.Name = "valorparamSet";
            this.valorparamSet.ReadOnly = true;
            // 
            // ParamPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParamPrincipal";
            this.Text = "ParamPrincipal";
            this.panelParam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametros)).EndInit();
            this.panelParamInferior.ResumeLayout(false);
            this.panelParamSuperior.ResumeLayout(false);
            this.panelParamSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaParametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.DataGridView dataGridViewParametros;
        private System.Windows.Forms.Panel panelParamInferior;
        private System.Windows.Forms.Button buttonEliminarPr;
        private System.Windows.Forms.Button buttonSalirAdmin;
        private System.Windows.Forms.Button buttonActualizarPr;
        private System.Windows.Forms.Button buttonRegistrarPr;
        private System.Windows.Forms.Panel panelParamSuperior;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarListaParametros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscarParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParamSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorparamSet;
    }
}