using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes{
    public partial class ClientePrincipal : Form{
        Form registroActucalizacion; 
        public ClientePrincipal(){
            InitializeComponent();

        }

        
        private void ButtonRegistrarCP_Click_1(object sender, EventArgs e){
            registroActucalizacion?.Close();
            registroActucalizacion = new ActualizarRegistrarCliente("Registro","Registrar");
            registroActucalizacion.Visible = true;
        }

        private void ButtonActualizarCP_Click(object sender, EventArgs e)        {
            registroActucalizacion?.Close();
            registroActucalizacion = new ActualizarRegistrarCliente("Actulización","Actualizar");
            registroActucalizacion.Visible = true;

        }

        private void ButtonDarBajaCP_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDarAltaCP_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonSalir_Click(object sender, EventArgs e){
            this.Close();
        }
    }

}