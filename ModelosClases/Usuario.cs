namespace GUI_AUGUR_V3.ModelosClases{
    public class Usuario{
        private string idUser; 
        private string nombreUsuario;
        private string cargo;
        public Usuario() { }
        public Usuario(string idUserm, string nombreUsuariom, string cargo) {
            this.idUser = idUser;
            this.nombreUsuario = nombreUsuario;
            this.cargo = cargo;
        }
        public string getidUser() {
            return idUser;
        }
        public string getNombreUsuario() {
            return nombreUsuario;
        }
        public string getCargo() {
            return cargo;
        }
    }
}
