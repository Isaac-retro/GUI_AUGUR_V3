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
    public partial class CreacionPedido : Form
    {
        Label labelTitulo;
        public CreacionPedido(Usuario user, Label labelTitulo)
        {
            InitializeComponent();
            this.labelTitulo = labelTitulo;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                MessageBox.Show("Pedido generado por Ticket exitosamente");
            }
            if (this.radioButton2.Checked)
            {
                MessageBox.Show("Pedido generado por Factura exitosamente");
            }
        }

        private void validarCedula(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));
            if (this.textBoxNombre.Text.Length > 10)
                MessageBox.Show("Cédula demasiado larga");
        }
    }
}
