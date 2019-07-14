using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración
{
    public partial class AdminPrincipal : Form{
        private CrearUsuario crearUser;
        public AdminPrincipal()
        {
            InitializeComponent();
        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCrearUsuario_Click(object sender, EventArgs e){
            crearUser?.Close();
            crearUser = new CrearUsuario();
        }
    }
}
