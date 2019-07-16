namespace GUI_AUGUR_V3.ModelosClases{
    public class Usuario{
        private int idUser;
        private string loggin; 
        private string nombreUsuario;
        private string cargo;
        private string pass;
        private bool activo;
        public Usuario() { }
        public Usuario(int idUser, string loggin, string nombreUsuario, string cargo, string pass, bool activo) {
            this.idUser = idUser;
            this.loggin = loggin;
            this.nombreUsuario = nombreUsuario;
            this.cargo = cargo;
            this.pass = pass;
            this.activo = activo;
        }
        public string getLoggin() {
            return loggin;
        }
        public string getNombreUsuario() {
            return nombreUsuario;
        }
        public string getCargo() {
            return cargo;
        }
        public int obtenerIDUsuario() {
            return idUser;
        }
        public string getPass() {
            return pass;
        }
        public bool isActivo() {
            return activo;
        }
    }
}
