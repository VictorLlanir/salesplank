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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btnPropostas = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnFecharSup = new System.Windows.Forms.Button();
            this.lblColorPropostas = new System.Windows.Forms.Label();
            this.lblColorContratos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLeftSide.Controls.Add(this.lblColorContratos);
            this.panelLeftSide.Controls.Add(this.lblColorPropostas);
            this.panelLeftSide.Controls.Add(this.btnFechar);
            this.panelLeftSide.Controls.Add(this.btnContratos);
            this.panelLeftSide.Controls.Add(this.btnPropostas);
            this.panelLeftSide.Controls.Add(this.pictureLogo);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(160, 512);
            this.panelLeftSide.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(0, 280);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(160, 40);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContratos.FlatAppearance.BorderSize = 0;
            this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratos.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.Location = new System.Drawing.Point(0, 220);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(160, 40);
            this.btnContratos.TabIndex = 1;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnPropostas
            // 
            this.btnPropostas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPropostas.FlatAppearance.BorderSize = 0;
            this.btnPropostas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropostas.Font = new System.Drawing.Font("Effra Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropostas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPropostas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropostas.Location = new System.Drawing.Point(0, 160);
            this.btnPropostas.Name = "btnPropostas";
            this.btnPropostas.Size = new System.Drawing.Size(160, 40);
            this.btnPropostas.TabIndex = 1;
            this.btnPropostas.Text = "Propostas";
            this.btnPropostas.UseVisualStyleBackColor = true;
            this.btnPropostas.Click += new System.EventHandler(this.btnPropostas_Click);
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
            // btnFecharSup
            // 
            this.btnFecharSup.FlatAppearance.BorderSize = 0;
            this.btnFecharSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharSup.Location = new System.Drawing.Point(774, 15);
            this.btnFecharSup.Name = "btnFecharSup";
            this.btnFecharSup.Size = new System.Drawing.Size(33, 32);
            this.btnFecharSup.TabIndex = 1;
            this.btnFecharSup.Text = "X";
            this.btnFecharSup.UseVisualStyleBackColor = true;
            this.btnFecharSup.Click += new System.EventHandler(this.btnFecharSup_Click);
            // 
            // lblColorPropostas
            // 
            this.lblColorPropostas.AutoSize = true;
            this.lblColorPropostas.BackColor = System.Drawing.Color.White;
            this.lblColorPropostas.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorPropostas.Location = new System.Drawing.Point(-21, 161);
            this.lblColorPropostas.Name = "lblColorPropostas";
            this.lblColorPropostas.Size = new System.Drawing.Size(25, 38);
            this.lblColorPropostas.TabIndex = 2;
            this.lblColorPropostas.Text = " ";
            // 
            // lblColorContratos
            // 
            this.lblColorContratos.AutoSize = true;
            this.lblColorContratos.BackColor = System.Drawing.Color.White;
            this.lblColorContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorContratos.Location = new System.Drawing.Point(-19, 222);
            this.lblColorContratos.Name = "lblColorContratos";
            this.lblColorContratos.Size = new System.Drawing.Size(23, 36);
            this.lblColorContratos.TabIndex = 3;
            this.lblColorContratos.Text = " ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Effra Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 54);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Salesplank";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(176, 108);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(220, 2);
            this.lblLine.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFecharSup);
            this.Controls.Add(this.panelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(822, 512);
            this.MinimumSize = new System.Drawing.Size(822, 512);
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
        private System.Windows.Forms.Button btnPropostas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnFecharSup;
        private System.Windows.Forms.Label lblColorContratos;
        private System.Windows.Forms.Label lblColorPropostas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLine;
    }
}

