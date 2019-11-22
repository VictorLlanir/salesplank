using System.Windows.Forms;

namespace Salesplank
{
    partial class mainForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.lblColorContracts = new System.Windows.Forms.Label();
            this.lblColorProposals = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnProposals = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseSup = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.contractUserControl = new Salesplank.Controls.contractUserControl();
            this.proposalUserControl = new Salesplank.Controls.proposalUserControl();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLeftSide.Controls.Add(this.lblColorContracts);
            this.panelLeftSide.Controls.Add(this.lblColorProposals);
            this.panelLeftSide.Controls.Add(this.btnClose);
            this.panelLeftSide.Controls.Add(this.btnContracts);
            this.panelLeftSide.Controls.Add(this.btnProposals);
            this.panelLeftSide.Controls.Add(this.pictureLogo);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(160, 522);
            this.panelLeftSide.TabIndex = 0;
            // 
            // lblColorContracts
            // 
            this.lblColorContracts.AutoSize = true;
            this.lblColorContracts.BackColor = System.Drawing.Color.White;
            this.lblColorContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorContracts.Location = new System.Drawing.Point(-19, 222);
            this.lblColorContracts.Name = "lblColorContracts";
            this.lblColorContracts.Size = new System.Drawing.Size(23, 36);
            this.lblColorContracts.TabIndex = 3;
            this.lblColorContracts.Text = " ";
            // 
            // lblColorProposals
            // 
            this.lblColorProposals.AutoSize = true;
            this.lblColorProposals.BackColor = System.Drawing.Color.White;
            this.lblColorProposals.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorProposals.Location = new System.Drawing.Point(-21, 161);
            this.lblColorProposals.Name = "lblColorProposals";
            this.lblColorProposals.Size = new System.Drawing.Size(25, 38);
            this.lblColorProposals.TabIndex = 2;
            this.lblColorProposals.Text = " ";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(0, 220);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(160, 40);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Contratos";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnProposals
            // 
            this.btnProposals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProposals.FlatAppearance.BorderSize = 0;
            this.btnProposals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProposals.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProposals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProposals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProposals.Location = new System.Drawing.Point(0, 160);
            this.btnProposals.Name = "btnProposals";
            this.btnProposals.Size = new System.Drawing.Size(160, 40);
            this.btnProposals.TabIndex = 1;
            this.btnProposals.Text = "Propostas";
            this.btnProposals.UseVisualStyleBackColor = true;
            this.btnProposals.Click += new System.EventHandler(this.btnProposals_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Salesplank.Properties.Resources.white_logo;
            this.pictureLogo.ImageLocation = "";
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 40);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(160, 67);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // btnCloseSup
            // 
            this.btnCloseSup.FlatAppearance.BorderSize = 0;
            this.btnCloseSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSup.Location = new System.Drawing.Point(770, 10);
            this.btnCloseSup.Name = "btnCloseSup";
            this.btnCloseSup.Size = new System.Drawing.Size(33, 32);
            this.btnCloseSup.TabIndex = 1;
            this.btnCloseSup.Text = "X";
            this.btnCloseSup.UseVisualStyleBackColor = true;
            this.btnCloseSup.Click += new System.EventHandler(this.btnCloseSup_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Effra Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(167, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 54);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Salesplank";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(176, 108);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(220, 2);
            this.lblLine.TabIndex = 4;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Effra Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(176, 117);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(0, 24);
            this.lblSelected.TabIndex = 6;
            // 
            // contractUserControl
            // 
            this.contractUserControl.Location = new System.Drawing.Point(160, 168);
            this.contractUserControl.MaximumSize = new System.Drawing.Size(662, 352);
            this.contractUserControl.MinimumSize = new System.Drawing.Size(662, 352);
            this.contractUserControl.Name = "contractUserControl";
            this.contractUserControl.Size = new System.Drawing.Size(662, 352);
            this.contractUserControl.TabIndex = 7;
            // 
            // proposalUserControl
            // 
            this.proposalUserControl.Location = new System.Drawing.Point(160, 168);
            this.proposalUserControl.Margin = new System.Windows.Forms.Padding(10);
            this.proposalUserControl.MaximumSize = new System.Drawing.Size(662, 352);
            this.proposalUserControl.MinimumSize = new System.Drawing.Size(662, 352);
            this.proposalUserControl.Name = "proposalUserControl";
            this.proposalUserControl.Size = new System.Drawing.Size(662, 352);
            this.proposalUserControl.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 522);
            this.Controls.Add(this.contractUserControl);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.proposalUserControl);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCloseSup);
            this.Controls.Add(this.panelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnProposals;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnCloseSup;
        private System.Windows.Forms.Label lblColorContracts;
        private System.Windows.Forms.Label lblColorProposals;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLine;
        private Controls.proposalUserControl proposalUserControl;
        private System.Windows.Forms.Label lblSelected;
        private Controls.contractUserControl contractUserControl;
    }
}

