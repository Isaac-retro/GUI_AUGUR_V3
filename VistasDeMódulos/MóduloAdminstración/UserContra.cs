using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración
{
    public partial class UserContra : Form{
        private byte flag;
        private Usuario user, user_change;

        public UserContra(string titulo, string funcion, byte flag, Usuario user, Usuario user_change){
            InitializeComponent();
            textBoxCargo.Enabled = false;
            this.user = user;
            this.user_change = user_change;
            labelTitulo.Text = titulo;
            labelError.Visible = false;
            labelError.Text = "Error al " + funcion;
            this.flag = flag;
            if (flag == 0) {
                // crear usuario 0

            } else if (flag == 1) {
                // cambiar contrasenia 
                textBoxNombreUser.Enabled = false;
                textBoxLoggin.Enabled = false;
                textBoxLoggin.Text = user.getLoggin();
                textBoxNombreUser.Text = user.getNombreUsuario();
                textBoxCargo.Text = user.getCargo();
            } else {
                //restablercer contrasenia
                textBoxNombreUser.Enabled = false;
                textBoxLoggin.Enabled = false;
                textBoxCargo.Text = user_change.getCargo();
                textBoxLoggin.Text = user.getLoggin();
                textBoxNombreUser.Text = user.getNombreUsuario();
            }


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
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void TextBoxContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) ;
        }

        private void ButtonRegistrarC_Click(object sender, EventArgs e){
            if (textBoxLoggin.Text.Length < 2 || textBoxLoggin.Text.Length > 6){

                labelError.Visible = true;
            }  else {

            }

            if (flag == 0){
                // crear usuario 0

            } else if (flag == 1){
                // cambiar contrasenia
                
            } else {
                //restablercer contrasenia

            }

        }

        private void TextBoxLoggin_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void Label4_Click(object sender, EventArgs e){

        }
    }
}
