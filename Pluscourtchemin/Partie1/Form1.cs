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
    public partial class Questionnaire : Form
    {
        public Question QuestionCourrante { get; private set; }
        public Questionnaire()
        {
            InitializeComponent();
            InitializeQuestion();
        }


        private void InitializeQuestion()
        {
            QuestionCourrante = new Question(1, "?", new List<Reponse>(), 'a');
            this.groupBoxQuestion.Text = $"Question n°{QuestionCourrante.Id}";
            this.labelQuestion.Text = QuestionCourrante.Contenu;
        }
    }
}
