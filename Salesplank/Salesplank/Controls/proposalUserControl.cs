using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Salesplank.Entities;

namespace Salesplank.Controls
{
    public partial class proposalUserControl : UserControl
    {
        public static List<Project> _projetoList;
        public static string _logoPath;
        public proposalUserControl()
        {
            InitializeComponent();
            _projetoList = new List<Project>();
        }
        private void PutProjetts(string[] objects)
        {
            cbProjects.Items.AddRange(objects);
        }
        private void rdbBrainInteracivity_CheckedChanged(object sender, EventArgs e)
        {
            cbProjects.Items.Clear();
            var objects = _projetoList.Where(p => p.Type == "Brain Interactivity").Select(p => p.Name).ToList();
            PutProjetts(objects.Cast<string>().ToArray());
        }
        private void rdbSab_CheckedChanged(object sender, EventArgs e)
        {
            cbProjects.Items.Clear();
            var objects = _projetoList.Where(p => p.Type == "SAB").Select(p => p.Name).ToList();
            PutProjetts(objects.Cast<string>().ToArray());
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ckbCotaBlue.Checked = false;
            ckbCotaPlatinum.Checked = false;
            ckbCotaPremier.Checked = false;
            ckbEbdiBranding.Checked = false;
            ckbEbdiContent.Checked = false;
            ckbEbdiGifts.Checked = false;
            ckbEbdiNetworking.Checked = false;
            ckbEbdiOffering.Checked = false;
            rdbBrainInteracivity.Checked = false;
            rdbMade2Make.Checked = false;
            rdbSab.Checked = false;
            cbProjects.Items.Clear();
        }
    }
}
