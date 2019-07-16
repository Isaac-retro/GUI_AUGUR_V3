using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3 {
    public partial class Loggin : Form {
        //  esta variable sirve para abrir la pantalla de munú principal
        private Form principal;

        //contador para el número de veces que un usuario se equivoca al ingresar su contraseña
        private byte contador;
        private int idUsuarioAux; //auxiliar para comparar los usuarios que han intentado loguarse y cambian de usuario reiniciando el conteo de count
        private Usuario usuarioObjeto; //usuario obtenido de la consulta al loguarse, se pasa como parámetro a la siguiente ventana
        private ConexionLoggin conector = new ConexionLoggin();
        public Loggin() {
            InitializeComponent();
            camposblancos();
            contador = 0;
            idUsuarioAux = -1;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  //librerias para que la ventana se mueva 
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
            usuarioObjeto = conector.consultarUsuario(textBoxUserLoggin.Text);
            if (usuarioObjeto != null){
                if (conector.md5_string(textBoxPassLoggin.Text) == usuarioObjeto.getPass() && buttonIngresarLoggin.Enabled){
                    if (conector.registrarLog(usuarioObjeto.getIdUser()) > 0){
                        principal = new Principal(usuarioObjeto);
                        principal.Visible = true;
                        this.Hide();
                    } else {
                        MessageBox.Show("Error del sistema, su acceso no pudo ser registrado");
                    }
                } else {
                    if (idUsuarioAux < 0){
                        idUsuarioAux = usuarioObjeto.getIdUser();
                    } else if (idUsuarioAux == usuarioObjeto.getIdUser() && usuarioObjeto.getIdUser() != 2) {
                        contador++;
                        if (contador > 4 && conector.bloquearUsuario(usuarioObjeto.getIdUser()) > 0) {
                            MessageBox.Show("El usuario \"" + usuarioObjeto.getNombreUsuario() + "\" ha sido bloqueado | Consulte al admnistrador");

                        }
                    } else  {
                        contador = 0;
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
