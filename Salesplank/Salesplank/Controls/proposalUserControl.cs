using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Salesplank.Entities;

namespace Salesplank.Controls
{
    public partial class proposalUserControl : UserControl
    {
        public static List<Project> _projectList;
        public static string _logoPath;
        public proposalUserControl()
        {
            InitializeComponent();
            _projectList = new List<Project>();
        }
        private void PutProjetts(string[] objects)
        {
            clbProjects.Items.AddRange(objects);
        }
        private void rdbBrainInteracivity_CheckedChanged(object sender, EventArgs e)
        {
            clbProjects.Items.Clear();
            var objects = _projectList.Where(p => p.Type == "Brain Interactivity").Select(p => p.Name).ToList();
            PutProjetts(objects.Cast<string>().ToArray());
        }
        private void rdbSab_CheckedChanged(object sender, EventArgs e)
        {
            clbProjects.Items.Clear();
            var objects = _projectList.Where(p => p.Type == "SAB").Select(p => p.Name).ToList();
            PutProjetts(objects.Cast<string>().ToArray());
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbBrainInteractivity.Checked = false;
            rdbMade2Make.Checked = false;
            rdbSab.Checked = false;
            clbProjects.Items.Clear();
            gpbInitialData.Visible = false;
        }
    }
}
