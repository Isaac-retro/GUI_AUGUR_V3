using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes;
using System.Linq;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3 {
    public partial class Principal : Form {
        private Usuario user;
        //ClientePrincipal clienteprincioalform;
        //private string nombreusuario = "", userid = "";
        public Principal(Usuario user){//string nombreusuario, string userid) {
            InitializeComponent();
            this.user = user;
            labelUser.Text = user.getNombreUsuario();
            labelUserCargo.Text = user.getCargo();



        }
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new() {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();
            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null) {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            } else {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

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

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e){

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void ButtonClientes_Click(object sender, EventArgs e){
            labelTitulo.Text = "Clientes";
            AbrirFormEnPanel<ClientePrincipal>();
    

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

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
