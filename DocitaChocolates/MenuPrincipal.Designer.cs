namespace DocitaChocolates
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDeProdutosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrosDeProdutosToolStripMenuItem
            // 
            this.cadastrosDeProdutosToolStripMenuItem.Name = "cadastrosDeProdutosToolStripMenuItem";
            this.cadastrosDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastrosDeProdutosToolStripMenuItem.Text = "Cadastros de Produtos";
            this.cadastrosDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDeProdutosToolStripMenuItem_Click);
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeProdutoToolStripMenuItem,
            this.controleDeSaídaToolStripMenuItem});
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.controleToolStripMenuItem.Text = "Controle ";
            // 
            // controleDeProdutoToolStripMenuItem
            // 
            this.controleDeProdutoToolStripMenuItem.Name = "controleDeProdutoToolStripMenuItem";
            this.controleDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.controleDeProdutoToolStripMenuItem.Text = "Controle de Entrada";
            this.controleDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.controleDeProdutoToolStripMenuItem_Click);
            // 
            // controleDeSaídaToolStripMenuItem
            // 
            this.controleDeSaídaToolStripMenuItem.Name = "controleDeSaídaToolStripMenuItem";
            this.controleDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.controleDeSaídaToolStripMenuItem.Text = "Controle de Saída";
            this.controleDeSaídaToolStripMenuItem.Click += new System.EventHandler(this.controleDeSaídaToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DocitaChocolates.Properties.Resources.tela_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 607);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Sistema Docita";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeSaídaToolStripMenuItem;
    }
}