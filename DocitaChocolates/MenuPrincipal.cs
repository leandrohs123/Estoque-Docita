using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocitaChocolates
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cadastrosDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastro = new CadastroProduto();
            cadastro.Show();

        }

        private void controleDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlarEntrada controleDeProduto = new ControlarEntrada();
            controleDeProduto.Show();
        }
                
        private void controleDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlarSaida controleDeSaida = new ControlarSaida();
            controleDeSaida.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Encerrar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
