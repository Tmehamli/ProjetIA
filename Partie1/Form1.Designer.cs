namespace Partie1
{
    partial class Questionnaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelCorrection = new System.Windows.Forms.Label();
            this.labelShowCorrectOrNo = new System.Windows.Forms.Label();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.labelSelectAnAnswer = new System.Windows.Forms.Label();
            this.groupBoxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.labelQuestion);
            this.groupBoxQuestion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(431, 72);
            this.groupBoxQuestion.TabIndex = 0;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question n°X";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AllowDrop = true;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(17, 36);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(62, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "La question";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(174, 292);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // labelCorrection
            // 
            this.labelCorrection.AutoSize = true;
            this.labelCorrection.Location = new System.Drawing.Point(320, 135);
            this.labelCorrection.Name = "labelCorrection";
            this.labelCorrection.Size = new System.Drawing.Size(75, 13);
            this.labelCorrection.TabIndex = 3;
            this.labelCorrection.Text = "Correction n°X";
            this.labelCorrection.Visible = false;
            // 
            // labelShowCorrectOrNo
            // 
            this.labelShowCorrectOrNo.AutoSize = true;
            this.labelShowCorrectOrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowCorrectOrNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelShowCorrectOrNo.Location = new System.Drawing.Point(320, 108);
            this.labelShowCorrectOrNo.Name = "labelShowCorrectOrNo";
            this.labelShowCorrectOrNo.Size = new System.Drawing.Size(77, 13);
            this.labelShowCorrectOrNo.TabIndex = 4;
            this.labelShowCorrectOrNo.Text = "CorrectOrNo";
            this.labelShowCorrectOrNo.Visible = false;
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Enabled = false;
            this.buttonSuivant.Location = new System.Drawing.Point(285, 292);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 5;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // labelSelectAnAnswer
            // 
            this.labelSelectAnAnswer.AutoSize = true;
            this.labelSelectAnAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelSelectAnAnswer.Location = new System.Drawing.Point(128, 318);
            this.labelSelectAnAnswer.Name = "labelSelectAnAnswer";
            this.labelSelectAnAnswer.Size = new System.Drawing.Size(165, 13);
            this.labelSelectAnAnswer.TabIndex = 6;
            this.labelSelectAnAnswer.Text = "Veuillez selectionner une réponse";
            this.labelSelectAnAnswer.Visible = false;
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 347);
            this.Controls.Add(this.labelSelectAnAnswer);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.labelShowCorrectOrNo);
            this.Controls.Add(this.labelCorrection);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.groupBoxQuestion);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelCorrection;
        private System.Windows.Forms.Label labelShowCorrectOrNo;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Label labelSelectAnAnswer;
    }
}

