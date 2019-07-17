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
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueadoDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResetearContra = new System.Windows.Forms.Button();
            this.buttonCrearUsuario = new System.Windows.Forms.Button();
            this.buttoncambiarContra = new System.Windows.Forms.Button();
            this.panelAdminSuperior = new System.Windows.Forms.Panel();
            this.pictureBoxRefrescarListaUsuarios = new System.Windows.Forms.PictureBox();
            this.labelListaUsers = new System.Windows.Forms.Label();
            this.labelUserCargo = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAdminSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.dataGridViewUsuario);
            this.panelAdmin.Controls.Add(this.panel1);
            this.panelAdmin.Controls.Add(this.panelAdminSuperior);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1050, 650);
            this.panelAdmin.TabIndex = 0;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGrid,
            this.nombreUsuarioDataGrid,
            this.cargoDataGrid,
            this.bloqueadoDataGrid});
            this.dataGridViewUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(354, 109);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(696, 541);
            this.dataGridViewUsuario.TabIndex = 19;
            this.dataGridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsuario_CellClick);
            // 
            // idUsuarioDataGrid
            // 
            this.idUsuarioDataGrid.Frozen = true;
            this.idUsuarioDataGrid.HeaderText = "ID";
            this.idUsuarioDataGrid.Name = "idUsuarioDataGrid";
            this.idUsuarioDataGrid.ReadOnly = true;
            // 
            // nombreUsuarioDataGrid
            // 
            this.nombreUsuarioDataGrid.Frozen = true;
            this.nombreUsuarioDataGrid.HeaderText = "Nombre de Usuario";
            this.nombreUsuarioDataGrid.Name = "nombreUsuarioDataGrid";
            this.nombreUsuarioDataGrid.ReadOnly = true;
            this.nombreUsuarioDataGrid.Width = 250;
            // 
            // cargoDataGrid
            // 
            this.cargoDataGrid.Frozen = true;
            this.cargoDataGrid.HeaderText = "Cargo";
            this.cargoDataGrid.Name = "cargoDataGrid";
            this.cargoDataGrid.ReadOnly = true;
            this.cargoDataGrid.Width = 150;
            // 
            // bloqueadoDataGrid
            // 
            this.bloqueadoDataGrid.Frozen = true;
            this.bloqueadoDataGrid.HeaderText = "Bloqueado";
            this.bloqueadoDataGrid.Name = "bloqueadoDataGrid";
            this.bloqueadoDataGrid.ReadOnly = true;
            this.bloqueadoDataGrid.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonResetearContra);
            this.panel1.Controls.Add(this.buttonCrearUsuario);
            this.panel1.Controls.Add(this.buttoncambiarContra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 541);
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
            this.buttonResetearContra.Location = new System.Drawing.Point(3, 153);
            this.buttonResetearContra.Name = "buttonResetearContra";
            this.buttonResetearContra.Size = new System.Drawing.Size(350, 46);
            this.buttonResetearContra.TabIndex = 23;
            this.buttonResetearContra.Text = "Resetar Contraseña";
            this.buttonResetearContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResetearContra.UseVisualStyleBackColor = true;
            this.buttonResetearContra.Click += new System.EventHandler(this.ButtonResetearContra_Click);
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
            this.buttonCrearUsuario.Location = new System.Drawing.Point(3, 101);
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
            this.buttoncambiarContra.Location = new System.Drawing.Point(3, 49);
            this.buttoncambiarContra.Name = "buttoncambiarContra";
            this.buttoncambiarContra.Size = new System.Drawing.Size(350, 46);
            this.buttoncambiarContra.TabIndex = 21;
            this.buttoncambiarContra.Text = "Cambiar mi constraseña";
            this.buttoncambiarContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoncambiarContra.UseVisualStyleBackColor = true;
            this.buttoncambiarContra.Click += new System.EventHandler(this.ButtoncambiarContra_Click);
            // 
            // panelAdminSuperior
            // 
            this.panelAdminSuperior.Controls.Add(this.pictureBoxRefrescarListaUsuarios);
            this.panelAdminSuperior.Controls.Add(this.labelListaUsers);
            this.panelAdminSuperior.Controls.Add(this.labelUserCargo);
            this.panelAdminSuperior.Controls.Add(this.labelUser);
            this.panelAdminSuperior.Controls.Add(this.pictureBoxImage);
            this.panelAdminSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelAdminSuperior.Name = "panelAdminSuperior";
            this.panelAdminSuperior.Size = new System.Drawing.Size(1050, 109);
            this.panelAdminSuperior.TabIndex = 0;
            // 
            // pictureBoxRefrescarListaUsuarios
            // 
            this.pictureBoxRefrescarListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarListaUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarListaUsuarios.Image")));
            this.pictureBoxRefrescarListaUsuarios.Location = new System.Drawing.Point(505, 73);
            this.pictureBoxRefrescarListaUsuarios.Name = "pictureBoxRefrescarListaUsuarios";
            this.pictureBoxRefrescarListaUsuarios.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxRefrescarListaUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescarListaUsuarios.TabIndex = 26;
            this.pictureBoxRefrescarListaUsuarios.TabStop = false;
            this.pictureBoxRefrescarListaUsuarios.Click += new System.EventHandler(this.PictureBoxRefrescarListaUsuarios_Click);
            // 
            // labelListaUsers
            // 
            this.labelListaUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListaUsers.AutoSize = true;
            this.labelListaUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelListaUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListaUsers.Location = new System.Drawing.Point(350, 77);
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
            this.labelUserCargo.Location = new System.Drawing.Point(136, 38);
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
            this.labelUser.Location = new System.Drawing.Point(136, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(103, 29);
            this.labelUser.TabIndex = 23;
            this.labelUser.Text = "Usuario";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(127, 85);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 22;
            this.pictureBoxImage.TabStop = false;
            // 
            // AdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPrincipal";
            this.Text = " ";
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelAdminSuperior.ResumeLayout(false);
            this.panelAdminSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelAdminSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResetearContra;
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Button buttoncambiarContra;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Label labelListaUsers;
        private System.Windows.Forms.Label labelUserCargo;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueadoDataGrid;
    }
}