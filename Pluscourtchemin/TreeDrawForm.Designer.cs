namespace Pluscourtchemin
{
    partial class TreeDrawForm
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupBoxConsignes = new System.Windows.Forms.GroupBox();
            this.labelCorrectOrNoTree = new System.Windows.Forms.Label();
            this.labelFinalNode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxConsignes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(150, 361);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(88, 31);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // groupBoxConsignes
            // 
            this.groupBoxConsignes.Controls.Add(this.label4);
            this.groupBoxConsignes.Controls.Add(this.label3);
            this.groupBoxConsignes.Controls.Add(this.label2);
            this.groupBoxConsignes.Controls.Add(this.label1);
            this.groupBoxConsignes.Controls.Add(this.labelFinalNode);
            this.groupBoxConsignes.Location = new System.Drawing.Point(13, 12);
            this.groupBoxConsignes.Name = "groupBoxConsignes";
            this.groupBoxConsignes.Size = new System.Drawing.Size(363, 100);
            this.groupBoxConsignes.TabIndex = 2;
            this.groupBoxConsignes.TabStop = false;
            this.groupBoxConsignes.Text = "Consignes";
            // 
            // labelCorrectOrNoTree
            // 
            this.labelCorrectOrNoTree.AutoSize = true;
            this.labelCorrectOrNoTree.Location = new System.Drawing.Point(13, 378);
            this.labelCorrectOrNoTree.Name = "labelCorrectOrNoTree";
            this.labelCorrectOrNoTree.Size = new System.Drawing.Size(35, 13);
            this.labelCorrectOrNoTree.TabIndex = 3;
            this.labelCorrectOrNoTree.Text = "label1";
            this.labelCorrectOrNoTree.Visible = false;
            // 
            // labelFinalNode
            // 
            this.labelFinalNode.AutoSize = true;
            this.labelFinalNode.Location = new System.Drawing.Point(6, 16);
            this.labelFinalNode.Name = "labelFinalNode";
            this.labelFinalNode.Size = new System.Drawing.Size(52, 13);
            this.labelFinalNode.TabIndex = 10;
            this.labelFinalNode.Text = "Veuillez : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "- saisir les numeros des noeuds,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "- saisir le cout pour y arriver depuis le noeud initial,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NB : Separer avec \":\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "- puis valider.";
            // 
            // TreeDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.labelCorrectOrNoTree);
            this.Controls.Add(this.groupBoxConsignes);
            this.Controls.Add(this.buttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TreeDrawForm";
            this.Text = "Arbre Dijkstra";
            this.Load += new System.EventHandler(this.DrawForm_Load);
            this.groupBoxConsignes.ResumeLayout(false);
            this.groupBoxConsignes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.GroupBox groupBoxConsignes;
        private System.Windows.Forms.Label labelCorrectOrNoTree;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelFinalNode;
    }
}