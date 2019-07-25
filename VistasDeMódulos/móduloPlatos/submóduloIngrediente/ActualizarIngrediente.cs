using GUI_AUGUR_V3.DataBase;
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
        string idIngrediente;
        IngredientePrincipal padre;
        public ActualizarIngrediente(string id, IngredientePrincipal padre)
        {
            InitializeComponent();
            this.idIngrediente = id;
            this.padre = padre;
        }

        private void validarPrecio(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == Convert.ToChar(Keys.Back));

        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            try { 
                ConexionDB conexion = new ConexionDB();
                conexion.actualizarIngrediente(this.idIngrediente, (float)Convert.ToDouble(this.textBoxNuevoPrecio.Text), Convert.ToInt32(this.textBoxCantidad.Text));
                this.padre.refrescarListaIngredientes(this.padre.conector.consultarIngredientes());
                this.Close();
                MessageBox.Show("Ingrediente actualizado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
