using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocitaChocolates
{
    static class Altenticacao
    {
        static string nome;
        static string senha;

        public static void login(string nome1, string senha1)
        {
            nome = nome1;
            senha = senha1;
        }

        public static string getUsuario()
        {
            return "Usuario: " + nome + "\nSenha: " + senha;
        }
    }
}
