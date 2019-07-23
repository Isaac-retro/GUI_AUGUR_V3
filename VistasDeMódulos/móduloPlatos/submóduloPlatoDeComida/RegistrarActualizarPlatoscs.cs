using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos
{
    public partial class RegistrarActualzarPlatocs : Form {
        private int idPlato = 0;
        private DataGridViewRow rowLista;
        private DataGridViewRow rowOkay;
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
                textBoxNombre.Enabled = false;
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


        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plato registrado correctamente");
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
            ppl.refreshListaPlatos();
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

            if (dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[3].Value.ToString() != "0" )
            {
                try
                {
                    Convert.ToDouble(dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[3].Value.ToString());
                    dataGridViewOk.Rows.Add(dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[0].Value,
                    dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[1].Value,
                    dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[2].Value,
                    dataGridViewLista.Rows[dataGridViewLista.CurrentRow.Index].Cells[3].Value);
                    dataGridViewLista.Rows.RemoveAt(dataGridViewLista.CurrentRow.Index);
                }
                catch {
                    MessageBox.Show("Escribe un valor númerico en la cantidad");
                }
            }
            else {
                MessageBox.Show("Escribe un valor númerico en la cantidad");
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
    }
}
