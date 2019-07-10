using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_AUGUR_V3 {
    public partial class Loggin : Form {
        private Form principal;
        public Loggin() {
            InitializeComponent();
            camposblancos();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void camposblancos() {
            textBoxUserLoggin.BackColor = Color.White;
            textBoxPassLoggin.BackColor = Color.White;
            labelErrorLoggin.Visible = false;
        }
        private void camposError() {
            textBoxUserLoggin.BackColor = Color.Pink;
            textBoxPassLoggin.BackColor = Color.Pink;
            textBoxPassLoggin.Text = "";
            labelErrorLoggin.Visible = true;

        }
        private void validarAcceso() {
            if (conector.validarLoggin(textBoxUserLoggin.Text,textBoxPassLoggin.Text) ) {
                principal = new Principal();
                principal.Visible = true;
                this.Hide();
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
            camposblancos();

        }

        private void TextBoxPassLoggin_TextChanged(object sender, EventArgs e){
            camposblancos();

        }

        private void Loggin_Load(object sender, EventArgs e){

        }

        private void PanelTituloLoggin_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TextBoxPassLoggin_KeyUp(object sender, KeyEventArgs e){
            
        }

        private void LabelTituloLoggin_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TextBoxPassLoggin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                validarAcceso();
            } 
        }

        private void TextBoxUserLoggin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
