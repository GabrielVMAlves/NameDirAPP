using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameDirAPP
{
    public partial class Form1 : Form
    {
        Form2 frmAltDir;
        Form3 frmNewDir;
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void criarNovoDiretorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewDir = new Form3();
            frmNewDir.MdiParent = this;
            frmNewDir.Show();
            if (flag == 1)
            {
                frmAltDir.Close();
            }
            flag = 2;
        }

        private void alterarNomeDoDiretorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltDir = new Form2();
            frmAltDir.MdiParent = this;
            frmAltDir.Show();
            if (flag == 2)
            {
                frmNewDir.Close();
            }
            flag = 1;
        }
    }
}
