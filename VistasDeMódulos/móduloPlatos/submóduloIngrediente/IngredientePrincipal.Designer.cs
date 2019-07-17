namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente
{
    partial class IngredientePrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxPrecioIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del ingrediente";
            // 
            // textBoxNombreIngrediente
            // 
            this.textBoxNombreIngrediente.Location = new System.Drawing.Point(342, 53);
            this.textBoxNombreIngrediente.Name = "textBoxNombreIngrediente";
            this.textBoxNombreIngrediente.Size = new System.Drawing.Size(206, 20);
            this.textBoxNombreIngrediente.TabIndex = 1;
            this.textBoxNombreIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCaracteresNombre);
            // 
            // textBoxPrecioIngrediente
            // 
            this.textBoxPrecioIngrediente.Location = new System.Drawing.Point(341, 86);
            this.textBoxPrecioIngrediente.Name = "textBoxPrecioIngrediente";
            this.textBoxPrecioIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioIngrediente.TabIndex = 2;
            this.textBoxPrecioIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCaracteres);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(18, 347);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(197, 67);
            this.buttonEliminar.TabIndex = 34;
            this.buttonEliminar.Text = "Eliminar ingrediente seleccionado";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrar.Location = new System.Drawing.Point(565, 53);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(170, 45);
            this.buttonRegistrar.TabIndex = 33;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(526, 358);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(170, 45);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(272, 350);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(216, 60);
            this.buttonActualizar.TabIndex = 31;
            this.buttonActualizar.Text = "Actualizar ingrediente seleccionado";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 223);
            this.dataGridView1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "dólares";
            // 
            // IngredientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrecioIngrediente);
            this.Controls.Add(this.textBoxNombreIngrediente);
            this.Controls.Add(this.label1);
            this.Name = "IngredientePrincipal";
            this.Text = "Ingredientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreIngrediente;
        private System.Windows.Forms.TextBox textBoxPrecioIngrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}