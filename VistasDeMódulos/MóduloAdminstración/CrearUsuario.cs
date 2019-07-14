using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario(){
            InitializeComponent();
            textBoxCargo.Enabled = false;


        }

        private void TextBox1_TextChanged(object sender, EventArgs e){

        }

        private void Label1_Click(object sender, EventArgs e){

        }

        private void ButtonCancelar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxNombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter);
        }

        private void TextBoxContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter);
        }
    }
}
