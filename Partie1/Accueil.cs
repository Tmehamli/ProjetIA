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
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            Questionnaire userControlQuestionnaire = new Questionnaire();
            ((Gestionnaire)this.Parent).ChangeControl(userControlQuestionnaire);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
