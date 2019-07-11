using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes;

namespace GUI_AUGUR_V3
{
    public partial class Principal : Form {
        public Form loggin = new Loggin();
        public Form generic;
        public Principal(){
            InitializeComponent();

        }
        public void abrirFormEnContenedor(object formHijo) {
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
                generic = formHijo as Form;
                generic.TopLevel = false;
                generic.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(generic);
                this.panelContenedor.Tag = generic;
                generic.Show();
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 62;
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

        private void ButtonClientes_Click(object sender, EventArgs e){
            labelTitulo.Text = "Clientes";
            abrirFormEnContenedor(new ClientePrincipal()); 

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e){

        }

        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e){

        }

        private void ButtonAyuda_Click(object sender, EventArgs e){
            
            
        }

        private void ButtonPagos_Click(object sender, EventArgs e){
            
            
        }


        private void ButtonAdmin_Click(object sender, EventArgs e){
           
            
        }

        private void ButtonPedidos_Click(object sender, EventArgs e){
            
            

        }

        private void ButtonReportes_Click(object sender, EventArgs e){
            
            

        }

        private void ButtonPlatosIng_Click(object sender, EventArgs e){
           
            

        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e){
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
