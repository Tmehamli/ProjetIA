﻿namespace Pluscourtchemin
{
    partial class Form1
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
            this.buttonInit1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAEtoile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonInit2 = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.textTitre = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.champOuverts = new System.Windows.Forms.TextBox();
            this.champFermes = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.Label();
            this.txtOuvert = new System.Windows.Forms.Label();
            this.txtFerme = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInit1
            // 
            this.buttonInit1.Location = new System.Drawing.Point(35, 22);
            this.buttonInit1.Name = "buttonInit1";
            this.buttonInit1.Size = new System.Drawing.Size(75, 23);
            this.buttonInit1.TabIndex = 0;
            this.buttonInit1.Text = "Init1";
            this.buttonInit1.UseVisualStyleBackColor = true;
            this.buttonInit1.Click += new System.EventHandler(this.buttonInit1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6";
            // 
            // buttonAEtoile
            // 
            this.buttonAEtoile.Location = new System.Drawing.Point(584, 76);
            this.buttonAEtoile.Name = "buttonAEtoile";
            this.buttonAEtoile.Size = new System.Drawing.Size(75, 23);
            this.buttonAEtoile.TabIndex = 3;
            this.buttonAEtoile.Text = "A*";
            this.buttonAEtoile.UseVisualStyleBackColor = true;
            this.buttonAEtoile.Click += new System.EventHandler(this.buttonAEtoile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(550, 114);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            // 
            // buttonInit2
            // 
            this.buttonInit2.Location = new System.Drawing.Point(47, 95);
            this.buttonInit2.Name = "buttonInit2";
            this.buttonInit2.Size = new System.Drawing.Size(75, 23);
            this.buttonInit2.TabIndex = 8;
            this.buttonInit2.Text = "Init2";
            this.buttonInit2.UseVisualStyleBackColor = true;
            this.buttonInit2.Click += new System.EventHandler(this.buttonInit2_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(35, 148);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            this.listBoxgraphe.SelectedIndexChanged += new System.EventHandler(this.listBoxgraphe_SelectedIndexChanged);
            // 
            // textTitre
            // 
            this.textTitre.AutoSize = true;
            this.textTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textTitre.Location = new System.Drawing.Point(308, 9);
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(91, 18);
            this.textTitre.TabIndex = 10;
            this.textTitre.Text = "Test Dijkstra";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(356, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(128, 121);
            this.listBox2.TabIndex = 11;
            // 
            // champOuverts
            // 
            this.champOuverts.Location = new System.Drawing.Point(314, 159);
            this.champOuverts.Name = "champOuverts";
            this.champOuverts.Size = new System.Drawing.Size(100, 20);
            this.champOuverts.TabIndex = 12;
            // 
            // champFermes
            // 
            this.champFermes.Location = new System.Drawing.Point(169, 159);
            this.champFermes.Name = "champFermes";
            this.champFermes.Size = new System.Drawing.Size(100, 20);
            this.champFermes.TabIndex = 13;
            // 
            // txtInstruction
            // 
            this.txtInstruction.AutoSize = true;
            this.txtInstruction.Location = new System.Drawing.Point(171, 43);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(113, 13);
            this.txtInstruction.TabIndex = 14;
            this.txtInstruction.Text = "Ecrire ici la consigne...";
            // 
            // txtOuvert
            // 
            this.txtOuvert.AutoSize = true;
            this.txtOuvert.Location = new System.Drawing.Point(314, 140);
            this.txtOuvert.Name = "txtOuvert";
            this.txtOuvert.Size = new System.Drawing.Size(53, 13);
            this.txtOuvert.TabIndex = 15;
            this.txtOuvert.Text = "Ouverts : ";
            // 
            // txtFerme
            // 
            this.txtFerme.AutoSize = true;
            this.txtFerme.Location = new System.Drawing.Point(172, 140);
            this.txtFerme.Name = "txtFerme";
            this.txtFerme.Size = new System.Drawing.Size(47, 13);
            this.txtFerme.TabIndex = 16;
            this.txtFerme.Text = "Fermés :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(426, 159);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(109, 23);
            this.btn_Valider.TabIndex = 17;
            this.btn_Valider.Text = "Valider cette étape";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 350);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.txtFerme);
            this.Controls.Add(this.txtOuvert);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.champFermes);
            this.Controls.Add(this.champOuverts);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textTitre);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.buttonInit2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAEtoile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAEtoile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonInit2;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.Label textTitre;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox champOuverts;
        private System.Windows.Forms.TextBox champFermes;
        private System.Windows.Forms.Label txtInstruction;
        private System.Windows.Forms.Label txtOuvert;
        private System.Windows.Forms.Label txtFerme;
        private System.Windows.Forms.Button btn_Valider;
    }
}

