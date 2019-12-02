using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Salesplank.Entities;
using Salesplank.Enums;
using Action = Salesplank.Entities.Action;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using Salesplank.Inputs;
using Application = Microsoft.Office.Interop.PowerPoint.Application;
using Salesplank.Helpers;

namespace Salesplank.Controls
{
    public partial class ProposalUserControl : UserControl
    {
        private static List<Project> _projectList = new List<Project>();
        private static List<Action> _actionList = new List<Action>();
        private static string _logoPath;
        private static string _ebdiLogoPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\logo_ebdi.png";
        private static string _oQueNaoSomosPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\o_que_nao_somos.jpg";
        private static string _oQueSomosPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\o_que_somos.jpg";
        private static string _comoFazemosPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\como_fazemos.jpg";
        private static string _oQueQueremosProporcionarPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\o_que_queremos_proporcionar.jpg";
        private static string _modeloBrainPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\modelo_brain.jpg";
        private static string _modeloSabPath = @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\modelo_sab.jpg";
        private static string _selectedModel;
        public ProposalUserControl()
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
            _selectedModel = @"Brain Interactivity";
        }
        private void rdbSab_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProjectCheckListBox(EProjectType.StrategicAdvisoryBoard);
            PopulateActionCheckListBoxes(EProjectType.StrategicAdvisoryBoard);
            _selectedModel = @"SAB";
        }
        private void rdbMade2Make_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckListBoxes();
            _selectedModel = @"Made 2 Make";
        }
        private void btnSelectSponsorLogo_Click(object sender, EventArgs e)
        {
            ofdSelectLogo.Filter = @"Arquivos de imagem (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ofdSelectLogo.CheckFileExists = true;
            ofdSelectLogo.CheckPathExists = true;
            ofdSelectLogo.Multiselect = false;
            if (ofdSelectLogo.ShowDialog() == DialogResult.OK)
            {
                _logoPath = ofdSelectLogo.FileName;
                lblLogoPath.Text = ofdSelectLogo.FileName.Split('\\').Last();
            }
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
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show(@"Preencha os dados corretamente!", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var formDataInput = new FormDataInput(txtSponsorName.Text, _logoPath, _selectedModel, cbNumSponsors.Text, txtContact.Text, ckbGenerateEmail.Checked);
                var selectedProjects = GetProjectList(clbProjects.CheckedItems);
                var selectedActions = GetActionList(clbActionsBranding.CheckedItems, clbActionsContent.CheckedItems, clbActionsRelationship.CheckedItems);
                Generate(formDataInput, selectedProjects, selectedActions);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
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
            var actionsBranding = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Branding).Select(p => $"{p.Name} - {EnumHelper.GetDescription(p.ProjectType)}").ToList();
            clbActionsBranding.Items.AddRange(actionsBranding.Cast<string>().ToArray());

            clbActionsContent.Items.Clear();
            var actionsContent = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Content).Select(p => $"{p.Name} - {EnumHelper.GetDescription(p.ProjectType)}").ToList();
            clbActionsContent.Items.AddRange(actionsContent.Cast<string>().ToArray());

            clbActionsRelationship.Items.Clear();
            var actionsRelationship = _actionList.Where(p => p.ProjectType == projectType && p.ActionType == EActionType.Relationship).Select(p => $"{p.Name} - {EnumHelper.GetDescription(p.ProjectType)}").ToList();
            clbActionsRelationship.Items.AddRange(actionsRelationship.Cast<string>().ToArray());
        }
        private void PopulateProjectList()
        {
            //var streamReader = new StreamReader(@"C:\Users\Victor\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Projects.json", Encoding.UTF8);
            var streamReader = new StreamReader(@"C:\Users\VictorTrevisan\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Projects.json", Encoding.UTF8);
            var json = streamReader.ReadToEnd();
            _projectList = JsonConvert.DeserializeObject<List<Project>>(json);
        }
        private static void PopulateActionList()
        {
            var streamReader = new StreamReader(@"C:\Users\VictorTrevisan\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Actions.json", Encoding.UTF8);
            //var streamReader = new StreamReader(@"C:\Users\Victor\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Actions.json", Encoding.UTF8);
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
        private static bool IsValid()
        {
            return true;
        }
        private static List<Project> GetProjectList(IEnumerable checkedProjects)
        {
            return (from object item in checkedProjects select _projectList.FirstOrDefault(p => p.Name == item.ToString())).ToList();
        }
        private static List<Action> GetActionList(IEnumerable checkedActionsBranding, IEnumerable checkedActionsContent, IEnumerable checkedActionsRelationship)
        {
            var actionList = (from object item in checkedActionsBranding select _actionList.FirstOrDefault(p => p.Name == item.ToString())).ToList();
            actionList.AddRange(from object item in checkedActionsContent select _actionList.FirstOrDefault(p => p.Name == item.ToString()));
            actionList.AddRange(from object item in checkedActionsRelationship select _actionList.FirstOrDefault(p => p.Name == item.ToString()));

            return actionList;
        }
        private static void Generate(FormDataInput formDataInput, List<Project> projects = null, List<Action> actions = null)
        {
            if (projects != null && actions != null)
            {
                var pptApplication = new Application();
                var pptPresentation = pptApplication.Presentations.Add(MsoTriState.msoTrue);
                var slides = pptPresentation.Slides;
                pptPresentation.SlideMaster.Shapes.AddPicture(
                    @"C:\Users\VictorTrevisan\Source\Repos\VictorLlanir\salesplank\Salesplank\Salesplank\Images\bg.jpg",
                    MsoTriState.msoTrue, MsoTriState.msoTrue, 0, 0, pptPresentation.PageSetup.SlideWidth,
                    pptPresentation.PageSetup.SlideHeight);

                // layouts
                var textLayout = pptPresentation.SlideMaster.CustomLayouts[PpSlideLayout.ppLayoutText];

                var firstSlide = slides.AddSlide(1, textLayout);
                var contactName = firstSlide.Shapes[1].TextFrame.TextRange;
                firstSlide.Shapes[1].Left = 90;
                firstSlide.Shapes[1].Top = 450;
                firstSlide.Shapes[2].Visible = MsoTriState.msoFalse;
                contactName.Text = formDataInput.Contact;
                contactName.Font.Size = 24;

                var sponsorLogo = firstSlide.Shapes.AddPicture(_logoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 100, 100);
                sponsorLogo.Left = 60;
                sponsorLogo.Top = 260;

                var ebdiLogo = firstSlide.Shapes.AddPicture(_ebdiLogoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 200, 260);
                ebdiLogo.Left = 500;
                ebdiLogo.Top = 400;

                AddSlideWithImage(pptPresentation, slides, 2, textLayout, _oQueNaoSomosPath);
                AddSlideWithImage(pptPresentation, slides, 3, textLayout, _oQueSomosPath);
                AddSlideWithImage(pptPresentation, slides, 4, textLayout, _comoFazemosPath);
                AddSlideWithImage(pptPresentation, slides, 5, textLayout, _oQueQueremosProporcionarPath);
                var pageNum = 6;
                if (projects.Count(p => p.ProjectType == EProjectType.BrainInteractivity) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, _modeloBrainPath);
                    pageNum++;
                }
                if (projects.Count(p => p.ProjectType == EProjectType.BrainInteractivity) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, _modeloSabPath);
                    pageNum++;
                }

                foreach (var project in projects)
                {

                }
                foreach (var action in actions)
                {

                }

                pptPresentation.SaveAs($@"C:\Users\VictorTrevisan\Desktop\Proposta - {formDataInput.SponsorName} - {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pptx", PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
                //pptPresentation.Close();
                //pptApplication.Quit();
            }
        }
        private static void AddSlideWithImage(Presentation pptPresentation, Slides slides, int index, CustomLayout layout, string path)
        {
            var slide = slides.AddSlide(index, layout);
            slide.Shapes[1].Visible = MsoTriState.msoFalse;
            slide.Shapes[2].Visible = MsoTriState.msoFalse;

            var bgSlide =
                slide.Shapes.AddPicture(path, MsoTriState.msoTrue, MsoTriState.msoTrue, 0, 0, pptPresentation.PageSetup.SlideWidth, pptPresentation.PageSetup.SlideHeight);
            if (index == 3)
                bgSlide.ActionSettings[PpMouseActivation.ppMouseClick].Hyperlink.Address = "https://www.youtube.com/watch?v=JlI-xOhjiUQ";
            bgSlide.Left = 0;
            bgSlide.Top = 0;
            bgSlide.Width = pptPresentation.PageSetup.SlideWidth;
            bgSlide.Height = pptPresentation.PageSetup.SlideHeight;
        }
    }
}
