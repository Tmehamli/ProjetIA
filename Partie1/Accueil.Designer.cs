namespace Partie1
{
    partial class Accueil
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
            this.btnCommencer = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.texteAuteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommencer
            // 
            this.btnCommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommencer.Location = new System.Drawing.Point(410, 206);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(207, 43);
            this.btnCommencer.TabIndex = 0;
            this.btnCommencer.Text = "Commencer le test";
            this.btnCommencer.UseVisualStyleBackColor = true;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(349, 30);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(328, 32);
            this.text1.TabIndex = 1;
            this.text1.Text = "Questionnaire module IA";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuitter.Location = new System.Drawing.Point(410, 272);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(207, 38);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(282, 111);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(478, 29);
            this.text2.TabIndex = 3;
            this.text2.Text = "Tester vos connaissances en 20 questions !";
            // 
            // texteAuteur
            // 
            this.texteAuteur.AutoSize = true;
            this.texteAuteur.Location = new System.Drawing.Point(605, 375);
            this.texteAuteur.Name = "texteAuteur";
            this.texteAuteur.Size = new System.Drawing.Size(371, 17);
            this.texteAuteur.TabIndex = 4;
            this.texteAuteur.Text = "Projet IA - Mehamli Théo, Gibert Marie, Ghennam Younes";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.texteAuteur);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnCommencer);
            this.Name = "Accueil";
            this.Size = new System.Drawing.Size(1080, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label texteAuteur;
    }
}