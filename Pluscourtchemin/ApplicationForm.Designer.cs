namespace Pluscourtchemin
{
    partial class FormDijkstra
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
            this.buttonInitAlea = new System.Windows.Forms.Button();
            this.textBoxInitialNode = new System.Windows.Forms.TextBox();
            this.textBoxFinalNode = new System.Windows.Forms.TextBox();
            this.buttonAEtoile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeViewCorrection = new System.Windows.Forms.TreeView();
            this.btnInitMemoire = new System.Windows.Forms.Button();
            this.listBoxGraphe = new System.Windows.Forms.ListBox();
            this.textTitre = new System.Windows.Forms.Label();
            this.listBoxShowFermeUti = new System.Windows.Forms.ListBox();
            this.textBoxOuverts = new System.Windows.Forms.TextBox();
            this.textBoxFermes = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.Label();
            this.txtOuvert = new System.Windows.Forms.Label();
            this.txtFerme = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.listBoxShowOuvertUti = new System.Windows.Forms.ListBox();
            this.txtCorrection = new System.Windows.Forms.Label();
            this.labelShowCorrectOrNot = new System.Windows.Forms.Label();
            this.listBoxShowOuvertIA = new System.Windows.Forms.ListBox();
            this.listBoxShowFermeIA = new System.Windows.Forms.ListBox();
            this.buttonShowTree = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ld14 = new System.Windows.Forms.Label();
            this.ld16 = new System.Windows.Forms.Label();
            this.ld22 = new System.Windows.Forms.Label();
            this.ld21 = new System.Windows.Forms.Label();
            this.ld15 = new System.Windows.Forms.Label();
            this.ld13 = new System.Windows.Forms.Label();
            this.ld17 = new System.Windows.Forms.Label();
            this.ld12 = new System.Windows.Forms.Label();
            this.ld11 = new System.Windows.Forms.Label();
            this.ld2 = new System.Windows.Forms.Label();
            this.ld6 = new System.Windows.Forms.Label();
            this.ld4 = new System.Windows.Forms.Label();
            this.ld7 = new System.Windows.Forms.Label();
            this.ld3 = new System.Windows.Forms.Label();
            this.ld5 = new System.Windows.Forms.Label();
            this.ld1 = new System.Windows.Forms.Label();
            this.ld20 = new System.Windows.Forms.Label();
            this.ld19 = new System.Windows.Forms.Label();
            this.ld18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInitAlea
            // 
            this.buttonInitAlea.Location = new System.Drawing.Point(35, 68);
            this.buttonInitAlea.Name = "buttonInitAlea";
            this.buttonInitAlea.Size = new System.Drawing.Size(100, 23);
            this.buttonInitAlea.TabIndex = 0;
            this.buttonInitAlea.Text = "Démarrer aléa";
            this.buttonInitAlea.UseVisualStyleBackColor = true;
            this.buttonInitAlea.Click += new System.EventHandler(this.buttonInitAlea_Click);
            // 
            // textBoxInitialNode
            // 
            this.textBoxInitialNode.Location = new System.Drawing.Point(177, 97);
            this.textBoxInitialNode.Name = "textBoxInitialNode";
            this.textBoxInitialNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitialNode.TabIndex = 1;
            this.textBoxInitialNode.Text = "0";
            // 
            // textBoxFinalNode
            // 
            this.textBoxFinalNode.Location = new System.Drawing.Point(317, 97);
            this.textBoxFinalNode.Name = "textBoxFinalNode";
            this.textBoxFinalNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalNode.TabIndex = 2;
            this.textBoxFinalNode.Text = "6";
            // 
            // buttonAEtoile
            // 
            this.buttonAEtoile.Location = new System.Drawing.Point(570, 12);
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
            this.label1.Location = new System.Drawing.Point(174, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(742, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 69);
            this.listBox1.TabIndex = 6;
            // 
            // treeViewCorrection
            // 
            this.treeViewCorrection.Location = new System.Drawing.Point(550, 114);
            this.treeViewCorrection.Name = "treeViewCorrection";
            this.treeViewCorrection.Size = new System.Drawing.Size(152, 180);
            this.treeViewCorrection.TabIndex = 7;
            // 
            // btnInitMemoire
            // 
            this.btnInitMemoire.Location = new System.Drawing.Point(35, 95);
            this.btnInitMemoire.Name = "btnInitMemoire";
            this.btnInitMemoire.Size = new System.Drawing.Size(100, 23);
            this.btnInitMemoire.TabIndex = 8;
            this.btnInitMemoire.Text = "Démarrer Mem";
            this.btnInitMemoire.UseVisualStyleBackColor = true;
            this.btnInitMemoire.Click += new System.EventHandler(this.buttonInitMemoire_Click);
            // 
            // listBoxGraphe
            // 
            this.listBoxGraphe.FormattingEnabled = true;
            this.listBoxGraphe.Location = new System.Drawing.Point(35, 148);
            this.listBoxGraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGraphe.Name = "listBoxGraphe";
            this.listBoxGraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxGraphe.TabIndex = 9;
            // 
            // textTitre
            // 
            this.textTitre.AutoSize = true;
            this.textTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textTitre.Location = new System.Drawing.Point(264, 9);
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(91, 18);
            this.textTitre.TabIndex = 10;
            this.textTitre.Text = "Test Dijkstra";
            // 
            // listBoxShowFermeUti
            // 
            this.listBoxShowFermeUti.FormattingEnabled = true;
            this.listBoxShowFermeUti.Location = new System.Drawing.Point(175, 185);
            this.listBoxShowFermeUti.Name = "listBoxShowFermeUti";
            this.listBoxShowFermeUti.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowFermeUti.TabIndex = 11;
            // 
            // textBoxOuverts
            // 
            this.textBoxOuverts.Location = new System.Drawing.Point(320, 159);
            this.textBoxOuverts.Name = "textBoxOuverts";
            this.textBoxOuverts.Size = new System.Drawing.Size(100, 20);
            this.textBoxOuverts.TabIndex = 12;
            // 
            // textBoxFermes
            // 
            this.textBoxFermes.Location = new System.Drawing.Point(175, 159);
            this.textBoxFermes.Name = "textBoxFermes";
            this.textBoxFermes.Size = new System.Drawing.Size(100, 20);
            this.textBoxFermes.TabIndex = 13;
            // 
            // txtInstruction
            // 
            this.txtInstruction.AutoSize = true;
            this.txtInstruction.Location = new System.Drawing.Point(60, 42);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(113, 13);
            this.txtInstruction.TabIndex = 14;
            this.txtInstruction.Text = "Ecrire ici la consigne...";
            // 
            // txtOuvert
            // 
            this.txtOuvert.AutoSize = true;
            this.txtOuvert.Location = new System.Drawing.Point(352, 140);
            this.txtOuvert.Name = "txtOuvert";
            this.txtOuvert.Size = new System.Drawing.Size(53, 13);
            this.txtOuvert.TabIndex = 15;
            this.txtOuvert.Text = "Ouverts : ";
            // 
            // txtFerme
            // 
            this.txtFerme.AutoSize = true;
            this.txtFerme.Location = new System.Drawing.Point(204, 140);
            this.txtFerme.Name = "txtFerme";
            this.txtFerme.Size = new System.Drawing.Size(47, 13);
            this.txtFerme.TabIndex = 16;
            this.txtFerme.Text = "Fermés :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(432, 159);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(109, 23);
            this.btn_Valider.TabIndex = 17;
            this.btn_Valider.Text = "Valider cette étape";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // listBoxShowOuvertUti
            // 
            this.listBoxShowOuvertUti.FormattingEnabled = true;
            this.listBoxShowOuvertUti.Location = new System.Drawing.Point(320, 186);
            this.listBoxShowOuvertUti.Name = "listBoxShowOuvertUti";
            this.listBoxShowOuvertUti.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowOuvertUti.TabIndex = 18;
            // 
            // txtCorrection
            // 
            this.txtCorrection.AutoSize = true;
            this.txtCorrection.Location = new System.Drawing.Point(547, 73);
            this.txtCorrection.Name = "txtCorrection";
            this.txtCorrection.Size = new System.Drawing.Size(64, 13);
            this.txtCorrection.TabIndex = 19;
            this.txtCorrection.Text = "Correction : ";
            // 
            // labelShowCorrectOrNot
            // 
            this.labelShowCorrectOrNot.AutoSize = true;
            this.labelShowCorrectOrNot.Location = new System.Drawing.Point(717, 31);
            this.labelShowCorrectOrNot.Name = "labelShowCorrectOrNot";
            this.labelShowCorrectOrNot.Size = new System.Drawing.Size(71, 13);
            this.labelShowCorrectOrNot.TabIndex = 20;
            this.labelShowCorrectOrNot.Text = "reussiteOrNot";
            // 
            // listBoxShowOuvertIA
            // 
            this.listBoxShowOuvertIA.FormattingEnabled = true;
            this.listBoxShowOuvertIA.Location = new System.Drawing.Point(887, 202);
            this.listBoxShowOuvertIA.Name = "listBoxShowOuvertIA";
            this.listBoxShowOuvertIA.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowOuvertIA.TabIndex = 22;
            // 
            // listBoxShowFermeIA
            // 
            this.listBoxShowFermeIA.FormattingEnabled = true;
            this.listBoxShowFermeIA.Location = new System.Drawing.Point(742, 201);
            this.listBoxShowFermeIA.Name = "listBoxShowFermeIA";
            this.listBoxShowFermeIA.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowFermeIA.TabIndex = 21;
            // 
            // buttonShowTree
            // 
            this.buttonShowTree.Location = new System.Drawing.Point(586, 315);
            this.buttonShowTree.Name = "buttonShowTree";
            this.buttonShowTree.Size = new System.Drawing.Size(116, 23);
            this.buttonShowTree.TabIndex = 23;
            this.buttonShowTree.Text = "Remplir l\'arbre";
            this.buttonShowTree.UseVisualStyleBackColor = true;
            this.buttonShowTree.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 191);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ld14
            // 
            this.ld14.AutoSize = true;
            this.ld14.Location = new System.Drawing.Point(198, 359);
            this.ld14.Name = "ld14";
            this.ld14.Size = new System.Drawing.Size(41, 13);
            this.ld14.TabIndex = 101;
            this.ld14.Text = "label14";
            // 
            // ld16
            // 
            this.ld16.AutoSize = true;
            this.ld16.Location = new System.Drawing.Point(204, 437);
            this.ld16.Name = "ld16";
            this.ld16.Size = new System.Drawing.Size(41, 13);
            this.ld16.TabIndex = 100;
            this.ld16.Text = "label16";
            // 
            // ld22
            // 
            this.ld22.AutoSize = true;
            this.ld22.Location = new System.Drawing.Point(364, 430);
            this.ld22.Name = "ld22";
            this.ld22.Size = new System.Drawing.Size(41, 13);
            this.ld22.TabIndex = 99;
            this.ld22.Text = "label22";
            // 
            // ld21
            // 
            this.ld21.AutoSize = true;
            this.ld21.Location = new System.Drawing.Point(376, 352);
            this.ld21.Name = "ld21";
            this.ld21.Size = new System.Drawing.Size(41, 13);
            this.ld21.TabIndex = 98;
            this.ld21.Text = "label21";
            // 
            // ld15
            // 
            this.ld15.AutoSize = true;
            this.ld15.Location = new System.Drawing.Point(248, 315);
            this.ld15.Name = "ld15";
            this.ld15.Size = new System.Drawing.Size(41, 13);
            this.ld15.TabIndex = 97;
            this.ld15.Text = "label15";
            // 
            // ld13
            // 
            this.ld13.AutoSize = true;
            this.ld13.Location = new System.Drawing.Point(115, 381);
            this.ld13.Name = "ld13";
            this.ld13.Size = new System.Drawing.Size(41, 13);
            this.ld13.TabIndex = 96;
            this.ld13.Text = "label13";
            // 
            // ld17
            // 
            this.ld17.AutoSize = true;
            this.ld17.Location = new System.Drawing.Point(264, 463);
            this.ld17.Name = "ld17";
            this.ld17.Size = new System.Drawing.Size(41, 13);
            this.ld17.TabIndex = 95;
            this.ld17.Text = "label17";
            // 
            // ld12
            // 
            this.ld12.AutoSize = true;
            this.ld12.Location = new System.Drawing.Point(94, 437);
            this.ld12.Name = "ld12";
            this.ld12.Size = new System.Drawing.Size(41, 13);
            this.ld12.TabIndex = 94;
            this.ld12.Text = "label12";
            // 
            // ld11
            // 
            this.ld11.AutoSize = true;
            this.ld11.Location = new System.Drawing.Point(115, 342);
            this.ld11.Name = "ld11";
            this.ld11.Size = new System.Drawing.Size(41, 13);
            this.ld11.TabIndex = 93;
            this.ld11.Text = "label11";
            // 
            // ld2
            // 
            this.ld2.AutoSize = true;
            this.ld2.BackColor = System.Drawing.Color.Black;
            this.ld2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld2.ForeColor = System.Drawing.SystemColors.Control;
            this.ld2.Location = new System.Drawing.Point(331, 324);
            this.ld2.Name = "ld2";
            this.ld2.Size = new System.Drawing.Size(16, 16);
            this.ld2.TabIndex = 92;
            this.ld2.Text = "4";
            // 
            // ld6
            // 
            this.ld6.AutoSize = true;
            this.ld6.BackColor = System.Drawing.Color.Black;
            this.ld6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld6.ForeColor = System.Drawing.SystemColors.Control;
            this.ld6.Location = new System.Drawing.Point(189, 463);
            this.ld6.Name = "ld6";
            this.ld6.Size = new System.Drawing.Size(16, 16);
            this.ld6.TabIndex = 91;
            this.ld6.Text = "2";
            // 
            // ld4
            // 
            this.ld4.AutoSize = true;
            this.ld4.BackColor = System.Drawing.Color.Black;
            this.ld4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld4.ForeColor = System.Drawing.SystemColors.Control;
            this.ld4.Location = new System.Drawing.Point(429, 390);
            this.ld4.Name = "ld4";
            this.ld4.Size = new System.Drawing.Size(16, 16);
            this.ld4.TabIndex = 90;
            this.ld4.Text = "6";
            // 
            // ld7
            // 
            this.ld7.AutoSize = true;
            this.ld7.BackColor = System.Drawing.Color.Black;
            this.ld7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld7.ForeColor = System.Drawing.SystemColors.Control;
            this.ld7.Location = new System.Drawing.Point(317, 437);
            this.ld7.Name = "ld7";
            this.ld7.Size = new System.Drawing.Size(16, 16);
            this.ld7.TabIndex = 89;
            this.ld7.Text = "5";
            // 
            // ld3
            // 
            this.ld3.AutoSize = true;
            this.ld3.BackColor = System.Drawing.Color.Black;
            this.ld3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld3.ForeColor = System.Drawing.SystemColors.Control;
            this.ld3.Location = new System.Drawing.Point(204, 390);
            this.ld3.Name = "ld3";
            this.ld3.Size = new System.Drawing.Size(16, 16);
            this.ld3.TabIndex = 88;
            this.ld3.Text = "3";
            // 
            // ld5
            // 
            this.ld5.AutoSize = true;
            this.ld5.BackColor = System.Drawing.Color.Black;
            this.ld5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld5.ForeColor = System.Drawing.SystemColors.Control;
            this.ld5.Location = new System.Drawing.Point(189, 324);
            this.ld5.Name = "ld5";
            this.ld5.Size = new System.Drawing.Size(16, 16);
            this.ld5.TabIndex = 87;
            this.ld5.Text = "1";
            // 
            // ld1
            // 
            this.ld1.AutoSize = true;
            this.ld1.BackColor = System.Drawing.Color.Black;
            this.ld1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld1.ForeColor = System.Drawing.SystemColors.Control;
            this.ld1.Location = new System.Drawing.Point(57, 385);
            this.ld1.Name = "ld1";
            this.ld1.Size = new System.Drawing.Size(16, 16);
            this.ld1.TabIndex = 86;
            this.ld1.Text = "0";
            // 
            // ld20
            // 
            this.ld20.AutoSize = true;
            this.ld20.Location = new System.Drawing.Point(323, 390);
            this.ld20.Name = "ld20";
            this.ld20.Size = new System.Drawing.Size(41, 13);
            this.ld20.TabIndex = 102;
            this.ld20.Text = "label20";
            // 
            // ld19
            // 
            this.ld19.AutoSize = true;
            this.ld19.Location = new System.Drawing.Point(264, 415);
            this.ld19.Name = "ld19";
            this.ld19.Size = new System.Drawing.Size(41, 13);
            this.ld19.TabIndex = 103;
            this.ld19.Text = "label19";
            // 
            // ld18
            // 
            this.ld18.AutoSize = true;
            this.ld18.Location = new System.Drawing.Point(259, 374);
            this.ld18.Name = "ld18";
            this.ld18.Size = new System.Drawing.Size(41, 13);
            this.ld18.TabIndex = 104;
            this.ld18.Text = "label18";
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 505);
            this.Controls.Add(this.ld18);
            this.Controls.Add(this.ld19);
            this.Controls.Add(this.ld20);
            this.Controls.Add(this.ld14);
            this.Controls.Add(this.ld16);
            this.Controls.Add(this.ld22);
            this.Controls.Add(this.ld21);
            this.Controls.Add(this.ld15);
            this.Controls.Add(this.ld13);
            this.Controls.Add(this.ld17);
            this.Controls.Add(this.ld12);
            this.Controls.Add(this.ld11);
            this.Controls.Add(this.ld2);
            this.Controls.Add(this.ld6);
            this.Controls.Add(this.ld4);
            this.Controls.Add(this.ld7);
            this.Controls.Add(this.ld3);
            this.Controls.Add(this.ld5);
            this.Controls.Add(this.ld1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonShowTree);
            this.Controls.Add(this.listBoxShowOuvertIA);
            this.Controls.Add(this.listBoxShowFermeIA);
            this.Controls.Add(this.labelShowCorrectOrNot);
            this.Controls.Add(this.txtCorrection);
            this.Controls.Add(this.listBoxShowOuvertUti);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.txtFerme);
            this.Controls.Add(this.txtOuvert);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.textBoxFermes);
            this.Controls.Add(this.textBoxOuverts);
            this.Controls.Add(this.listBoxShowFermeUti);
            this.Controls.Add(this.textTitre);
            this.Controls.Add(this.listBoxGraphe);
            this.Controls.Add(this.btnInitMemoire);
            this.Controls.Add(this.treeViewCorrection);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAEtoile);
            this.Controls.Add(this.textBoxFinalNode);
            this.Controls.Add(this.textBoxInitialNode);
            this.Controls.Add(this.buttonInitAlea);
            this.Name = "FormDijkstra";
            this.Text = "Mise en application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxInitialNode;
        public System.Windows.Forms.TextBox textBoxFinalNode;
        public System.Windows.Forms.Button buttonAEtoile;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TreeView treeViewCorrection;
        public System.Windows.Forms.Button btnInitMemoire;
        public System.Windows.Forms.ListBox listBoxGraphe;
        public System.Windows.Forms.Label textTitre;
        public System.Windows.Forms.ListBox listBoxShowFermeUti;
        public System.Windows.Forms.TextBox textBoxOuverts;
        public System.Windows.Forms.TextBox textBoxFermes;
        public System.Windows.Forms.Label txtInstruction;
        public System.Windows.Forms.Label txtOuvert;
        public System.Windows.Forms.Label txtFerme;
        public System.Windows.Forms.Button btn_Valider;
        public System.Windows.Forms.ListBox listBoxShowOuvertUti;
        public System.Windows.Forms.Label txtCorrection;
        public System.Windows.Forms.Label labelShowCorrectOrNot;
        public System.Windows.Forms.Button buttonInitAlea;
        public System.Windows.Forms.ListBox listBoxShowOuvertIA;
        public System.Windows.Forms.ListBox listBoxShowFermeIA;
        private System.Windows.Forms.Button buttonShowTree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ld14;
        private System.Windows.Forms.Label ld16;
        private System.Windows.Forms.Label ld22;
        private System.Windows.Forms.Label ld21;
        private System.Windows.Forms.Label ld15;
        private System.Windows.Forms.Label ld13;
        private System.Windows.Forms.Label ld17;
        private System.Windows.Forms.Label ld12;
        private System.Windows.Forms.Label ld11;
        private System.Windows.Forms.Label ld2;
        private System.Windows.Forms.Label ld6;
        private System.Windows.Forms.Label ld4;
        private System.Windows.Forms.Label ld7;
        private System.Windows.Forms.Label ld3;
        private System.Windows.Forms.Label ld5;
        private System.Windows.Forms.Label ld1;
        private System.Windows.Forms.Label ld20;
        private System.Windows.Forms.Label ld19;
        private System.Windows.Forms.Label ld18;
    }
}

