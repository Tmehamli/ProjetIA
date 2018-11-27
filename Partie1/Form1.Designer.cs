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
            this.labelCorrection = new System.Windows.Forms.Label();
            this.labelShowCorrectOrNo = new System.Windows.Forms.Label();
            this.labelSelectAnAnswer = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.groupBoxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.labelQuestion);
            this.groupBoxQuestion.Location = new System.Drawing.Point(16, 15);
            this.groupBoxQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxQuestion.Size = new System.Drawing.Size(575, 89);
            this.groupBoxQuestion.TabIndex = 0;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question n°X";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AllowDrop = true;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(23, 44);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(82, 17);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "La question";
            // 
            // labelCorrection
            // 
            this.labelCorrection.AutoSize = true;
            this.labelCorrection.Location = new System.Drawing.Point(427, 166);
            this.labelCorrection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorrection.Name = "labelCorrection";
            this.labelCorrection.Size = new System.Drawing.Size(100, 17);
            this.labelCorrection.TabIndex = 3;
            this.labelCorrection.Text = "Correction n°X";
            this.labelCorrection.Visible = false;
            // 
            // labelShowCorrectOrNo
            // 
            this.labelShowCorrectOrNo.AutoSize = true;
            this.labelShowCorrectOrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowCorrectOrNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelShowCorrectOrNo.Location = new System.Drawing.Point(427, 133);
            this.labelShowCorrectOrNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowCorrectOrNo.Name = "labelShowCorrectOrNo";
            this.labelShowCorrectOrNo.Size = new System.Drawing.Size(99, 17);
            this.labelShowCorrectOrNo.TabIndex = 4;
            this.labelShowCorrectOrNo.Text = "CorrectOrNo";
            this.labelShowCorrectOrNo.Visible = false;
            // 
            // labelSelectAnAnswer
            // 
            this.labelSelectAnAnswer.AutoSize = true;
            this.labelSelectAnAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelSelectAnAnswer.Location = new System.Drawing.Point(171, 391);
            this.labelSelectAnAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectAnAnswer.Name = "labelSelectAnAnswer";
            this.labelSelectAnAnswer.Size = new System.Drawing.Size(222, 17);
            this.labelSelectAnAnswer.TabIndex = 6;
            this.labelSelectAnAnswer.Text = "Veuillez selectionner une réponse";
            this.labelSelectAnAnswer.Visible = false;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(244, 339);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(85, 34);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "button1";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.labelSelectAnAnswer);
            this.Controls.Add(this.labelShowCorrectOrNo);
            this.Controls.Add(this.labelCorrection);
            this.Controls.Add(this.groupBoxQuestion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Questionnaire";
            this.Size = new System.Drawing.Size(645, 427);
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelCorrection;
        private System.Windows.Forms.Label labelShowCorrectOrNo;
        private System.Windows.Forms.Label labelSelectAnAnswer;
        private System.Windows.Forms.Button btnControl;
    }
}

