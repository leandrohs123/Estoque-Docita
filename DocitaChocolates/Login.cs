using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocitaChocolates
{
    public partial class Login : Form{
        MySqlDataReader reader;
        public Login(){
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnEntrar_Click(object sender, EventArgs e){

           string query = "SELECT * FROM login WHERE nome=@nome AND senha=@senha";

            Conexao conexao = new Conexao();
            conexao.conectar();

            MySqlCommand cmdMySQL = new MySqlCommand(query, conexao.conMySQL);
            cmdMySQL.Parameters.AddWithValue("@nome", txtUsuario.Text);
            cmdMySQL.Parameters.AddWithValue("@senha", txtSenha.Text);
            reader = cmdMySQL.ExecuteReader();

            if (reader.Read())
            {
                Altenticacao.login(reader["nome"].ToString(), reader["senha"].ToString());
                this.Hide();
                MenuPrincipal form = new MenuPrincipal();
                form.Closed += (s, args) => this.Close();
                form.Show();

            }
            else
            {
                MessageBox.Show("ERRO: Usuário ou senha não encontrados...");
            }
            

        }
    }
}
