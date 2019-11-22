namespace Salesplank.Controls
{
    partial class proposalUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarProposta = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpbInitialData = new System.Windows.Forms.GroupBox();
            this.ckbGenerateEmail = new System.Windows.Forms.CheckBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clbProjects = new System.Windows.Forms.CheckedListBox();
            this.lblNumSponsors = new System.Windows.Forms.Label();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.lblSponsorName = new System.Windows.Forms.Label();
            this.txtSponsorName = new System.Windows.Forms.TextBox();
            this.rdbMade2Make = new System.Windows.Forms.RadioButton();
            this.cbNumSponsors = new System.Windows.Forms.ComboBox();
            this.rdbBrainInteractivity = new System.Windows.Forms.RadioButton();
            this.rdbSab = new System.Windows.Forms.RadioButton();
            this.btnSelectSponsorLogo = new System.Windows.Forms.Button();
            this.gpbActions = new System.Windows.Forms.GroupBox();
            this.lblBrainBranding = new System.Windows.Forms.Label();
            this.lblBrainRelationship = new System.Windows.Forms.Label();
            this.lblBrainContent = new System.Windows.Forms.Label();
            this.clbActionsBranding = new System.Windows.Forms.CheckedListBox();
            this.clbActionsRelationship = new System.Windows.Forms.CheckedListBox();
            this.clbActionsContent = new System.Windows.Forms.CheckedListBox();
            this.gpbInitialData.SuspendLayout();
            this.gpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarProposta
            // 
            this.btnGerarProposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarProposta.FlatAppearance.BorderSize = 0;
            this.btnGerarProposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarProposta.Font = new System.Drawing.Font("Effra Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarProposta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerarProposta.Location = new System.Drawing.Point(13, 308);
            this.btnGerarProposta.Name = "btnGerarProposta";
            this.btnGerarProposta.Size = new System.Drawing.Size(125, 30);
            this.btnGerarProposta.TabIndex = 1;
            this.btnGerarProposta.Text = "Gerar proposta";
            this.btnGerarProposta.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Effra Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(194, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gpbInitialData
            // 
            this.gpbInitialData.Controls.Add(this.ckbGenerateEmail);
            this.gpbInitialData.Controls.Add(this.lblContact);
            this.gpbInitialData.Controls.Add(this.textBox1);
            this.gpbInitialData.Controls.Add(this.clbProjects);
            this.gpbInitialData.Controls.Add(this.lblNumSponsors);
            this.gpbInitialData.Controls.Add(this.lblSelectProject);
            this.gpbInitialData.Controls.Add(this.lblSponsorName);
            this.gpbInitialData.Controls.Add(this.txtSponsorName);
            this.gpbInitialData.Controls.Add(this.rdbMade2Make);
            this.gpbInitialData.Controls.Add(this.cbNumSponsors);
            this.gpbInitialData.Controls.Add(this.rdbBrainInteractivity);
            this.gpbInitialData.Controls.Add(this.rdbSab);
            this.gpbInitialData.Controls.Add(this.btnSelectSponsorLogo);
            this.gpbInitialData.Font = new System.Drawing.Font("Effra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInitialData.Location = new System.Drawing.Point(13, 13);
            this.gpbInitialData.Name = "gpbInitialData";
            this.gpbInitialData.Size = new System.Drawing.Size(306, 285);
            this.gpbInitialData.TabIndex = 2;
            this.gpbInitialData.TabStop = false;
            this.gpbInitialData.Text = "Dados iniciais";
            // 
            // ckbGenerateEmail
            // 
            this.ckbGenerateEmail.AutoSize = true;
            this.ckbGenerateEmail.Location = new System.Drawing.Point(21, 252);
            this.ckbGenerateEmail.Name = "ckbGenerateEmail";
            this.ckbGenerateEmail.Size = new System.Drawing.Size(143, 16);
            this.ckbGenerateEmail.TabIndex = 11;
            this.ckbGenerateEmail.Text = "Gerar email com proposta";
            this.ckbGenerateEmail.UseVisualStyleBackColor = true;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(19, 131);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(43, 12);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "Contato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 9;
            // 
            // clbProjects
            // 
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(158, 159);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(132, 84);
            this.clbProjects.TabIndex = 8;
            // 
            // lblNumSponsors
            // 
            this.lblNumSponsors.AutoSize = true;
            this.lblNumSponsors.Location = new System.Drawing.Point(19, 103);
            this.lblNumSponsors.Name = "lblNumSponsors";
            this.lblNumSponsors.Size = new System.Drawing.Size(120, 12);
            this.lblNumSponsors.TabIndex = 7;
            this.lblNumSponsors.Text = "Numero de participantes";
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Location = new System.Drawing.Point(19, 159);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(104, 12);
            this.lblSelectProject.TabIndex = 7;
            this.lblSelectProject.Text = "Selecione os projetos";
            // 
            // lblSponsorName
            // 
            this.lblSponsorName.AutoSize = true;
            this.lblSponsorName.Location = new System.Drawing.Point(19, 22);
            this.lblSponsorName.Name = "lblSponsorName";
            this.lblSponsorName.Size = new System.Drawing.Size(109, 12);
            this.lblSponsorName.TabIndex = 6;
            this.lblSponsorName.Text = "Nome do patrocinador";
            // 
            // txtSponsorName
            // 
            this.txtSponsorName.Location = new System.Drawing.Point(159, 19);
            this.txtSponsorName.Name = "txtSponsorName";
            this.txtSponsorName.Size = new System.Drawing.Size(131, 21);
            this.txtSponsorName.TabIndex = 5;
            // 
            // rdbMade2Make
            // 
            this.rdbMade2Make.AutoSize = true;
            this.rdbMade2Make.Location = new System.Drawing.Point(199, 77);
            this.rdbMade2Make.Name = "rdbMade2Make";
            this.rdbMade2Make.Size = new System.Drawing.Size(84, 16);
            this.rdbMade2Make.TabIndex = 4;
            this.rdbMade2Make.TabStop = true;
            this.rdbMade2Make.Text = "Made 2 Make";
            this.rdbMade2Make.UseVisualStyleBackColor = true;
            // 
            // cbNumSponsors
            // 
            this.cbNumSponsors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumSponsors.FormattingEnabled = true;
            this.cbNumSponsors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbNumSponsors.Location = new System.Drawing.Point(159, 100);
            this.cbNumSponsors.Name = "cbNumSponsors";
            this.cbNumSponsors.Size = new System.Drawing.Size(131, 20);
            this.cbNumSponsors.TabIndex = 3;
            // 
            // rdbBrainInteractivity
            // 
            this.rdbBrainInteractivity.AutoSize = true;
            this.rdbBrainInteractivity.Location = new System.Drawing.Point(21, 77);
            this.rdbBrainInteractivity.Name = "rdbBrainInteractivity";
            this.rdbBrainInteractivity.Size = new System.Drawing.Size(101, 16);
            this.rdbBrainInteractivity.TabIndex = 2;
            this.rdbBrainInteractivity.TabStop = true;
            this.rdbBrainInteractivity.Text = "Brain Interacivity";
            this.rdbBrainInteractivity.UseVisualStyleBackColor = true;
            this.rdbBrainInteractivity.CheckedChanged += new System.EventHandler(this.rdbBrainInteracivity_CheckedChanged);
            // 
            // rdbSab
            // 
            this.rdbSab.AutoSize = true;
            this.rdbSab.Location = new System.Drawing.Point(136, 77);
            this.rdbSab.Name = "rdbSab";
            this.rdbSab.Size = new System.Drawing.Size(42, 16);
            this.rdbSab.TabIndex = 1;
            this.rdbSab.TabStop = true;
            this.rdbSab.Text = "SAB";
            this.rdbSab.UseVisualStyleBackColor = true;
            this.rdbSab.CheckedChanged += new System.EventHandler(this.rdbSab_CheckedChanged);
            // 
            // btnSelectSponsorLogo
            // 
            this.btnSelectSponsorLogo.Font = new System.Drawing.Font("Effra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSponsorLogo.Location = new System.Drawing.Point(14, 48);
            this.btnSelectSponsorLogo.Name = "btnSelectSponsorLogo";
            this.btnSelectSponsorLogo.Size = new System.Drawing.Size(276, 23);
            this.btnSelectSponsorLogo.TabIndex = 0;
            this.btnSelectSponsorLogo.Text = "Selecionar logo do patrocinador";
            this.btnSelectSponsorLogo.UseVisualStyleBackColor = true;
            // 
            // gpbActions
            // 
            this.gpbActions.Controls.Add(this.lblBrainBranding);
            this.gpbActions.Controls.Add(this.lblBrainRelationship);
            this.gpbActions.Controls.Add(this.lblBrainContent);
            this.gpbActions.Controls.Add(this.clbActionsBranding);
            this.gpbActions.Controls.Add(this.clbActionsRelationship);
            this.gpbActions.Controls.Add(this.clbActionsContent);
            this.gpbActions.Font = new System.Drawing.Font("Effra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbActions.Location = new System.Drawing.Point(326, 13);
            this.gpbActions.Name = "gpbActions";
            this.gpbActions.Size = new System.Drawing.Size(321, 325);
            this.gpbActions.TabIndex = 5;
            this.gpbActions.TabStop = false;
            this.gpbActions.Text = "Cotas";
            // 
            // lblBrainBranding
            // 
            this.lblBrainBranding.AutoSize = true;
            this.lblBrainBranding.Location = new System.Drawing.Point(10, 172);
            this.lblBrainBranding.Name = "lblBrainBranding";
            this.lblBrainBranding.Size = new System.Drawing.Size(46, 12);
            this.lblBrainBranding.TabIndex = 1;
            this.lblBrainBranding.Text = "Branding";
            // 
            // lblBrainRelationship
            // 
            this.lblBrainRelationship.AutoSize = true;
            this.lblBrainRelationship.Location = new System.Drawing.Point(165, 22);
            this.lblBrainRelationship.Name = "lblBrainRelationship";
            this.lblBrainRelationship.Size = new System.Drawing.Size(79, 12);
            this.lblBrainRelationship.TabIndex = 1;
            this.lblBrainRelationship.Text = "Relacionamento";
            // 
            // lblBrainContent
            // 
            this.lblBrainContent.AutoSize = true;
            this.lblBrainContent.Location = new System.Drawing.Point(10, 22);
            this.lblBrainContent.Name = "lblBrainContent";
            this.lblBrainContent.Size = new System.Drawing.Size(52, 12);
            this.lblBrainContent.TabIndex = 1;
            this.lblBrainContent.Text = "Conteúdo";
            // 
            // clbActionsBranding
            // 
            this.clbActionsBranding.FormattingEnabled = true;
            this.clbActionsBranding.Location = new System.Drawing.Point(10, 190);
            this.clbActionsBranding.Name = "clbActionsBranding";
            this.clbActionsBranding.Size = new System.Drawing.Size(301, 116);
            this.clbActionsBranding.TabIndex = 0;
            // 
            // clbActionsRelationship
            // 
            this.clbActionsRelationship.FormattingEnabled = true;
            this.clbActionsRelationship.Location = new System.Drawing.Point(167, 40);
            this.clbActionsRelationship.Name = "clbActionsRelationship";
            this.clbActionsRelationship.Size = new System.Drawing.Size(144, 116);
            this.clbActionsRelationship.TabIndex = 0;
            // 
            // clbActionsContent
            // 
            this.clbActionsContent.FormattingEnabled = true;
            this.clbActionsContent.Location = new System.Drawing.Point(10, 40);
            this.clbActionsContent.Name = "clbActionsContent";
            this.clbActionsContent.Size = new System.Drawing.Size(144, 116);
            this.clbActionsContent.TabIndex = 0;
            // 
            // proposalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbActions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gpbInitialData);
            this.Controls.Add(this.btnGerarProposta);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximumSize = new System.Drawing.Size(662, 352);
            this.MinimumSize = new System.Drawing.Size(662, 352);
            this.Name = "proposalUserControl";
            this.Size = new System.Drawing.Size(662, 352);
            this.gpbInitialData.ResumeLayout(false);
            this.gpbInitialData.PerformLayout();
            this.gpbActions.ResumeLayout(false);
            this.gpbActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarProposta;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpbInitialData;
        private System.Windows.Forms.TextBox txtSponsorName;
        private System.Windows.Forms.RadioButton rdbMade2Make;
        private System.Windows.Forms.ComboBox cbNumSponsors;
        private System.Windows.Forms.RadioButton rdbBrainInteractivity;
        private System.Windows.Forms.RadioButton rdbSab;
        private System.Windows.Forms.Button btnSelectSponsorLogo;
        private System.Windows.Forms.Label lblSponsorName;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.Label lblNumSponsors;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckbGenerateEmail;
        private System.Windows.Forms.GroupBox gpbActions;
        private System.Windows.Forms.CheckedListBox clbActionsRelationship;
        private System.Windows.Forms.CheckedListBox clbActionsContent;
        private System.Windows.Forms.CheckedListBox clbActionsBranding;
        private System.Windows.Forms.Label lblBrainBranding;
        private System.Windows.Forms.Label lblBrainRelationship;
        private System.Windows.Forms.Label lblBrainContent;
    }
}
