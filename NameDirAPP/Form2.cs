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
        string userPath;
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
                MessageBox.Show(originPath);
                createBatch(path, newPath, client);
            }
        }

        public String stringTreatment(string t)
        {
            string initial = t;
            string final;
            final = Regex.Replace(initial.Normalize(NormalizationForm.FormD), "[^A-Za-z0-9_ | ]", string.Empty);
            final = final.Replace(" ", @"_");
            MessageBox.Show(final);

            return final;
        }

        public void createBatch(string o, string n, string c)
        {
            try
            {
                userPath = Environment.GetEnvironmentVariable("userprofile");
                originPath = userPath+""+@"\AppData\Local\Temp";
                n = stringTreatment(n);

                System.IO.StreamWriter sw = new StreamWriter(originPath + "\\" + "MeuArquivo.bat", false);
                userPath = userPath.Remove(0, 2);

                sw.WriteLine("@echo off");
                sw.WriteLine("cls");
                //entrando nos diretorios e renomeando as pastas
                sw.WriteLine("G:");
                sw.WriteLine("cd "+c);
                sw.WriteLine("REN "+o+" "+n);
                sw.WriteLine("@echo Pasta renomeada no Atendimento");
                sw.WriteLine("I:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada na Ilustracao");
                sw.WriteLine("J:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada na Interacao");
                sw.WriteLine("K:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada na Midia");
                sw.WriteLine("N:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada no Planejamento");
                sw.WriteLine("L:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada na PreProducao");
                sw.WriteLine("W:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada na Programacao");
                sw.WriteLine("H:");
                sw.WriteLine("cd " + c);
                sw.WriteLine("REN " + o + " " + n);
                sw.WriteLine("@echo Pasta renomeada no Projetos");
                //criando os atalhos
                sw.WriteLine(@"shortcut /f:'\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n  +@"\Atendimento.lnk' /a:c /t:'\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Midia$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Atendimento.lnk /a:c /t:\\CIA-SRV-FS-03\Atendimento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Ilustracao.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Interacao.lnk /a:c /t:\\CIA-SRV-FS-03\Interacao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Midia.lnk /a:c /t:\\CIA-SRV-FS-03\Ilustracao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Planejamento.lnk /a:c /t:\\CIA-SRV-FS-03\Planejamento$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\PreProducao.lnk /a:c /t:\\CIA-SRV-FS-03\PreProducao$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Projetos.lnk /a:c /t:\\CIA-SRV-FS-03\Projetos$" + c + @"\" + n + "");
                sw.WriteLine(@"shortcut /f:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + @"\Programacao.lnk /a:c /t:\\CIA-SRV-FS-03\Programacao$" + c + @"\" + n + "");

                sw.WriteLine("pause");
                sw.Close();

                Process processo = new Process();
                processo.StartInfo.FileName = originPath + "\\" + "MeuArquivo.bat";
                processo.Start();
                //System.IO.File.Delete(originPath + "\\" + "MeuArquivo.bat");
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
