using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes;
using GUI_AUGUR_V3.ModelosClases;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración;

namespace GUI_AUGUR_V3 {
    public partial class Principal : Form {
        private Usuario user;
        Form cpform;
        public Principal(Usuario user){
            InitializeComponent();
            this.user = user;
            labelUser.Text = user.getNombreUsuario();
            labelUserCargo.Text = user.getCargo();
            

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250){
                panelMenuVertical.Width = 62;
                labelUserCargo.Visible = false;
                labelUser.Visible = false;
            } else {
                panelMenuVertical.Width = 250;
                labelUserCargo.Visible = true;
                labelUser.Visible = true;
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
            pictureBoxImagen.Visible = false;
            cpform?.Close();
            cpform = new ClientePrincipal() { TopLevel = false, FormBorderStyle = FormBorderStyle.None , Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(cpform);
            cpform.Show();
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
            labelTitulo.Text = "Administración";
            pictureBoxImagen.Visible = false;
            cpform?.Close();
            cpform = new AdminPrincipal() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(cpform);
            cpform.Show();

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
