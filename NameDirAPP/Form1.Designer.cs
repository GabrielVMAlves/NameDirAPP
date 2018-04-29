namespace NameDirAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovoDiretorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarNomeDoDiretorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovoDiretorioToolStripMenuItem,
            this.alterarNomeDoDiretorioToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // criarNovoDiretorioToolStripMenuItem
            // 
            this.criarNovoDiretorioToolStripMenuItem.Name = "criarNovoDiretorioToolStripMenuItem";
            this.criarNovoDiretorioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.criarNovoDiretorioToolStripMenuItem.Text = "Criar novo diretorio";
            this.criarNovoDiretorioToolStripMenuItem.Click += new System.EventHandler(this.criarNovoDiretorioToolStripMenuItem_Click);
            // 
            // alterarNomeDoDiretorioToolStripMenuItem
            // 
            this.alterarNomeDoDiretorioToolStripMenuItem.Name = "alterarNomeDoDiretorioToolStripMenuItem";
            this.alterarNomeDoDiretorioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.alterarNomeDoDiretorioToolStripMenuItem.Text = "Alterar nome do diretorio";
            this.alterarNomeDoDiretorioToolStripMenuItem.Click += new System.EventHandler(this.alterarNomeDoDiretorioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NameDirAPP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovoDiretorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarNomeDoDiretorioToolStripMenuItem;
    }
}

