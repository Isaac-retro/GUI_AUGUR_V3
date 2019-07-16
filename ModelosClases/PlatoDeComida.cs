namespace GUI_AUGUR_V3.ModelosClases {
    class PlatoDeComida{
        private int idPlato;
        private string nombrePlato;
        private float valorPlato;
        private bool activo;
        public PlatoDeComida(int idPlato, string nombrePlato, float valorPlato, bool activo) {
            this.idPlato = idPlato;
            this.nombrePlato = nombrePlato;
            this.valorPlato = valorPlato;
            this.activo = activo;
        }
        public int getIdPlato() {
            return idPlato;
        }
        public string getNombrePlato() {
            return nombrePlato;
        }
        public float getValorPlato() {
            return valorPlato;
        }
        public bool isActive() {
            return activo;
        }
    }
}
