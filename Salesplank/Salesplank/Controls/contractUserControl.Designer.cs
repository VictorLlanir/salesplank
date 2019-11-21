namespace Salesplank.Controls
{
    partial class contractUserControl
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
            this.btnGerarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarContrato
            // 
            this.btnGerarContrato.Location = new System.Drawing.Point(546, 326);
            this.btnGerarContrato.Name = "btnGerarContrato";
            this.btnGerarContrato.Size = new System.Drawing.Size(113, 23);
            this.btnGerarContrato.TabIndex = 0;
            this.btnGerarContrato.Text = "Gerar contrato";
            this.btnGerarContrato.UseVisualStyleBackColor = true;
            // 
            // contratoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGerarContrato);
            this.MaximumSize = new System.Drawing.Size(662, 352);
            this.MinimumSize = new System.Drawing.Size(662, 352);
            this.Name = "contratoUserControl";
            this.Size = new System.Drawing.Size(662, 352);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarContrato;
    }
}
