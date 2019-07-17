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
namespace GUI_AUGUR_V3.VistasDeMódulos.móduloReportes
{
    public partial class RClientesFrecuentes : Form
    {
        Label titulo;
        public RClientesFrecuentes(Usuario usuario, Label titulo)
        {
            InitializeComponent();
            this.titulo = titulo;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("CLIENTE" + i, "CEDULA" + i, "N COMPRAS XYZ");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.titulo.Text = "AUGUR";
        }
    }
}
