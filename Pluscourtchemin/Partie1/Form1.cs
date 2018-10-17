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
        private List<Question> questions;

        public Questionnaire()
        {
            ////CreatXMLStructure();
            InitializeComponent();
            questions = new List<Question>();
            InitializeQuestion();
        }

        private void CreatXMLStructure()
        {
            var reponses = new List<Reponse>();
            var reponse1 = new Reponse(1, 1, "la mer noir 1");
            var reponse2 = new Reponse(2, 1, "la mer noir 2");
            var reponse3 = new Reponse(3, 1, "la mer noir 3");
            var reponse4 = new Reponse(4, 1, "la mer noir 4");
            reponses.Add(reponse1);
            reponses.Add(reponse2);
            reponses.Add(reponse3);
            reponses.Add(reponse4);
            var maQuestion = new Question(1, 2, "quelle est la mer?", reponses);
            maQuestion.Reponses = reponses;
            XmlSerializer serializerQ = new XmlSerializer(typeof(Question));
            TextWriter writer = new StreamWriter("QuestionsReponses.xml");
            serializerQ.Serialize(writer, maQuestion);
            writer.Close();
        }

        private void InitializeQuestion()
        {
            this.RecupToutesQuestions();
            this.QuestionCourrante = new Question(1, 2, "?", new List<Reponse>());
            this.groupBoxQuestion.Text = $"Question n°{QuestionCourrante.IdQuestion}";
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
