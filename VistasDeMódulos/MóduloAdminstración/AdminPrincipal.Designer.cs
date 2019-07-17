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
            this.label1 = new System.Windows.Forms.Label();
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
            this.labelTituloParam = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAdminSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametros)).BeginInit();
            this.panelParamInferior.SuspendLayout();
            this.panelParamSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.dataGridViewUsuario);
            this.panelAdmin.Controls.Add(this.panel1);
            this.panelAdmin.Controls.Add(this.panelAdminSuperior);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(430, 650);
            this.panelAdmin.TabIndex = 0;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGrid,
            this.nombreUsuarioDataGrid,
            this.cargoDataGrid,
            this.bloqueadoDataGrid});
            this.dataGridViewUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(430, 338);
            this.dataGridViewUsuario.TabIndex = 19;
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
            // 
            // cargoDataGrid
            // 
            this.cargoDataGrid.Frozen = true;
            this.cargoDataGrid.HeaderText = "Cargo";
            this.cargoDataGrid.Name = "cargoDataGrid";
            this.cargoDataGrid.ReadOnly = true;
            // 
            // bloqueadoDataGrid
            // 
            this.bloqueadoDataGrid.Frozen = true;
            this.bloqueadoDataGrid.HeaderText = "Bloqueado";
            this.bloqueadoDataGrid.Name = "bloqueadoDataGrid";
            this.bloqueadoDataGrid.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonResetearContra);
            this.panel1.Controls.Add(this.buttonCrearUsuario);
            this.panel1.Controls.Add(this.buttoncambiarContra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 156);
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
            this.buttonResetearContra.Location = new System.Drawing.Point(40, 108);
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
            this.buttonCrearUsuario.Location = new System.Drawing.Point(40, 56);
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
            this.buttoncambiarContra.Location = new System.Drawing.Point(40, 4);
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
            this.panelAdminSuperior.Controls.Add(this.label1);
            this.panelAdminSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelAdminSuperior.Name = "panelAdminSuperior";
            this.panelAdminSuperior.Size = new System.Drawing.Size(430, 156);
            this.panelAdminSuperior.TabIndex = 0;
            // 
            // pictureBoxRefrescarListaUsuarios
            // 
            this.pictureBoxRefrescarListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarListaUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarListaUsuarios.Image")));
            this.pictureBoxRefrescarListaUsuarios.Location = new System.Drawing.Point(198, 129);
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
            this.labelListaUsers.Location = new System.Drawing.Point(43, 136);
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
            this.labelUserCargo.Location = new System.Drawing.Point(181, 65);
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
            this.labelUser.Location = new System.Drawing.Point(178, 36);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(103, 29);
            this.labelUser.TabIndex = 23;
            this.labelUser.Text = "Usuario";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(48, 36);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(127, 85);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 22;
            this.pictureBoxImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(42, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sistema";
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.dataGridViewParametros);
            this.panelParam.Controls.Add(this.panelParamInferior);
            this.panelParam.Controls.Add(this.panelParamSuperior);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParam.Location = new System.Drawing.Point(430, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(620, 650);
            this.panelParam.TabIndex = 1;
            // 
            // dataGridViewParametros
            // 
            this.dataGridViewParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParametros.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewParametros.Name = "dataGridViewParametros";
            this.dataGridViewParametros.Size = new System.Drawing.Size(620, 495);
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
            this.panelParamInferior.Size = new System.Drawing.Size(620, 50);
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
            this.buttonEliminarPr.Location = new System.Drawing.Point(322, 1);
            this.buttonEliminarPr.Name = "buttonEliminarPr";
            this.buttonEliminarPr.Size = new System.Drawing.Size(155, 46);
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
            this.buttonSalirAdmin.Location = new System.Drawing.Point(465, 0);
            this.buttonSalirAdmin.Name = "buttonSalirAdmin";
            this.buttonSalirAdmin.Size = new System.Drawing.Size(155, 46);
            this.buttonSalirAdmin.TabIndex = 14;
            this.buttonSalirAdmin.Text = "Salir";
            this.buttonSalirAdmin.UseVisualStyleBackColor = true;
            this.buttonSalirAdmin.Click += new System.EventHandler(this.ButtonSalirAdmin_Click);
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
            this.buttonActualizarPr.Location = new System.Drawing.Point(161, 1);
            this.buttonActualizarPr.Name = "buttonActualizarPr";
            this.buttonActualizarPr.Size = new System.Drawing.Size(155, 46);
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
            this.buttonRegistrarPr.Location = new System.Drawing.Point(0, 1);
            this.buttonRegistrarPr.Name = "buttonRegistrarPr";
            this.buttonRegistrarPr.Size = new System.Drawing.Size(155, 46);
            this.buttonRegistrarPr.TabIndex = 11;
            this.buttonRegistrarPr.Text = "Registrar";
            this.buttonRegistrarPr.UseVisualStyleBackColor = true;
            this.buttonRegistrarPr.Click += new System.EventHandler(this.ButtonRegistrarPr_Click);
            // 
            // panelParamSuperior
            // 
            this.panelParamSuperior.Controls.Add(this.pictureBoxRefrescarListaParametros);
            this.panelParamSuperior.Controls.Add(this.label3);
            this.panelParamSuperior.Controls.Add(this.textBoxBuscarParam);
            this.panelParamSuperior.Controls.Add(this.label2);
            this.panelParamSuperior.Controls.Add(this.labelTituloParam);
            this.panelParamSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParamSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelParamSuperior.Name = "panelParamSuperior";
            this.panelParamSuperior.Size = new System.Drawing.Size(620, 105);
            this.panelParamSuperior.TabIndex = 0;
            // 
            // pictureBoxRefrescarListaParametros
            // 
            this.pictureBoxRefrescarListaParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescarListaParametros.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescarListaParametros.Image")));
            this.pictureBoxRefrescarListaParametros.Location = new System.Drawing.Point(187, 78);
            this.pictureBoxRefrescarListaParametros.Name = "pictureBoxRefrescarListaParametros";
            this.pictureBoxRefrescarListaParametros.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxRefrescarListaParametros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescarListaParametros.TabIndex = 27;
            this.pictureBoxRefrescarListaParametros.TabStop = false;
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
            // textBoxBuscarParam
            // 
            this.textBoxBuscarParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarParam.Location = new System.Drawing.Point(238, 43);
            this.textBoxBuscarParam.Name = "textBoxBuscarParam";
            this.textBoxBuscarParam.Size = new System.Drawing.Size(368, 22);
            this.textBoxBuscarParam.TabIndex = 15;
            this.textBoxBuscarParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBuscarParam_KeyPress);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelAdminSuperior.ResumeLayout(false);
            this.panelAdminSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelParam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametros)).EndInit();
            this.panelParamInferior.ResumeLayout(false);
            this.panelParamSuperior.ResumeLayout(false);
            this.panelParamSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescarListaParametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelAdminSuperior;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Panel panelParamInferior;
        private System.Windows.Forms.Panel panelParamSuperior;
        private System.Windows.Forms.Button buttonEliminarPr;
        private System.Windows.Forms.Button buttonSalirAdmin;
        private System.Windows.Forms.Button buttonRegistrarPr;
        private System.Windows.Forms.Button buttonActualizarPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTituloParam;
        private System.Windows.Forms.TextBox textBoxBuscarParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewParametros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResetearContra;
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Button buttoncambiarContra;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Label labelListaUsers;
        private System.Windows.Forms.Label labelUserCargo;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarListaUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxRefrescarListaParametros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueadoDataGrid;
    }
}