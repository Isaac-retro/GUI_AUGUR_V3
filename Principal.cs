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
using GUI_AUGUR_V3.VistasDeMódulos.móduloAdminstración;

namespace GUI_AUGUR_V3 {

    /// <summary>
    /// Clase de la ventana principal del programa, en el panel contenedor se abren los demas formularios
    /// </summary>
    public partial class Principal : Form {
        // variable que almacena el usuario logueado en el sistema
        private Usuario user;

        //variable generica a la que se le realiza un casting para abrir distintos tipos de formularios
        private Form formgenerico;


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

        private void cerrarbotones() {
            buttonCrearPedido.Visible = false;
            buttonInvalidarPedido.Visible = false;
            buttonConsultarPedido.Visible = false;
            buttonSubPlatosDeComida.Visible = false;
            buttonSubIngredientes.Visible = false;
            buttonClientesFrec.Visible = false;
            buttonPlatosMas.Visible = false;
            buttonReporteDiario.Visible = false;
            buttonReporteMensual.Visible = false;
        }


        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            cerrarbotones();
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
            formgenerico?.Close();
            formgenerico = new ClientePrincipal() { TopLevel = false, FormBorderStyle = FormBorderStyle.None , Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelContenedor_Paint(object sender, PaintEventArgs e){
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e){
            cerrarbotones();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAyuda_Click(object sender, EventArgs e){
            this.ocultarBotonesExtra();

            labelTitulo.Text = "Ayuda";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new AyudaPrincipal(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();


        }


        /// <summary>
        /// abre el formulario de administración casteando al form genérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdmin_Click(object sender, EventArgs e){
            cerrarbotones();
            buttonSubAdmin.Visible = !buttonSubAdmin.Visible;
            buttonSubParam.Visible = !buttonSubParam.Visible;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPedidos_Click(object sender, EventArgs e) {
            cerrarbotones();
            buttonCrearPedido.Visible = !buttonCrearPedido.Visible;
            buttonInvalidarPedido.Visible = !buttonInvalidarPedido.Visible;
            buttonConsultarPedido.Visible = !buttonConsultarPedido.Visible;
        }


        /// <summary>
        /// despliega las opciones de pantalla para 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReportes_Click(object sender, EventArgs e){
            cerrarbotones();
            buttonClientesFrec.Visible = !buttonClientesFrec.Visible;
            buttonPlatosMas.Visible = !buttonPlatosMas.Visible;
            buttonReporteDiario.Visible = !buttonReporteDiario.Visible;
            buttonReporteMensual.Visible = !buttonReporteMensual.Visible;


        }


        /// <summary>
        /// abre el formulario de Platos casteando al form genérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlatosIng_Click(object sender, EventArgs e){
            cerrarbotones();
            buttonSubPlatosDeComida.Visible = !buttonSubPlatosDeComida.Visible;
            buttonSubIngredientes.Visible = !buttonSubIngredientes.Visible;


        }



        /// <summary>
        /// si toca esta parte de la pantalla no se ocultan los botones desplegados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelTitulo_Paint(object sender, PaintEventArgs e){
            cerrarbotones();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubPlatosDeComida_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();
            labelTitulo.Text = "Platos de Comida";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new PlatosPrincipal(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubIngredientes_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();
            labelTitulo.Text = "Ingredientes";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new IngredientePrincipal(user, labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClientesFrec_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();
            labelTitulo.Text = "Reportes: Clientes más frecuentes";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new RClientesFrecuentes(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlatosMas_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reportes: Platos más vendidos";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new RPlatosMasVendidos(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReporteDiario_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();
            labelTitulo.Text = "Reporte Diario";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new RReporteDiario(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReporteMensual_Click(object sender, EventArgs e)
        {
            ocultarBotonesExtra();

            labelTitulo.Text = "Reporte Mensual";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new ReporteMensual(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }



        /// <summary>
        /// 
        /// </summary>
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCrearPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Creación de pedido";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new CreacionPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInvalidarPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Invalidación de pedido";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new InvalidacionPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConsultarPedido_Click(object sender, EventArgs e)
        {
            this.ocultarBotonesExtra();
            labelTitulo.Text = "Consulta de pedido";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new ConsultaPedido(user, this.labelTitulo) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubAdmin_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Administración: Sistema";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new AdminPrincipal(user) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }



        private void LabelTitulo2_Click(object sender, EventArgs e)
        {
            cerrarbotones();
        }

        private void LabelTitulo1_Click(object sender, EventArgs e)
        {
            cerrarbotones();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            cerrarbotones();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInicio_Click(object sender, EventArgs e)
        {
            cerrarbotones();
            formgenerico?.Close();
            pictureBoxImagen.Visible = true;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubParam_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Administración: Parámetros";
            pictureBoxImagen.Visible = false;
            formgenerico?.Close();
            formgenerico = new ParamPrincipal() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelContenedor.Controls.Add(formgenerico);
            formgenerico.Show();
        }
    }
}
