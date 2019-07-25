namespace GUI_AUGUR_V3.ModelosClases {
    public class PlatoDeComida{
        private int idPlato;
        private string nombrePlato;
        private float valorPlato;
        private string tipoPlato;
        private bool activo;
        public PlatoDeComida(int idPlato, string nombrePlato, float valorPlato, string tipoPlato, bool activo) {
            this.idPlato = idPlato;
            this.nombrePlato = nombrePlato;
            this.valorPlato = valorPlato;
            this.tipoPlato = tipoPlato;
            this.activo = activo;
        }
        public int obtenerIdPlato() {
            return idPlato;
        }
        public string obtenerNombrePlato() {
            return nombrePlato;
        }
        public float obtenerValorPlato() {
            return valorPlato;
        }
        public bool isActivo() {
            return activo;
        }
        public string obtenerTipo() {
            return tipoPlato;
        }
    }
}
