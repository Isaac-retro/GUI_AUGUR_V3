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
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenuVertical.Controls.Add(this.labelUserId);
            this.panelMenuVertical.Controls.Add(this.labelUser);
            this.panelMenuVertical.Controls.Add(this.pictureBox1);
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
            // labelUserId
            // 
            this.labelUserId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserId.Location = new System.Drawing.Point(86, 621);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(90, 20);
            this.labelUserId.TabIndex = 14;
            this.labelUserId.Text = "UsuarioID";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUser.Location = new System.Drawing.Point(86, 590);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 20);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 590);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitulo.Controls.Add(this.labelTitulo);
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
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitulo.Location = new System.Drawing.Point(412, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(125, 33);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "AUGUR";
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
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 605);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
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
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserId;
    }
}

