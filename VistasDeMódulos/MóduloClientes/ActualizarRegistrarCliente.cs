using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    public partial class ActualizarRegistrarCliente : Form
    {
        public ActualizarRegistrarCliente(string titulo, string funcion){
            InitializeComponent();
            labelError.Visible = false;
            labelError.Text = "Error al " + funcion + "Cliente";
            labelTitulo.Text = titulo;

            if(funcion == "registrar")
            {
                buttonActualizar.Visible = false;
            }
            else
            {
                
                buttonRegistrarC.Visible = false;
            }
            
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegistrarC_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "" || textBoxNombre.Text == "" || textBoxdirección.Text == "" || textBoxDocumento.Text == "" || textBoxTeléfono.Text == "") {
                labelError.Visible = true;

            } else {
                MessageBox.Show("Cliente Registrado Exitosamente");
                this.Close();

            }
            
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente actualizado Exitosamente");
        }
    }
}
