using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración{
    /// <summary>
    /// esta clase es la ventan principla de la cual se despliegua  
    /// </summary>
    public partial class AdminPrincipal : Form{
        //variable que almacena el usuario logueado actualmente
        private Usuario usuario;

        //esta variable sirve para realizar un casting a los forms que se pidan llamar
        private Form formGenerico;

        //todos los erros relacionado con la conexión de base de datos se realizan en la clase Conexion DB
        private ConexionDB conector = new ConexionDB();

        /// <summary>
        /// Este construtor se activa con el parametro user y activa el from 
        /// </summary>
        /// <param name="user"></param>
        public AdminPrincipal(Usuario user ){
            InitializeComponent();
            buttonResetearContra.Enabled = false;
            this.usuario = user;
            labelUser.Text = user.obtenerNombreUsuario();
            labelUserCargo.Text = user.obtenerCargo();
            denegarAcciones(user.obtenerCargo());
            refrescarListaUsuario(conector.regresarListaUsuarios());
        }

        public void refrescarListaUsuario(List<Usuario> listaUsuarios) {
            dataGridViewUsuario.Rows.Clear();
            for (int i = 0; i < listaUsuarios.Count; i++) {
                if (listaUsuarios[i].isActivo()) {
                    dataGridViewUsuario.Rows.Add(listaUsuarios[i].obtenerIDUsuario().ToString(), listaUsuarios[i].obtenerNombreUsuario(), listaUsuarios[i].obtenerCargo(), "No");
                } else {
                    dataGridViewUsuario.Rows.Add(listaUsuarios[i].obtenerIDUsuario().ToString(), listaUsuarios[i].obtenerNombreUsuario(), listaUsuarios[i].obtenerCargo(), "Si");
                }           

            }
            
        }



        private void denegarAcciones(string cargo) {
            if (cargo != "Administrador") {
                buttonCrearUsuario.Enabled = false;
                dataGridViewUsuario.Enabled = false;

            }
        }



        private void ButtonCrearUsuario_Click(object sender, EventArgs e){
            formGenerico?.Close();
            formGenerico = new UserContra("Creación Nuevo Usuario","crear nuevo usuario",0,usuario,0);
            formGenerico.Show();
        }


        private void ButtoncambiarContra_Click(object sender, EventArgs e){
            formGenerico?.Close();
            formGenerico = new UserContra("Cambio de contraseña", "cambiar contraseña", 1, usuario,0);

            formGenerico.Show();
        }


        private void ButtonResetearContra_Click(object sender, EventArgs e){
            formGenerico?.Close();
            formGenerico = new UserContra("Reseteo de contraseña", "resetear contraseña", 2, usuario,1); // cambiar por usuario seleccionado
            formGenerico.Show();
        }


        
        private void PictureBoxRefrescarListaUsuarios_Click(object sender, EventArgs e){
            refrescarListaUsuario(conector.regresarListaUsuarios());
        }

        private void DataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonResetearContra.Enabled = true;
        }
    }
}
