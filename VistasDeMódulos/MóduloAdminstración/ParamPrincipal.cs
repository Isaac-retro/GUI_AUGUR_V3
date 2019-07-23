using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración;
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
        RegistrarActualizarParam raParam;
        ConexionDB conector;
        public ParamPrincipal()
        {
            InitializeComponent();
            conector = new ConexionDB();
            refrescarListaParam(conector.regresarListaParametros(""));

        }
        private void refrescarListaParam(List<Parametro> param) {
            dataGridViewParametros.Rows.Clear();
            for (int i = 0; i < param.Count; i++)
            {
                if (param[i].isActive())
                {
                    dataGridViewParametros.Rows.Add(param[i].getIdIngrediente().ToString(), param[i].getNombreIngrediente(), param[i].getValorIngrediente(), "Si");
                }
            }
        }
        private void ButtonRegistrarPr_Click(object sender, EventArgs e)
        {
            raParam?.Close();
            raParam = new RegistrarActualizarParam("Registro de Parámetros","registrar Parámetro");
            raParam.Show();
        }

        private void TextBoxBuscarParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void ButtonActualizarPr_Click(object sender, EventArgs e)
        {
            raParam?.Close();
            raParam = new RegistrarActualizarParam("Actualización de Parámetros", "actualizar parámetro");
            raParam.Show();
        }

        private void PictureBoxRefrescarListaParametros_Click(object sender, EventArgs e)
        {
            refrescarListaParam(conector.regresarListaParametros(""));
        }
    }
}
