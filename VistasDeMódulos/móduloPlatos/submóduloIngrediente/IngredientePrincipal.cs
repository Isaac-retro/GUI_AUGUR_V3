using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente
{
    public partial class IngredientePrincipal : Form
    {
        Label labelTitulo;
        public ConexionDB conector;
        public IngredientePrincipal(Usuario usuario, Label labelTitulo)
        {
            InitializeComponent();
            conector = new ConexionDB();
            this.labelTitulo = labelTitulo;
            refrescarListaIngredientes(conector.consultarIngredientes());
        }


        public void refrescarListaIngredientes(List<Ingrediente> ingredientes)
        {
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < ingredientes.Count; i++)
            {
                dataGridView1.Rows.Add(ingredientes[i].obtenerNombreIngrediente().ToString(), ingredientes[i].obtenerValorIngrediente().ToString(), ingredientes[i].obtnerCantidaddisponible());

            }
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
            try { 
                int longitudNombre = this.textBoxNombreIngrediente.Text.Length;
                if(longitudNombre >= 3 && longitudNombre <= 50)
                {
                    ConexionDB conexion = new ConexionDB();
                    conexion.crearIngrediente(new Ingrediente(100,this.textBoxNombreIngrediente.Text, (float)Convert.ToDouble(this.textBoxPrecioIngrediente.Text), (float)Convert.ToDouble(this.textBoxCantidad.Text), true));
                    refrescarListaIngredientes(conector.consultarIngredientes());
                    MessageBox.Show("Ingrediente registrado correctamente");
                    limpiarCajas();
                }
                else
                {
                    MessageBox.Show("La longitud del nombre del ingrediente debe estar entre:\n3 y 50 caracteres");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try{ 
            ConexionDB conexion = new ConexionDB();
            string nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            conexion.eliminarIngrediente(nombre);

            refrescarListaIngredientes(conector.consultarIngredientes());

            MessageBox.Show("Ingrediente eliminado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value != null)
                {
                    string nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    ActualizarIngrediente ventanaActualizar = new ActualizarIngrediente(nombre, this);
                    ventanaActualizar.Show();
                    
                    limpiarCajas();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            

            
        }

        private void limpiarCajas()
        {
            this.textBoxNombreIngrediente.Text = "";
            this.textBoxPrecioIngrediente.Text = "";
            this.textBoxCantidad.Text = "";
        }


    }
}