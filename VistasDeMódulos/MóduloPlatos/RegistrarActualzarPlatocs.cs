using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class RegistrarActualzarPlatocs : Form{
        int idPlato;
        private Usuario user;
        public RegistrarActualzarPlatocs(string titulo, string funcion, Usuario user, int idPlato){
            InitializeComponent();
            this.user = user;
            this.idPlato = idPlato;
            labelTitulo.Text = titulo;
            labelError.Text = "Error al " + funcion;
            if (idPlato == 1 ) {
                textBoxNombre.Text = "Encebollado Futbolero";
                textBoxApellido.Text = "$ 3.75";
                textBoxNombre.Enabled = false;
                textBoxApellido.Enabled = false;
            }
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
