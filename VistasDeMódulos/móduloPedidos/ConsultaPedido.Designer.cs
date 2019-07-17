namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPedidos
{
    partial class ConsultaPedido
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombrePlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePlato,
            this.precioPlato,
            this.cantidadPlato});
            this.dataGridView1.Location = new System.Drawing.Point(327, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombrePlato
            // 
            this.nombrePlato.Frozen = true;
            this.nombrePlato.HeaderText = "Plato pedido";
            this.nombrePlato.Name = "nombrePlato";
            this.nombrePlato.ReadOnly = true;
            // 
            // precioPlato
            // 
            this.precioPlato.Frozen = true;
            this.precioPlato.HeaderText = "precio";
            this.precioPlato.Name = "precioPlato";
            this.precioPlato.ReadOnly = true;
            // 
            // cantidadPlato
            // 
            this.cantidadPlato.HeaderText = "cantidad";
            this.cantidadPlato.Name = "cantidadPlato";
            this.cantidadPlato.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificador del pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaPedido";
            this.Text = "ConsultaPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPlato;
    }
}