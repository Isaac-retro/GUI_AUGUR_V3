using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3
{
    public partial class ReseteoContra : Form
    {

        private ConexionDB conector;
        private int id;
        private Principal principal;
        public ReseteoContra(Usuario usuario, Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            conector = new ConexionDB();
            label1.Text = "Estimado " +usuario.obtenerNombreUsuario() + " debido a que es la primera vez que ingresas al\nprograma debes reestablecer tu contraseña\nPor favor ingresa tu nueva contraseña ";
            id = usuario.obtenerIDUsuario();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUserLoggin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPassLoggin_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAcpetar_Click(object sender, EventArgs e)
        {

            if(textBoxUserLoggin.Text == textBoxPassLoggin.Text && textBoxPassLoggin.Text.Length > 7 && textBoxPassLoggin.Text.Length < 17){
                conector.cambiarContrassniaID(id, textBoxUserLoggin.Text);
                principal.Visible = true;
                this.Close();
            } else {
                MessageBox.Show("Las contraseñas no coinciden");
                textBoxUserLoggin.Text = "";
                textBoxPassLoggin.Text = "";
            }

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxUserLoggin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void TextBoxPassLoggin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
