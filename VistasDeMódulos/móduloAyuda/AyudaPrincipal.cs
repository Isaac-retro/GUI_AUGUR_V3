using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloAyuda
{
    public partial class AyudaPrincipal : Form
    {
        Label labelTitulo;
        public AyudaPrincipal(Usuario usuario, Label labelTitulo)
        {
            InitializeComponent();
            this.labelTitulo = labelTitulo;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.labelTitulo.Text = "AUGUR";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este módulo cuenta con un auxiliar de búsqueda, solo debe escribir el dato relativo al cliente y la aplicación lo buscará\nEl módulo cliente cuenta con 4 funciones:\n1. Agregar un cliente, para lo cual es necesario dar clic a la opción registrar y llenar los datos.\n2. Actualizar datos de un cliente, para ello se debe seleccionar uno de la lista antes de dar clic a la opción de actualizar\n3.Dar de baja, si no se desea tomar en cuenta los datos de un cliente, se debe seleccionar el cliente deseado y simplemente dar clic al botón dar de baja. \n4. Dar de alta, si por el contrario deseamos volver a tomar en cuenta los datos de un cliente seleccionamos al cliente deseado y pulsamos dar de alta");
        }
    }
}
