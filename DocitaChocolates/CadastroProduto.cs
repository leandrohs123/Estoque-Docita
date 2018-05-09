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
    public partial class CadastroProduto : Form
    {

        MySqlConnection conMySql = new MySqlConnection("host=localhost; uid=root; " +
            "password=; database=docitabd");
        MySqlCommand cmdMySql = new MySqlCommand();
        MySqlDataReader reader;
        int idTpUn = 0;


        public CadastroProduto()
        {
            InitializeComponent();

            conMySql.Open();

            carregarProdutos();

            
            cmdMySql.Connection = conMySql;
            cmdMySql.CommandText = "select tipo from unidade;";
            reader = cmdMySql.ExecuteReader();
            DataTable dtUn = new DataTable();
            dtUn.Load(reader);
            cmbTipoUn.DisplayMember = "tipo";
            cmbTipoUn.DataSource = dtUn;            
        }


        void carregarProdutos(){
            
            cmdMySql.Connection = conMySql;
            try
            {
                lstvProdutos.Items.Clear();
                if (txtPesNome.Text == "" && txtPesMarca.Text == ""){//ou contato
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id ORDER BY nome ASC";
                }else if (txtPesNome.Text != "" && txtPesMarca.Text == ""){
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id AND nome LIKE '" +
                        txtPesNome.Text + "%' ORDER BY nome ASC";
                }else if (txtPesNome.Text == "" && txtPesMarca.Text != ""){
                    cmdMySql.CommandText = "SELECT * FROM produtos,unidade WHERE produtos.idunidade = unidade.id AND marca LIKE '" +
                        txtPesMarca.Text + "%' ORDER BY marca ASC";
                }
                reader = cmdMySql.ExecuteReader();

                while (reader.Read()){
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
            }catch (Exception ex) { MessageBox.Show(ex.ToString()); }{
            }
        }

        private void cmbTipoUn_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTpUn = (cmbTipoUn.SelectedIndex + 1);
            
        }

        private void btnSalvar_Click(object sender, EventArgs e){

            string nome = txtNome.Text;
            string marca = txtMarca.Text;
            string preco = txtPrecoCusto.Text;
            string qtdMax = txtQtdMax.Text;
            string qtdMin = txtQtdMin.Text;
            string qtd = "0";


            double precoCust = double.Parse(preco);
            double max = double.Parse(qtdMax);
            double min = double.Parse(qtdMin);
            double qtdEstoque = double.Parse(qtd);

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
                else if (txtPrecoCusto.Text == "")
                {
                    MessageBox.Show("Informe o preço do produto!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoCusto.Focus();
                }
                else if (txtQtdMax.Text == "")
                {
                    MessageBox.Show("Informe a quantidade maxima do Produto!", "Warning",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtQtdMin.Text == "")
                {
                    MessageBox.Show("Informe a quantidade minima do Produto!", "Warning",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else{
                    if (max <= min)
                    {
                        MessageBox.Show("Erro quantidade mínima maior ou igual a máxima!", "Salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmdMySql.CommandText = "INSERT INTO produtos(idunidade, nome, marca, precoCusto, quantidade, quantidadeMax, quantidadeMin)"
                            + "VALUES(" + idTpUn + ", '" + nome + "','" + marca + "', " + precoCust.ToString(CultureInfo.InvariantCulture) + "," + qtdEstoque.ToString(CultureInfo.InvariantCulture) + "," + max.ToString(CultureInfo.InvariantCulture) + "," + min.ToString(CultureInfo.InvariantCulture) + ");";
                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();
                        MessageBox.Show("Registro Salvo com Sucesso!", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                btnNovo.PerformClick();
                carregarProdutos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtMarca.Text = "";
            txtPrecoCusto.Text = "";
            txtQtdMax.Text = "";
            txtQtdMin.Text = "";
            txtPesMarca.Text = "";
            txtPesNome.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e){
            string nome = txtNome.Text;
            string marca = txtMarca.Text;
            string preco = txtPrecoCusto.Text;
            string qtdMax = txtQtdMax.Text;
            string qtdMin = txtQtdMin.Text;

            double precoCust = double.Parse(preco);
            double max = double.Parse(qtdMax);
            double min = double.Parse(qtdMin);

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
                else if (txtPrecoCusto.Text == "")
                {
                    MessageBox.Show("Informe o preço do produto!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoCusto.Focus();
                }
                else if (txtQtdMax.Text == "")
                {
                    MessageBox.Show("Informe a quantidade maxima do Produto!", "Warning",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtQtdMin.Text == "")
                {
                    MessageBox.Show("Informe a quantidade minima do Produto!", "Warning",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else{
                    if (max <= min)
                    {
                        MessageBox.Show("Erro quantidade mínima maior ou igual a máxima!", "Salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        cmdMySql.CommandText = "UPDATE produtos SET idUnidade='" + idTpUn + "', nome='" + txtNome.Text + "', marca='" + txtMarca.Text + "', precoCusto='" + precoCust.ToString(CultureInfo.InvariantCulture) + "', quantidadeMax='" + max.ToString(CultureInfo.InvariantCulture) + "',quantidadeMin='" + min.ToString(CultureInfo.InvariantCulture) + "' WHERE id='"
                            + lstvProdutos.Items[lstvProdutos.FocusedItem.Index].Text + "'";
                        cmdMySql.ExecuteNonQuery();
                        cmdMySql.Dispose();
                        MessageBox.Show("Registro Salvo com Sucesso!", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                carregarProdutos();
                btnNovo.PerformClick();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
           if (MessageBox.Show("Deseja Deletar o Item Selecionado?", "Encerrar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmdMySql.CommandText = "DELETE FROM produtos WHERE id='"
                        + lstvProdutos.Items[lstvProdutos.FocusedItem.Index].Text + "'";
                    cmdMySql.ExecuteNonQuery();
                    MessageBox.Show("Registro Deletado com Sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNovo.PerformClick();
                    carregarProdutos();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você Precisa Selecionar um Contato para Deletar!");
                }
           }
            
        }

        private void lstvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtNome.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[1].Text;
                txtMarca.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[2].Text;
                txtPrecoCusto.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[3].Text;
                txtQtdMax.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[6].Text;
                txtQtdMin.Text = lstvProdutos.Items[lstvProdutos.FocusedItem.Index].SubItems[7].Text;

            }
            catch (Exception)
            {
                MessageBox.Show("Não Existem Registros na Lista!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Encerrar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                conMySql.Close();
                this.Close();
            }
        }

        private void txtPesNome_TextChanged(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void txtPesMarca_TextChanged(object sender, EventArgs e)
        {
            carregarProdutos();
        }
    }
}
