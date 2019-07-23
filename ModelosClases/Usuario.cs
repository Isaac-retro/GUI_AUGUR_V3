namespace GUI_AUGUR_V3.ModelosClases{
    public class Usuario{
        // alamcena el id  del usuario mediante el cual se identifca de manera única en la base de datos
        private int idUsuario;

        //es el nombre de usuario con el que se accede al sistema
        private string nombreUsuario; 

        //el nombre del usuario
        private string nombreNatural;

        //almacena el nombre del cargo que ocupa un usuaurio
        private string cargo;

        //guarda el hash de la contraseña del usuario
        private string pass;

        //indica si el usuario no está bloquedoz
        private bool activo;

        public Usuario() { }
        public Usuario(int idUsuario, string nombreUsuario, string nombreNatural, string cargo, string pass, bool activo) {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.nombreNatural = nombreNatural;
            this.cargo = cargo;
            this.pass = pass;
            this.activo = activo;
        }
        public string obtenerLoggin() {
            return nombreUsuario;
        }
        public string obtenerNombreNatural() {
            return nombreNatural;
        }
        public string obtenerCargo() {
            return cargo;
        }
        public int obtenerIDUsuario() {
            return idUsuario;
        }
        public string obtenerPass() {
            return pass;
        }
        public bool isActivo() {
            return activo;
        }
    }
}
