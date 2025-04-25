using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UC12_usuario
{
    internal class MySQLConexao
    {
        public static string servidor = "Server=10.55.51.43;Database=bd_usuario;Uid=b2024;Pwd=P@ssw0rd";

        public static MySqlConnection conexao = null;
        public static MySqlCommand comando = null;
    }
}
