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
            this.components = new System.ComponentModel.Container();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonReponseX = new System.Windows.Forms.RadioButton();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelCorrection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderChoisirReponse = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChoisirReponse)).BeginInit();
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
            // radioButtonReponseX
            // 
            this.radioButtonReponseX.AutoSize = true;
            this.radioButtonReponseX.Location = new System.Drawing.Point(32, 108);
            this.radioButtonReponseX.Name = "radioButtonReponseX";
            this.radioButtonReponseX.Size = new System.Drawing.Size(129, 17);
            this.radioButtonReponseX.TabIndex = 1;
            this.radioButtonReponseX.TabStop = true;
            this.radioButtonReponseX.Text = "radioButtonReponseX";
            this.radioButtonReponseX.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(108, 152);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // labelCorrection
            // 
            this.labelCorrection.AutoSize = true;
            this.labelCorrection.Location = new System.Drawing.Point(12, 199);
            this.labelCorrection.Name = "labelCorrection";
            this.labelCorrection.Size = new System.Drawing.Size(75, 13);
            this.labelCorrection.TabIndex = 3;
            this.labelCorrection.Text = "Correction n°X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CorrectOrNo";
            // 
            // errorProviderChoisirReponse
            // 
            this.errorProviderChoisirReponse.ContainerControl = this;
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCorrection);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.radioButtonReponseX);
            this.Controls.Add(this.groupBoxQuestion);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChoisirReponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonReponseX;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelCorrection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderChoisirReponse;
    }
}

