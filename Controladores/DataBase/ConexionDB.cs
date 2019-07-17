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

        //private readonly string CONECCION_STRING = "Data Source=DESKTOP-9G3OD0K\\ISAAC_SQL_SERVER;Initial Catalog=AUGUR;Integrated Security=True";
        private readonly string CONECCION_STRING = "Data Source=DESKTOP-U6QA500;Initial Catalog=AUGUR;Integrated Security=True";

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
        /// devuelve un objeto usuario de acuerdo al loggin del usuario almacenado en la base de datos
        /// </summary>
        /// <param name="logginUsuario"></param>
        /// <returns></returns>
        public Usuario consultarUsuario(string logginUsuario) {
            Usuario user_object;
            coneccion = new SqlConnection(CONECCION_STRING);
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open) {
                consultaString = "select idUsuario,nombreUsuario,loggin,pass from usuario where  activoUsuario = 'Si' AND loggin = '" + logginUsuario + "';";
                comandoQuery = new SqlCommand(consultaString, coneccion);
                lectorDeDatos = comandoQuery.ExecuteReader();
                if (lectorDeDatos.Read()) {
                    if (logginUsuario.ToString() == Convert.ToString(lectorDeDatos["loggin"])) {
                        user_object = new Usuario(Convert.ToInt32(lectorDeDatos["idUsuario"]), Convert.ToString(lectorDeDatos["loggin"]), Convert.ToString(lectorDeDatos["nombreUsuario"]), seleccionarCargo(Convert.ToString(lectorDeDatos["loggin"])), Convert.ToString(lectorDeDatos["pass"]),true);
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
        /// selecciona un cargo de acuerdo al loggin del usuario
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string seleccionarCargo(string param) {
            if (param == "manag") {
                return "Gerente";
            } else if (param == "admin") {
                return "Administrador";
            } else {
                return "Cajero";
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
            coneccion.Open();
            if (coneccion.State == System.Data.ConnectionState.Open){
                consultaString = "insert into LogAcceso (idUsuario,fechaHoraAcceso) values ("+ id + ",GETDATE());";
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
                    resultado.Add(new Usuario(Convert.ToInt32(lectorDeDatos["idUsuario"]), Convert.ToString(lectorDeDatos["loggin"]), Convert.ToString(lectorDeDatos["nombreUsuario"]), seleccionarCargo(Convert.ToString(lectorDeDatos["loggin"])), Convert.ToString(lectorDeDatos["pass"]), Convert.ToString(lectorDeDatos["activoUsuario"]) == "Si"));
                }

                coneccion.Close();
            }
            return resultado;
        }

    }
}
