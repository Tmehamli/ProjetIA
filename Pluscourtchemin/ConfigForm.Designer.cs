namespace Pluscourtchemin
{
    partial class ConfigForm
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
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonMemoire = new System.Windows.Forms.RadioButton();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelFinalNode = new System.Windows.Forms.Label();
            this.textBoxInitialNode = new System.Windows.Forms.TextBox();
            this.textBoxFinalNode = new System.Windows.Forms.TextBox();
            this.labelInitNode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(195, 105);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(66, 17);
            this.radioButtonRandom.TabIndex = 0;
            this.radioButtonRandom.Text = "Aléatoire";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonMemoire
            // 
            this.radioButtonMemoire.AutoSize = true;
            this.radioButtonMemoire.Checked = true;
            this.radioButtonMemoire.Location = new System.Drawing.Point(196, 80);
            this.radioButtonMemoire.Name = "radioButtonMemoire";
            this.radioButtonMemoire.Size = new System.Drawing.Size(65, 17);
            this.radioButtonMemoire.TabIndex = 1;
            this.radioButtonMemoire.TabStop = true;
            this.radioButtonMemoire.Text = "Mémoire";
            this.radioButtonMemoire.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(105, 133);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelFinalNode
            // 
            this.labelFinalNode.AutoSize = true;
            this.labelFinalNode.Location = new System.Drawing.Point(83, 61);
            this.labelFinalNode.Name = "labelFinalNode";
            this.labelFinalNode.Size = new System.Drawing.Size(61, 13);
            this.labelFinalNode.TabIndex = 9;
            this.labelFinalNode.Text = "Noeud final";
            // 
            // textBoxInitialNode
            // 
            this.textBoxInitialNode.Location = new System.Drawing.Point(15, 82);
            this.textBoxInitialNode.Name = "textBoxInitialNode";
            this.textBoxInitialNode.Size = new System.Drawing.Size(52, 20);
            this.textBoxInitialNode.TabIndex = 6;
            this.textBoxInitialNode.Text = "0";
            // 
            // textBoxFinalNode
            // 
            this.textBoxFinalNode.Location = new System.Drawing.Point(86, 82);
            this.textBoxFinalNode.Name = "textBoxFinalNode";
            this.textBoxFinalNode.Size = new System.Drawing.Size(52, 20);
            this.textBoxFinalNode.TabIndex = 7;
            this.textBoxFinalNode.Text = "6";
            // 
            // labelInitNode
            // 
            this.labelInitNode.AutoSize = true;
            this.labelInitNode.Location = new System.Drawing.Point(12, 61);
            this.labelInitNode.Name = "labelInitNode";
            this.labelInitNode.Size = new System.Drawing.Size(65, 13);
            this.labelInitNode.TabIndex = 8;
            this.labelInitNode.Text = "Noeud initial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veuillez choisir les noeuds initiaux et finaux,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "et le type d\'arbre qui sera généré.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinalNode);
            this.Controls.Add(this.textBoxInitialNode);
            this.Controls.Add(this.textBoxFinalNode);
            this.Controls.Add(this.labelInitNode);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.radioButtonMemoire);
            this.Controls.Add(this.radioButtonRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConfigForm";
            this.Text = "Configuration du graphe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonMemoire;
        private System.Windows.Forms.Button buttonValider;
        public System.Windows.Forms.Label labelFinalNode;
        public System.Windows.Forms.TextBox textBoxInitialNode;
        public System.Windows.Forms.TextBox textBoxFinalNode;
        public System.Windows.Forms.Label labelInitNode;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}