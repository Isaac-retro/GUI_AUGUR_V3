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
    public partial class ReporteMensual : Form
    {
        Label titulo;
        public ReporteMensual(Usuario usuario, Label titulo)
        {
            InitializeComponent();
            this.titulo = titulo;

            chart1.Series["Series1"].LegendText = "Ventas por semana";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Semana1", 576);
            dic.Add("Semana2", 1087);
            dic.Add("Semana3", 1061);
            dic.Add("Semana4", 660);

            foreach (KeyValuePair<string, int> d in dic)
            {
                chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }


            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("Plato " + i, "Precio" + i, "N COMPRAS XYZ");

            }


            dataGridView2.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView2.Rows.Add("CLIENTE" + i, "CÉDULA" + i, i*10);

            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.titulo.Text = "AUGUR";
        }
    }
}
