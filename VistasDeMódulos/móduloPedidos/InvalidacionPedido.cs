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
    public partial class InvalidacionPedido : Form
    {
        Label labelTitulo;
        public InvalidacionPedido(Usuario user, Label labelTitulo)
        {
            InitializeComponent();
            this.labelTitulo = labelTitulo;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido invalidado correctamente");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";

        }
    }
}
