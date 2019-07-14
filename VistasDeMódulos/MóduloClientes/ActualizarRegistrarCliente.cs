using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    public partial class ActualizarRegistrarCliente : Form
    {
        public ActualizarRegistrarCliente(string funcion_name,string funcion){
            InitializeComponent();
            label1.Visible = false;
            label1.Text = "Error al " + funcion + "Cliente";
            labelTitulo.Text = funcion_name;
            buttonRegistrarC.Text = funcion;
            
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
                label1.Visible = true;

            } else {
                MessageBox.Show("Cliente Registrado Exitosamente");
                this.Close();

            }
            
        }
    }
}
