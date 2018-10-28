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
        private Question currentQuesion;
        private List<Question> questions;
        private List<System.Windows.Forms.RadioButton> answer;
        private List<int> notAlreadyAskedQuestions;
        private List<Question> mesQuestions;

        public Questionnaire()
        {

            CreatXMLStructure();
            InitializeComponent();
            questions = new List<Question>();
            this.notAlreadyAskedQuestions = new List<int>();
            this.DownloadQuestions();
            this.notAlreadyAskedQuestions = questions.Select(q => q.IdQuestion).ToList();
            InitializeQuestion();

            UpdateDisplay();
        }
        /// <summary>
        /// Affiche les radios button en fonction des reponses disponibles
        /// </summary>
        private void UpdateDisplay()
        {
            answer = new List<RadioButton>();
            for (int i = 0; i < this.currentQuesion.Reponses.Count; i++)
            {
                // 
                // radioButtonReponseX
                // 
                var radioButtonReponseX = new RadioButton();
                radioButtonReponseX.AutoSize = true;
                radioButtonReponseX.Location = new System.Drawing.Point(32, 95 + (i * 21));
                radioButtonReponseX.Name = "radioButtonReponse_" + i;
                radioButtonReponseX.Size = new System.Drawing.Size(129, 17);
                radioButtonReponseX.TabIndex = this.label1.TabIndex + 1 + i;
                radioButtonReponseX.TabStop = true;
                radioButtonReponseX.Text = this.currentQuesion.Reponses[i].Contenu;
                radioButtonReponseX.UseVisualStyleBackColor = true;
                this.Controls.Add(radioButtonReponseX);
                this.answer.Add(radioButtonReponseX);
            }
        }

        /// <summary>
        /// Permet la création d'un fichier xml de réference. 
        /// </summary>
        private void CreatXMLStructure()
        {
            // Création des questions
            var reponses = new List<Reponse>();
            var reponse1 = new Reponse(0, 0, "la mer noir 1");
            reponses.Add(reponse1);
            var reponse2 = new Reponse(1, 0, "la mer noir 2");
            reponses.Add(reponse2);
            var reponse3 = new Reponse(2, 0, "la mer noir 3");
            reponses.Add(reponse3);
            var reponse4 = new Reponse(3, 0, "la mer noir 4");
            reponses.Add(reponse4);

            // Création de la question associée et ajout des questions.
            var maQuestion = new Question(0, 2, "quelle est la mer?", reponses);

            // Création des questions
            var reponses_2 = new List<Reponse>();
            var reponse1_2 = new Reponse(0, 0, "la mer noir 1");
            reponses_2.Add(reponse1_2);
            var reponse2_2 = new Reponse(1, 0, "la mer noir 2");
            reponses_2.Add(reponse2_2);
            var reponse3_2 = new Reponse(2, 0, "la mer noir 3");
            reponses_2.Add(reponse3_2);

            // Création de la question associée et ajout des questions.
            var maQuestion_2 = new Question(1, 2, "quelle est la mer azer?", reponses_2);
            mesQuestions = new List<Question>();
            mesQuestions.Add(maQuestion);
            mesQuestions.Add(maQuestion_2);
            // Opération de serialization
            XmlSerializer serializerQ = new XmlSerializer(typeof(List<Question>));
            TextWriter writer = new StreamWriter("QuestionsReponses.xml");
            serializerQ.Serialize(writer, mesQuestions);
            writer.Close();
        }
        /// <summary>
        /// Determine la question à charger et afficher
        /// </summary>
        private void InitializeQuestion()
        {
            ////this.QuestionCourrante = new Question(1, 2, "?", new List<Reponse>());
            ///
            var r = new Random();
            var randomIndex = r.Next(notAlreadyAskedQuestions.Count);
            var indexOfQuestion = notAlreadyAskedQuestions.Where(q => q.Equals(randomIndex )).ToList().First();
            this.currentQuesion = questions[indexOfQuestion];
            notAlreadyAskedQuestions.Remove(indexOfQuestion);
            this.groupBoxQuestion.Text = $"Question n°{currentQuesion.IdQuestion}";
            this.labelQuestion.Text = currentQuesion.Contenu;
            this.notAlreadyAskedQuestions.Add(this.currentQuesion.IdQuestion);
        }
        /// <summary>
        /// Charge les questions depuis le document xml
        /// </summary>
        public void DownloadQuestions()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Question>));
            using (StreamReader rd = new StreamReader("QuestionsReponses.xml"))
            {
                List<Question> q = xs.Deserialize(rd) as List<Question>;
                questions = q;
            }
        }

    }
}
