using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente
{
    public partial class ActualizarIngrediente : Form
    {
        public ActualizarIngrediente()
        {
            InitializeComponent();
        }

        private void validarPrecio(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == Convert.ToChar(Keys.Back));

        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrediente actualizado correctamente");
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
