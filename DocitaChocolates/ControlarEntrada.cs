using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocitaChocolates
{
    public partial class ControlarEntrada : Form{

        MySqlConnection conMySql = new MySqlConnection("host=localhost; uid=root; " +
            "password=; database=docitabd");
        MySqlCommand cmdMySql = new MySqlCommand();
        MySqlDataReader reader;

        double qtdMaxima;
        double estoque;
        double entrada;


        public ControlarEntrada()
        {
            InitializeComponent();
        }


        void carregarProdutos()
        {

            cmdMySql.Connection = conMySql;
            try
            {
                lstvProdutos.Items.Clear();
                if (txtPesquisa.Text == ""){
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id ORDER BY nome ASC";
                }
                else if(txtPesquisa.Text != ""){
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id AND nome LIKE '" +
                        txtPesquisa.Text + "%' ORDER BY nome ASC";
                }
                reader = cmdMySql.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem list = new ListViewItem(reader[0].ToString());
                    list.SubItems.Add(reader[2].ToString());
                    list.SubItems.Add(reader[3].ToString());
                    list.SubItems.Add(reader[4].ToString());
                    list.SubItems.Add(reader[5].ToString());
                    list.SubItems.Add(reader[6].ToString());
                    list.SubItems.Add(reader[7].ToString());
                    list.SubItems.Add(reader[1].ToString());
                    list.SubItems.Add(reader[9].ToString());

                    lstvProdutos.Items.AddRange(new ListViewItem[] { list });
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            {
            }
        }

        private void ControlarProduto_Load(object sender, EventArgs e)
        {

            conMySql.Open();

            carregarProdutos();

            
        }

        private void gBoxTipoProd_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[0].Text;
                txtNome.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[1].Text;
                txtMarca.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[2].Text;                
                string qtdEstoque = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[4].Text;
                string max = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[5].Text;
                qtdMaxima = Convert.ToDouble(max.ToString());
                estoque = Convert.ToDouble(qtdEstoque.ToString());
                txtEstoque.Text = estoque.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Não Existem Registros na Lista!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cod = txtCodigo.Text;
            string nome = txtNome.Text;
            string marca = txtMarca.Text;
            string qtdEntrada = txtQtdEntrada.Text;
            string dataFabric = dateTmFabric.Value.ToString("yyyy-MM-dd");
            string dataValid = dateTmValid.Value.ToString("yyyy-MM-dd");
            string dataAtul = DateTime.Now.ToString("yyyy-MM-dd");
            int diasPVenc;

            entrada = Convert.ToDouble(qtdEntrada.ToString());

            DateTime dataInicial = Convert.ToDateTime(dataAtul.ToString());
            DateTime dataFinal = Convert.ToDateTime(dataValid.ToString());

            TimeSpan diferenca = dataFinal.Subtract(dataInicial);

            diasPVenc = diferenca.Days;

            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Informe o Nome do Produto!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                }
                else if (txtMarca.Text == "")
                {
                    MessageBox.Show("Informe a Marca do Produto!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarca.Focus();
                }
                else if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Informe o preço do produto!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                }
                
                else if (txtQtdEntrada.Text == "")
                {
                    MessageBox.Show("Informe a quantidade minima do Produto!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdEntrada.Focus();
                }
                else {
                    if (diasPVenc <= 0)  {

                        MessageBox.Show("Data de validade é menor que a data atual!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else { 

                        estoque = estoque + entrada;
                        cmdMySql.CommandText = "INSERT INTO entradaprodutos(idProduto, qtdEntrada, dataFabric, dataValid, dataEntrada, diasParaVenc)"
                                + "VALUES(" + cod + ",'" + entrada.ToString(CultureInfo.InvariantCulture) + "','" + dataFabric.ToString() + "','" + dataValid.ToString() + "','" + dataAtul.ToString() + "', " + diasPVenc.ToString() + ");";

                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();

                        cmdMySql.CommandText = "UPDATE produtos SET quantidade='" + estoque.ToString(CultureInfo.InvariantCulture) + "' WHERE id="
                                + cod + ";";
                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();

                        MessageBox.Show("Registro Salvo com Sucesso!", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(qtdMaxima < (estoque + entrada)) { 
                            MessageBox.Show("Seu estoque ultrapassou a quantidade máxima permitida para o produto!", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                }
                btnNovo.PerformClick();
                carregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtMarca.Text = "";
            txtQtdEntrada.Text = "";
            txtEstoque.Text = "";
            txtPesquisa.Text = "";

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            
            CadastroProduto cadastro = new CadastroProduto();
            this.Close();
            cadastro.Show();
        }
    }
}
