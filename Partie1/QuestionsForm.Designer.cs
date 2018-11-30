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
            this.image = new System.Windows.Forms.PictureBox();
            this.groupBoxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.labelQuestion);
            this.groupBoxQuestion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(659, 72);
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
            // labelCorrection
            // 
            this.labelCorrection.AutoSize = true;
            this.labelCorrection.Location = new System.Drawing.Point(181, 245);
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
            this.labelShowCorrectOrNo.Location = new System.Drawing.Point(181, 218);
            this.labelShowCorrectOrNo.Name = "labelShowCorrectOrNo";
            this.labelShowCorrectOrNo.Size = new System.Drawing.Size(77, 13);
            this.labelShowCorrectOrNo.TabIndex = 4;
            this.labelShowCorrectOrNo.Text = "CorrectOrNo";
            this.labelShowCorrectOrNo.Visible = false;
            // 
            // labelSelectAnAnswer
            // 
            this.labelSelectAnAnswer.AutoSize = true;
            this.labelSelectAnAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelSelectAnAnswer.Location = new System.Drawing.Point(132, 318);
            this.labelSelectAnAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectAnAnswer.Name = "labelSelectAnAnswer";
            this.labelSelectAnAnswer.Size = new System.Drawing.Size(165, 13);
            this.labelSelectAnAnswer.TabIndex = 6;
            this.labelSelectAnAnswer.Text = "Veuillez selectionner une réponse";
            this.labelSelectAnAnswer.Visible = false;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(183, 275);
            this.btnControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(64, 28);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "button1";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(481, 88);
            this.image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(316, 254);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 8;
            this.image.TabStop = false;
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.labelSelectAnAnswer);
            this.Controls.Add(this.labelShowCorrectOrNo);
            this.Controls.Add(this.labelCorrection);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.image);
            this.Name = "Questionnaire";
            this.Size = new System.Drawing.Size(810, 347);
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
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
        private System.Windows.Forms.PictureBox image;
    }
}

