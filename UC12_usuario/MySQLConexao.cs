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
        public static string servidor = "Server=10.55.51.37;Database=iamanaka_bd_usuarios;Uid=senac;Pwd=senac2025";

        public static MySqlConnection conexao = null;
        public static MySqlCommand comando = null;
    }
}
