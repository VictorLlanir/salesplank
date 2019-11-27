using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Salesplank
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 10, 10));
            lblTitle.BringToFront();
            lblLine.BringToFront();
            lblSelected.BringToFront();
            lblSelected.Text = @"Bem-vindo";
            lblColorContracts.Visible = false;
            lblColorProposals.Visible = false;
            proposalUserControl.Visible = false;
            contractUserControl.Visible = false;

            btnContracts.Enabled = false;
        }
        private void btnCloseSup_Click(object sender, EventArgs e) => Close();
        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void btnProposals_Click(object sender, EventArgs e)
        {
            lblSelected.Text = @"Propostas";
            lblColorContracts.Visible = false;
            lblColorProposals.Visible = true;
            contractUserControl.Visible = false;
            proposalUserControl.Visible = true;
        }
        private void btnContracts_Click(object sender, EventArgs e)
        {
            lblSelected.Text = @"Contratos";
            lblColorProposals.Visible = false;
            lblColorContracts.Visible = true;
            proposalUserControl.Visible = false;
            contractUserControl.Visible = true;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }
}
