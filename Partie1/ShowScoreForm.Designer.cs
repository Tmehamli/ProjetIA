namespace Partie1
{
    partial class ShowScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonFinir = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSur20 = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonFinir
            // 
            this.ButtonFinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinir.Location = new System.Drawing.Point(406, 247);
            this.ButtonFinir.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFinir.Name = "ButtonFinir";
            this.ButtonFinir.Size = new System.Drawing.Size(268, 70);
            this.ButtonFinir.TabIndex = 7;
            this.ButtonFinir.Text = "Revenir à l\'accueil";
            this.ButtonFinir.UseVisualStyleBackColor = true;
            this.ButtonFinir.Click += new System.EventHandler(this.ButtonFinir_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(569, 133);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(60, 25);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "score";
            // 
            // labelSur20
            // 
            this.labelSur20.AutoSize = true;
            this.labelSur20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSur20.Location = new System.Drawing.Point(625, 133);
            this.labelSur20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSur20.Name = "labelSur20";
            this.labelSur20.Size = new System.Drawing.Size(40, 25);
            this.labelSur20.TabIndex = 5;
            this.labelSur20.Text = "/20";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.Location = new System.Drawing.Point(388, 133);
            this.labelResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(102, 24);
            this.labelResultat.TabIndex = 4;
            this.labelResultat.Text = "Résultat : ";
            // 
            // LastWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonFinir);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelSur20);
            this.Controls.Add(this.labelResultat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LastWindow";
            this.Size = new System.Drawing.Size(1080, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFinir;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSur20;
        private System.Windows.Forms.Label labelResultat;
    }
}