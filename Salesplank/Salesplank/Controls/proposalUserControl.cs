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
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Core;
using Salesplank.Inputs;
using Application = Microsoft.Office.Interop.PowerPoint.Application;
using System.Drawing;
using Exception = System.Exception;

namespace Salesplank.Controls
{
    public partial class ProposalUserControl : UserControl
    {
        private static List<Project> _projectList = new List<Project>();
        private static List<Action> _actionList = new List<Action>();
        private static string LogoPath;
        private const string BgPath = "bg.jpg";
        private const string EbdiLogoPath = "logo_ebdi.png";
        private const string OQueNaoSomosPath = "o_que_nao_somos.jpg";
        private const string OQueSomosPath = "o_que_somos.jpg";
        private const string ComoFazemosPath = "como_fazemos.jpg";
        private const string OQueQueremosProporcionarPath = "o_que_queremos_proporcionar.jpg";
        private const string ModeloBrainPath = "modelo_brain.jpg";
        private const string ModeloSabPath = "modelo_sab.jpg";
        private const string ContrapartidasAdicionaisPath = "contrapartidas_adicionais.jpg";
        private const string ContraCapaPath = "contra_capa.jpg";
        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static readonly string WorkingDir = AppDomain.CurrentDomain.BaseDirectory;
        public ProposalUserControl()
        {
            InitializeComponent();
            PopulateProjectList();
            PopulateActionList();
            Directory.CreateDirectory($"{DesktopPath}/Propostas");
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
                LogoPath = ofdSelectLogo.FileName;
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
                var formDataInput = new FormDataInput(txtSponsorName.Text, LogoPath, cbNumSponsors.Text, txtContact.Text, ckbGenerateEmail.Checked);
                var selectedProjects = GetProjectList(clbProjects.CheckedItems);
                var selectedActions = GetActionList(clbActionsBranding.CheckedItems, clbActionsContent.CheckedItems, clbActionsRelationship.CheckedItems);

                var proposalInput = new ProposalInput();
                if (rdbSabBrainInteractivity.Checked)
                    proposalInput = Generate(formDataInput, selectedProjects, selectedActions);
                else
                    proposalInput = Generate(formDataInput);

                //if (formDataInput.GenerateEmail)
                //{
                //    var outlookApp = new Microsoft.Office.Interop.Outlook.Application();
                //    var mail = outlookApp.CreateItem(OlItemType.olMailItem) as MailItem;
                //    mail.Subject = $"Proposta {proposalInput.FormDataInput.SponsorName}";
                //    mail.Attachments.Add(proposalInput.Path, OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                //    mail.Save();
                //}
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var streamReader = new StreamReader($"{WorkingDir}/Data/Projects.json", Encoding.UTF8);
            var json = streamReader.ReadToEnd();
            _projectList = JsonConvert.DeserializeObject<List<Project>>(json);
        }
        private static void PopulateActionList()
        {
            var streamReader = new StreamReader($"{WorkingDir}/Data/Actions.json", Encoding.UTF8);
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
        private static ProposalInput Generate(FormDataInput formDataInput, List<Project> projects = null, List<Action> actions = null)
        {
            if (projects != null && actions != null)
            {
                var pptApplication = new Application();
                var pptPresentation = pptApplication.Presentations.Add();
                var slides = pptPresentation.Slides;
                pptPresentation.SlideMaster.Shapes.AddPicture(
                    $"{WorkingDir}/Images/{BgPath}",
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
                if (LogoPath != null)
                {
                    var sponsorLogo = firstSlide.Shapes.AddPicture(LogoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 80, 80);
                    sponsorLogo.Width = 300;
                    sponsorLogo.Left = 40;
                    sponsorLogo.Top = 400;
                }


                var ebdiLogo = firstSlide.Shapes.AddPicture($"{WorkingDir}/Images/{EbdiLogoPath}", MsoTriState.msoTrue, MsoTriState.msoTrue, 180, 220);
                ebdiLogo.Width = 300;
                ebdiLogo.Left = 550;
                ebdiLogo.Top = 400;

                AddSlideWithImage(pptPresentation, slides, 2, textLayout, $"{WorkingDir}/Images/{OQueNaoSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 3, textLayout, $"{WorkingDir}/Images/{OQueSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 4, textLayout, $"{WorkingDir}/Images/{ComoFazemosPath}");
                AddSlideWithImage(pptPresentation, slides, 5, textLayout, $"{WorkingDir}/Images/{OQueQueremosProporcionarPath}");
                var pageNum = 6;
                if (projects.Count(p => p.ProjectType == EProjectType.BrainInteractivity) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{ModeloBrainPath}");
                    pageNum++;
                }
                if (projects.Count(p => p.ProjectType == EProjectType.StrategicAdvisoryBoard) > 0)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{ ModeloSabPath}");
                    pageNum++;
                }

                foreach (var project in projects)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{project.Image}", project);
                    pageNum++;
                }
                foreach (var action in actions)
                {
                    AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{action.Image}");
                    pageNum++;
                }
                AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{ContrapartidasAdicionaisPath}", null, formDataInput);
                pageNum++;
                AddSlideWithImage(pptPresentation, slides, pageNum, textLayout, $"{WorkingDir}/Images/{ContraCapaPath}");

                var proposalPath =
                    $"{DesktopPath}/Propostas/Proposta - {formDataInput.SponsorName} - {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pptx";
                pptPresentation.SaveAs(proposalPath, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);

                //pptPresentation.Close();
                pptApplication.Quit();
                return new ProposalInput(proposalPath, formDataInput);
            }
            else
            {
                var pptApplication = new Application();
                var pptPresentation = pptApplication.Presentations.Add();
                var slides = pptPresentation.Slides;

                var textLayout = pptPresentation.SlideMaster.CustomLayouts[PpSlideLayout.ppLayoutText];
                AddSlideWithImage(pptPresentation, slides, 1, textLayout, $"{WorkingDir}/Images/projects/made2make/capa.jpg");
                AddSlideWithImage(pptPresentation, slides, 2, textLayout, $"{WorkingDir}/Images/{OQueNaoSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 3, textLayout, $"{WorkingDir}/Images/{OQueSomosPath}");
                AddSlideWithImage(pptPresentation, slides, 4, textLayout, $"{WorkingDir}/Images/{ComoFazemosPath}");
                AddSlideWithImage(pptPresentation, slides, 5, textLayout, $"{WorkingDir}/Images/{OQueQueremosProporcionarPath}");
                AddSlideWithImage(pptPresentation, slides, 6, textLayout, $"{WorkingDir}/Images/projects/made2make/modelo_made2make.jpg");
                AddSlideWithImage(pptPresentation, slides, 7, textLayout, $"{WorkingDir}/Images/projects/made2make/sua_proposta.jpg");
                AddSlideWithImage(pptPresentation, slides, 8, textLayout, $"{WorkingDir}/Images/projects/made2make/contrapartidas_investimento.jpg", null, formDataInput);
                AddSlideWithImage(pptPresentation, slides, 9, textLayout, $"{WorkingDir}/Images/projects/made2make/contra_capa.jpg");

                var proposalPath =
                    $"{DesktopPath}/Propostas/Proposta Made2Make - {formDataInput.SponsorName} - {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pptx";
                pptPresentation.SaveAs(proposalPath, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);

                //pptPresentation.Close();
                pptApplication.Quit();
                return new ProposalInput(proposalPath, formDataInput);
            }
        }
        private static void AddSlideWithImage(Presentation pptPresentation, Slides slides, int index, CustomLayout layout, string path, Project project = null, FormDataInput formDataInput = null)
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
            if (project != null)
            {
                var dateText = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 310, 260, 600, 100);
                dateText.TextFrame.TextRange.Text = $"DIAS: {project.Date.ToUpper()}";
                dateText.TextFrame.TextRange.Font.Size = 26;
                dateText.TextFrame.TextRange.Font.Name = "Effra";
                dateText.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
                if (project.Link != "")
                    bgSlide.ActionSettings[PpMouseActivation.ppMouseClick].Hyperlink.Address = project.Link;
            }
            if (path.Contains(ContrapartidasAdicionaisPath))
            {
                var numSponsors = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 163, 115, 150, 80);
                numSponsors.TextFrame.TextRange.Text = formDataInput?.NumSponsors;
                numSponsors.TextFrame.TextRange.Font.Size = 16;
                numSponsors.TextFrame.TextRange.Font.Name = "Effra";
                numSponsors.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;

                var valueInvestment = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 420, 450, 250, 100);
                valueInvestment.TextFrame.TextRange.Text = "VALOR";
                valueInvestment.TextFrame.TextRange.Font.Size = 22;
                valueInvestment.TextFrame.TextRange.Font.Name = "Effra";
                valueInvestment.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
            }
            if (path.Contains("sua_proposta"))
            {
                if (LogoPath != "")
                {
                    var sponsorLogo = slide.Shapes.AddPicture(LogoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 175, 220);
                    sponsorLogo.Width = 450;
                    sponsorLogo.Left = 350;
                    sponsorLogo.Top = 120;
                }

                var valueInvestment = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 350, 450, 400, 100);
                valueInvestment.TextFrame.TextRange.Text = "INVESTIMENTO: R$ VALOR";
                valueInvestment.TextFrame.TextRange.Font.Size = 30;
                valueInvestment.TextFrame.TextRange.Font.Name = "Effra";
                valueInvestment.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
            }
            if (path.Contains("contrapartidas_investimento"))
            {
                var numGuests = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 80, 243, 150, 80);
                numGuests.TextFrame.TextRange.Text = "XX participantes";
                numGuests.TextFrame.TextRange.Font.Size = 12;
                numGuests.TextFrame.TextRange.Font.Name = "Effra";
                numGuests.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;

                var numSponsors = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 80, 292, 150, 80);
                numSponsors.TextFrame.TextRange.Text = $"{formDataInput?.NumSponsors} inscrições";
                numSponsors.TextFrame.TextRange.Font.Size = 12;
                numSponsors.TextFrame.TextRange.Font.Name = "Effra";
                numSponsors.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;

                if (LogoPath != "")
                {
                    var sponsorLogo = slide.Shapes.AddPicture(LogoPath, MsoTriState.msoTrue, MsoTriState.msoTrue, 175, 230);
                    sponsorLogo.Width = 300;
                    sponsorLogo.Left = 550;
                    sponsorLogo.Top = 220;
                }
            }
            if (path.Contains("made2make") && path.Contains("capa") && !path.Contains("contra_capa"))
            {
                var numSponsors = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 59, 430, 240, 80);
                numSponsors.TextFrame.TextRange.Text = "seu_email@ebdicorp.com.br";
                numSponsors.TextFrame.TextRange.Font.Size = 14;
                numSponsors.TextFrame.TextRange.Font.Name = "Effra";
                numSponsors.TextFrame.TextRange.Font.Bold = MsoTriState.msoFalse;
                numSponsors.TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();
            }
            if (path.Contains("made2make") && path.Contains("contra_capa"))
            {
                var numSponsors = slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 140, 160, 240, 80);
                numSponsors.TextFrame.TextRange.Text = "(00) 0000-0000";
                numSponsors.TextFrame.TextRange.Font.Size = 16;
                numSponsors.TextFrame.TextRange.Font.Name = "Effra";
                numSponsors.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
                numSponsors.TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();
            }
        }
    }
}
