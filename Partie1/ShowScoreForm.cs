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
        private int score;

        public ShowScoreForm()
        {
            InitializeComponent();
        }

        public ShowScoreForm(int score)
        {
            InitializeComponent();
            this.score = score;
            this.labelScore.Text = ""+ this.score;
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
