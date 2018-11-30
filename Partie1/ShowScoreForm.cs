using System;
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
    public partial class ShowScoreForm : UserControl
    {
        private double score;
        private int scoreMax;

        public ShowScoreForm()
        {
            InitializeComponent();
        }

        public ShowScoreForm(int score, int scoreMax)
        {
            InitializeComponent();
            this.score = score;
            this.scoreMax = scoreMax;

            //remttre sur 20
            if (this.scoreMax != 20)
            {
               double x = 20.00 / this.scoreMax;
               this.score = this.score * x;
            }

            //Afficher score
            this.labelScore.Text = ""+ Math.Round(this.score,2);
            this.labelSur20.Text = " / 20";
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
