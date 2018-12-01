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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeViewCorrection = new System.Windows.Forms.TreeView();
            this.btnInitMemoire = new System.Windows.Forms.Button();
            this.listBoxGraphe = new System.Windows.Forms.ListBox();
            this.listBoxShowFermeUti = new System.Windows.Forms.ListBox();
            this.textBoxOuverts = new System.Windows.Forms.TextBox();
            this.textBoxFermes = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.Label();
            this.txtOuvert = new System.Windows.Forms.Label();
            this.txtFerme = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.listBoxShowOuvertUti = new System.Windows.Forms.ListBox();
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
            this.buttonRetour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCor1Part = new System.Windows.Forms.GroupBox();
            this.isGraphInMemory = new System.Windows.Forms.Label();
            this.groupBoxCor2Part = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.isGraphInMemory2 = new System.Windows.Forms.Label();
            this.panelGraphImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxCor1Part.SuspendLayout();
            this.groupBoxCor2Part.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInitAlea
            // 
            this.buttonInitAlea.Location = new System.Drawing.Point(161, 95);
            this.buttonInitAlea.Name = "buttonInitAlea";
            this.buttonInitAlea.Size = new System.Drawing.Size(100, 23);
            this.buttonInitAlea.TabIndex = 0;
            this.buttonInitAlea.Text = "Démarrer aléa";
            this.buttonInitAlea.UseVisualStyleBackColor = true;
            this.buttonInitAlea.Click += new System.EventHandler(this.buttonInitAlea_Click);
            // 
            // textBoxInitialNode
            // 
            this.textBoxInitialNode.Location = new System.Drawing.Point(16, 98);
            this.textBoxInitialNode.Name = "textBoxInitialNode";
            this.textBoxInitialNode.Size = new System.Drawing.Size(52, 20);
            this.textBoxInitialNode.TabIndex = 1;
            this.textBoxInitialNode.Text = "0";
            // 
            // textBoxFinalNode
            // 
            this.textBoxFinalNode.Location = new System.Drawing.Point(87, 98);
            this.textBoxFinalNode.Name = "textBoxFinalNode";
            this.textBoxFinalNode.Size = new System.Drawing.Size(52, 20);
            this.textBoxFinalNode.TabIndex = 2;
            this.textBoxFinalNode.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 69);
            this.listBox1.TabIndex = 6;
            // 
            // treeViewCorrection
            // 
            this.treeViewCorrection.Location = new System.Drawing.Point(6, 159);
            this.treeViewCorrection.Name = "treeViewCorrection";
            this.treeViewCorrection.Size = new System.Drawing.Size(152, 180);
            this.treeViewCorrection.TabIndex = 7;
            // 
            // btnInitMemoire
            // 
            this.btnInitMemoire.Location = new System.Drawing.Point(267, 96);
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
            this.listBoxGraphe.Location = new System.Drawing.Point(7, 18);
            this.listBoxGraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGraphe.Name = "listBoxGraphe";
            this.listBoxGraphe.Size = new System.Drawing.Size(100, 186);
            this.listBoxGraphe.TabIndex = 9;
            // 
            // listBoxShowFermeUti
            // 
            this.listBoxShowFermeUti.FormattingEnabled = true;
            this.listBoxShowFermeUti.Location = new System.Drawing.Point(6, 55);
            this.listBoxShowFermeUti.Name = "listBoxShowFermeUti";
            this.listBoxShowFermeUti.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowFermeUti.TabIndex = 11;
            // 
            // textBoxOuverts
            // 
            this.textBoxOuverts.Location = new System.Drawing.Point(145, 28);
            this.textBoxOuverts.Name = "textBoxOuverts";
            this.textBoxOuverts.Size = new System.Drawing.Size(100, 20);
            this.textBoxOuverts.TabIndex = 12;
            // 
            // textBoxFermes
            // 
            this.textBoxFermes.Location = new System.Drawing.Point(6, 29);
            this.textBoxFermes.Name = "textBoxFermes";
            this.textBoxFermes.Size = new System.Drawing.Size(100, 20);
            this.textBoxFermes.TabIndex = 13;
            // 
            // txtInstruction
            // 
            this.txtInstruction.AutoSize = true;
            this.txtInstruction.Location = new System.Drawing.Point(13, 25);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(113, 13);
            this.txtInstruction.TabIndex = 14;
            this.txtInstruction.Text = "Ecrire ici la consigne...";
            // 
            // txtOuvert
            // 
            this.txtOuvert.AutoSize = true;
            this.txtOuvert.Location = new System.Drawing.Point(142, 14);
            this.txtOuvert.Name = "txtOuvert";
            this.txtOuvert.Size = new System.Drawing.Size(53, 13);
            this.txtOuvert.TabIndex = 15;
            this.txtOuvert.Text = "Ouverts : ";
            // 
            // txtFerme
            // 
            this.txtFerme.AutoSize = true;
            this.txtFerme.Location = new System.Drawing.Point(6, 15);
            this.txtFerme.Name = "txtFerme";
            this.txtFerme.Size = new System.Drawing.Size(47, 13);
            this.txtFerme.TabIndex = 16;
            this.txtFerme.Text = "Fermés :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(145, 169);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(100, 23);
            this.btn_Valider.TabIndex = 17;
            this.btn_Valider.Text = "Valider étape";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // listBoxShowOuvertUti
            // 
            this.listBoxShowOuvertUti.FormattingEnabled = true;
            this.listBoxShowOuvertUti.Location = new System.Drawing.Point(145, 55);
            this.listBoxShowOuvertUti.Name = "listBoxShowOuvertUti";
            this.listBoxShowOuvertUti.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowOuvertUti.TabIndex = 18;
            // 
            // labelShowCorrectOrNot
            // 
            this.labelShowCorrectOrNot.AutoSize = true;
            this.labelShowCorrectOrNot.Location = new System.Drawing.Point(6, 146);
            this.labelShowCorrectOrNot.Name = "labelShowCorrectOrNot";
            this.labelShowCorrectOrNot.Size = new System.Drawing.Size(71, 13);
            this.labelShowCorrectOrNot.TabIndex = 20;
            this.labelShowCorrectOrNot.Text = "reussiteOrNot";
            // 
            // listBoxShowOuvertIA
            // 
            this.listBoxShowOuvertIA.FormattingEnabled = true;
            this.listBoxShowOuvertIA.Location = new System.Drawing.Point(124, 35);
            this.listBoxShowOuvertIA.Name = "listBoxShowOuvertIA";
            this.listBoxShowOuvertIA.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowOuvertIA.TabIndex = 22;
            // 
            // listBoxShowFermeIA
            // 
            this.listBoxShowFermeIA.FormattingEnabled = true;
            this.listBoxShowFermeIA.Location = new System.Drawing.Point(9, 35);
            this.listBoxShowFermeIA.Name = "listBoxShowFermeIA";
            this.listBoxShowFermeIA.Size = new System.Drawing.Size(100, 108);
            this.listBoxShowFermeIA.TabIndex = 21;
            // 
            // buttonShowTree
            // 
            this.buttonShowTree.Location = new System.Drawing.Point(58, 172);
            this.buttonShowTree.Name = "buttonShowTree";
            this.buttonShowTree.Size = new System.Drawing.Size(116, 23);
            this.buttonShowTree.TabIndex = 23;
            this.buttonShowTree.Text = "Remplir l\'arbre";
            this.buttonShowTree.UseVisualStyleBackColor = true;
            this.buttonShowTree.Click += new System.EventHandler(this.buttonShowTree_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(112, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 191);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ld14
            // 
            this.ld14.AutoSize = true;
            this.ld14.Location = new System.Drawing.Point(275, 78);
            this.ld14.Name = "ld14";
            this.ld14.Size = new System.Drawing.Size(41, 13);
            this.ld14.TabIndex = 101;
            this.ld14.Text = "label14";
            // 
            // ld16
            // 
            this.ld16.AutoSize = true;
            this.ld16.Location = new System.Drawing.Point(281, 156);
            this.ld16.Name = "ld16";
            this.ld16.Size = new System.Drawing.Size(41, 13);
            this.ld16.TabIndex = 100;
            this.ld16.Text = "label16";
            // 
            // ld22
            // 
            this.ld22.AutoSize = true;
            this.ld22.Location = new System.Drawing.Point(441, 149);
            this.ld22.Name = "ld22";
            this.ld22.Size = new System.Drawing.Size(41, 13);
            this.ld22.TabIndex = 99;
            this.ld22.Text = "label22";
            // 
            // ld21
            // 
            this.ld21.AutoSize = true;
            this.ld21.Location = new System.Drawing.Point(453, 71);
            this.ld21.Name = "ld21";
            this.ld21.Size = new System.Drawing.Size(41, 13);
            this.ld21.TabIndex = 98;
            this.ld21.Text = "label21";
            // 
            // ld15
            // 
            this.ld15.AutoSize = true;
            this.ld15.Location = new System.Drawing.Point(325, 34);
            this.ld15.Name = "ld15";
            this.ld15.Size = new System.Drawing.Size(41, 13);
            this.ld15.TabIndex = 97;
            this.ld15.Text = "label15";
            // 
            // ld13
            // 
            this.ld13.AutoSize = true;
            this.ld13.Location = new System.Drawing.Point(192, 100);
            this.ld13.Name = "ld13";
            this.ld13.Size = new System.Drawing.Size(41, 13);
            this.ld13.TabIndex = 96;
            this.ld13.Text = "label13";
            // 
            // ld17
            // 
            this.ld17.AutoSize = true;
            this.ld17.Location = new System.Drawing.Point(341, 182);
            this.ld17.Name = "ld17";
            this.ld17.Size = new System.Drawing.Size(41, 13);
            this.ld17.TabIndex = 95;
            this.ld17.Text = "label17";
            // 
            // ld12
            // 
            this.ld12.AutoSize = true;
            this.ld12.Location = new System.Drawing.Point(171, 156);
            this.ld12.Name = "ld12";
            this.ld12.Size = new System.Drawing.Size(41, 13);
            this.ld12.TabIndex = 94;
            this.ld12.Text = "label12";
            // 
            // ld11
            // 
            this.ld11.AutoSize = true;
            this.ld11.Location = new System.Drawing.Point(192, 61);
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
            this.ld2.Location = new System.Drawing.Point(408, 43);
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
            this.ld6.Location = new System.Drawing.Point(266, 182);
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
            this.ld4.Location = new System.Drawing.Point(506, 109);
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
            this.ld7.Location = new System.Drawing.Point(394, 156);
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
            this.ld3.Location = new System.Drawing.Point(281, 109);
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
            this.ld5.Location = new System.Drawing.Point(266, 43);
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
            this.ld1.Location = new System.Drawing.Point(134, 104);
            this.ld1.Name = "ld1";
            this.ld1.Size = new System.Drawing.Size(16, 16);
            this.ld1.TabIndex = 86;
            this.ld1.Text = "0";
            // 
            // ld20
            // 
            this.ld20.AutoSize = true;
            this.ld20.Location = new System.Drawing.Point(400, 109);
            this.ld20.Name = "ld20";
            this.ld20.Size = new System.Drawing.Size(41, 13);
            this.ld20.TabIndex = 102;
            this.ld20.Text = "label20";
            // 
            // ld19
            // 
            this.ld19.AutoSize = true;
            this.ld19.Location = new System.Drawing.Point(341, 134);
            this.ld19.Name = "ld19";
            this.ld19.Size = new System.Drawing.Size(41, 13);
            this.ld19.TabIndex = 103;
            this.ld19.Text = "label19";
            // 
            // ld18
            // 
            this.ld18.AutoSize = true;
            this.ld18.Location = new System.Drawing.Point(356, 78);
            this.ld18.Name = "ld18";
            this.ld18.Size = new System.Drawing.Size(41, 13);
            this.ld18.TabIndex = 104;
            this.ld18.Text = "label18";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(6, 169);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(100, 23);
            this.buttonRetour.TabIndex = 105;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInstruction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxInitialNode);
            this.groupBox1.Controls.Add(this.textBoxFinalNode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonInitAlea);
            this.groupBox1.Controls.Add(this.btnInitMemoire);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 124);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test de Dijkstra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGraphImage);
            this.groupBox2.Controls.Add(this.listBoxGraphe);
            this.groupBox2.Controls.Add(this.ld1);
            this.groupBox2.Controls.Add(this.ld5);
            this.groupBox2.Controls.Add(this.ld18);
            this.groupBox2.Controls.Add(this.ld3);
            this.groupBox2.Controls.Add(this.ld19);
            this.groupBox2.Controls.Add(this.ld7);
            this.groupBox2.Controls.Add(this.ld20);
            this.groupBox2.Controls.Add(this.ld4);
            this.groupBox2.Controls.Add(this.ld14);
            this.groupBox2.Controls.Add(this.ld6);
            this.groupBox2.Controls.Add(this.ld16);
            this.groupBox2.Controls.Add(this.ld2);
            this.groupBox2.Controls.Add(this.ld22);
            this.groupBox2.Controls.Add(this.ld11);
            this.groupBox2.Controls.Add(this.ld21);
            this.groupBox2.Controls.Add(this.ld12);
            this.groupBox2.Controls.Add(this.ld15);
            this.groupBox2.Controls.Add(this.ld17);
            this.groupBox2.Controls.Add(this.ld13);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 230);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Le graphe";
            // 
            // panelGraphImage
            // 
            this.panelGraphImage.Location = new System.Drawing.Point(112, 18);
            this.panelGraphImage.Name = "panelGraphImage";
            this.panelGraphImage.Size = new System.Drawing.Size(456, 191);
            this.panelGraphImage.TabIndex = 113;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isGraphInMemory2);
            this.groupBox3.Controls.Add(this.listBoxShowFermeUti);
            this.groupBox3.Controls.Add(this.textBoxFermes);
            this.groupBox3.Controls.Add(this.txtFerme);
            this.groupBox3.Controls.Add(this.buttonRetour);
            this.groupBox3.Controls.Add(this.listBoxShowOuvertUti);
            this.groupBox3.Controls.Add(this.textBoxOuverts);
            this.groupBox3.Controls.Add(this.txtOuvert);
            this.groupBox3.Controls.Add(this.btn_Valider);
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 219);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remplir";
            // 
            // isGraphInMemory2
            // 
            this.isGraphInMemory2.AutoSize = true;
            this.isGraphInMemory2.ForeColor = System.Drawing.Color.Red;
            this.isGraphInMemory2.Location = new System.Drawing.Point(111, 195);
            this.isGraphInMemory2.Name = "isGraphInMemory2";
            this.isGraphInMemory2.Size = new System.Drawing.Size(134, 13);
            this.isGraphInMemory2.TabIndex = 108;
            this.isGraphInMemory2.Text = "Veuillez générer les graphe";
            this.isGraphInMemory2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Fermés :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Ouverts : ";
            // 
            // groupBoxCor1Part
            // 
            this.groupBoxCor1Part.Controls.Add(this.isGraphInMemory);
            this.groupBoxCor1Part.Controls.Add(this.label3);
            this.groupBoxCor1Part.Controls.Add(this.label4);
            this.groupBoxCor1Part.Controls.Add(this.listBoxShowFermeIA);
            this.groupBoxCor1Part.Controls.Add(this.listBoxShowOuvertIA);
            this.groupBoxCor1Part.Controls.Add(this.labelShowCorrectOrNot);
            this.groupBoxCor1Part.Controls.Add(this.buttonShowTree);
            this.groupBoxCor1Part.Location = new System.Drawing.Point(346, 378);
            this.groupBoxCor1Part.Name = "groupBoxCor1Part";
            this.groupBoxCor1Part.Size = new System.Drawing.Size(240, 219);
            this.groupBoxCor1Part.TabIndex = 110;
            this.groupBoxCor1Part.TabStop = false;
            this.groupBoxCor1Part.Text = "Correction première partie";
            // 
            // isGraphInMemory
            // 
            this.isGraphInMemory.AutoSize = true;
            this.isGraphInMemory.ForeColor = System.Drawing.Color.Red;
            this.isGraphInMemory.Location = new System.Drawing.Point(53, 198);
            this.isGraphInMemory.Name = "isGraphInMemory";
            this.isGraphInMemory.Size = new System.Drawing.Size(134, 13);
            this.isGraphInMemory.TabIndex = 107;
            this.isGraphInMemory.Text = "Veuillez générer les graphe";
            this.isGraphInMemory.Visible = false;
            // 
            // groupBoxCor2Part
            // 
            this.groupBoxCor2Part.Controls.Add(this.label6);
            this.groupBoxCor2Part.Controls.Add(this.label5);
            this.groupBoxCor2Part.Controls.Add(this.treeViewCorrection);
            this.groupBoxCor2Part.Controls.Add(this.listBox1);
            this.groupBoxCor2Part.Location = new System.Drawing.Point(592, 12);
            this.groupBoxCor2Part.Name = "groupBoxCor2Part";
            this.groupBoxCor2Part.Size = new System.Drawing.Size(259, 360);
            this.groupBoxCor2Part.TabIndex = 111;
            this.groupBoxCor2Part.TabStop = false;
            this.groupBoxCor2Part.Text = "Correction deuxième partie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "L\'arbre de resolution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Le bon chemin";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(684, 473);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(88, 48);
            this.buttonQuitter.TabIndex = 112;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 609);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBoxCor2Part);
            this.Controls.Add(this.groupBoxCor1Part);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDijkstra";
            this.Text = "Mise en application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxCor1Part.ResumeLayout(false);
            this.groupBoxCor1Part.PerformLayout();
            this.groupBoxCor2Part.ResumeLayout(false);
            this.groupBoxCor2Part.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxInitialNode;
        public System.Windows.Forms.TextBox textBoxFinalNode;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TreeView treeViewCorrection;
        public System.Windows.Forms.Button btnInitMemoire;
        public System.Windows.Forms.ListBox listBoxGraphe;
        public System.Windows.Forms.ListBox listBoxShowFermeUti;
        public System.Windows.Forms.TextBox textBoxOuverts;
        public System.Windows.Forms.TextBox textBoxFermes;
        public System.Windows.Forms.Label txtInstruction;
        public System.Windows.Forms.Label txtOuvert;
        public System.Windows.Forms.Label txtFerme;
        public System.Windows.Forms.Button btn_Valider;
        public System.Windows.Forms.ListBox listBoxShowOuvertUti;
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
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCor1Part;
        private System.Windows.Forms.GroupBox groupBoxCor2Part;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonQuitter;
        public System.Windows.Forms.Label isGraphInMemory;
        public System.Windows.Forms.Label isGraphInMemory2;
        private System.Windows.Forms.Panel panelGraphImage;
    }
}

