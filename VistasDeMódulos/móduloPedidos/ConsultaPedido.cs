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

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPedidos
{
    public partial class ConsultaPedido : Form
    {
        Label labelTitulo;
        public ConsultaPedido(Usuario user, Label labelTitulo)
        {
            InitializeComponent();
            this.labelTitulo = labelTitulo;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("Plato " + i, "Precio" + i, "N COMPRAS XYZ");

            }
        }
    }
}
