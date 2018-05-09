using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DocitaChocolates
{
    class Conexao
    {
        public MySqlConnection conMySQL = new MySqlConnection();

        public void conectar()
        {
            conMySQL.ConnectionString = "host = localhost; uid = root; password =; database = docitabd";
            conMySQL.Open();
        }

        public void desconectar()
        {
            conMySQL.Close();
        }
    }
}
