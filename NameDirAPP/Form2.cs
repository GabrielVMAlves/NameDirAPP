using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameDirAPP
{
    public partial class Form2 : Form
    {
        string originPath;
        string userPath = Environment.GetEnvironmentVariable("userprofile");
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAltDir_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            string newPath = txtNewPath.Text;
            string client = txtClient.Text;

            if (path.Equals(""))
            {
                MessageBox.Show("Favor inserir o nome atual da Pasta! Exemplo AI000_Informacoes_Gerais");
                txtPath.Focus();
            }
            else if (newPath.Equals(""))
            {
                MessageBox.Show("Favor inserir o novo nome da Pasta! Exemplo AI001_Aplicacao");
                txtNewPath.Focus();
            }
            else if(client.Equals(""))
            {
                MessageBox.Show("Favor inserir o Cliente! Exemplo AmericaMovil_AI");
                txtNewPath.Focus();
            }
            else
            {
                originPath = userPath;
                originPath += @"\AppData\Local\Temp";
                MessageBox.Show(originPath);
                createBatch(path, newPath);
            }
        }

        public String stringTreatment(string t)
        {
            string initial = t;
            string final;
            final = Regex.Replace(initial.Normalize(NormalizationForm.FormD), "[^A-Za-z0-9 | ]", string.Empty);
            final = final.Replace(" ", @"_");
            MessageBox.Show(final);

            return final;
        }

        public void createBatch(string o, string n)
        {
            try
            {
                stringTreatment(o);
                System.IO.StreamWriter sw = new StreamWriter(originPath + "\\" + "MeuArquivo.bat", false);
                userPath = userPath.Remove(0, 2);
                sw.WriteLine("@echo");
                sw.WriteLine("c:");
                sw.WriteLine("cd "+userPath+@"\Desktop");
                sw.WriteLine("REN "+o+" "+n);
                sw.WriteLine("pause");
                sw.Close();

                Process processo = new Process();
                processo.StartInfo.FileName = originPath + "\\" + "MeuArquivo.bat";
                processo.Start();
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtClient.Clear();
            txtNewPath.Clear();
            txtPath.Clear();
        }

        private void alterarNomeDoDiretorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmAltDir;
            frmAltDir = new Form2();
            frmAltDir.MdiParent = this;
            frmAltDir.Show();
        }
    }
}
