
namespace GUI_AUGUR_V3.ModelosClases
{
    class Ingrediente{
        private int idIngrediente;
        private string nombreIngrediente;
        private float valorIngrediente;
        private string unidad;
        private float cantidad;
        private bool activo;


        public Ingrediente(int idIngrediente, string nombreIngrediente, float valorIngrediente, string unidad, float cantidad,bool activo)
        {
            this.idIngrediente = idIngrediente;
            this.unidad = unidad;
            this.cantidad = cantidad;
            this.nombreIngrediente = nombreIngrediente;
            this.valorIngrediente = valorIngrediente;

            this.activo = activo;
        }



        public int obtenerIdIngrediente()
        {
            return idIngrediente;
        }
        public string obtenerNombreIngrediente()
        {
            return nombreIngrediente;
        }
        public float obtenerValorIngrediente()
        {
            return valorIngrediente;
        }

        public string obtenerUnidad() {
            return unidad;
        }
        public float obtnerCantidaddisponible() {
            return cantidad;
        }
        public bool isActive()
        {
            return activo;
        }


    }
}
