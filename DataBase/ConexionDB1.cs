using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GUI_AUGUR_V3.DataBase{
    class ConexionDB1 {
        public ConexionDB1 () {
        }
        private String connection_string = "Data Source=DESKTOP-9G3OD0K\\ISAAC_SQL_SERVER;Initial Catalog=prueba1_AugurV3;Integrated Security=True";
        private String user_this = "", pass_this = "";
        private SqlConnection connection;
        private SqlCommand command_query;
        private SqlDataReader readerSet;
        private String query_string = "";
        private MD5 md5_convertor = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes, hash;
        private StringBuilder builder_string;
        private String md5_string(String pass) {
            inputBytes =  System.Text.Encoding.ASCII.GetBytes(pass);
            hash = md5_convertor.ComputeHash(inputBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++) {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }
        public bool validarLoggin(String user, String pass){
            connection = new SqlConnection(connection_string);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open){
                query_string = "select userid, pass from empleado where idEmp = 1;";
                command_query = new SqlCommand(query_string, connection);
                readerSet = command_query.ExecuteReader();
                if (readerSet.Read()) {
                    user_this = Convert.ToString(readerSet["userid"]);
                    pass_this = Convert.ToString(readerSet["pass"]);
                    System.Console.WriteLine(pass_this);
                }
                connection.Close();
                return user.ToString() == user_this && md5_string(pass.ToString()) == pass_this;
            } else {
                MessageBox.Show("Error en la conexión de base de datos");
                return false;
            }
        }
    }
}
