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
            this.gpboxFirst = new System.Windows.Forms.GroupBox();
            this.rdbMade2Make = new System.Windows.Forms.RadioButton();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.rdbBrainInteracivity = new System.Windows.Forms.RadioButton();
            this.rdbSab = new System.Windows.Forms.RadioButton();
            this.btnSelectSponsor = new System.Windows.Forms.Button();
            this.gpbActions = new System.Windows.Forms.GroupBox();
            this.ckbCotaPlatinum = new System.Windows.Forms.CheckBox();
            this.ckbCotaPremier = new System.Windows.Forms.CheckBox();
            this.ckbCotaBlue = new System.Windows.Forms.CheckBox();
            this.ckbEbdiBranding = new System.Windows.Forms.CheckBox();
            this.ckbEbdiOffering = new System.Windows.Forms.CheckBox();
            this.ckbEbdiGifts = new System.Windows.Forms.CheckBox();
            this.ckbEbdiNetworking = new System.Windows.Forms.CheckBox();
            this.ckbEbdiContent = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpboxFirst.SuspendLayout();
            this.gpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarProposta
            // 
            this.btnGerarProposta.Location = new System.Drawing.Point(25, 127);
            this.btnGerarProposta.Name = "btnGerarProposta";
            this.btnGerarProposta.Size = new System.Drawing.Size(125, 29);
            this.btnGerarProposta.TabIndex = 1;
            this.btnGerarProposta.Text = "Gerar proposta";
            this.btnGerarProposta.UseVisualStyleBackColor = true;
            // 
            // gpboxFirst
            // 
            this.gpboxFirst.Controls.Add(this.rdbMade2Make);
            this.gpboxFirst.Controls.Add(this.cbProjects);
            this.gpboxFirst.Controls.Add(this.rdbBrainInteracivity);
            this.gpboxFirst.Controls.Add(this.rdbSab);
            this.gpboxFirst.Controls.Add(this.btnSelectSponsor);
            this.gpboxFirst.Font = new System.Drawing.Font("Effra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxFirst.Location = new System.Drawing.Point(25, 15);
            this.gpboxFirst.Name = "gpboxFirst";
            this.gpboxFirst.Size = new System.Drawing.Size(289, 104);
            this.gpboxFirst.TabIndex = 2;
            this.gpboxFirst.TabStop = false;
            this.gpboxFirst.Text = "Dados iniciais";
            // 
            // rdbMade2Make
            // 
            this.rdbMade2Make.AutoSize = true;
            this.rdbMade2Make.Location = new System.Drawing.Point(199, 49);
            this.rdbMade2Make.Name = "rdbMade2Make";
            this.rdbMade2Make.Size = new System.Drawing.Size(84, 16);
            this.rdbMade2Make.TabIndex = 4;
            this.rdbMade2Make.TabStop = true;
            this.rdbMade2Make.Text = "Made 2 Make";
            this.rdbMade2Make.UseVisualStyleBackColor = true;
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(7, 72);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(276, 20);
            this.cbProjects.TabIndex = 3;
            // 
            // rdbBrainInteracivity
            // 
            this.rdbBrainInteracivity.AutoSize = true;
            this.rdbBrainInteracivity.Location = new System.Drawing.Point(7, 49);
            this.rdbBrainInteracivity.Name = "rdbBrainInteracivity";
            this.rdbBrainInteracivity.Size = new System.Drawing.Size(101, 16);
            this.rdbBrainInteracivity.TabIndex = 2;
            this.rdbBrainInteracivity.TabStop = true;
            this.rdbBrainInteracivity.Text = "Brain Interacivity";
            this.rdbBrainInteracivity.UseVisualStyleBackColor = true;
            this.rdbBrainInteracivity.CheckedChanged += new System.EventHandler(this.rdbBrainInteracivity_CheckedChanged);
            // 
            // rdbSab
            // 
            this.rdbSab.AutoSize = true;
            this.rdbSab.Location = new System.Drawing.Point(131, 49);
            this.rdbSab.Name = "rdbSab";
            this.rdbSab.Size = new System.Drawing.Size(42, 16);
            this.rdbSab.TabIndex = 1;
            this.rdbSab.TabStop = true;
            this.rdbSab.Text = "SAB";
            this.rdbSab.UseVisualStyleBackColor = true;
            this.rdbSab.CheckedChanged += new System.EventHandler(this.rdbSab_CheckedChanged);
            // 
            // btnSelectSponsor
            // 
            this.btnSelectSponsor.Font = new System.Drawing.Font("Effra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSponsor.Location = new System.Drawing.Point(7, 20);
            this.btnSelectSponsor.Name = "btnSelectSponsor";
            this.btnSelectSponsor.Size = new System.Drawing.Size(276, 23);
            this.btnSelectSponsor.TabIndex = 0;
            this.btnSelectSponsor.Text = "Selecionar logo do patrocinador";
            this.btnSelectSponsor.UseVisualStyleBackColor = true;
            // 
            // gpbActions
            // 
            this.gpbActions.Controls.Add(this.ckbCotaPlatinum);
            this.gpbActions.Controls.Add(this.ckbCotaPremier);
            this.gpbActions.Controls.Add(this.ckbCotaBlue);
            this.gpbActions.Controls.Add(this.ckbEbdiBranding);
            this.gpbActions.Controls.Add(this.ckbEbdiOffering);
            this.gpbActions.Controls.Add(this.ckbEbdiGifts);
            this.gpbActions.Controls.Add(this.ckbEbdiNetworking);
            this.gpbActions.Controls.Add(this.ckbEbdiContent);
            this.gpbActions.Location = new System.Drawing.Point(320, 17);
            this.gpbActions.Name = "gpbActions";
            this.gpbActions.Size = new System.Drawing.Size(315, 88);
            this.gpbActions.TabIndex = 3;
            this.gpbActions.TabStop = false;
            this.gpbActions.Text = "Cotas";
            // 
            // ckbCotaPlatinum
            // 
            this.ckbCotaPlatinum.AutoSize = true;
            this.ckbCotaPlatinum.Location = new System.Drawing.Point(218, 65);
            this.ckbCotaPlatinum.Name = "ckbCotaPlatinum";
            this.ckbCotaPlatinum.Size = new System.Drawing.Size(91, 17);
            this.ckbCotaPlatinum.TabIndex = 7;
            this.ckbCotaPlatinum.Text = "Cota Platinum";
            this.ckbCotaPlatinum.UseVisualStyleBackColor = true;
            // 
            // ckbCotaPremier
            // 
            this.ckbCotaPremier.AutoSize = true;
            this.ckbCotaPremier.Location = new System.Drawing.Point(104, 65);
            this.ckbCotaPremier.Name = "ckbCotaPremier";
            this.ckbCotaPremier.Size = new System.Drawing.Size(86, 17);
            this.ckbCotaPremier.TabIndex = 6;
            this.ckbCotaPremier.Text = "Cota Premier";
            this.ckbCotaPremier.UseVisualStyleBackColor = true;
            // 
            // ckbCotaBlue
            // 
            this.ckbCotaBlue.AutoSize = true;
            this.ckbCotaBlue.Location = new System.Drawing.Point(7, 65);
            this.ckbCotaBlue.Name = "ckbCotaBlue";
            this.ckbCotaBlue.Size = new System.Drawing.Size(72, 17);
            this.ckbCotaBlue.TabIndex = 5;
            this.ckbCotaBlue.Text = "Cota Blue";
            this.ckbCotaBlue.UseVisualStyleBackColor = true;
            // 
            // ckbEbdiBranding
            // 
            this.ckbEbdiBranding.AutoSize = true;
            this.ckbEbdiBranding.Location = new System.Drawing.Point(104, 43);
            this.ckbEbdiBranding.Name = "ckbEbdiBranding";
            this.ckbEbdiBranding.Size = new System.Drawing.Size(96, 17);
            this.ckbEbdiBranding.TabIndex = 4;
            this.ckbEbdiBranding.Text = "EBDI Branding";
            this.ckbEbdiBranding.UseVisualStyleBackColor = true;
            // 
            // ckbEbdiOffering
            // 
            this.ckbEbdiOffering.AutoSize = true;
            this.ckbEbdiOffering.Location = new System.Drawing.Point(7, 43);
            this.ckbEbdiOffering.Name = "ckbEbdiOffering";
            this.ckbEbdiOffering.Size = new System.Drawing.Size(91, 17);
            this.ckbEbdiOffering.TabIndex = 3;
            this.ckbEbdiOffering.Text = "EBDI Offering";
            this.ckbEbdiOffering.UseVisualStyleBackColor = true;
            // 
            // ckbEbdiGifts
            // 
            this.ckbEbdiGifts.AutoSize = true;
            this.ckbEbdiGifts.Location = new System.Drawing.Point(218, 20);
            this.ckbEbdiGifts.Name = "ckbEbdiGifts";
            this.ckbEbdiGifts.Size = new System.Drawing.Size(75, 17);
            this.ckbEbdiGifts.TabIndex = 2;
            this.ckbEbdiGifts.Text = "EBDI Gifts";
            this.ckbEbdiGifts.UseVisualStyleBackColor = true;
            // 
            // ckbEbdiNetworking
            // 
            this.ckbEbdiNetworking.AutoSize = true;
            this.ckbEbdiNetworking.Location = new System.Drawing.Point(104, 20);
            this.ckbEbdiNetworking.Name = "ckbEbdiNetworking";
            this.ckbEbdiNetworking.Size = new System.Drawing.Size(108, 17);
            this.ckbEbdiNetworking.TabIndex = 1;
            this.ckbEbdiNetworking.Text = "EBDI Networking";
            this.ckbEbdiNetworking.UseVisualStyleBackColor = true;
            // 
            // ckbEbdiContent
            // 
            this.ckbEbdiContent.AutoSize = true;
            this.ckbEbdiContent.Location = new System.Drawing.Point(7, 20);
            this.ckbEbdiContent.Name = "ckbEbdiContent";
            this.ckbEbdiContent.Size = new System.Drawing.Size(91, 17);
            this.ckbEbdiContent.TabIndex = 0;
            this.ckbEbdiContent.Text = "EBDI Content";
            this.ckbEbdiContent.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // proposalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gpbActions);
            this.Controls.Add(this.gpboxFirst);
            this.Controls.Add(this.btnGerarProposta);
            this.MaximumSize = new System.Drawing.Size(662, 177);
            this.MinimumSize = new System.Drawing.Size(662, 177);
            this.Name = "proposalUserControl";
            this.Size = new System.Drawing.Size(662, 177);
            this.gpboxFirst.ResumeLayout(false);
            this.gpboxFirst.PerformLayout();
            this.gpbActions.ResumeLayout(false);
            this.gpbActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarProposta;
        private System.Windows.Forms.GroupBox gpboxFirst;
        private System.Windows.Forms.Button btnSelectSponsor;
        private System.Windows.Forms.RadioButton rdbBrainInteracivity;
        private System.Windows.Forms.RadioButton rdbSab;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.GroupBox gpbActions;
        private System.Windows.Forms.CheckBox ckbEbdiGifts;
        private System.Windows.Forms.CheckBox ckbEbdiNetworking;
        private System.Windows.Forms.CheckBox ckbEbdiContent;
        private System.Windows.Forms.CheckBox ckbEbdiBranding;
        private System.Windows.Forms.CheckBox ckbEbdiOffering;
        private System.Windows.Forms.RadioButton rdbMade2Make;
        private System.Windows.Forms.CheckBox ckbCotaPlatinum;
        private System.Windows.Forms.CheckBox ckbCotaPremier;
        private System.Windows.Forms.CheckBox ckbCotaBlue;
        private System.Windows.Forms.Button btnClear;
    }
}
