using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class PlatosPrincipal : Form{
        private Form registrarActualizarP;
        private Usuario user;
        private Principal pl;
        private ConexionDB conector;
        public PlatosPrincipal(Principal pl,Usuario user ){
            InitializeComponent();
            this.user = user;
            this.pl = pl;
            conector = new ConexionDB();
            refrescarLista(conector.regresarListaPlatos(""));
            buttonActualizar.Enabled = false;
        }

        private void refrescarLista(List<PlatoDeComida> listPlatos) {
            dataGridViewPlatos.Rows.Clear();
            for (int i = 0; i < listPlatos.Count; i++)
            {
                if (listPlatos[i].isActivo())
                {
                    dataGridViewPlatos.Rows.Add(listPlatos[i].obtenerIdPlato().ToString(), listPlatos[i].obtenerNombrePlato(), listPlatos[i].obtenerValorPlato(), listPlatos[i].obtenerTipo());
                }

            }
        }

        public void refreshListaPlatos() {
            refrescarLista(conector.regresarListaPlatos(""));
        }

        private void validarCaracteres(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));
            if (this.textBoxNombrePlato.Text.Length > 20)
            {
                MessageBox.Show("Nombre demasiado largo");
                textBoxNombrePlato.Text = "";
                refrescarLista(conector.regresarListaPlatos(""));
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plato X eliminado exitosamente");
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            pl.abrirInicio();
            this.Close();
            

        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs(this,"Registro Plato de comida", "registar", user, 0);
            registrarActualizarP.Show();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            registrarActualizarP?.Close();
            registrarActualizarP = new RegistrarActualzarPlatocs(this,"Actualización Plato de comida", "actualizar", user, 0);
            registrarActualizarP.Show();
        }

        private void TextBoxNombrePlato_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBoxNombrePlato_TextChanged(object sender, EventArgs e)
        {
            refrescarLista(conector.regresarListaPlatos(textBoxNombrePlato.Text));
        }

        private void PictureBoxRefrescarLista_Click(object sender, EventArgs e)
        {
            refrescarLista(conector.regresarListaPlatos(""));
            textBoxNombrePlato.Text = "";

        }
    }
}
