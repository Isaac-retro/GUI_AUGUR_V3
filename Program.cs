using System;
using System.Windows.Forms;
namespace GUI_AUGUR_V3{
    static class Program{
        /// Punto de entrada principal para la aplicación.
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loggin());
        }
    }
}
