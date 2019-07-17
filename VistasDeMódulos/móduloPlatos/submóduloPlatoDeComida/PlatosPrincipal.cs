using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class PlatosPrincipal : Form{
        Form registrarActualizarP;
        Usuario user;
        public PlatosPrincipal(Usuario user){
            InitializeComponent();
            this.user = user;
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegistrarP_Click(object sender, EventArgs e){
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs("Registro de platos","registar plato", user,0);
            registrarActualizarP.Show();
        }

        private void ButtonActualizarP_Click(object sender, EventArgs e)
        {
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs("Actualización de platos", "actualizar plato", user, 0);
            registrarActualizarP.Show();
        }
    }
}
