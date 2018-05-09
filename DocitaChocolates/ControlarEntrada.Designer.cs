namespace DocitaChocolates
{
    partial class ControlarEntrada
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblQtdeAtual = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblQuantEntrada = new System.Windows.Forms.Label();
            this.txtQtdEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dateTmFabric = new System.Windows.Forms.DateTimePicker();
            this.dateTmValid = new System.Windows.Forms.DateTimePicker();
            this.lblDtFabr = new System.Windows.Forms.Label();
            this.lblDtVal = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::DocitaChocolates.Properties.Resources.novo1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(271, 506);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(74, 76);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::DocitaChocolates.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(71, 506);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 76);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DocitaChocolates.Properties.Resources.docita;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(21, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 181);
            this.panel2.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(36, 214);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(29, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Cod:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 211);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(48, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 244);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 239);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblQtdeAtual
            // 
            this.lblQtdeAtual.AutoSize = true;
            this.lblQtdeAtual.Location = new System.Drawing.Point(27, 352);
            this.lblQtdeAtual.Name = "lblQtdeAtual";
            this.lblQtdeAtual.Size = new System.Drawing.Size(101, 13);
            this.lblQtdeAtual.TabIndex = 16;
            this.lblQtdeAtual.Text = "Quant. em Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(151, 349);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(254, 20);
            this.txtEstoque.TabIndex = 17;
            // 
            // lblQuantEntrada
            // 
            this.lblQuantEntrada.AutoSize = true;
            this.lblQuantEntrada.Location = new System.Drawing.Point(27, 325);
            this.lblQuantEntrada.Name = "lblQuantEntrada";
            this.lblQuantEntrada.Size = new System.Drawing.Size(82, 13);
            this.lblQuantEntrada.TabIndex = 20;
            this.lblQuantEntrada.Text = "Quant. Entrada:";
            // 
            // txtQtdEntrada
            // 
            this.txtQtdEntrada.Location = new System.Drawing.Point(150, 318);
            this.txtQtdEntrada.Name = "txtQtdEntrada";
            this.txtQtdEntrada.Size = new System.Drawing.Size(255, 20);
            this.txtQtdEntrada.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Produtos Cadastrados";
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
            this.lstvProdutos.Location = new System.Drawing.Point(466, 149);
            this.lstvProdutos.Name = "lstvProdutos";
            this.lstvProdutos.Size = new System.Drawing.Size(503, 395);
            this.lstvProdutos.TabIndex = 23;
            this.lstvProdutos.UseCompatibleStateImageBehavior = false;
            this.lstvProdutos.View = System.Windows.Forms.View.Details;
            this.lstvProdutos.SelectedIndexChanged += new System.EventHandler(this.lstvProdutos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 261;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.Width = 256;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço de Custo";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantidade MAX";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantidade MIN";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID Tipo de Unidade";
            this.columnHeader8.Width = 149;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pesquisa de Produto:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(577, 86);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(312, 20);
            this.txtPesquisa.TabIndex = 25;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dateTmFabric
            // 
            this.dateTmFabric.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTmFabric.Location = new System.Drawing.Point(92, 446);
            this.dateTmFabric.Name = "dateTmFabric";
            this.dateTmFabric.Size = new System.Drawing.Size(111, 20);
            this.dateTmFabric.TabIndex = 26;
            this.dateTmFabric.Value = new System.DateTime(2018, 4, 30, 0, 0, 0, 0);
            this.dateTmFabric.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTmValid
            // 
            this.dateTmValid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTmValid.Location = new System.Drawing.Point(333, 445);
            this.dateTmValid.Name = "dateTmValid";
            this.dateTmValid.Size = new System.Drawing.Size(111, 20);
            this.dateTmValid.TabIndex = 27;
            this.dateTmValid.Value = new System.DateTime(2018, 4, 30, 0, 0, 0, 0);
            // 
            // lblDtFabr
            // 
            this.lblDtFabr.AutoSize = true;
            this.lblDtFabr.Location = new System.Drawing.Point(30, 451);
            this.lblDtFabr.Name = "lblDtFabr";
            this.lblDtFabr.Size = new System.Drawing.Size(57, 13);
            this.lblDtFabr.TabIndex = 28;
            this.lblDtFabr.Text = "Data Fabr.";
            // 
            // lblDtVal
            // 
            this.lblDtVal.AutoSize = true;
            this.lblDtVal.Location = new System.Drawing.Point(268, 451);
            this.lblDtVal.Name = "lblDtVal";
            this.lblDtVal.Size = new System.Drawing.Size(59, 13);
            this.lblDtVal.TabIndex = 29;
            this.lblDtVal.Text = "Data Valid.";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(624, 573);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(255, 23);
            this.btnNovoProduto.TabIndex = 30;
            this.btnNovoProduto.Text = "Cadastrar Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 273);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 31;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(76, 270);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(329, 20);
            this.txtMarca.TabIndex = 32;
            // 
            // ControlarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 607);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.lblDtVal);
            this.Controls.Add(this.lblDtFabr);
            this.Controls.Add(this.dateTmValid);
            this.Controls.Add(this.dateTmFabric);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstvProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdEntrada);
            this.Controls.Add(this.lblQuantEntrada);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblQtdeAtual);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.panel2);
            this.Name = "ControlarEntrada";
            this.Text = "Controlar Entrada";
            this.Load += new System.EventHandler(this.ControlarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblQtdeAtual;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblQuantEntrada;
        private System.Windows.Forms.TextBox txtQtdEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DateTimePicker dateTmFabric;
        private System.Windows.Forms.DateTimePicker dateTmValid;
        private System.Windows.Forms.Label lblDtFabr;
        private System.Windows.Forms.Label lblDtVal;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
    }
}