﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes{
    public partial class ClientePrincipal : Form{
        Form registro; 
        public ClientePrincipal(){
            InitializeComponent();

        }

        private void ButtonRegistrarCP_Click(object sender, EventArgs e){
            registro = new RegistrarCliente();
            registro.Visible = true;
        }

        private void ButtonDarAltaCP_Click(object sender, EventArgs e){

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e){
            //invocar a método de consulta

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}