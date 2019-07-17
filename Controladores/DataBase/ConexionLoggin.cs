using System;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3.DataBase{

    /// <summary>
    /// Conexión Loggin sirver para estalecer una conexión a  
    /// autor = Isaac Tuquerrez
    /// </summary>
    class ConexionLoggin {
        public ConexionLoggin() { }
        // variable final que contiene el directorio de la conexión
        //private readonly string CONNECTION_STRING = "Data Source=DESKTOP-9G3OD0K\\ISAAC_SQL_SERVER;Initial Catalog=AUGUR;Integrated Security=True";
        private readonly string CONNECTION_STRING = "Data Source=DESKTOP-U6QA500;Initial Catalog=AUGUR;Integrated Security=True";



        //DESKTOP-U6QA500
        /// variable goblal que sirve para almacenar el comando SQL
        private string query_string = "";

        ///  de la clase SqlConnection sirve para establcer una instancia de conexción cliente a SQL
        private SqlConnection connection;

        /// de la clase SqlCommand sirver para ejecutar un comando de Sql en una conexión de cliente SQL
        private SqlCommand command_query;

        /// de la clase SqlDataReader sirve para almacenar los datos resultates de una consula en una conexión cliente SQL 
        private SqlDataReader readerSet;

        /// de la clase MD5 sirver para invocar las funciones de encriptación y hash de MD5 incluidas en las librerias de C#}}
        private MD5 md5_convertor = MD5.Create();

        /// arreglo donde se almacena los en código ASCII los elementos de un string para un proceso de hash
        private byte[] inputBytes;

        /// arreglo donde se almacena el resultado de la operación hash de MD5
        private byte[]hash;
        /// <summary>
        /// builder_string sirve para transformar valores de hexadecimales de ASCII a los caracteres correspondientes
        /// </summary>
        private StringBuilder builder_string;



        /// <summary>
        /// devuele un string resultado del cálculo hash del parametro
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public string md5_string(string pass) {
            inputBytes = Encoding.ASCII.GetBytes(pass);
            hash = md5_convertor.ComputeHash(inputBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++) {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Usuario consultarUsuario(string user) {
            Usuario user_object;
            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open) {
                query_string = "select idUsuario,nombreUsuario,loggin,pass from usuario where  bloqueado = 1 AND loggin = '" + user + "';";
                command_query = new SqlCommand(query_string, connection);
                readerSet = command_query.ExecuteReader();
                if (readerSet.Read()) {
                    if (user.ToString() == Convert.ToString(readerSet["loggin"])) {
                        user_object = new Usuario(Convert.ToInt32(readerSet["idUsuario"]), Convert.ToString(readerSet["loggin"]), Convert.ToString(readerSet["nombreUsuario"]), seleccionarCargo(Convert.ToString(readerSet["loggin"])), Convert.ToString(readerSet["pass"]), true);
                        connection.Close();
                        return user_object;
                    } else {
                        return null;
                    }
                }
                connection.Close();
                return null;
            } else {
                MessageBox.Show("Error en la conexión de base de datos");
                return null;
            }
        }
        private string seleccionarCargo(string param) {
            if (param == "manag") {
                return "Gerente";
            } else if (param == "admin") {
                return "Administrador";
            } else {
                return "Cajero";
            }

        }
        public int bloquearUsuario(int id) {
            if (id != 2) {
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open) {
                    query_string = "update usuario set bloqueado = 0 where idusuario = " + id + ";";
                    command_query = new SqlCommand(query_string, connection);
                    id = Convert.ToInt16(command_query.ExecuteNonQuery());
                    connection.Close();
                    return id;
                }
                return -1;
            }
            return -1;
        }
        public int registrarLog(int id){
            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open){
                query_string = "insert into LogAcceso (idUsuario,fechaHoraAcceso) values ("+ id + ",GETDATE());";
                command_query = new SqlCommand(query_string, connection);
                id = Convert.ToInt16(command_query.ExecuteNonQuery());
                connection.Close();
                return id;
            }
            return -1;
        }
    }
}
