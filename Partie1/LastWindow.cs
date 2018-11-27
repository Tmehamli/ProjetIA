﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1
{
    public partial class LastWindow : UserControl
    {
        private int score;
        private int scoreMax;

        public LastWindow()
        {
            InitializeComponent();
        }

        public LastWindow(int score, int scoreMax)
        {
            InitializeComponent();
            this.score = score;
            this.scoreMax = scoreMax;
            this.labelScore.Text = ""+ this.score;
            this.labelSur20.Text = " / " + this.scoreMax;
        }

        private void ButtonFinir_Click(object sender, EventArgs e)
        {
            Accueil ucAccueil = new Accueil();
            ((Gestionnaire)this.Parent).ChangeControl(ucAccueil);
        }

        private void LastWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
