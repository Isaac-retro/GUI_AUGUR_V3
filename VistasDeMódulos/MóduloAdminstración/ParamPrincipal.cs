using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.móduloAdminstración
{
    public partial class ParamPrincipal : Form
    {
        public ParamPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonRegistrarPr_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxBuscarParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
