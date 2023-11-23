using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criarDiretorio_Click(object sender, EventArgs e)
        {
            string arqtxt = Application.StartupPath + @"\Pastinha";

            /// Criando um diretório para obter informações do Arquivo
            DirectoryInfo diretorio = new DirectoryInfo(arqtxt);

            try
            {
                if (diretorio.Exists)
                {
                    MessageBox.Show("Diretório Já Existe");
                    return;
                }

                diretorio.Create();
                MessageBox.Show("Diretório criado com Sucesso");
            }

            catch (Exception idiota)
            {
                MessageBox.Show("Não foi possível " + idiota.Message);
            }
        }

        private void apagarDiretorio_Click(object sender, EventArgs e)
        {
            string arqtxt = Application.StartupPath + @"\Pastinha";

            /// Criando um diretório para obter informações do Arquivo
            DirectoryInfo diretorio = new DirectoryInfo(arqtxt);

            try
            {
                if (!diretorio.Exists)
                {
                    MessageBox.Show("Diretório não Existe");
                    return;
                }

                diretorio.Delete();
                MessageBox.Show("Diretório Apagado");
            }

            catch (Exception idiota)
            {
                MessageBox.Show("Não foi possível " + idiota.Message);
            }
        }

        private void verInformacoes_Click(object sender, EventArgs e)
        {
            string arqtxt = @"C:\Users\aluno_lab4\Desktop\Eduvasco\Diretorio\Diretorio";

            DirectoryInfo diretorio = new DirectoryInfo(arqtxt);

            caixaLista.Items.Clear();
            caixaLista.Items.Add("diretorio completo: " + diretorio.FullName);
            caixaLista.Items.Add("diretorio principal: " + diretorio.Parent);
            caixaLista.Items.Add("nome do diretorio: " + diretorio.Name);
            caixaLista.Items.Add("data de criação: " + diretorio.CreationTime);
            caixaLista.Items.Add("atributos: " + diretorio.Attributes);
            caixaLista.Items.Add("existencia: " + diretorio.Exists);
            caixaLista.Items.Add("diretorio raiz: " + diretorio.Root);
            caixaLista.Items.Add(" ");

            DirectoryInfo[] dires = diretorio.GetDirectories();
            foreach (DirectoryInfo item in dires)
            {
                caixaLista.Items.Add("Pasta 1: " + item.FullName);
            }

            caixaLista.Items.Add(" ");
            FileInfo[] arqs = diretorio.GetFiles();

            foreach (FileInfo item in arqs)
            {
                caixaLista.Items.Add(item.Name);
            }


        }
        private void moverDiretorio_Click(object sender, EventArgs e)
        {
            string arqtxt = Application.StartupPath + @"\Pastinha";

            DirectoryInfo diretorio = new DirectoryInfo(arqtxt);

            try
            {
                if (diretorio.Exists)
                {
                    diretorio.MoveTo(@"C:\Users\aluno_lab4\Desktop\Eduvasco");
                    MessageBox.Show("Diretorio movido");
                }
            }

            catch (Exception er)
            {
                MessageBox.Show("Erro ao mover diretório " + er.Message);
            }
        }
    }
}
