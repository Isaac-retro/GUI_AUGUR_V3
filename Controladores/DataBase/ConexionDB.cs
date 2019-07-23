using System;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using GUI_AUGUR_V3.ModelosClases;
using System.Collections.Generic;

namespace GUI_AUGUR_V3.DataBase{

    /// <summary>
    /// Conexión Loggin sirver para estalecer una conexión a  
    /// autor = Isaac Tuquerrez
    /// </summary>
    class ConexionDB {
        public ConexionDB() { }

        // variable final que contiene el directorio de la conexión
        //private readonly string CONECCION_STRING = "Data Source=DESKTOP-U6QA500;Initial Catalog=AUGUR;Integrated Security=True";
        private readonly string CONECCION_STRING = "Data Source=DESKTOP-9G3OD0K\\ISAAC_SQL_SERVER;Initial Catalog=AUGUR_BASE;Integrated Security=True";


        /// variable goblal que sirve para almacenar el comando SQL
        private string consultaString = "";

        ///  de la clase SqlConnection sirve para establcer una instancia de conexción cliente a SQL
        private SqlConnection coneccion;

        /// de la clase SqlCommand sirver para ejecutar un comando de Sql en una conexión de cliente SQL
        private SqlCommand comandoQuery;

        /// de la clase SqlDataReader sirve para almacenar los datos resultates de una consula en una conexión cliente SQL 
        private SqlDataReader lectorDeDatos;

        /// de la clase MD5 sirver para invocar las funciones de encriptación y hash de MD5 incluidas en las librerias de C#}}
        private MD5 md5_conversor = MD5.Create();

        /// arreglo donde se almacena los en código ASCII los elementos de un string para un proceso de hash
        private byte[] entradaBytes;

        /// arreglo donde se almacena el resultado de la operación hash de MD5
        private byte[] hash;
        
        /// builder_string sirve para transformar valores de hexadecimales de ASCII a los caracteres correspondientes
        private StringBuilder builder_string;


        /// <summary>
        /// devuele un string resultado del cálculo hash del parametro
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public string md5_string(string pass) {
            entradaBytes = Encoding.ASCII.GetBytes(pass);
            hash = md5_conversor.ComputeHash(entradaBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++) {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }


        /// <summary>
        /// devuelve un objeto usuario de acuerdo al nombre de usuario almacenado en la base de datos
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns></returns>
        public Usuario consultarUsuario(string nombreUsuario) {
            Usuario user_object;
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open) {
                consultaString = "select idUsuario,nombreUsuario,nombreNatural,pass,cargo from usuario where  activoUsuario = 'Si' AND nombreUsuario = '" + nombreUsuario + "';";
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                if (lectorDeDatos.Read()) {
                    if (nombreUsuario.ToString() == Convert.ToString(lectorDeDatos["nombreUsuario"])) {
                        user_object = new Usuario(Convert.ToInt32(lectorDeDatos["idUsuario"]), Convert.ToString(lectorDeDatos["nombreUsuario"]), Convert.ToString(lectorDeDatos["nombreNatural"]), Convert.ToString(lectorDeDatos["cargo"]), Convert.ToString(lectorDeDatos["pass"]), Convert.ToString(lectorDeDatos["pass"]) == "Si");
                        coneccion.Close();
                        return user_object;
                    } else {
                        return null;
                    }
                }
                coneccion.Close();
                return null;
            } else {
                MessageBox.Show("Error en la conexión de base de datos");
                return null;
            }
        }


        /// <summary>
        /// consulta un usuario cde acuerdo al id usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public Usuario consultarUsuarioId(int idUsuario)
        {
            Usuario usuariObjeto;
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                consultaString = "select nombreUsuario,nombreNatural,pass,cargo,activoUsuario from usuario where idUsuario = '" + idUsuario + "';";
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                if (lectorDeDatos.Read())
                {
                    usuariObjeto = new Usuario(idUsuario,
                                              Convert.ToString(lectorDeDatos["nombreUsuario"]),
                                              Convert.ToString(lectorDeDatos["nombreNatural"]),
                                                Convert.ToString(lectorDeDatos["cargo"]),
                                              Convert.ToString(lectorDeDatos["pass"]),
                                              Convert.ToString(lectorDeDatos["activoUsuario"]) == "Si");
                    coneccion.Close();
                    return usuariObjeto;
                    
                }
                coneccion.Close();
                return null;
            }
            else
            {
                MessageBox.Show("Error en la conexión de base de datos");
                return null;
            }
        }

        /// <summary>
        /// cambia el atributo de activoUsuario almacenado en la base datos mediante el Id del usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int bloquearUsuario(int id) {
            if (id > 1) {
                coneccion = new SqlConnection(CONECCION_STRING);
                coneccion.Open();
                if (coneccion.State == System.Data.ConnectionState.Open) {
                    consultaString = "update usuario set activoUsuario = 'No' where idusuario = " + id + ";";
                    comandoQuery = new SqlCommand(consultaString, coneccion);
                    id = Convert.ToInt16(comandoQuery.ExecuteNonQuery());
                    coneccion.Close();
                    return id;
                }
                return -1;
            }
            return -1;
        }


        /// <summary>
        /// registra el acceso de un usuario al sistema
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int registrarLog(int id){
            coneccion = new SqlConnection(CONECCION_STRING);
            consultaString = "insert into LogAcceso (idUsuario,fechaHoraAcceso) values (" + id + ",GETDATE());";
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open){
                comandoQuery = new SqlCommand(consultaString, coneccion);
                id = Convert.ToInt16(comandoQuery.ExecuteNonQuery());
                coneccion.Close();
                return id;
            }
            return -1;
        }


        /// <summary>
        /// esta funcion regresa en una lista de usuarios, todos los usuarios registrados en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> regresarListaUsuarios() {
            List<Usuario> resultado =  new List<Usuario>();
            consultaString = "select * from usuario";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString,coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                while (lectorDeDatos.Read())
                {
                    resultado.Add(new Usuario(Convert.ToInt32(lectorDeDatos["idUsuario"]),
                        Convert.ToString(lectorDeDatos["nombreUsuario"]),
                        Convert.ToString(lectorDeDatos["nombreNatural"]),
                        Convert.ToString(lectorDeDatos["Cargo"]),
                        Convert.ToString(lectorDeDatos["pass"]),
                        Convert.ToString(lectorDeDatos["activoUsuario"]) == "Si"));
                }

                coneccion.Close();
            }
            return resultado;
        }

        /// <summary>
        /// registra un usuario en valido en la base de datos
        /// </summary>
        /// <param name="nombreNatural"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public int registrarUsuario(string nombreNatural, string nombreUsuario, string pass)
        {
            consultaString = "insert into Usuario (nombreNatural,nombreUsuario,cargo,pass,activoUsuario ) values ('" + nombreNatural + "', '" + nombreUsuario + "', 'Cajero','" + md5_string(pass) + "' , 'Si'  );";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                int i = Convert.ToInt16(comandoQuery.ExecuteNonQuery());
                coneccion.Close();
                return i;
            }
            return -1;
        }


        /// <summary>
        /// cambia con la contraseña de un usuario y lo desbloquea
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public int cambiarContrassniaID(int idUsuario, string pass) {
            consultaString = "update Usuario set pass = '"  + md5_string(pass) + "' , activoUsuario = 'Si' where idUsuario = " +  idUsuario +";";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                int i = Convert.ToInt16(comandoQuery.ExecuteNonQuery());
                coneccion.Close();
                return i;
            }
            return -1;
        }

        /// <summary>
        /// compureba si un susuario a ingresado por primera vez
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public bool consultarLogVacio(int idUsuario) {
            bool bandera = false;
            consultaString = "select * from logAcceso where logacceso.idusuario = " + idUsuario;
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                bandera = lectorDeDatos.Read();
                bandera = lectorDeDatos.Read();
                coneccion.Close();
                return bandera;
            }
            return bandera;

        }


        public List<PlatoDeComida> regresarListaPlatos(string nombrePlato) {
            List<PlatoDeComida> resultado = new List<PlatoDeComida>();
            consultaString = "select * from PlatoDeComida where nombrePlato like '" + nombrePlato + "%'";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                while (lectorDeDatos.Read())
                {
                    resultado.Add(new PlatoDeComida(Convert.ToInt32(lectorDeDatos["idPlato"]),
                        Convert.ToString(lectorDeDatos["nombrePlato"]),
                        (float)Convert.ToDouble(lectorDeDatos["precioPlato"]),
                        Convert.ToString(lectorDeDatos["tipoPlato"]),
                        Convert.ToString(lectorDeDatos["activoPlato"]) == "Si"));
                }

                coneccion.Close();
            }
            return resultado;
        }

        public int registrarPlato(PlatoDeComida plato) {
            consultaString = "insert into PlatoDeComida (nombrePlato,precioPlato,tipoPlato,activoPlato )" +
                " values ('" + plato.obtenerNombrePlato() + "', '" + plato.obtenerValorPlato() + "', '"+  plato.obtenerTipo()  + "', 'Si'  );";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                int i = Convert.ToInt16(comandoQuery.ExecuteNonQuery());
                coneccion.Close();
                return i;
            }
            return -1;
        }

        public List<Ingrediente> regresarListaIngredientes(string nombreIngrediente) {
            List<Ingrediente> resultado = new List<Ingrediente>();
            consultaString = "select * from Ingredientes where nombreIngrediente like '" + nombreIngrediente + "%' ";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                while (lectorDeDatos.Read())
                {
                    resultado.Add(new Ingrediente(Convert.ToInt32(lectorDeDatos["idIngrediente"]),
                        Convert.ToString(lectorDeDatos["nombreIngrediente"]),
                        (float)Convert.ToDouble(lectorDeDatos["precioIngrediente"]),
                        Convert.ToString(lectorDeDatos["unidadMedida"]),
                        (float)Convert.ToDouble(lectorDeDatos["cantidadDisponible"]),
                        Convert.ToString(lectorDeDatos["activoparametro"]) == "Si"));
                }

                coneccion.Close();
            }
            return resultado;
        }

        public List<Parametro> regresarListaParametros(string nombreParam) {
            List<Parametro> resultado = new List<Parametro>();
            consultaString = "select * from Parametro where nombreParametro like '" + nombreParam + "%' ";
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open)
            {
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                while (lectorDeDatos.Read())
                {
                    resultado.Add(new Parametro(Convert.ToInt32(lectorDeDatos["idParametro"]),
                        Convert.ToString(lectorDeDatos["nombreParametro"]),
                        (float)Convert.ToDouble(lectorDeDatos["valorParametro"]),
                        Convert.ToString(lectorDeDatos["activoParametro"]) == "Si"));
                }

                coneccion.Close();
            }
            return resultado;
        }
    }
}
