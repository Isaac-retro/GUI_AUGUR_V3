using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class RegistrarActualzarPlatocs : Form {
        private int idPlato = -1;
        private DataGridViewRow rowLista;


        private Usuario user;
        private PlatosPrincipal ppl;
        private ConexionDB conector;
        public RegistrarActualzarPlatocs(PlatosPrincipal ppl, string titulo, string funcion, Usuario user, int idPlato) {
            InitializeComponent();
            this.user = user;
            this.idPlato = idPlato;
            this.Text = titulo;
            this.ppl = ppl;
            conector = new ConexionDB();
            refrescarLista(conector.regresarListaIngredientes("") );
            if (funcion == "actualizar")
            {
                label2.Visible = false;
                textBoxNombre.Visible = false;
                buttonRegistrar.Visible = false;

            }
            else
            {
                buttonActualizar.Visible = false;
            }
            buttonAgregar.Enabled = false;


        }

        private void refrescarLista(List<Ingrediente> listaIngredientes)
        {
            dataGridViewLista.Rows.Clear();
            for (int i = 0; i < listaIngredientes.Count; i++)
            {
                if (listaIngredientes[i].isActive())
                {
                    dataGridViewLista.Rows.Add(listaIngredientes[i].obtenerIdIngrediente().ToString(), listaIngredientes[i].obtenerNombreIngrediente(), listaIngredientes[i].obtenerUnidad(),"0");
                }

            }
        }




        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            ppl.refreshListaPlatos();
            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            ppl.RefrescarLista(conector.consultarPlatos());
            this.Close();
        }



        private void DataGridViewLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                rowLista = dataGridViewLista.Rows[e.RowIndex];
                buttonAgregar.Enabled = true;
 

            }
        }

        private void DataGridViewOk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                buttonQuitar.Enabled = true;
                   
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

           
            try
            {
                //Convert.ToDouble(dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[3].Value.ToString());
                dataGridViewOk.Rows.Add(dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[0].Value, 0);
                dataGridViewLista.Rows.RemoveAt(dataGridViewLista.CurrentRow.Index);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '´' || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back));
            if (this.textBoxNombre.Text.Length > 20)
            {
                textBoxNombre.Text = "";
            }
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            refrescarLista(conector.regresarListaIngredientes(""));
            dataGridViewOk.Rows.Clear();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            try { 
            ConexionDB conexion = new ConexionDB();
            conexion.actualizarPlato(this.idPlato, (float)Convert.ToDouble(this.textBoxPrecio.Text), true);
            refrescarLista(conector.regresarListaIngredientes(""));
                limpiarCajas();
                MessageBox.Show("Plato actualizado");
            dataGridViewOk.Rows.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }



        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            try { 

                ConexionDB conexion = new ConexionDB();
                conexion.crearPlatoDeComida(new PlatoDeComida(100,this.textBoxNombre.Text,(float)Convert.ToDouble(this.textBoxPrecio.Text),"Fuerte",true));
                refrescarLista(conector.regresarListaIngredientes(""));
                limpiarCajas();
                dataGridViewOk.Rows.Clear();
                MessageBox.Show("Plato registrado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void limpiarCajas()
        {
            this.textBoxNombre.Text = "";
            this.textBoxPrecio.Text = "";
        }


    }
}
