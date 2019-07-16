using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración {
    public partial class RegistrarActualizarParam : Form {
        public RegistrarActualizarParam(string titulo, string funcion) {
            InitializeComponent();
            labelTitulo.Text = titulo;
            labelError.Text = "Erro al " + funcion;
            
        }

        private void campoBlacos() {
            textBoxNombreParam.BackColor = Color.White;
            textBoxValorParam.BackColor = Color.White;
            labelError.Visible = false;
        }

        private void camposError() {
            textBoxNombreParam.BackColor = Color.Pink;
            textBoxValorParam.BackColor = Color.Pink;
            textBoxValorParam.Text = "";
            labelError.Visible = true;
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegistrarC_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxNombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) ;
        }

        private void TextBoxNombreParam_Enter(object sender, EventArgs e)
        {
            campoBlacos();
        }

        private void TextBoxValorParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Decimal);
        }
    }
}
