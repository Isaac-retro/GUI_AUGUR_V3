using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_AUGUR_V3.ModelosClases;


namespace GUI_AUGUR_V3.VistasDeMódulos.móduloReportes
{
    public partial class RPlatosMasVendidos : Form
    {
        Label titulo;
        public RPlatosMasVendidos(Usuario usuario, Label titulo)
        {
            InitializeComponent();
            this.titulo = titulo;
        }

        private void ButtonConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("PLATO " + i, "PRECIO " + i, "N veces");

            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.titulo.Text = "AUGUR";
        }
    }
}
