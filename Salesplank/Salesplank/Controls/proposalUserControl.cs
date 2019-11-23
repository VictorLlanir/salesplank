using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Salesplank.Entities;
using Salesplank.Enums;
using Action = Salesplank.Entities.Action;

namespace Salesplank.Controls
{
    public partial class proposalUserControl : UserControl
    {
        public static List<Project> _projectList = new List<Project>();
        public static List<Action> _actionList = new List<Action>();
        public static string _logoPath;
        public proposalUserControl()
        {
            InitializeComponent();
            PopulateProjectList();
            PopulateActionList();
        }
        // Eventos
        private void rdbBrainInteracivity_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProjectCheckListBox(EProjectType.BrainInteractivity);
            PopulateActionCheckListBoxes(EProjectType.BrainInteractivity);
        }
        private void rdbSab_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProjectCheckListBox(EProjectType.StrategicAdvisoryBoard);
            PopulateActionCheckListBoxes(EProjectType.StrategicAdvisoryBoard);
        }
        private void rdbMade2Make_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckListBoxes();
        }
        private void btnSelectSponsorLogo_Click(object sender, EventArgs e)
        {
            ofdSelectLogo.Filter = "Arquivos de imagem (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ofdSelectLogo.CheckFileExists = true;
            ofdSelectLogo.CheckPathExists = true;
            ofdSelectLogo.Multiselect = false;
            if (ofdSelectLogo.ShowDialog() == DialogResult.OK)
                lblLogoPath.Text = ofdSelectLogo.FileName.Split('\\').Last();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbBrainInteractivity.Checked = false;
            rdbMade2Make.Checked = false;
            rdbSab.Checked = false;
            ClearCheckListBoxes();
            txtSponsorName.Text = "";
            cbNumSponsors.SelectedItem = null;
            txtContact.Text = "";
            ckbGenerateEmail.Checked = false;
            lblLogoPath.Text = "";
            ofdSelectLogo.Dispose();
        }
        private void btnGerarProposta_Click(object sender, EventArgs e)
        {
            var x = clbProjects.CheckedItems;
        }
        // Meus métodos
        private void PopulateProjectCheckListBox(EProjectType projectType)
        {
            clbProjects.Items.Clear();
            var projects = _projectList.Where(p => p.ProjectType == projectType).Select(p => p.Name).ToList();
            clbProjects.Items.AddRange(projects.Cast<string>().ToArray());
        }
        private void PopulateActionCheckListBoxes(EProjectType projectType)
        {
            clbActionsBranding.Items.Clear();
            var actionsBranding = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Branding).Select(p => p.Name).ToList();
            clbActionsBranding.Items.AddRange(actionsBranding.Cast<string>().ToArray());

            clbActionsContent.Items.Clear();
            var actionsContent = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Content).Select(p => p.Name).ToList();
            clbActionsContent.Items.AddRange(actionsContent.Cast<string>().ToArray());

            clbActionsRelationship.Items.Clear();
            var actionsRelationship = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Relationship).Select(p => p.Name).ToList();
            clbActionsRelationship.Items.AddRange(actionsRelationship.Cast<string>().ToArray());
        }
        private void PopulateProjectList()
        {
            var streamReader = new StreamReader(@"C:\Users\Victor\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Projects.json", Encoding.UTF8);
            var json = streamReader.ReadToEnd();
            _projectList = JsonConvert.DeserializeObject<List<Project>>(json);
        }
        private void PopulateActionList()
        {
            var streamReader = new StreamReader(@"C:\Users\Victor\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Actions.json", Encoding.UTF8);
            var json = streamReader.ReadToEnd();
            _actionList = JsonConvert.DeserializeObject<List<Action>>(json);
        }
        private void ClearCheckListBoxes()
        {
            clbProjects.Items.Clear();
            clbActionsBranding.Items.Clear();
            clbActionsContent.Items.Clear();
            clbActionsRelationship.Items.Clear();
        }
    }
}
