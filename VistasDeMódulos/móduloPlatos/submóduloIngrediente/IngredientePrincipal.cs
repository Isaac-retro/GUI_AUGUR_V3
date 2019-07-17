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

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente
{
    public partial class IngredientePrincipal : Form
    {
        Label labelTitulo;
        public IngredientePrincipal(Usuario usuario, Label labelTitulo)
        {
            InitializeComponent();
            this.labelTitulo = labelTitulo;
        }

        private void validarCaracteres(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == Convert.ToChar(Keys.Back));

        }

        private void validarCaracteresNombre(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));

        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            int longitudNombre = this.textBoxNombreIngrediente.Text.Length;
            if(longitudNombre >= 3 && longitudNombre <= 50)
            {
                MessageBox.Show("Ingrediente registrado");
            }
            else
            {
                MessageBox.Show("La longitud del nombre del ingrediente debe estar entre:\n3 y 50 caracteres");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = this.dataGridView1.SelectedRows;

            foreach (var item in filas)
            {
                Console.WriteLine(item);
            }

            MessageBox.Show("Ingrediente eliminado correctamente");

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            ActualizarIngrediente ventanaActualizar = new ActualizarIngrediente();
            ventanaActualizar.Show();
        }
    }
}