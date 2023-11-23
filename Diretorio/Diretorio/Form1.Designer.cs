
namespace Diretorio
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
            this.caixaLista = new System.Windows.Forms.ListBox();
            this.criarDiretorio = new System.Windows.Forms.Button();
            this.apagarDiretorio = new System.Windows.Forms.Button();
            this.verInformacoes = new System.Windows.Forms.Button();
            this.moverDiretorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixaLista
            // 
            this.caixaLista.FormattingEnabled = true;
            this.caixaLista.Location = new System.Drawing.Point(30, 35);
            this.caixaLista.Name = "caixaLista";
            this.caixaLista.Size = new System.Drawing.Size(406, 368);
            this.caixaLista.TabIndex = 0;
            this.caixaLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // criarDiretorio
            // 
            this.criarDiretorio.Location = new System.Drawing.Point(469, 35);
            this.criarDiretorio.Name = "criarDiretorio";
            this.criarDiretorio.Size = new System.Drawing.Size(200, 52);
            this.criarDiretorio.TabIndex = 1;
            this.criarDiretorio.Text = "Criar Diretório";
            this.criarDiretorio.UseVisualStyleBackColor = true;
            this.criarDiretorio.Click += new System.EventHandler(this.criarDiretorio_Click);
            // 
            // apagarDiretorio
            // 
            this.apagarDiretorio.Location = new System.Drawing.Point(469, 146);
            this.apagarDiretorio.Name = "apagarDiretorio";
            this.apagarDiretorio.Size = new System.Drawing.Size(200, 52);
            this.apagarDiretorio.TabIndex = 2;
            this.apagarDiretorio.Text = "Apagar Diretório";
            this.apagarDiretorio.UseVisualStyleBackColor = true;
            this.apagarDiretorio.Click += new System.EventHandler(this.apagarDiretorio_Click);
            // 
            // verInformacoes
            // 
            this.verInformacoes.Location = new System.Drawing.Point(469, 245);
            this.verInformacoes.Name = "verInformacoes";
            this.verInformacoes.Size = new System.Drawing.Size(200, 52);
            this.verInformacoes.TabIndex = 3;
            this.verInformacoes.Text = "Ver Informações";
            this.verInformacoes.UseVisualStyleBackColor = true;
            this.verInformacoes.Click += new System.EventHandler(this.verInformacoes_Click);
            // 
            // moverDiretorio
            // 
            this.moverDiretorio.Location = new System.Drawing.Point(469, 351);
            this.moverDiretorio.Name = "moverDiretorio";
            this.moverDiretorio.Size = new System.Drawing.Size(200, 52);
            this.moverDiretorio.TabIndex = 4;
            this.moverDiretorio.Text = "Mover Diretório";
            this.moverDiretorio.UseVisualStyleBackColor = true;
            this.moverDiretorio.Click += new System.EventHandler(this.moverDiretorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.moverDiretorio);
            this.Controls.Add(this.verInformacoes);
            this.Controls.Add(this.apagarDiretorio);
            this.Controls.Add(this.criarDiretorio);
            this.Controls.Add(this.caixaLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox caixaLista;
        private System.Windows.Forms.Button criarDiretorio;
        private System.Windows.Forms.Button apagarDiretorio;
        private System.Windows.Forms.Button verInformacoes;
        private System.Windows.Forms.Button moverDiretorio;
    }
}

