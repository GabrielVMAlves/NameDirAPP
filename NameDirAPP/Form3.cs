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
    public partial class Form3 : Form
    {
        string originPath;
        string userPath = Environment.GetEnvironmentVariable("userprofile");
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNewDir_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            string cod = txtCod.Text;
            string nameDir = txtName.Text;

            if (path.Equals(""))
            {
                MessageBox.Show("Favor inserir o Path! Exemplo AmericaMovil_AI");
                txtPath.Focus();
            }
            else if (nameDir.Equals(""))
            {
                MessageBox.Show("Favor inserir o nome da pasta! Exemplo Informacoes_Gerais");
                txtName.Focus();
            }
            else if (cod.Equals(""))
            {
                MessageBox.Show("Favor inserir o Código! Exemplo AI000");
                txtCod.Focus();
            }
            else
            {
                MessageBox.Show(path + " " + cod + " " + nameDir + "!");
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
                sw.WriteLine("cd " + userPath + @"\Desktop");
                sw.WriteLine("REN " + o + " " + n);
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
            txtCod.Clear();
            txtName.Clear();
            txtPath.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
