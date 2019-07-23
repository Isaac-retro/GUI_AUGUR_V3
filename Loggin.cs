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


        //auxiliar para comparar los usuarios que han intentado loguarse y cambian de usuario reiniciando el conteo de count
        private int idUsuarioAux;

        //usuario obtenido de la consulta al loguarse, se pasa como parámetro a la siguiente ventana
        private Usuario usuarioObjeto;

        // de la clase ConexionDB el objeto controla las conexiones a base de datos a SQL en esta clase
        private ConexionDB conector = new ConexionDB();


        private ReseteoContra primer;
        /// <summary>
        /// Constructor del Form
        /// </summary>
        public Loggin() {
            InitializeComponent();
            camposblancos();
            contador = 0;
            idUsuarioAux = -1;


        }

        /// <summary>
        /// Importacion de librerias para mover las ventanas a traves de la pantalla
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  //librerias para que la ventana se mueva 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /// <summary>
        /// coloca todos los campos de texto en colo blanco y limpia el campo de texto de la contraseña
        /// </summary>
        private void camposblancos() {
            textBoxUserLoggin.BackColor = Color.White;
            textBoxPassLoggin.BackColor = Color.White;
            textBoxPassLoggin.Text = "";
            labelErrorLoggin.Visible = false;
            buttonIngresarLoggin.Enabled = false;
        }

        /// <summary>
        /// coloca los campos en color rosa y limpia el campo de contraseña y muestra el label de Error de ingreso
        /// </summary>
        private void camposError() {
            textBoxUserLoggin.BackColor = Color.Pink;
            textBoxPassLoggin.BackColor = Color.Pink;
            textBoxPassLoggin.Text = "";
            labelErrorLoggin.Visible = true;
            buttonIngresarLoggin.Enabled = false;

        }


        /// <summary>
        /// Valida un usuario consultado en la base de datos y compara el hash en md5 de la contraseña
        /// guardada en la base con la ingresada
        /// si es correcta entonces permite el ingreso al sistema, si no, entonces muestra error
        /// </summary>
        private void validarAcceso() {
            usuarioObjeto = conector.consultarUsuario(textBoxUserLoggin.Text);
            if (usuarioObjeto != null && (textBoxUserLoggin.Text.Length > 2 || textBoxUserLoggin.Text.Length < 7) && (textBoxPassLoggin.Text.Length > 7 || textBoxPassLoggin.Text.Length < 17)){
                if (conector.md5_string(textBoxPassLoggin.Text) == usuarioObjeto.obtenerPass() && buttonIngresarLoggin.Enabled){

                    if (conector.registrarLog(usuarioObjeto.obtenerIDUsuario()) > 0){
                        principal = new Principal(usuarioObjeto);
                        if (!conector.consultarLogVacio(usuarioObjeto.obtenerIDUsuario()))
                        {
                            primer = new ReseteoContra(usuarioObjeto,(Principal)principal);
                            primer.Show();
                            this.Hide();
                            
                        }
                        else {
                            principal.Visible = true;
                            this.Hide();
                        }
                        
                    } else {
                        MessageBox.Show("Error del sistema, su acceso no pudo ser registrado");
                    }
                } else {

                    if (idUsuarioAux < 0){
                        idUsuarioAux = usuarioObjeto.obtenerIDUsuario();
                    } else if (idUsuarioAux == usuarioObjeto.obtenerIDUsuario() && usuarioObjeto.obtenerIDUsuario() != 2) {
                        contador++;
                        if (contador > 4 && conector.bloquearUsuario(usuarioObjeto.obtenerIDUsuario()) > 0) {

                            MessageBox.Show("El usuario \"" + usuarioObjeto.obtenerNombreNatural() + "\" ha sido bloqueado | Consulte al admnistrador");

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

        /// <summary>
        /// cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSalir_Click(object sender, EventArgs e){
            Application.Exit();
        }

        /// <summary>
        /// el evento de presionar el boton de ingreso llama a la funcion validar acceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonIngresarLoggin_Click(object sender, EventArgs e){
            validarAcceso();
        }

        /// <summary>
        /// Cierra rodo el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSalirLoggin_Click(object sender, EventArgs e){
            Application.Exit();

        }


        /// <summary>
        /// controla que no presione teclas a excepción de los caracteres del teclado inglés y la tecla de borrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            buttonIngresarLoggin.Enabled = (textBoxUserLoggin.Text.Length > 2 && textBoxUserLoggin.Text.Length < 7) && (textBoxPassLoggin.Text.Length > 7 && textBoxPassLoggin.Text.Length < 17);
        }

        private void LabelTituloLoggin_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// controla que no presione teclas a excepción de los caracteres del teclado inglé, la tecla de borrado y la tecla enter que valida el acceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPassLoggin_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                validarAcceso();
            }
        }

        private void TextBoxUserLoggin_TextChanged(object sender, EventArgs e){

        }


        /// <summary>
        /// eveneto que llama a limpiar campos cada vez que se entra al campo de texto de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxUserLoggin_Enter(object sender, EventArgs e){
            camposblancos();
        }

        private void TextBoxPassLoggin_Enter(object sender, EventArgs e){

        }

        private void TextBoxUserLoggin_KeyUp(object sender, KeyEventArgs e){
            buttonIngresarLoggin.Enabled = (textBoxUserLoggin.Text.Length > 2 || textBoxUserLoggin.Text.Length < 7) && (textBoxPassLoggin.Text.Length > 7 || textBoxPassLoggin.Text.Length < 17);
        }
    }
}
