namespace GUI_AUGUR_V3
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.labelTitulo1 = new System.Windows.Forms.Label();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonPagos = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonPlatosIng = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelDesIngredientes = new System.Windows.Forms.Panel();
            this.buttonEliminarIngrdiente = new System.Windows.Forms.Button();
            this.buttonConsultarIngrdiente = new System.Windows.Forms.Button();
            this.buttonActulizarIngrediente = new System.Windows.Forms.Button();
            this.buttonRegistrarIngrdientes = new System.Windows.Forms.Button();
            this.panelDesClientes = new System.Windows.Forms.Panel();
            this.buttonDarAlta = new System.Windows.Forms.Button();
            this.buttonDarBaja = new System.Windows.Forms.Button();
            this.buttonConsulCliente = new System.Windows.Forms.Button();
            this.buttonActualizarCliente = new System.Windows.Forms.Button();
            this.buttonRegistrarClientes = new System.Windows.Forms.Button();
            this.panelDesPlatos = new System.Windows.Forms.Panel();
            this.buttonIngredientes = new System.Windows.Forms.Button();
            this.buttonEliminarPlato = new System.Windows.Forms.Button();
            this.buttonConsultarPlato = new System.Windows.Forms.Button();
            this.buttonActualizarPlato = new System.Windows.Forms.Button();
            this.buttonRegistraPlato = new System.Windows.Forms.Button();
            this.panelDesReportes = new System.Windows.Forms.Panel();
            this.buttonPlatosVendidos = new System.Windows.Forms.Button();
            this.buttonClientesFrecuentes = new System.Windows.Forms.Button();
            this.buttonTicketsEmitidos = new System.Windows.Forms.Button();
            this.panelDesPedidos = new System.Windows.Forms.Panel();
            this.buttonInvalidarPedido = new System.Windows.Forms.Button();
            this.buttonCrearPedido = new System.Windows.Forms.Button();
            this.panelDesPagos = new System.Windows.Forms.Panel();
            this.buttonServiciosB = new System.Windows.Forms.Button();
            this.buttonBalanCuentas = new System.Windows.Forms.Button();
            this.panelDesAdmin = new System.Windows.Forms.Panel();
            this.buttonAdminSistema = new System.Windows.Forms.Button();
            this.buttonAdminParam = new System.Windows.Forms.Button();
            this.panelDesAyuda = new System.Windows.Forms.Panel();
            this.buttonAcerca = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonInfoSistema = new System.Windows.Forms.Button();
            this.labelTituloLoggin = new System.Windows.Forms.Label();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelDesIngredientes.SuspendLayout();
            this.panelDesClientes.SuspendLayout();
            this.panelDesPlatos.SuspendLayout();
            this.panelDesReportes.SuspendLayout();
            this.panelDesPedidos.SuspendLayout();
            this.panelDesPagos.SuspendLayout();
            this.panelDesAdmin.SuspendLayout();
            this.panelDesAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenuVertical.Controls.Add(this.flowLayoutPanel1);
            this.panelMenuVertical.Controls.Add(this.labelTitulo2);
            this.panelMenuVertical.Controls.Add(this.labelTitulo1);
            this.panelMenuVertical.Controls.Add(this.buttonAyuda);
            this.panelMenuVertical.Controls.Add(this.buttonAdmin);
            this.panelMenuVertical.Controls.Add(this.buttonPagos);
            this.panelMenuVertical.Controls.Add(this.buttonPedidos);
            this.panelMenuVertical.Controls.Add(this.buttonReportes);
            this.panelMenuVertical.Controls.Add(this.buttonPlatosIng);
            this.panelMenuVertical.Controls.Add(this.buttonClientes);
            this.panelMenuVertical.Controls.Add(this.pictureBox2);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 650);
            this.panelMenuVertical.TabIndex = 0;
            this.panelMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuVertical_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(250, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitulo2.Location = new System.Drawing.Point(57, 112);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(195, 29);
            this.labelTitulo2.TabIndex = 10;
            this.labelTitulo2.Text = "Los de Solanda";
            // 
            // labelTitulo1
            // 
            this.labelTitulo1.AutoSize = true;
            this.labelTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitulo1.Location = new System.Drawing.Point(71, 83);
            this.labelTitulo1.Name = "labelTitulo1";
            this.labelTitulo1.Size = new System.Drawing.Size(173, 29);
            this.labelTitulo1.TabIndex = 9;
            this.labelTitulo1.Text = "Encebollados";
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonAyuda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAyuda.Image")));
            this.buttonAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAyuda.Location = new System.Drawing.Point(0, 512);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(250, 45);
            this.buttonAyuda.TabIndex = 8;
            this.buttonAyuda.Text = "Ayuda";
            this.buttonAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAyuda.UseVisualStyleBackColor = true;
            this.buttonAyuda.Click += new System.EventHandler(this.ButtonAyuda_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 461);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(250, 45);
            this.buttonAdmin.TabIndex = 7;
            this.buttonAdmin.Text = "Adminitración";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // buttonPagos
            // 
            this.buttonPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPagos.FlatAppearance.BorderSize = 0;
            this.buttonPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPagos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPagos.Image = ((System.Drawing.Image)(resources.GetObject("buttonPagos.Image")));
            this.buttonPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagos.Location = new System.Drawing.Point(0, 410);
            this.buttonPagos.Name = "buttonPagos";
            this.buttonPagos.Size = new System.Drawing.Size(250, 45);
            this.buttonPagos.TabIndex = 6;
            this.buttonPagos.Text = "Pagos";
            this.buttonPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPagos.UseVisualStyleBackColor = true;
            this.buttonPagos.Click += new System.EventHandler(this.ButtonPagos_Click);
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPedidos.FlatAppearance.BorderSize = 0;
            this.buttonPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPedidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPedidos.Image = ((System.Drawing.Image)(resources.GetObject("buttonPedidos.Image")));
            this.buttonPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPedidos.Location = new System.Drawing.Point(0, 359);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(250, 45);
            this.buttonPedidos.TabIndex = 5;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPedidos.UseVisualStyleBackColor = true;
            this.buttonPedidos.Click += new System.EventHandler(this.ButtonPedidos_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportes.FlatAppearance.BorderSize = 0;
            this.buttonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReportes.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportes.Image")));
            this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.Location = new System.Drawing.Point(0, 308);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(250, 45);
            this.buttonReportes.TabIndex = 4;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.ButtonReportes_Click);
            // 
            // buttonPlatosIng
            // 
            this.buttonPlatosIng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlatosIng.FlatAppearance.BorderSize = 0;
            this.buttonPlatosIng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPlatosIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlatosIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPlatosIng.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPlatosIng.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlatosIng.Image")));
            this.buttonPlatosIng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlatosIng.Location = new System.Drawing.Point(0, 257);
            this.buttonPlatosIng.Name = "buttonPlatosIng";
            this.buttonPlatosIng.Size = new System.Drawing.Size(250, 45);
            this.buttonPlatosIng.TabIndex = 2;
            this.buttonPlatosIng.Text = "Platos";
            this.buttonPlatosIng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlatosIng.UseVisualStyleBackColor = true;
            this.buttonPlatosIng.Click += new System.EventHandler(this.ButtonPlatosIng_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 208);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(250, 45);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitulo.Controls.Add(this.labelTituloLoggin);
            this.panelTitulo.Controls.Add(this.pictureBoxMenu);
            this.panelTitulo.Controls.Add(this.pictureBoxMax);
            this.panelTitulo.Controls.Add(this.pictureBoxMin);
            this.panelTitulo.Controls.Add(this.pictureBoxSalir);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1050, 45);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitulo_Paint);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(6, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.Image")));
            this.pictureBoxMax.Location = new System.Drawing.Point(972, 3);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 2;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.PictureBoxMax_Click);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.Image")));
            this.pictureBoxMin.Location = new System.Drawing.Point(931, 3);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMin.TabIndex = 1;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.PictureBoxMin_Click);
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(1013, 4);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 0;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.PictureBoxSalir_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.panelDesIngredientes);
            this.panelContenedor.Controls.Add(this.panelDesClientes);
            this.panelContenedor.Controls.Add(this.panelDesPlatos);
            this.panelContenedor.Controls.Add(this.panelDesReportes);
            this.panelContenedor.Controls.Add(this.panelDesPedidos);
            this.panelContenedor.Controls.Add(this.panelDesPagos);
            this.panelContenedor.Controls.Add(this.panelDesAdmin);
            this.panelContenedor.Controls.Add(this.panelDesAyuda);
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 605);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // panelDesIngredientes
            // 
            this.panelDesIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesIngredientes.Controls.Add(this.buttonEliminarIngrdiente);
            this.panelDesIngredientes.Controls.Add(this.buttonConsultarIngrdiente);
            this.panelDesIngredientes.Controls.Add(this.buttonActulizarIngrediente);
            this.panelDesIngredientes.Controls.Add(this.buttonRegistrarIngrdientes);
            this.panelDesIngredientes.Location = new System.Drawing.Point(163, 357);
            this.panelDesIngredientes.Name = "panelDesIngredientes";
            this.panelDesIngredientes.Size = new System.Drawing.Size(214, 152);
            this.panelDesIngredientes.TabIndex = 21;
            // 
            // buttonEliminarIngrdiente
            // 
            this.buttonEliminarIngrdiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarIngrdiente.FlatAppearance.BorderSize = 0;
            this.buttonEliminarIngrdiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonEliminarIngrdiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarIngrdiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarIngrdiente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEliminarIngrdiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarIngrdiente.Location = new System.Drawing.Point(0, 108);
            this.buttonEliminarIngrdiente.Name = "buttonEliminarIngrdiente";
            this.buttonEliminarIngrdiente.Size = new System.Drawing.Size(214, 33);
            this.buttonEliminarIngrdiente.TabIndex = 15;
            this.buttonEliminarIngrdiente.Text = "Eliminar Ingrediente";
            this.buttonEliminarIngrdiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarIngrdiente.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarIngrdiente
            // 
            this.buttonConsultarIngrdiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultarIngrdiente.FlatAppearance.BorderSize = 0;
            this.buttonConsultarIngrdiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonConsultarIngrdiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarIngrdiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarIngrdiente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConsultarIngrdiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultarIngrdiente.Location = new System.Drawing.Point(0, 74);
            this.buttonConsultarIngrdiente.Name = "buttonConsultarIngrdiente";
            this.buttonConsultarIngrdiente.Size = new System.Drawing.Size(214, 33);
            this.buttonConsultarIngrdiente.TabIndex = 14;
            this.buttonConsultarIngrdiente.Text = "Consultar Ingrediente";
            this.buttonConsultarIngrdiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultarIngrdiente.UseVisualStyleBackColor = true;
            // 
            // buttonActulizarIngrediente
            // 
            this.buttonActulizarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActulizarIngrediente.FlatAppearance.BorderSize = 0;
            this.buttonActulizarIngrediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonActulizarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActulizarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActulizarIngrediente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonActulizarIngrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActulizarIngrediente.Location = new System.Drawing.Point(0, 40);
            this.buttonActulizarIngrediente.Name = "buttonActulizarIngrediente";
            this.buttonActulizarIngrediente.Size = new System.Drawing.Size(214, 33);
            this.buttonActulizarIngrediente.TabIndex = 13;
            this.buttonActulizarIngrediente.Text = "Actualizar Ingrediente";
            this.buttonActulizarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActulizarIngrediente.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrarIngrdientes
            // 
            this.buttonRegistrarIngrdientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarIngrdientes.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarIngrdientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRegistrarIngrdientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarIngrdientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarIngrdientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRegistrarIngrdientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarIngrdientes.Location = new System.Drawing.Point(0, 3);
            this.buttonRegistrarIngrdientes.Name = "buttonRegistrarIngrdientes";
            this.buttonRegistrarIngrdientes.Size = new System.Drawing.Size(214, 33);
            this.buttonRegistrarIngrdientes.TabIndex = 12;
            this.buttonRegistrarIngrdientes.Text = "Registrar Ingredientes";
            this.buttonRegistrarIngrdientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistrarIngrdientes.UseVisualStyleBackColor = true;
            // 
            // panelDesClientes
            // 
            this.panelDesClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesClientes.Controls.Add(this.buttonDarAlta);
            this.panelDesClientes.Controls.Add(this.buttonDarBaja);
            this.panelDesClientes.Controls.Add(this.buttonConsulCliente);
            this.panelDesClientes.Controls.Add(this.buttonActualizarCliente);
            this.panelDesClientes.Controls.Add(this.buttonRegistrarClientes);
            this.panelDesClientes.Location = new System.Drawing.Point(0, 163);
            this.panelDesClientes.Name = "panelDesClientes";
            this.panelDesClientes.Size = new System.Drawing.Size(172, 191);
            this.panelDesClientes.TabIndex = 20;
            // 
            // buttonDarAlta
            // 
            this.buttonDarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarAlta.FlatAppearance.BorderSize = 0;
            this.buttonDarAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDarAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarAlta.Location = new System.Drawing.Point(0, 147);
            this.buttonDarAlta.Name = "buttonDarAlta";
            this.buttonDarAlta.Size = new System.Drawing.Size(172, 28);
            this.buttonDarAlta.TabIndex = 16;
            this.buttonDarAlta.Text = "Dar Alta Cliente";
            this.buttonDarAlta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonDarAlta.UseVisualStyleBackColor = true;
            this.buttonDarAlta.Click += new System.EventHandler(this.ButtonDarAlta_Click);
            // 
            // buttonDarBaja
            // 
            this.buttonDarBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarBaja.FlatAppearance.BorderSize = 0;
            this.buttonDarBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDarBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDarBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarBaja.Location = new System.Drawing.Point(0, 108);
            this.buttonDarBaja.Name = "buttonDarBaja";
            this.buttonDarBaja.Size = new System.Drawing.Size(172, 33);
            this.buttonDarBaja.TabIndex = 15;
            this.buttonDarBaja.Text = "Dar Baja Cliente";
            this.buttonDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDarBaja.UseVisualStyleBackColor = true;
            this.buttonDarBaja.Click += new System.EventHandler(this.ButtonDarBaja_Click);
            // 
            // buttonConsulCliente
            // 
            this.buttonConsulCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsulCliente.FlatAppearance.BorderSize = 0;
            this.buttonConsulCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonConsulCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsulCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsulCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConsulCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsulCliente.Location = new System.Drawing.Point(0, 74);
            this.buttonConsulCliente.Name = "buttonConsulCliente";
            this.buttonConsulCliente.Size = new System.Drawing.Size(172, 28);
            this.buttonConsulCliente.TabIndex = 14;
            this.buttonConsulCliente.Text = "Consultar Cliente";
            this.buttonConsulCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsulCliente.UseVisualStyleBackColor = true;
            this.buttonConsulCliente.Click += new System.EventHandler(this.ButtonConsulCliente_Click);
            // 
            // buttonActualizarCliente
            // 
            this.buttonActualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarCliente.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarCliente.Location = new System.Drawing.Point(0, 40);
            this.buttonActualizarCliente.Name = "buttonActualizarCliente";
            this.buttonActualizarCliente.Size = new System.Drawing.Size(172, 28);
            this.buttonActualizarCliente.TabIndex = 13;
            this.buttonActualizarCliente.Text = "Actualizar Cliente";
            this.buttonActualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizarCliente.UseVisualStyleBackColor = true;
            this.buttonActualizarCliente.Click += new System.EventHandler(this.ButtonActualizarCliente_Click);
            // 
            // buttonRegistrarClientes
            // 
            this.buttonRegistrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarClientes.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRegistrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRegistrarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarClientes.Location = new System.Drawing.Point(0, 3);
            this.buttonRegistrarClientes.Name = "buttonRegistrarClientes";
            this.buttonRegistrarClientes.Size = new System.Drawing.Size(172, 33);
            this.buttonRegistrarClientes.TabIndex = 12;
            this.buttonRegistrarClientes.Text = "Registrar Cliente";
            this.buttonRegistrarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistrarClientes.UseVisualStyleBackColor = true;
            this.buttonRegistrarClientes.Click += new System.EventHandler(this.ButtonRegistrarClientes_Click);
            // 
            // panelDesPlatos
            // 
            this.panelDesPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesPlatos.Controls.Add(this.buttonIngredientes);
            this.panelDesPlatos.Controls.Add(this.buttonEliminarPlato);
            this.panelDesPlatos.Controls.Add(this.buttonConsultarPlato);
            this.panelDesPlatos.Controls.Add(this.buttonActualizarPlato);
            this.panelDesPlatos.Controls.Add(this.buttonRegistraPlato);
            this.panelDesPlatos.Location = new System.Drawing.Point(0, 212);
            this.panelDesPlatos.Name = "panelDesPlatos";
            this.panelDesPlatos.Size = new System.Drawing.Size(162, 191);
            this.panelDesPlatos.TabIndex = 19;
            // 
            // buttonIngredientes
            // 
            this.buttonIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngredientes.FlatAppearance.BorderSize = 0;
            this.buttonIngredientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngredientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIngredientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIngredientes.Location = new System.Drawing.Point(-2, 142);
            this.buttonIngredientes.Name = "buttonIngredientes";
            this.buttonIngredientes.Size = new System.Drawing.Size(162, 33);
            this.buttonIngredientes.TabIndex = 16;
            this.buttonIngredientes.Text = "Ingredientes >";
            this.buttonIngredientes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonIngredientes.UseVisualStyleBackColor = true;
            this.buttonIngredientes.Click += new System.EventHandler(this.ButtonIngredientes_Click);
            // 
            // buttonEliminarPlato
            // 
            this.buttonEliminarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarPlato.FlatAppearance.BorderSize = 0;
            this.buttonEliminarPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonEliminarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarPlato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEliminarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarPlato.Location = new System.Drawing.Point(-3, 106);
            this.buttonEliminarPlato.Name = "buttonEliminarPlato";
            this.buttonEliminarPlato.Size = new System.Drawing.Size(162, 28);
            this.buttonEliminarPlato.TabIndex = 15;
            this.buttonEliminarPlato.Text = "EliminarPlato";
            this.buttonEliminarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarPlato.UseVisualStyleBackColor = true;
            this.buttonEliminarPlato.Click += new System.EventHandler(this.ButtonEliminarPlato_Click);
            // 
            // buttonConsultarPlato
            // 
            this.buttonConsultarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultarPlato.FlatAppearance.BorderSize = 0;
            this.buttonConsultarPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonConsultarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarPlato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConsultarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultarPlato.Location = new System.Drawing.Point(-2, 75);
            this.buttonConsultarPlato.Name = "buttonConsultarPlato";
            this.buttonConsultarPlato.Size = new System.Drawing.Size(162, 28);
            this.buttonConsultarPlato.TabIndex = 14;
            this.buttonConsultarPlato.Text = "Consultar Plato";
            this.buttonConsultarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultarPlato.UseVisualStyleBackColor = true;
            this.buttonConsultarPlato.Click += new System.EventHandler(this.ButtonConsultarPlato_Click);
            // 
            // buttonActualizarPlato
            // 
            this.buttonActualizarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarPlato.FlatAppearance.BorderSize = 0;
            this.buttonActualizarPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonActualizarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarPlato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonActualizarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarPlato.Location = new System.Drawing.Point(-2, 40);
            this.buttonActualizarPlato.Name = "buttonActualizarPlato";
            this.buttonActualizarPlato.Size = new System.Drawing.Size(162, 28);
            this.buttonActualizarPlato.TabIndex = 13;
            this.buttonActualizarPlato.Text = "Actualizar Plato";
            this.buttonActualizarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizarPlato.UseVisualStyleBackColor = true;
            this.buttonActualizarPlato.Click += new System.EventHandler(this.ButtonActualizarPlato_Click);
            // 
            // buttonRegistraPlato
            // 
            this.buttonRegistraPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistraPlato.FlatAppearance.BorderSize = 0;
            this.buttonRegistraPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRegistraPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistraPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistraPlato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRegistraPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistraPlato.Location = new System.Drawing.Point(-1, 3);
            this.buttonRegistraPlato.Name = "buttonRegistraPlato";
            this.buttonRegistraPlato.Size = new System.Drawing.Size(162, 33);
            this.buttonRegistraPlato.TabIndex = 12;
            this.buttonRegistraPlato.Text = "Registrar Plato";
            this.buttonRegistraPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistraPlato.UseVisualStyleBackColor = true;
            this.buttonRegistraPlato.Click += new System.EventHandler(this.ButtonRegistraPlato_Click);
            // 
            // panelDesReportes
            // 
            this.panelDesReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesReportes.Controls.Add(this.buttonPlatosVendidos);
            this.panelDesReportes.Controls.Add(this.buttonClientesFrecuentes);
            this.panelDesReportes.Controls.Add(this.buttonTicketsEmitidos);
            this.panelDesReportes.Location = new System.Drawing.Point(0, 263);
            this.panelDesReportes.Name = "panelDesReportes";
            this.panelDesReportes.Size = new System.Drawing.Size(207, 112);
            this.panelDesReportes.TabIndex = 18;
            // 
            // buttonPlatosVendidos
            // 
            this.buttonPlatosVendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlatosVendidos.FlatAppearance.BorderSize = 0;
            this.buttonPlatosVendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPlatosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlatosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlatosVendidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPlatosVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlatosVendidos.Location = new System.Drawing.Point(-3, 71);
            this.buttonPlatosVendidos.Name = "buttonPlatosVendidos";
            this.buttonPlatosVendidos.Size = new System.Drawing.Size(207, 28);
            this.buttonPlatosVendidos.TabIndex = 14;
            this.buttonPlatosVendidos.Text = "Platos Más Vendidos";
            this.buttonPlatosVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlatosVendidos.UseVisualStyleBackColor = true;
            this.buttonPlatosVendidos.Click += new System.EventHandler(this.ButtonPlatosMasVendidos_Click);
            // 
            // buttonClientesFrecuentes
            // 
            this.buttonClientesFrecuentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientesFrecuentes.FlatAppearance.BorderSize = 0;
            this.buttonClientesFrecuentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClientesFrecuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientesFrecuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientesFrecuentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClientesFrecuentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientesFrecuentes.Location = new System.Drawing.Point(-3, 37);
            this.buttonClientesFrecuentes.Name = "buttonClientesFrecuentes";
            this.buttonClientesFrecuentes.Size = new System.Drawing.Size(207, 28);
            this.buttonClientesFrecuentes.TabIndex = 13;
            this.buttonClientesFrecuentes.Text = "Clientes Frecuentes";
            this.buttonClientesFrecuentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClientesFrecuentes.UseVisualStyleBackColor = true;
            this.buttonClientesFrecuentes.Click += new System.EventHandler(this.ButtonClientesFrecuentes_Click);
            // 
            // buttonTicketsEmitidos
            // 
            this.buttonTicketsEmitidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTicketsEmitidos.FlatAppearance.BorderSize = 0;
            this.buttonTicketsEmitidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonTicketsEmitidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketsEmitidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTicketsEmitidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicketsEmitidos.Location = new System.Drawing.Point(0, 3);
            this.buttonTicketsEmitidos.Name = "buttonTicketsEmitidos";
            this.buttonTicketsEmitidos.Size = new System.Drawing.Size(204, 28);
            this.buttonTicketsEmitidos.TabIndex = 12;
            this.buttonTicketsEmitidos.Text = "Tickets Emitidos";
            this.buttonTicketsEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTicketsEmitidos.UseVisualStyleBackColor = true;
            // 
            // panelDesPedidos
            // 
            this.panelDesPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesPedidos.Controls.Add(this.buttonInvalidarPedido);
            this.panelDesPedidos.Controls.Add(this.buttonCrearPedido);
            this.panelDesPedidos.Location = new System.Drawing.Point(0, 318);
            this.panelDesPedidos.Name = "panelDesPedidos";
            this.panelDesPedidos.Size = new System.Drawing.Size(156, 81);
            this.panelDesPedidos.TabIndex = 17;
            // 
            // buttonInvalidarPedido
            // 
            this.buttonInvalidarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvalidarPedido.FlatAppearance.BorderSize = 0;
            this.buttonInvalidarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonInvalidarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvalidarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvalidarPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInvalidarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvalidarPedido.Location = new System.Drawing.Point(-3, 37);
            this.buttonInvalidarPedido.Name = "buttonInvalidarPedido";
            this.buttonInvalidarPedido.Size = new System.Drawing.Size(159, 28);
            this.buttonInvalidarPedido.TabIndex = 13;
            this.buttonInvalidarPedido.Text = "Invalidar Pedido";
            this.buttonInvalidarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInvalidarPedido.UseVisualStyleBackColor = true;
            this.buttonInvalidarPedido.Click += new System.EventHandler(this.ButtonInvalidarPedido_Click);
            // 
            // buttonCrearPedido
            // 
            this.buttonCrearPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearPedido.FlatAppearance.BorderSize = 0;
            this.buttonCrearPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCrearPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrearPedido.Location = new System.Drawing.Point(0, 3);
            this.buttonCrearPedido.Name = "buttonCrearPedido";
            this.buttonCrearPedido.Size = new System.Drawing.Size(156, 28);
            this.buttonCrearPedido.TabIndex = 12;
            this.buttonCrearPedido.Text = "Crear Pedido";
            this.buttonCrearPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCrearPedido.UseVisualStyleBackColor = true;
            this.buttonCrearPedido.Click += new System.EventHandler(this.ButtonCrearPedido_Click);
            // 
            // panelDesPagos
            // 
            this.panelDesPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesPagos.Controls.Add(this.buttonServiciosB);
            this.panelDesPagos.Controls.Add(this.buttonBalanCuentas);
            this.panelDesPagos.Location = new System.Drawing.Point(0, 365);
            this.panelDesPagos.Name = "panelDesPagos";
            this.panelDesPagos.Size = new System.Drawing.Size(215, 83);
            this.panelDesPagos.TabIndex = 16;
            // 
            // buttonServiciosB
            // 
            this.buttonServiciosB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServiciosB.FlatAppearance.BorderSize = 0;
            this.buttonServiciosB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonServiciosB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServiciosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServiciosB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonServiciosB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServiciosB.Location = new System.Drawing.Point(1, 39);
            this.buttonServiciosB.Name = "buttonServiciosB";
            this.buttonServiciosB.Size = new System.Drawing.Size(204, 28);
            this.buttonServiciosB.TabIndex = 14;
            this.buttonServiciosB.Text = "Servicio Básicos";
            this.buttonServiciosB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonServiciosB.UseVisualStyleBackColor = true;
            this.buttonServiciosB.Click += new System.EventHandler(this.ButtonServiciosB_Click);
            // 
            // buttonBalanCuentas
            // 
            this.buttonBalanCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBalanCuentas.FlatAppearance.BorderSize = 0;
            this.buttonBalanCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonBalanCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalanCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalanCuentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBalanCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBalanCuentas.Location = new System.Drawing.Point(2, 2);
            this.buttonBalanCuentas.Name = "buttonBalanCuentas";
            this.buttonBalanCuentas.Size = new System.Drawing.Size(204, 28);
            this.buttonBalanCuentas.TabIndex = 13;
            this.buttonBalanCuentas.Text = "Balance de Cuentas";
            this.buttonBalanCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBalanCuentas.UseVisualStyleBackColor = true;
            // 
            // panelDesAdmin
            // 
            this.panelDesAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesAdmin.Controls.Add(this.buttonAdminSistema);
            this.panelDesAdmin.Controls.Add(this.buttonAdminParam);
            this.panelDesAdmin.Location = new System.Drawing.Point(0, 416);
            this.panelDesAdmin.Name = "panelDesAdmin";
            this.panelDesAdmin.Size = new System.Drawing.Size(134, 77);
            this.panelDesAdmin.TabIndex = 1;
            // 
            // buttonAdminSistema
            // 
            this.buttonAdminSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminSistema.FlatAppearance.BorderSize = 0;
            this.buttonAdminSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAdminSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminSistema.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdminSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminSistema.Location = new System.Drawing.Point(-3, 37);
            this.buttonAdminSistema.Name = "buttonAdminSistema";
            this.buttonAdminSistema.Size = new System.Drawing.Size(134, 28);
            this.buttonAdminSistema.TabIndex = 13;
            this.buttonAdminSistema.Text = "Sistema";
            this.buttonAdminSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdminSistema.UseVisualStyleBackColor = true;
            this.buttonAdminSistema.Click += new System.EventHandler(this.ButtonAdminSistema_Click);
            // 
            // buttonAdminParam
            // 
            this.buttonAdminParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminParam.FlatAppearance.BorderSize = 0;
            this.buttonAdminParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAdminParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminParam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdminParam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminParam.Location = new System.Drawing.Point(0, 3);
            this.buttonAdminParam.Name = "buttonAdminParam";
            this.buttonAdminParam.Size = new System.Drawing.Size(131, 28);
            this.buttonAdminParam.TabIndex = 12;
            this.buttonAdminParam.Text = "Parámetros";
            this.buttonAdminParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdminParam.UseVisualStyleBackColor = true;
            this.buttonAdminParam.Click += new System.EventHandler(this.ButtonAdminParam_Click);
            // 
            // panelDesAyuda
            // 
            this.panelDesAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDesAyuda.Controls.Add(this.buttonAcerca);
            this.panelDesAyuda.Controls.Add(this.buttonManual);
            this.panelDesAyuda.Controls.Add(this.buttonInfoSistema);
            this.panelDesAyuda.Location = new System.Drawing.Point(0, 471);
            this.panelDesAyuda.Name = "panelDesAyuda";
            this.panelDesAyuda.Size = new System.Drawing.Size(230, 118);
            this.panelDesAyuda.TabIndex = 0;
            this.panelDesAyuda.Visible = false;
            this.panelDesAyuda.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // buttonAcerca
            // 
            this.buttonAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcerca.FlatAppearance.BorderSize = 0;
            this.buttonAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcerca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcerca.Location = new System.Drawing.Point(0, 72);
            this.buttonAcerca.Name = "buttonAcerca";
            this.buttonAcerca.Size = new System.Drawing.Size(230, 28);
            this.buttonAcerca.TabIndex = 13;
            this.buttonAcerca.Text = "Acerca del Sistema";
            this.buttonAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcerca.UseVisualStyleBackColor = true;
            this.buttonAcerca.Click += new System.EventHandler(this.ButtonAcerca_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManual.FlatAppearance.BorderSize = 0;
            this.buttonManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManual.Location = new System.Drawing.Point(-3, 38);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(230, 28);
            this.buttonManual.TabIndex = 12;
            this.buttonManual.Text = "Manual Usuario";
            this.buttonManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.ButtonManual_Click);
            // 
            // buttonInfoSistema
            // 
            this.buttonInfoSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoSistema.FlatAppearance.BorderSize = 0;
            this.buttonInfoSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonInfoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfoSistema.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInfoSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoSistema.Location = new System.Drawing.Point(-2, 3);
            this.buttonInfoSistema.Name = "buttonInfoSistema";
            this.buttonInfoSistema.Size = new System.Drawing.Size(230, 28);
            this.buttonInfoSistema.TabIndex = 11;
            this.buttonInfoSistema.Text = "Información del Sistema";
            this.buttonInfoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInfoSistema.UseVisualStyleBackColor = true;
            this.buttonInfoSistema.Click += new System.EventHandler(this.ButtonInfoSistema_Click);
            // 
            // labelTituloLoggin
            // 
            this.labelTituloLoggin.AutoSize = true;
            this.labelTituloLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTituloLoggin.Location = new System.Drawing.Point(412, 5);
            this.labelTituloLoggin.Name = "labelTituloLoggin";
            this.labelTituloLoggin.Size = new System.Drawing.Size(125, 33);
            this.labelTituloLoggin.TabIndex = 12;
            this.labelTituloLoggin.Text = "AUGUR";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "FormPrincipal";
            this.panelMenuVertical.ResumeLayout(false);
            this.panelMenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelDesIngredientes.ResumeLayout(false);
            this.panelDesClientes.ResumeLayout(false);
            this.panelDesPlatos.ResumeLayout(false);
            this.panelDesReportes.ResumeLayout(false);
            this.panelDesPedidos.ResumeLayout(false);
            this.panelDesPagos.ResumeLayout(false);
            this.panelDesAdmin.ResumeLayout(false);
            this.panelDesAyuda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonPagos;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonPlatosIng;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelTitulo1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelDesAyuda;
        private System.Windows.Forms.Button buttonInfoSistema;
        private System.Windows.Forms.Button buttonAcerca;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Panel panelDesAdmin;
        private System.Windows.Forms.Button buttonAdminSistema;
        private System.Windows.Forms.Button buttonAdminParam;
        private System.Windows.Forms.Panel panelDesPedidos;
        private System.Windows.Forms.Button buttonInvalidarPedido;
        private System.Windows.Forms.Button buttonCrearPedido;
        private System.Windows.Forms.Panel panelDesPagos;
        private System.Windows.Forms.Panel panelDesReportes;
        private System.Windows.Forms.Button buttonPlatosVendidos;
        private System.Windows.Forms.Button buttonClientesFrecuentes;
        private System.Windows.Forms.Button buttonTicketsEmitidos;
        private System.Windows.Forms.Panel panelDesPlatos;
        private System.Windows.Forms.Button buttonEliminarPlato;
        private System.Windows.Forms.Button buttonConsultarPlato;
        private System.Windows.Forms.Button buttonActualizarPlato;
        private System.Windows.Forms.Button buttonRegistraPlato;
        private System.Windows.Forms.Button buttonIngredientes;
        private System.Windows.Forms.Panel panelDesClientes;
        private System.Windows.Forms.Button buttonDarAlta;
        private System.Windows.Forms.Button buttonDarBaja;
        private System.Windows.Forms.Button buttonConsulCliente;
        private System.Windows.Forms.Button buttonActualizarCliente;
        private System.Windows.Forms.Button buttonRegistrarClientes;
        private System.Windows.Forms.Panel panelDesIngredientes;
        private System.Windows.Forms.Button buttonEliminarIngrdiente;
        private System.Windows.Forms.Button buttonConsultarIngrdiente;
        private System.Windows.Forms.Button buttonActulizarIngrediente;
        private System.Windows.Forms.Button buttonRegistrarIngrdientes;
        private System.Windows.Forms.Button buttonServiciosB;
        private System.Windows.Forms.Button buttonBalanCuentas;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Label labelTituloLoggin;
    }
}

