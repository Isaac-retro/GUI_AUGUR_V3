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
            //refrescarLista(conector.regresarListaPlatos(""));
            RefrescarLista(conector.consultarPlatos());
            buttonActualizar.Enabled = false;
        }

        public void RefrescarLista(List<PlatoDeComida> listPlatos) {
            dataGridViewPlatos.Rows.Clear();
            for (int i = 0; i < listPlatos.Count; i++)
            {
                string ingredient = obtenerIngredientesString(listPlatos[i].obtenerIdPlato());

               

                dataGridViewPlatos.Rows.Add(listPlatos[i].obtenerIdPlato().ToString(), listPlatos[i].obtenerNombrePlato(), listPlatos[i].obtenerValorPlato(), 
                        ingredient);
                
            }
        }

        public string obtenerIngredientesString(int id)
        {
            string salida = "";
            List<Ingrediente> ings = conector.consultarIngredientesPlato(id);
            for (int i = 0; i < ings.Count; i++)
            {
                salida += ings[i].obtenerNombreIngrediente() + " + ";
            }

            return salida;
        }
        public void refreshListaPlatos() {
            RefrescarLista(conector.consultarPlatos());
        }

        private void validarCaracteres(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));
            if (this.textBoxNombrePlato.Text.Length > 20)
            {
                MessageBox.Show("Nombre demasiado largo");
                textBoxNombrePlato.Text = "";
                RefrescarLista(conector.consultarPlatos());
            }
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
            try { 
                //this.dataGridViewPlatos.Rows(dataGridViewLista.Rows.RemoveAt(dataGridViewLista.CurrentRow.Index));
                if (dataGridViewPlatos.Rows[dataGridViewPlatos.CurrentRow.Index].Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dataGridViewPlatos.Rows[dataGridViewPlatos.CurrentRow.Index].Cells[0].Value.ToString());
                    registrarActualizarP?.Close();
                    registrarActualizarP = new RegistrarActualzarPlatocs(this, "Actualización Plato de comida", "actualizar", user, id);
                    registrarActualizarP.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            try { 
                ConexionDB conexion = new ConexionDB();
                int id = Convert.ToInt32(dataGridViewPlatos.Rows[dataGridViewPlatos.CurrentRow.Index].Cells[0].Value.ToString());

                conexion.eliminarPlato(id);

                RefrescarLista(conector.consultarPlatos());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void TextBoxNombrePlato_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBoxNombrePlato_TextChanged(object sender, EventArgs e)
        {
            RefrescarLista(conector.regresarListaPlatos(textBoxNombrePlato.Text));
        }

        private void PictureBoxRefrescarLista_Click(object sender, EventArgs e)
        {
            RefrescarLista(conector.consultarPlatos());
            textBoxNombrePlato.Text = "";

        }

        private void DataGridViewPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.buttonActualizar.Enabled = true;
        }

        private void DataGridViewPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.buttonActualizar.Enabled = true;
        }
    }
}
