using System;
using System.Windows.Forms;

namespace Salesplank
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            lblColorContratos.Visible = false;
        }

        private void btnFecharSup_Click(object sender, EventArgs e) => Close();
        private void btnFechar_Click(object sender, EventArgs e) => Close();
        private void btnPropostas_Click(object sender, EventArgs e)
        {
            lblColorContratos.Visible = false;
            lblColorPropostas.Visible = true;
        }
        private void btnContratos_Click(object sender, EventArgs e)
        {
            lblColorPropostas.Visible = false;
            lblColorContratos.Visible = true;
        }
    }
}
