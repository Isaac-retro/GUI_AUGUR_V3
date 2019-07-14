using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes
{
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
            
        }
        private void invalidarCampos() {
            textBoxNombre.Enabled = false;
            textBoxApellido.Enabled = false;
            textBoxDocumento.Enabled = false;
        }
        private void ButtonActualizarC_Click(object sender, EventArgs e){

        }
    }
}
