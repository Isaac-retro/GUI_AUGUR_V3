
namespace GUI_AUGUR_V3.ModelosClases
{
    class Ingrediente{
        private int idIngrediente;
        private string nombreIngrediente;
        private float valorIngrediente;
        private bool activo;
        public Ingrediente(int idIngrediente, string nombreIngrediente, float valorIngrediente, bool activo)
        {
            this.idIngrediente = idIngrediente;
            this.nombreIngrediente = nombreIngrediente;
            this.valorIngrediente = valorIngrediente;
            this.activo = activo;
        }
        public int getIdIngrediente()
        {
            return idIngrediente;
        }
        public string getNombreIngrediente()
        {
            return nombreIngrediente;
        }
        public float getValorIngrediente()
        {
            return valorIngrediente;
        }
        public bool isActive()
        {
            return activo;
        }


    }
}
