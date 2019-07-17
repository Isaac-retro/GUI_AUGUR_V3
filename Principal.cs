using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloClientes;
using GUI_AUGUR_V3.ModelosClases;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloAdminstración;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos;
using GUI_AUGUR_V3.VistasDeMódulos.móduloPedidos;
using GUI_AUGUR_V3.VistasDeMódulos.móduloAyuda;
using GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente;
using GUI_AUGUR_V3.VistasDeMódulos.móduloReportes;


namespace GUI_AUGUR_V3 {

    /// <summary>
    /// Clase de la ventana principal del programa, en el panel contenedor se abren los demas formularios
    /// </summary>
    public partial class Principal : Form {
        // variable que almacena el usuario logueado en el sistema
        private Usuario user;

        //variable generica a la que se le realiza un casting para abrir distintos tipos de formularios
        private Form genericform;


        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="user"></param>
        public Principal(Usuario user){
            InitializeComponent();
            this.user = user;
            labelUser.Text = user.obtenerNombreUsuario();
            labelUserCargo.Text = user.obtenerCargo();
            pictureBoxImagen.Visible = true;
           

        }


        /// <summary>
        /// Importacion de librerias para mover las ventanas a traves de la pantalla
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// evento que mueve la ventana en la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
   
        /// <summary>
        /// Cierra toda la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Maximiza o normaliza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }


        /// <summary>
        /// minimiza la ventana 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// mueve la ventana en la pantalla presionando un label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e){

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }


        /// <summary>
        /// abre el formulario de clientes casteando al form genérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClientes_Click(object sender, EventArgs e){
            labelTitulo.Text = "Clientes";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new ClientePrincipal() { TopLevel = false, FormBorderStyle = FormBorderStyle.None , Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e){
            
        }

        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e){

        }

        private void ButtonAyuda_Click(object sender, EventArgs e){
            this.ocultarBotonesExtra();

            labelTitulo.Text = "Ayuda";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new AyudaPrincipal(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();


        }


        /// <summary>
        /// abre el formulario de administración casteando al form genérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdmin_Click(object sender, EventArgs e){
            labelTitulo.Text = "Administración";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new AdminPrincipal(user) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();

        }

        private void ButtonPedidos_Click(object sender, EventArgs e) {
            this.buttonCrearPedido.Visible = !this.buttonCrearPedido.Visible;
            this.buttonInvalidarPedido.Visible = !this.buttonInvalidarPedido.Visible;
            this.buttonConsultarPedido.Visible = !this.buttonConsultarPedido.Visible;
            this.buttonSubPlatosDeComida.Visible = false;
            this.buttonSubIngredientes.Visible = false;
            this.buttonClientesFrec.Visible = false;
            this.buttonPlatosMas.Visible = false;
            this.buttonReporteDiario.Visible = false;
            this.buttonReporteMensual.Visible = false;
            

        }

        private void ButtonReportes_Click(object sender, EventArgs e){
            this.buttonSubPlatosDeComida.Visible = false;
            this.buttonSubIngredientes.Visible = false;

            this.buttonClientesFrec.Visible = !this.buttonClientesFrec.Visible;
            this.buttonPlatosMas.Visible = !this.buttonPlatosMas.Visible;
            this.buttonReporteDiario.Visible = !this.buttonReporteDiario.Visible;
            this.buttonReporteMensual.Visible = !this.buttonReporteMensual.Visible;


        }


        /// <summary>
        /// abre el formulario de Platos casteando al form genérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlatosIng_Click(object sender, EventArgs e){
            this.buttonSubPlatosDeComida.Visible =!this.buttonSubPlatosDeComida.Visible;
            this.buttonSubIngredientes.Visible =!this.buttonSubIngredientes.Visible;

            this.buttonClientesFrec.Visible = false;
            this.buttonPlatosMas.Visible = false;
            this.buttonReporteDiario.Visible = false;
            this.buttonReporteMensual.Visible = false;


        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e){
        }


        private void ButtonSubPlatosDeComida_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();



            labelTitulo.Text = "Platos de Comida";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new PlatosPrincipal(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();

        }

        private void ButtonSubIngredientes_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();
            labelTitulo.Text = "Ingredientes";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new IngredientePrincipal(user, labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonClientesFrec_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reportes: Clientes más frecuentes";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new RClientesFrecuentes(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonPlatosMas_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reportes: Platos más vendidos";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new RPlatosMasVendidos(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonReporteDiario_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reporte Diario";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new RReporteDiario(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonReporteMensual_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reporte Mensual";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new ReporteMensual(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ocultarBotonesExtra()
        {
            this.buttonSubPlatosDeComida.Visible = false;
            this.buttonSubIngredientes.Visible = false;
            this.buttonClientesFrec.Visible = false;
            this.buttonPlatosMas.Visible = false;
            this.buttonReporteDiario.Visible = false;
            this.buttonReporteMensual.Visible = false;

            this.buttonCrearPedido.Visible = false;
            this.buttonInvalidarPedido.Visible = false;
            this.buttonConsultarPedido.Visible = false;
        }

        private void ButtonCrearPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Creación de pedido";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new CreacionPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonInvalidarPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Invalidación de pedido";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new InvalidacionPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }

        private void ButtonConsultarPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Consulta de pedido";
            pictureBoxImagen.Visible = false;
            genericform?.Close();
            genericform = new ConsultaPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(genericform);
            genericform.Show();
        }
    }
}
