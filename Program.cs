using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI_AUGUR_V3.DataBase;
using GUI_AUGUR_V3.ModelosClases;
using GUI_AUGUR_V3.VistasDeMódulos.móduloPlatos.submóduloIngrediente;
using GUI_AUGUR_V3.VistasDeMódulos.MóduloPlatos;

namespace GUI_AUGUR_V3{
    static class Program{
        /// Punto de entrada principal para la aplicación.
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ConexionDB conexion = new ConexionDB();
            //conexion.crearPlatoDeComida(new ModelosClases.PlatoDeComida(100,"PlatoTest",5.6f,"Fuerte",true));
            List<PlatoDeComida> platos = conexion.consultarPlatos();
            foreach (PlatoDeComida item in platos)
            {
                Console.WriteLine(item.obtenerNombrePlato() + " valor " + item.obtenerValorPlato());
            }

            Application.Run(new Loggin());
        }
    }
}
