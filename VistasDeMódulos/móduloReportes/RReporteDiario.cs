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
    public partial class RReporteDiario : Form
    {
        Label titulo;
        public RReporteDiario(Usuario usuario, Label titulo)
        {
            InitializeComponent();
            this.titulo = titulo;
            DateTime fecha = DateTime.Now;

            this.labelTit.Text = "Reporte del día, " + fecha;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("Plato " + i, "Precio" + i, "N COMPRAS XYZ");

            }


            dataGridView2.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("CLIENTE" + i, "CÉDULA" + i);

            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.titulo.Text = "AUGUR";
        }
    }
}
