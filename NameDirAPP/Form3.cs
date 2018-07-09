using IWshRuntimeLibrary;
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
                try
                {
                    createFolders(cod, nameDir, path);
                }catch(Exception k)
                {
                    MessageBox.Show(k.Message);
                }
                
            }
        }

        public String stringTreatment(string t)
        {
            string initial = t;
            string final;
            final = Regex.Replace(initial.Normalize(NormalizationForm.FormD), "[^A-Za-z0-9 | ]", string.Empty);
            final = final.Replace(" ", @"_");

            return final;
        }

        public void createFolders(string cod, string nameDir, string path)
        {
            cod = stringTreatment(cod);
            nameDir = stringTreatment(nameDir);
            path = stringTreatment(path);
            string teste = @"C:\"+path+@"\"+cod+"_"+nameDir;
            string teste1 = @"d:\" + path + @"\" + cod + "_" + nameDir;
            Directory.CreateDirectory(teste);
            Directory.CreateDirectory(teste1);

            try
            {

                var wshShell = new WshShellClass();
                string ShortcutFile = teste + ".ink";
                string TargetPath = teste1;
                IWshRuntimeLibrary.IWshShortcut shorcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(ShortcutFile);
                shorcut.TargetPath = TargetPath;
                shorcut.Save();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message+" parte2");
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
