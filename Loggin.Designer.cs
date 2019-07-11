namespace GUI_AUGUR_V3
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            this.panelTituloLoggin = new System.Windows.Forms.Panel();
            this.labelTituloLoggin = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserLoggin = new System.Windows.Forms.TextBox();
            this.textBoxPassLoggin = new System.Windows.Forms.TextBox();
            this.buttonIngresarLoggin = new System.Windows.Forms.Button();
            this.buttonSalirLoggin = new System.Windows.Forms.Button();
            this.labelErrorLoggin = new System.Windows.Forms.Label();
            this.panelTituloLoggin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloLoggin
            // 
            this.panelTituloLoggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTituloLoggin.Controls.Add(this.labelTituloLoggin);
            this.panelTituloLoggin.Controls.Add(this.pictureBoxSalir);
            this.panelTituloLoggin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloLoggin.Location = new System.Drawing.Point(0, 0);
            this.panelTituloLoggin.Name = "panelTituloLoggin";
            this.panelTituloLoggin.Size = new System.Drawing.Size(308, 45);
            this.panelTituloLoggin.TabIndex = 0;
            this.panelTituloLoggin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTituloLoggin_MouseDown);
            // 
            // labelTituloLoggin
            // 
            this.labelTituloLoggin.AutoSize = true;
            this.labelTituloLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloLoggin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTituloLoggin.Location = new System.Drawing.Point(37, 7);
            this.labelTituloLoggin.Name = "labelTituloLoggin";
            this.labelTituloLoggin.Size = new System.Drawing.Size(227, 29);
            this.labelTituloLoggin.TabIndex = 11;
            this.labelTituloLoggin.Text = "Acceso al Sistema";
            this.labelTituloLoggin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTituloLoggin_MouseDown);
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(270, 3);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 1;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.PictureBoxSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Constraseña";
            // 
            // textBoxUserLoggin
            // 
            this.textBoxUserLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBoxUserLoggin.Location = new System.Drawing.Point(141, 287);
            this.textBoxUserLoggin.Name = "textBoxUserLoggin";
            this.textBoxUserLoggin.ShortcutsEnabled = false;
            this.textBoxUserLoggin.Size = new System.Drawing.Size(155, 26);
            this.textBoxUserLoggin.TabIndex = 15;
            this.textBoxUserLoggin.TextChanged += new System.EventHandler(this.TextBoxUserLoggin_TextChanged);
            this.textBoxUserLoggin.Enter += new System.EventHandler(this.TextBoxUserLoggin_Enter);
            this.textBoxUserLoggin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUserLoggin_KeyPress);
            // 
            // textBoxPassLoggin
            // 
            this.textBoxPassLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBoxPassLoggin.Location = new System.Drawing.Point(141, 320);
            this.textBoxPassLoggin.Name = "textBoxPassLoggin";
            this.textBoxPassLoggin.ShortcutsEnabled = false;
            this.textBoxPassLoggin.Size = new System.Drawing.Size(155, 26);
            this.textBoxPassLoggin.TabIndex = 16;
            this.textBoxPassLoggin.UseSystemPasswordChar = true;
            this.textBoxPassLoggin.TextChanged += new System.EventHandler(this.TextBoxPassLoggin_TextChanged);
            this.textBoxPassLoggin.Enter += new System.EventHandler(this.TextBoxPassLoggin_Enter);
            this.textBoxPassLoggin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassLoggin_KeyPress);
            this.textBoxPassLoggin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassLoggin_KeyUp);
            // 
            // buttonIngresarLoggin
            // 
            this.buttonIngresarLoggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresarLoggin.FlatAppearance.BorderSize = 0;
            this.buttonIngresarLoggin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonIngresarLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresarLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonIngresarLoggin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIngresarLoggin.Location = new System.Drawing.Point(16, 387);
            this.buttonIngresarLoggin.Name = "buttonIngresarLoggin";
            this.buttonIngresarLoggin.Size = new System.Drawing.Size(123, 29);
            this.buttonIngresarLoggin.TabIndex = 17;
            this.buttonIngresarLoggin.Text = "Ingresar";
            this.buttonIngresarLoggin.UseVisualStyleBackColor = true;
            this.buttonIngresarLoggin.Click += new System.EventHandler(this.ButtonIngresarLoggin_Click);
            // 
            // buttonSalirLoggin
            // 
            this.buttonSalirLoggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalirLoggin.FlatAppearance.BorderSize = 0;
            this.buttonSalirLoggin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSalirLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalirLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSalirLoggin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalirLoggin.Location = new System.Drawing.Point(173, 387);
            this.buttonSalirLoggin.Name = "buttonSalirLoggin";
            this.buttonSalirLoggin.Size = new System.Drawing.Size(123, 29);
            this.buttonSalirLoggin.TabIndex = 18;
            this.buttonSalirLoggin.Text = "Salir";
            this.buttonSalirLoggin.UseVisualStyleBackColor = true;
            this.buttonSalirLoggin.Click += new System.EventHandler(this.ButtonSalirLoggin_Click);
            // 
            // labelErrorLoggin
            // 
            this.labelErrorLoggin.AutoSize = true;
            this.labelErrorLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelErrorLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelErrorLoggin.Location = new System.Drawing.Point(18, 255);
            this.labelErrorLoggin.Name = "labelErrorLoggin";
            this.labelErrorLoggin.Size = new System.Drawing.Size(278, 20);
            this.labelErrorLoggin.TabIndex = 19;
            this.labelErrorLoggin.Text = "Usuario o Contraseña incorrectos";
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.labelErrorLoggin);
            this.Controls.Add(this.buttonSalirLoggin);
            this.Controls.Add(this.buttonIngresarLoggin);
            this.Controls.Add(this.textBoxPassLoggin);
            this.Controls.Add(this.textBoxUserLoggin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTituloLoggin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loggin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loggin";
            this.Load += new System.EventHandler(this.Loggin_Load);
            this.panelTituloLoggin.ResumeLayout(false);
            this.panelTituloLoggin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloLoggin;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTituloLoggin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserLoggin;
        private System.Windows.Forms.TextBox textBoxPassLoggin;
        private System.Windows.Forms.Button buttonIngresarLoggin;
        private System.Windows.Forms.Button buttonSalirLoggin;
        private System.Windows.Forms.Label labelErrorLoggin;
    }
}