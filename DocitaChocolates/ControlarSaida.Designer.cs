namespace DocitaChocolates
{
    partial class ControlarSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lstvProdutos = new System.Windows.Forms.ListView();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtQtdSaida = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(442, 82);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(96, 13);
            this.lblPesquisa.TabIndex = 40;
            this.lblPesquisa.Text = "Pesquisar Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Produtos Cadastrados";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo Unidade";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID Tipo de Unidade";
            this.columnHeader8.Width = 149;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantidade MIN";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantidade MAX";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço de Custo";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.Width = 256;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 261;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(544, 79);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(294, 20);
            this.txtPesquisa.TabIndex = 39;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged_1);
            // 
            // lstvProdutos
            // 
            this.lstvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstvProdutos.FullRowSelect = true;
            this.lstvProdutos.GridLines = true;
            this.lstvProdutos.Location = new System.Drawing.Point(433, 117);
            this.lstvProdutos.Name = "lstvProdutos";
            this.lstvProdutos.Size = new System.Drawing.Size(443, 242);
            this.lstvProdutos.TabIndex = 37;
            this.lstvProdutos.UseCompatibleStateImageBehavior = false;
            this.lstvProdutos.View = System.Windows.Forms.View.Details;
            this.lstvProdutos.SelectedIndexChanged += new System.EventHandler(this.lstvProdutos_SelectedIndexChanged_1);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(24, 336);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(129, 23);
            this.btnBaixar.TabIndex = 34;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtQtdSaida
            // 
            this.txtQtdSaida.Location = new System.Drawing.Point(97, 290);
            this.txtQtdSaida.Name = "txtQtdSaida";
            this.txtQtdSaida.Size = new System.Drawing.Size(89, 20);
            this.txtQtdSaida.TabIndex = 33;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(8, 293);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(83, 13);
            this.lblQtde.TabIndex = 32;
            this.lblQtde.Text = "Qtd para Baixar:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(55, 252);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(318, 20);
            this.txtMarca.TabIndex = 31;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(9, 255);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 30;
            this.lblMarca.Text = "Marca:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 205);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 208);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 160);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 163);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DocitaChocolates.Properties.Resources.docita;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(55, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 136);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Estoque: ";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(273, 290);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 42;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(191, 335);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 43;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ControlarSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 379);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lstvProdutos);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.txtQtdSaida);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.panel1);
            this.Name = "ControlarSaida";
            this.Text = "ControlarSaida";
            this.Load += new System.EventHandler(this.ControlarSaida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ListView lstvProdutos;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.TextBox txtQtdSaida;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnNovo;
    }
}