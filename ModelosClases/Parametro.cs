namespace GUI_AUGUR_V3.ModelosClases {
    public class Parametro {
        private int idParametro;
        private string nombreParametro;
        private float valorParametro;
        private bool activo;
        public Parametro(int idParametro, string nombreParametro, float valorParametro, bool activo)
        {
            this.idParametro = idParametro;
            this.nombreParametro = nombreParametro;
            this.valorParametro = valorParametro;
            this.activo = activo;
        }
        public int getIdIngrediente()
        {
            return idParametro;
        }
        public string getNombreIngrediente()
        {
            return nombreParametro;
        }
        public float getValorIngrediente()
        {
            return valorParametro;
        }
        public bool isActive()
        {
            return activo;
        }
    }
}
