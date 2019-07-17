using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class PlatosPrincipal : Form{
        Form registrarActualizarP;
        Usuario user;
        Label labelTitulo;
        public PlatosPrincipal(Usuario user, Label labelTitulo){
            InitializeComponent();
            this.user = user;
            this.labelTitulo = labelTitulo; 
        }


        private void validarCaracteres(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));

            if (this.textBoxNombre.Text.Length > 50)
                MessageBox.Show("Nombre demasiado largo");
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plato X eliminado exitosamente");
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";

        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs("Registro de plato de comida", "registar", user, 0);
            registrarActualizarP.Show();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs("Actualización de un plato de comida", "actualizar", user, 0);
            registrarActualizarP.Show();
        }
    }
}
