using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class RegistrarActualzarPlatocs : Form{
        int idPlato;
        private Usuario user;
        public RegistrarActualzarPlatocs(string titulo, string funcion, Usuario user, int idPlato) {
            InitializeComponent();
            this.user = user;
            this.idPlato = idPlato;
            this.Text = titulo;

            if (funcion == "actualizar")
            {
                this.textBoxNombre.Visible = false;
                this.label2.Visible = false;
                this.buttonRegistrar.Visible = false;
            }
            else
            {
                this.buttonActualizar.Visible = false;
            }
            
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));
        }

        private void validarPrecio(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == Convert.ToChar(Keys.Back));

        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plato registrado correctamente");
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plato actualizado correctamente");
        }
    }
}
