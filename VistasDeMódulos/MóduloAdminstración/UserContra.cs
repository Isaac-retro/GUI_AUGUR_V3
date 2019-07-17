using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración
{
    public partial class UserContra : Form{
        private byte flag;
        private Usuario user;
        private Usuario usuarioCambiar;
        private ConexionDB conector;

        public UserContra(string titulo, string funcion, byte flag, Usuario user, int idUsuarioCambiar){
            InitializeComponent();
            conector = new ConexionDB();
            textBoxCargo.Enabled = false;
            this.user = user;
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
                textBoxLoggin.Text = user.obtenerLoggin();
                textBoxNombreUser.Text = user.obtenerNombreUsuario();
                textBoxCargo.Text = user.obtenerCargo();
            } else {
                //restablercer contrasenia
                textBoxNombreUser.Enabled = false;
                textBoxLoggin.Enabled = false;
                usuarioCambiar = conector.consultarUsuarioId(idUsuarioCambiar);
                textBoxCargo.Text = usuarioCambiar.obtenerCargo();
                textBoxLoggin.Text = usuarioCambiar.obtenerLoggin();
                textBoxNombreUser.Text = usuarioCambiar.obtenerNombreUsuario();
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
            
            if ((textBoxLoggin.Text.Length < 2 || textBoxLoggin.Text.Length > 6) && (textBoxContra.Text.Length < 8 || textBoxContra.Text.Length > 16)  ){
                if (flag == 0)
                {
                    // crear usuario 0
                    if (conector.registrarUsuario(textBoxNombreUser.Text, textBoxLoggin.Text, textBoxContra.Text) > 0)
                    {
                        MessageBox.Show("Usuario ingresado exitosamente");
                        this.Close();
                    }
                    else {
                        labelError.Visible = true;
                    }
                }
                else if (flag == 1)
                {
                    // cambiar contrasenia

                }
                else
                {
                    //restablercer contrasenia

                }

            }  else {
                labelError.Visible = true;
            }

            

        }

        private void TextBoxLoggin_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void Label4_Click(object sender, EventArgs e){

        }
    }
}
