namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración
{
    partial class AdminPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPrincipal));
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.panelAdminSuperior = new System.Windows.Forms.Panel();
            this.panelParamSuperior = new System.Windows.Forms.Panel();
            this.panelParamInferior = new System.Windows.Forms.Panel();
            this.buttonRegistrarPr = new System.Windows.Forms.Button();
            this.ActualizarPr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalirAdmin = new System.Windows.Forms.Button();
            this.labelTituloParam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataSetParam = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResetearContra = new System.Windows.Forms.Button();
            this.buttonCrearUsuario = new System.Windows.Forms.Button();
            this.buttoncambiarContra = new System.Windows.Forms.Button();
            this.labelListaUsers = new System.Windows.Forms.Label();
            this.labelUserCargo = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panelAdminSuperior.SuspendLayout();
            this.panelParamSuperior.SuspendLayout();
            this.panelParamInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParam)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.dataGridView1);
            this.panelAdmin.Controls.Add(this.panel1);
            this.panelAdmin.Controls.Add(this.panelAdminSuperior);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(350, 650);
            this.panelAdmin.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.dataSetParam);
            this.panelParam.Controls.Add(this.panelParamInferior);
            this.panelParam.Controls.Add(this.panelParamSuperior);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParam.Location = new System.Drawing.Point(350, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(700, 650);
            this.panelParam.TabIndex = 1;
            // 
            // panelAdminSuperior
            // 
            this.panelAdminSuperior.Controls.Add(this.labelListaUsers);
            this.panelAdminSuperior.Controls.Add(this.labelUserCargo);
            this.panelAdminSuperior.Controls.Add(this.labelUser);
            this.panelAdminSuperior.Controls.Add(this.pictureBoxImage);
            this.panelAdminSuperior.Controls.Add(this.label1);
            this.panelAdminSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelAdminSuperior.Name = "panelAdminSuperior";
            this.panelAdminSuperior.Size = new System.Drawing.Size(350, 156);
            this.panelAdminSuperior.TabIndex = 0;
            // 
            // panelParamSuperior
            // 
            this.panelParamSuperior.Controls.Add(this.label3);
            this.panelParamSuperior.Controls.Add(this.textBox1);
            this.panelParamSuperior.Controls.Add(this.label2);
            this.panelParamSuperior.Controls.Add(this.labelTituloParam);
            this.panelParamSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParamSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelParamSuperior.Name = "panelParamSuperior";
            this.panelParamSuperior.Size = new System.Drawing.Size(700, 105);
            this.panelParamSuperior.TabIndex = 0;
            // 
            // panelParamInferior
            // 
            this.panelParamInferior.Controls.Add(this.button1);
            this.panelParamInferior.Controls.Add(this.buttonSalirAdmin);
            this.panelParamInferior.Controls.Add(this.ActualizarPr);
            this.panelParamInferior.Controls.Add(this.buttonRegistrarPr);
            this.panelParamInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelParamInferior.Location = new System.Drawing.Point(0, 600);
            this.panelParamInferior.Name = "panelParamInferior";
            this.panelParamInferior.Size = new System.Drawing.Size(700, 50);
            this.panelParamInferior.TabIndex = 1;
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
            this.buttonRegistrarPr.Location = new System.Drawing.Point(1, 2);
            this.buttonRegistrarPr.Name = "buttonRegistrarPr";
            this.buttonRegistrarPr.Size = new System.Drawing.Size(175, 46);
            this.buttonRegistrarPr.TabIndex = 11;
            this.buttonRegistrarPr.Text = "Registrar";
            this.buttonRegistrarPr.UseVisualStyleBackColor = true;
            // 
            // ActualizarPr
            // 
            this.ActualizarPr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ActualizarPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarPr.FlatAppearance.BorderSize = 0;
            this.ActualizarPr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ActualizarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ActualizarPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ActualizarPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarPr.Location = new System.Drawing.Point(182, 2);
            this.ActualizarPr.Name = "ActualizarPr";
            this.ActualizarPr.Size = new System.Drawing.Size(175, 46);
            this.ActualizarPr.TabIndex = 12;
            this.ActualizarPr.Text = "Actualizar";
            this.ActualizarPr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(363, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
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
            this.buttonSalirAdmin.Location = new System.Drawing.Point(522, 2);
            this.buttonSalirAdmin.Name = "buttonSalirAdmin";
            this.buttonSalirAdmin.Size = new System.Drawing.Size(175, 46);
            this.buttonSalirAdmin.TabIndex = 14;
            this.buttonSalirAdmin.Text = "Salir";
            this.buttonSalirAdmin.UseVisualStyleBackColor = true;
            // 
            // labelTituloParam
            // 
            this.labelTituloParam.AutoSize = true;
            this.labelTituloParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTituloParam.Location = new System.Drawing.Point(3, 3);
            this.labelTituloParam.Name = "labelTituloParam";
            this.labelTituloParam.Size = new System.Drawing.Size(176, 33);
            this.labelTituloParam.TabIndex = 13;
            this.labelTituloParam.Text = "Parámetros";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sistema";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Parámetro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 15;
            // 
            // dataSetParam
            // 
            this.dataSetParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSetParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSetParam.Location = new System.Drawing.Point(0, 105);
            this.dataSetParam.Name = "dataSetParam";
            this.dataSetParam.Size = new System.Drawing.Size(700, 495);
            this.dataSetParam.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonResetearContra);
            this.panel1.Controls.Add(this.buttonCrearUsuario);
            this.panel1.Controls.Add(this.buttoncambiarContra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 156);
            this.panel1.TabIndex = 18;
            // 
            // buttonResetearContra
            // 
            this.buttonResetearContra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonResetearContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetearContra.FlatAppearance.BorderSize = 0;
            this.buttonResetearContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonResetearContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetearContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonResetearContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonResetearContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetearContra.Location = new System.Drawing.Point(0, 108);
            this.buttonResetearContra.Name = "buttonResetearContra";
            this.buttonResetearContra.Size = new System.Drawing.Size(350, 46);
            this.buttonResetearContra.TabIndex = 23;
            this.buttonResetearContra.Text = "Resetar Contraseña";
            this.buttonResetearContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResetearContra.UseVisualStyleBackColor = true;
            // 
            // buttonCrearUsuario
            // 
            this.buttonCrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearUsuario.FlatAppearance.BorderSize = 0;
            this.buttonCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonCrearUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrearUsuario.Location = new System.Drawing.Point(0, 56);
            this.buttonCrearUsuario.Name = "buttonCrearUsuario";
            this.buttonCrearUsuario.Size = new System.Drawing.Size(350, 46);
            this.buttonCrearUsuario.TabIndex = 22;
            this.buttonCrearUsuario.Text = "Crear Usuario";
            this.buttonCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCrearUsuario.UseVisualStyleBackColor = true;
            this.buttonCrearUsuario.Click += new System.EventHandler(this.ButtonCrearUsuario_Click);
            // 
            // buttoncambiarContra
            // 
            this.buttoncambiarContra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttoncambiarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncambiarContra.FlatAppearance.BorderSize = 0;
            this.buttoncambiarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttoncambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncambiarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttoncambiarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttoncambiarContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncambiarContra.Location = new System.Drawing.Point(0, 4);
            this.buttoncambiarContra.Name = "buttoncambiarContra";
            this.buttoncambiarContra.Size = new System.Drawing.Size(350, 46);
            this.buttoncambiarContra.TabIndex = 21;
            this.buttoncambiarContra.Text = "Cambiar mi constraseña";
            this.buttoncambiarContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoncambiarContra.UseVisualStyleBackColor = true;
            // 
            // labelListaUsers
            // 
            this.labelListaUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListaUsers.AutoSize = true;
            this.labelListaUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelListaUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListaUsers.Location = new System.Drawing.Point(3, 136);
            this.labelListaUsers.Name = "labelListaUsers";
            this.labelListaUsers.Size = new System.Drawing.Size(149, 20);
            this.labelListaUsers.TabIndex = 25;
            this.labelListaUsers.Text = "Lista de Usuarios";
            // 
            // labelUserCargo
            // 
            this.labelUserCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserCargo.AutoSize = true;
            this.labelUserCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserCargo.Location = new System.Drawing.Point(141, 65);
            this.labelUserCargo.Name = "labelUserCargo";
            this.labelUserCargo.Size = new System.Drawing.Size(84, 29);
            this.labelUserCargo.TabIndex = 24;
            this.labelUserCargo.Text = "Cargo";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUser.Location = new System.Drawing.Point(138, 36);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(103, 29);
            this.labelUser.TabIndex = 23;
            this.labelUser.Text = "Usuario";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(8, 36);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(127, 85);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 22;
            this.pictureBoxImage.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 338);
            this.dataGridView1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lista de  Parámetros";
            // 
            // AdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelParam);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPrincipal";
            this.Text = " ";
            this.panelAdmin.ResumeLayout(false);
            this.panelParam.ResumeLayout(false);
            this.panelAdminSuperior.ResumeLayout(false);
            this.panelAdminSuperior.PerformLayout();
            this.panelParamSuperior.ResumeLayout(false);
            this.panelParamSuperior.PerformLayout();
            this.panelParamInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParam)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelAdminSuperior;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Panel panelParamInferior;
        private System.Windows.Forms.Panel panelParamSuperior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalirAdmin;
        private System.Windows.Forms.Button buttonRegistrarPr;
        private System.Windows.Forms.Button ActualizarPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTituloParam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataSetParam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResetearContra;
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Button buttoncambiarContra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelListaUsers;
        private System.Windows.Forms.Label labelUserCargo;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label3;
    }
}