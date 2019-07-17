namespace GUI_AUGUR_V3
{
    partial class ReseteoContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReseteoContra));
            this.panelTituloLoggin = new System.Windows.Forms.Panel();
            this.labelTituloRest = new System.Windows.Forms.Label();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassLoggin = new System.Windows.Forms.TextBox();
            this.textBoxUserLoggin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAcpetar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelTituloLoggin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloLoggin
            // 
            this.panelTituloLoggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTituloLoggin.Controls.Add(this.labelTituloRest);
            this.panelTituloLoggin.Controls.Add(this.pictureBoxSalir);
            this.panelTituloLoggin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloLoggin.Location = new System.Drawing.Point(0, 0);
            this.panelTituloLoggin.Name = "panelTituloLoggin";
            this.panelTituloLoggin.Size = new System.Drawing.Size(640, 45);
            this.panelTituloLoggin.TabIndex = 1;
            // 
            // labelTituloRest
            // 
            this.labelTituloRest.AutoSize = true;
            this.labelTituloRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloRest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTituloRest.Location = new System.Drawing.Point(37, 7);
            this.labelTituloRest.Name = "labelTituloRest";
            this.labelTituloRest.Size = new System.Drawing.Size(289, 29);
            this.labelTituloRest.TabIndex = 11;
            this.labelTituloRest.Text = "Restabelcer contraseña";
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(602, 3);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 1;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.PictureBoxSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBoxPassLoggin
            // 
            this.textBoxPassLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBoxPassLoggin.Location = new System.Drawing.Point(150, 185);
            this.textBoxPassLoggin.Name = "textBoxPassLoggin";
            this.textBoxPassLoggin.ShortcutsEnabled = false;
            this.textBoxPassLoggin.Size = new System.Drawing.Size(443, 26);
            this.textBoxPassLoggin.TabIndex = 18;
            this.textBoxPassLoggin.UseSystemPasswordChar = true;
            this.textBoxPassLoggin.TextChanged += new System.EventHandler(this.TextBoxPassLoggin_TextChanged);
            this.textBoxPassLoggin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassLoggin_KeyPress);
            // 
            // textBoxUserLoggin
            // 
            this.textBoxUserLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBoxUserLoggin.Location = new System.Drawing.Point(150, 152);
            this.textBoxUserLoggin.Name = "textBoxUserLoggin";
            this.textBoxUserLoggin.ShortcutsEnabled = false;
            this.textBoxUserLoggin.Size = new System.Drawing.Size(443, 26);
            this.textBoxUserLoggin.TabIndex = 17;
            this.textBoxUserLoggin.UseSystemPasswordChar = true;
            this.textBoxUserLoggin.UseWaitCursor = true;
            this.textBoxUserLoggin.TextChanged += new System.EventHandler(this.TextBoxUserLoggin_TextChanged);
            this.textBoxUserLoggin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUserLoggin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(38, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(38, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "De nuevo";
            // 
            // buttonAcpetar
            // 
            this.buttonAcpetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcpetar.FlatAppearance.BorderSize = 0;
            this.buttonAcpetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAcpetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcpetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcpetar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAcpetar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcpetar.Location = new System.Drawing.Point(150, 272);
            this.buttonAcpetar.Name = "buttonAcpetar";
            this.buttonAcpetar.Size = new System.Drawing.Size(123, 29);
            this.buttonAcpetar.TabIndex = 21;
            this.buttonAcpetar.Text = "Aceptar";
            this.buttonAcpetar.UseVisualStyleBackColor = true;
            this.buttonAcpetar.Click += new System.EventHandler(this.ButtonAcpetar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(345, 272);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(123, 29);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ReseteoContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 313);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcpetar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassLoggin);
            this.Controls.Add(this.textBoxUserLoggin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTituloLoggin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReseteoContra";
            this.Text = "ReseteoContra";
            this.panelTituloLoggin.ResumeLayout(false);
            this.panelTituloLoggin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloLoggin;
        private System.Windows.Forms.Label labelTituloRest;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassLoggin;
        private System.Windows.Forms.TextBox textBoxUserLoggin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAcpetar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}