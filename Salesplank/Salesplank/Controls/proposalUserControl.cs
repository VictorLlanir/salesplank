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

namespace Salesplank.Controls
{
    public partial class ProposalUserControl : UserControl
    {
        private static List<Project> _projectList = new List<Project>();
        private static List<Action> _actionList = new List<Action>();
        private static string _logoPath;
        private static string _bgPath = "bg.jpg";
        private static string _ebdiLogoPath = "logo_ebdi.png";
        private static string _oQueNaoSomosPath = "o_que_nao_somos.jpg";
        private static string _oQueSomosPath = "o_que_somos.jpg";
        private static string _comoFazemosPath = "como_fazemos.jpg";
        private static string _oQueQueremosProporcionarPath = "o_que_queremos_proporcionar.jpg";
        private static string _modeloBrainPath = "modelo_brain.jpg";
        private static string _modeloSabPath = "modelo_sab.jpg";
        private static string _contrapartidasAdicionaisPath = "contrapartidas_adicionais.jpg";
        private static string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string _workingDir = AppDomain.CurrentDomain.BaseDirectory;
        public ProposalUserControl()
        {
            InitializeComponent();
            PopulateProjectList();
            PopulateActionList();
        }
        // Eventos
        private void rdbSabBrainInteracivity_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProjectCheckListBox();
            PopulateActionCheckListBoxes();
        }
        private void rdbMade2Make_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckListBoxes();
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
            rdbSabBrainInteractivity.Checked = false;
            rdbMade2Make.Checked = false;
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
            try
            {
                var formDataInput = new FormDataInput(txtSponsorName.Text, _logoPath, cbNumSponsors.Text, txtContact.Text, ckbGenerateEmail.Checked);
                var selectedProjects = GetProjectList(clbProjects.CheckedItems);
                var selectedActions = GetActionList(clbActionsBranding.CheckedItems, clbActionsContent.CheckedItems, clbActionsRelationship.CheckedItems);
                Generate(formDataInput, selectedProjects, selectedActions);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        // Meus métodos
        private void PopulateProjectCheckListBox()
        {
            clbProjects.Items.Clear();
            var projects = new List<string>();
            projects.AddRange(_projectList.Where(p => p.ProjectType == EProjectType.BrainInteractivity).Select(p => p.Name));
            projects.AddRange(_projectList.Where(p => p.ProjectType == EProjectType.StrategicAdvisoryBoard).Select(p => p.Name));
            clbProjects.Items.AddRange(projects.Cast<string>().ToArray());
        }
        private void PopulateActionCheckListBoxes()
        {
            clbActionsBranding.Items.Clear();
            var actionsBranding = _actionList.Where(p => p.ActionType == EActionType.Branding).Select(p => p.Name).ToList();
            clbActionsBranding.Items.AddRange(actionsBranding.Cast<string>().ToArray());

            clbActionsContent.Items.Clear();
            var actionsContent = _actionList.Where(p => p.ActionType == EActionType.Content).Select(p => p.Name).ToList();
            clbActionsContent.Items.AddRange(actionsContent.Cast<string>().ToArray());

            clbActionsRelationship.Items.Clear();
            var actionsRelationship = _actionList.Where(p => p.ActionType == EActionType.Relationship).Select(p => p.Name).ToList();
            clbActionsRelationship.Items.AddRange(actionsRelationship.Cast<string>().ToArray());
        }
        private void PopulateProjectList()
        {
            //var streamReader = new StreamReader(@"C:\Users\Victor\source\repos\VictorLlanir\salesplank\Salesplank\Salesplank\Data\Projects.json", Encoding.UTF8);
            var streamReader = new StreamReader($"{_workingDir}/Data/Projects.json", Encoding.UTF8);
            var json = streamReader.ReadToEnd();
            _projectList = JsonConvert.DeserializeObject<List<Project>>(json);
        }
        private static void PopulateActionList()
        {
            var streamReader = new StreamReader($"{_workingDir}/Data/Actions.json", Encoding.UTF8);
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
                    $"{_workingDir}/Images/{_bgPath}",
                    MsoTriState.msoTrue, MsoTriState.msoTrue, 0, 0, pptPresentation.PageSetup.SlideWidth,
                    pptPresentation.PageSetup.SlideHeight);

                // layouts
                var textLayout = pptPresentation.SlideMaster.CustomLayouts[PpSlideLayout.ppLayoutText];

                var firstSlide = slides.AddSlide(1, textLayout);
                var contactName = firstSlide.Shapes[1].TextFrame.TextRange;
                firstSlide.Shapes[1].Left = 90;
                firstSlide.Shapes[1].Top = 450;
                contactName.Text = $"A/C: {formDataInput.Contact}";
                contactName.Font.Size = 24;

                firstSlide.Shapes[2].TextFrame.TextRange.Font.Size = 17;
                firstSlide.Shapes[2].TextFrame.TextRange.ParagraphFormat.SpaceWithin = (float)0.8;
                var first = 1;
                foreach (var project in projects)
                {
                    if (first == 1)
                        firstSlide.Shapes[2].TextFrame.TextRange.Text += $"{project.Name} - {project.Description}";
                    else
                        firstSlide.Shapes[2].TextFrame.TextRange.Text += $"\n{project.Name} - {project.Description}";
                    first = 0;
                }
                if (_logoPath != null)
                {
                    var sponsorLogo = firstSlide.Shapes.AddPicture(_logoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 80, 80);
                    sponsorLogo.Width = 300;
                    sponsorLogo.Left = 40;
                    sponsorLogo.Top = 400;
                }


                var ebdiLogo = firstSlide.Shapes.AddPicture($"{_workingDir}/Images/{_ebdiLogoPath}", MsoTriState.msoTrue, MsoTriState.msoTrue, 180, 220);
                ebdiLogo.Width = 300;
                ebdiLogo.Left = 550;
                ebdiLogo.Top = 400;

                AddSlideWithImage(pptPresentation, slides, 2, textLayout, $"{_workingDir}/Images/{_oQueNaoSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 3, textLayout, $"{_workingDir}/Images/{_oQueSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 4, textLayout, $"{_workingDir}/Images/{_comoFazemosPath}");
                AddSlideWithImage(pptPresentation, slides, 5, textLayout, $"{_workingDir}/Images/{_oQueQueremosProporcionarPath}");
                var pageNum = 6;
                if (projects.Count(p => p.ProjectType == EProjectType.BrainInteractivity) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{_workingDir}/Images/{_modeloBrainPath}");
                    pageNum++;
                }
                if (projects.Count(p => p.ProjectType == EProjectType.StrategicAdvisoryBoard) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{_workingDir}/Images/{ _modeloSabPath}");
                    pageNum++;
                }

                foreach (var project in projects)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{_workingDir}/Images/{project.Image}", project.Date);
                    pageNum++;
                }
                foreach (var action in actions)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{_workingDir}/Images/{action.Image}");
                    pageNum++;
                }
                AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{_workingDir}/Images/{_contrapartidasAdicionaisPath}", "", formDataInput);
                pageNum++;
                pptPresentation.SaveAs($"{_desktopPath}/Propostas/Proposta - {formDataInput.SponsorName} - {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pptx", PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
                //pptPresentation.Close();
                //pptApplication.Quit();
            }
        }
        private static void AddSlideWithImage(Presentation pptPresentation, Slides slides, int index, CustomLayout layout, string path, string projectDate = "", FormDataInput formDataInput = null)
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
            if (projectDate != "")
            {
                var dateText = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 310, 260, 600, 100);
                dateText.TextFrame.TextRange.Text = $"DIAS: {projectDate.ToUpper()}";
                dateText.TextFrame.TextRange.Font.Size = 26;
                dateText.TextFrame.TextRange.Font.Name = "Effra";
                dateText.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
            }
            if (path.Contains(_contrapartidasAdicionaisPath))
            {
                var numSponsors = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 163, 115, 150, 80);
                numSponsors.TextFrame.TextRange.Text = formDataInput.NumSponsors;
                numSponsors.TextFrame.TextRange.Font.Size = 16;
                numSponsors.TextFrame.TextRange.Font.Name = "Effra";
                numSponsors.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;

                var valueInvestment = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 420, 450, 250, 100);
                valueInvestment.TextFrame.TextRange.Text = "VALOR";
                valueInvestment.TextFrame.TextRange.Font.Size = 22;
                valueInvestment.TextFrame.TextRange.Font.Name = "Effra";
                valueInvestment.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
            }
        }
    }
}
