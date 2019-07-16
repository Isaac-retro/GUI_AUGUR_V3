using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración{
    public partial class AdminPrincipal : Form{
        private Usuario user;
        private Form genericForm;
        public AdminPrincipal(Usuario user ){
            InitializeComponent();
            buttonResetearContra.Enabled = false;
            buttonActualizarPr.Enabled = false;
            this.user = user;
            labelUser.Text = user.getNombreUsuario();
            labelUserCargo.Text = user.getCargo();
            denegarAcciones(user.getCargo());
            
        }
        private void denegarAcciones(string cargo) {
            if (cargo == "Administrador") {
                dataGridViewParam.Enabled = false;
                buttonRegistrarPr.Enabled = false;
                buttonEliminarPr.Enabled = false;
                textBoxBuscarParam.Enabled = false;
            } else if (cargo == "Gerente") {
                buttonCrearUsuario.Enabled = false;
                dataGridViewUser.Enabled = false;

            } else {
                textBoxBuscarParam.Enabled = false;
                buttonRegistrarPr.Enabled = false;
                buttonEliminarPr.Enabled = false;
                buttonCrearUsuario.Enabled = false;
                dataGridViewParam.Enabled = false;
                dataGridViewUser.Enabled = false;

            }
        }
        private void PictureBoxImage_Click(object sender, EventArgs e)
        {

        }


        private void ButtonCrearUsuario_Click(object sender, EventArgs e){
            genericForm?.Close();
            genericForm = new UserContra("Creación Nuevo Usuario","crear nuevo usuario",0,user,null);
            genericForm.Show();
        }

        private void ButtoncambiarContra_Click(object sender, EventArgs e){
            genericForm?.Close();
            genericForm = new UserContra("Cambio de contraseña", "cambiar contraseña", 1, user,null);
            genericForm.Show();
        }

        private void ButtonResetearContra_Click(object sender, EventArgs e){
            genericForm?.Close();
            genericForm = new UserContra("Reseteo de contraseña", "resetear contraseña", 2, user, user); // cambiar por usuario seleccionado
            genericForm.Show();
        }

        private void ButtonSalirAdmin_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ButtonRegistrarPr_Click(object sender, EventArgs e)
        {
            genericForm?.Close();
            genericForm = new RegistrarActualizarParam("Registro de Parámetros","registrar parámetro");
            genericForm.Show();
        }

        private void ButtonActualizarPr_Click(object sender, EventArgs e)
        {
            genericForm?.Close();
            genericForm = new RegistrarActualizarParam("Actualización de Parámetros", "actualizar parámetro");
            genericForm.Show();
        }

        private void TextBoxBuscarParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
