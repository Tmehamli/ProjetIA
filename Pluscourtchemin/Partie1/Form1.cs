using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Partie1
{
    public partial class Questionnaire : Form
    {
        //
        public Question QuestionCourrante { get; private set; }
        List<Question> questions;

        public Questionnaire()
        {
            InitializeComponent();
            InitializeQuestion();
            questions = new List<Question>();
        }


        private void InitializeQuestion()
        {
            QuestionCourrante = new Question(1, "?", new List<Reponse>(), 'a');
            this.groupBoxQuestion.Text = $"Question n°{QuestionCourrante.Id}";
            this.labelQuestion.Text = QuestionCourrante.Contenu;
        }

        public void RecupToutesQuestions()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Question));
            using (StreamReader rd = new StreamReader("QuestionsReponses.xml"))
            {
                Question q = xs.Deserialize(rd) as Question;
                questions.Add(q);
            }
        }
        
    }
}
