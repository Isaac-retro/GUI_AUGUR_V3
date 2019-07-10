using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   

namespace GUI_AUGUR_V3
{
    public partial class Principal : Form
    {
        Form loggin = new Loggin();

        public Principal()
        {
            InitializeComponent();

        }
        private void ocultarsubmenu(){
            panelDesAdmin.Visible = false;
            panelDesAyuda.Visible = false;
            panelDesClientes.Visible = false;
            panelDesIngredientes.Visible = false;
            panelDesPagos.Visible = false;
            panelDesPedidos.Visible = false;
            panelDesReportes.Visible = false;
            panelDesPlatos.Visible = false;

        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 65;
            } else {
                panelMenuVertical.Width = 250; 
            }
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void PictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesClientes.Visible = true;

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e)
        {
            ocultarsubmenu();
        }

        private void ButtonAyuda_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesAyuda.Visible = true;
        }

        private void ButtonPagos_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesPagos.Visible = true;
        }

        private void ButtonInfoSistema_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonAcerca_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonManual_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

       

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesAdmin.Visible = true;
        }

        private void ButtonPedidos_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesPedidos.Visible = true;

        }

        private void ButtonReportes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesReportes.Visible = true;

        }

        private void ButtonPlatosIng_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            panelDesPlatos.Visible = true;

        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {
            ocultarsubmenu();
        }

        private void ButtonTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void PanelDesReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDesReportes_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ButtonActualizarPlato_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonAdminSistema_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonAdminParam_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonServiciosB_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonInvalidarPedido_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonCrearPedido_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonPlatosMasVendidos_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonClientesFrecuentes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonIngredientes_Click(object sender, EventArgs e)
        {
            panelDesIngredientes.Visible = true;

        }

        private void ButtonEliminarPlato_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonConsultarPlato_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonRegistraPlato_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonRegistrarClientes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonActualizarCliente_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonConsulCliente_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonDarBaja_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }

        private void ButtonDarAlta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();

        }
    }
}
