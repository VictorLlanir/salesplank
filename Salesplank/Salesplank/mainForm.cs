using System;
using System.Windows.Forms;

namespace Salesplank
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            lblSelected.Text = "Bem-vindo";
            lblColorContracts.Visible = false;
            lblColorProposals.Visible = false;
            proposalUserControl.Visible = false;
            contractUserControl.Visible = false;
        }
        private void btnCloseSup_Click(object sender, EventArgs e) => Close();
        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void btnProposals_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Propostas";
            lblColorContracts.Visible = false;
            lblColorProposals.Visible = true;
            contractUserControl.Visible = false;
            proposalUserControl.Visible = true;
        }
        private void btnContracts_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Contratos";
            lblColorProposals.Visible = false;
            lblColorContracts.Visible = true;
            proposalUserControl.Visible = false;
            contractUserControl.Visible = true;
        }
    }
}
