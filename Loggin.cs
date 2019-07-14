using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3 {
    public partial class Loggin : Form {
        private Form principal;
        private byte count;
        private int iduser_aux;
        private Usuario user_object;
        private ConexionLoggin conector = new ConexionLoggin();
        public Loggin() {
            InitializeComponent();
            camposblancos();
            count = 0;
            iduser_aux = -1;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void camposblancos() {
            textBoxUserLoggin.BackColor = Color.White;
            textBoxPassLoggin.BackColor = Color.White;
            textBoxPassLoggin.Text = "";
            labelErrorLoggin.Visible = false;
            buttonIngresarLoggin.Enabled = false;
        }
        private void camposError() {
            textBoxUserLoggin.BackColor = Color.Pink;
            textBoxPassLoggin.BackColor = Color.Pink;
            labelErrorLoggin.Visible = true;
            buttonIngresarLoggin.Enabled = false;

        }
        private void validarAcceso() {
            user_object = conector.consultarUsuario(textBoxUserLoggin.Text);
            if (user_object != null){
                if (conector.md5_string(textBoxPassLoggin.Text) == user_object.getPass() && buttonIngresarLoggin.Enabled){
                    principal = new Principal(user_object);
                    principal.Visible = true;
                    this.Hide();
                } else {
                    if (iduser_aux < 0){
                        iduser_aux = user_object.getIdUser();
                    } else if (iduser_aux == user_object.getIdUser() && user_object.getIdUser() != 2) {
                        count++;
                        if (count > 4 && conector.bloquearUsuario(user_object.getIdUser()) > 0) {
                            MessageBox.Show("El usuario \"" + user_object.getNombreUsuario() + "\" ha sido bloqueado | Consulte al admnistrador");

                        }
                    } else  {
                        count = 0;
                    }
                    camposError();
                }
            } else {
                camposError();
            }
        }          

        private void PictureBoxSalir_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void ButtonIngresarLoggin_Click(object sender, EventArgs e){
            validarAcceso();
        }

        private void ButtonSalirLoggin_Click(object sender, EventArgs e){
            Application.Exit();

        }

        private void TextBoxUserLoggin_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);

        }

        private void TextBoxPassLoggin_TextChanged(object sender, EventArgs e){
            

        }

        private void Loggin_Load(object sender, EventArgs e){

        }

        private void PanelTituloLoggin_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TextBoxPassLoggin_KeyUp(object sender, KeyEventArgs e){
            buttonIngresarLoggin.Enabled = (textBoxUserLoggin.Text.Length > 2 || textBoxUserLoggin.Text.Length < 7) && (textBoxPassLoggin.Text.Length > 7 || textBoxPassLoggin.Text.Length < 17);
        }

        private void LabelTituloLoggin_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TextBoxPassLoggin_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                validarAcceso();
            }
        }

        private void TextBoxUserLoggin_TextChanged(object sender, EventArgs e){

        }

        private void TextBoxUserLoggin_Enter(object sender, EventArgs e){
            camposblancos();
        }

        private void TextBoxPassLoggin_Enter(object sender, EventArgs e){
            camposblancos();
        }

        private void TextBoxUserLoggin_KeyUp(object sender, KeyEventArgs e)
        {
            buttonIngresarLoggin.Enabled = (textBoxUserLoggin.Text.Length > 2 || textBoxUserLoggin.Text.Length < 7) && (textBoxPassLoggin.Text.Length > 7 || textBoxPassLoggin.Text.Length < 17);
        }
    }
}
