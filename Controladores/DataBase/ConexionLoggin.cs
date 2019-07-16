using System;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using GUI_AUGUR_V3.ModelosClases;

namespace GUI_AUGUR_V3.DataBase{
    class ConexionLoggin {
        public ConexionLoggin() { }
        private readonly string connection_string = "Data Source=DESKTOP-9G3OD0K\\ISAAC_SQL_SERVER;Initial Catalog=AUGUR;Integrated Security=True";
        private string query_string = "";
        private SqlConnection connection;
        private SqlCommand command_query;
        private SqlDataReader readerSet;
        private MD5 md5_convertor = MD5.Create();
        byte[] inputBytes, hash;
        private StringBuilder builder_string;
        public string md5_string(string pass) {
            inputBytes = Encoding.ASCII.GetBytes(pass);
            hash = md5_convertor.ComputeHash(inputBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++) {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }
        public Usuario consultarUsuario(string user) {
            Usuario user_object;
            connection = new SqlConnection(connection_string);
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
                connection = new SqlConnection(connection_string);
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
            connection = new SqlConnection(connection_string);
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
