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
    public partial class ControlarSaida : Form {
        MySqlConnection conMySql = new MySqlConnection("host=localhost; uid=root; " +
            "password=; database=docitabd");
        MySqlCommand cmdMySql = new MySqlCommand();
        MySqlDataReader reader;

        double qtdMinima;
        double estoque;
        double baixa;

        public ControlarSaida()
        {
            InitializeComponent();
        }

        void carregarProdutos()
        {

            cmdMySql.Connection = conMySql;
            try
            {
                lstvProdutos.Items.Clear();
                if (txtPesquisa.Text == "")
                {
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id ORDER BY nome ASC";
                }
                else if (txtPesquisa.Text != "")
                {
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE nome LIKE '" +
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

        private void ControlarSaida_Load(object sender, EventArgs e)
        {
            conMySql.Open();

            carregarProdutos();
        }

        private void lstvProdutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[0].Text;
                txtNome.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[1].Text;
                txtMarca.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[2].Text;
                string qtdEstoque = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[4].Text;
                string min = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[6].Text;
                qtdMinima = Convert.ToDouble(min.ToString());
                estoque = Convert.ToDouble(qtdEstoque.ToString());
                txtEstoque.Text = estoque.ToString(CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                MessageBox.Show("Não Existem Registros na Lista!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            string cod = txtCodigo.Text;
            string nome = txtNome.Text;
            string marca = txtMarca.Text;
            string qtdSaida = txtQtdSaida.Text;
            string dataAtul = DateTime.Now.ToString("yyyy-MM-dd");

            baixa = Convert.ToDouble(qtdSaida.ToString());

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

                else if (txtQtdSaida.Text == "")
                {
                    MessageBox.Show("Informe a quantidade minima do Produto!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdSaida.Focus();
                }
                else
                {
                    if ((estoque - baixa) < 0)
                    {

                        MessageBox.Show("Quantidade de Saida é maior que seu estoque!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(baixa == 0)
                    {
                        MessageBox.Show("Quantidade de igual a zero informe uma quantidade!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtQtdSaida.Text = "";
                        txtQtdSaida.Focus();
                    }
                    else
                    {

                        estoque = estoque - baixa;
                        cmdMySql.CommandText = "INSERT INTO saidaprodutos(idProduto, qtdSaida, dataSaida)"
                                + "VALUES(" + cod + ",'" + baixa.ToString(CultureInfo.InvariantCulture) + "','" + dataAtul.ToString() + "');";

                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();

                        cmdMySql.CommandText = "UPDATE produtos SET quantidade='" + estoque.ToString(CultureInfo.InvariantCulture) + "' WHERE id="
                                + cod + ";";
                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();

                        MessageBox.Show("Registro Salvo com Sucesso!", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (qtdMinima >= (estoque - baixa))
                        {
                            MessageBox.Show("Seu estoque está menor que quantidade mínima permitida para o produto!", "OK",
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
            txtEstoque.Text = "";
            txtQtdSaida.Text = "";
            txtPesquisa.Text = "";
        }
    }
}
