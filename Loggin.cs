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
        private int iduserAux;
        private Usuario userObject;
        private ConexionLoggin conector = new ConexionLoggin();
        public Loggin() {
            InitializeComponent();
            camposblancos();
            count = 0;
            iduserAux = -1;

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
            userObject = conector.consultarUsuario(textBoxUserLoggin.Text);


            if (userObject != null){
                if (conector.md5_string(textBoxPassLoggin.Text) == userObject.getPass() && buttonIngresarLoggin.Enabled){
                    if (conector.registrarLog(userObject.obtenerIDUsuario()) > 0){
                        principal = new Principal(userObject);
                        principal.Visible = true;
                        this.Hide();
                    } else {
                        MessageBox.Show("Error del sistema, su acceso no pudo ser registrado");
                    }
                } else {
                    if (iduserAux < 0){
                        iduserAux = userObject.obtenerIDUsuario();
                    } else if (iduserAux == userObject.obtenerIDUsuario() && userObject.obtenerIDUsuario() != 2) {
                        count++;
                        if (count > 4 && conector.bloquearUsuario(userObject.obtenerIDUsuario()) > 0) {
                            MessageBox.Show("El usuario \"" + userObject.getNombreUsuario() + "\" ha sido bloqueado | Consulte al admnistrador");

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
