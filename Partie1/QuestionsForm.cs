﻿using System;
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
using Pluscourtchemin;

namespace Partie1
{
    public partial class Questionnaire : UserControl
    {
        private Question currentQuestion;
        private List<Question> questions;
        private List<RadioButton> answers;
        private List<int> notAlreadyAskedQuestionsIndex;
        private int nbQuestion;
        private int score;
        private int scoreMax;
        private int nbQuestionTotal;

        public bool reussiteDij1;
        public bool reussiteDij2;

        public Questionnaire()
        {

            ////CreatXMLStructure();
            InitializeComponent();
            questions = new List<Question>();
            this.score = 0;
            this.scoreMax = 0;
            reussiteDij1 = false;
            reussiteDij2 = false;
            this.notAlreadyAskedQuestionsIndex = new List<int>();
            this.DownloadQuestions();
            nbQuestionTotal = 20;
            this.notAlreadyAskedQuestionsIndex = questions.Select(q => q.IdQuestion).ToList();

            AskNewQuestion();

            btnControl.Text = "Valider";
        }

        /// <summary>
        /// Affiche les radios bouton en fonction des reponses disponibles
        /// </summary>
        private void UpdateDisplay()
        {
            //Afficher les boutons de réponses
            answers = new List<RadioButton>();
            for (int i = 0; i < this.currentQuestion.Reponses.Count; i++)
            {
                // 
                // radioButtonReponseX
                // 
                var radioButtonReponseX = new RadioButton();
                radioButtonReponseX.AutoSize = true;
                radioButtonReponseX.Location = new System.Drawing.Point(32, 95 + (i * 21));
                radioButtonReponseX.Name = "radioButtonReponse_" + i;
                radioButtonReponseX.Size = new System.Drawing.Size(300, 17);
                radioButtonReponseX.TabIndex = this.labelShowCorrectOrNo.TabIndex + 1 + i;
                radioButtonReponseX.TabStop = true;
                radioButtonReponseX.Text = $"{i + 1}: {this.currentQuestion.Reponses[i].Contenu}";
                radioButtonReponseX.UseVisualStyleBackColor = true;
                this.Controls.Add(radioButtonReponseX);
                this.answers.Add(radioButtonReponseX);
            }

            //Afficher l'image
            image.Visible = false;
            if (currentQuestion.ImageAdresse != "")
            {
                image.Visible = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Image = Image.FromFile(@"..\..\Resources\" + currentQuestion.ImageAdresse + ".jpg");   
            }
        }

        /// <summary>
        /// Permet la création d'un fichier xml de réference. 
        /// </summary>
        private void CreatXMLStructure()
        {
            List<Question> mesQuestions;

            // Création des reponses à la question 1
            var reponses = new List<Reponse>();
            var reponse1 = new Reponse(0, 0, "la reponse 1 à la question 1");
            reponses.Add(reponse1);
            var reponse2 = new Reponse(1, 0, "la reponse 2 à la question 1");
            reponses.Add(reponse2);
            var reponse3 = new Reponse(2, 0, "la reponse 3 à la question 1");
            reponses.Add(reponse3);
            var reponse4 = new Reponse(3, 0, "la reponse 4 à la question 1");
            reponses.Add(reponse4);

            // Création de la question 1 et ajout des reponses.
            var maQuestion = new Question(0, 2, 1, "quelle est la reponse à cette question 1 ?", "", reponses);

            // Création des reponses à la question 2
            var reponses_2 = new List<Reponse>();
            var reponse1_2 = new Reponse(0, 0, "la reponse 1 à la question 2");
            reponses_2.Add(reponse1_2);
            var reponse2_2 = new Reponse(1, 0, "la reponse 2 à la question 2");
            reponses_2.Add(reponse2_2);
            var reponse3_2 = new Reponse(2, 0, "la reponse 3 à la question 2");
            reponses_2.Add(reponse3_2);

            // Création de la question 2 et ajout des questions.
            var maQuestion_2 = new Question(1, 2, 1, "quelle est la reponse à cette question 2 ?", "", reponses_2);
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
        /// Determine la question à charger et à afficher
        /// </summary>
        private void AskNewQuestion()
        {
            var r = new Random();
            var randomIndex = r.Next(notAlreadyAskedQuestionsIndex.Count);
            var indexOfQuestion = notAlreadyAskedQuestionsIndex[randomIndex];
            this.currentQuestion = questions[indexOfQuestion];
            notAlreadyAskedQuestionsIndex.Remove(indexOfQuestion);
            nbQuestion++;
            this.groupBoxQuestion.Text = $"Question n°{nbQuestion}";
            this.labelQuestion.Text = currentQuestion.Contenu;
            this.UpdateDisplay();
        }

        /// <summary>
        /// Charge les questions depuis le document xml
        /// </summary>
        public void DownloadQuestions()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Question>));
            using (StreamReader rd = new StreamReader("../../QuestionsReponses.xml"))
            {
                List<Question> q = xs.Deserialize(rd) as List<Question>;
                questions = q;
            }
        }

        private void ActionValider(object sender, EventArgs e)
        {
            var buttonsChecked = this.answers.Where(a => a.Checked).ToList();
            this.labelSelectAnAnswer.Visible = false;
            this.labelCorrection.Visible = false;

            if (buttonsChecked.Count != 0)
            {
                foreach (var answer in answers)
                {
                    answer.Enabled = false;
                }
                var buttonChecked = buttonsChecked[0];
                bool isCorrect = this.CheckAnswer(buttonChecked);
                this.scoreMax += this.currentQuestion.Valeur;
                if (isCorrect)
                {
                    this.score += this.currentQuestion.Valeur;
                    this.labelShowCorrectOrNo.Text = "Bonne réponse";
                    this.labelShowCorrectOrNo.ForeColor = Color.Green;
                }
                else
                {
                    this.labelShowCorrectOrNo.Text = "Mauvaise réponse";
                    this.labelShowCorrectOrNo.ForeColor = Color.Red;
                    this.labelCorrection.Visible = true;
                    this.labelCorrection.Text = $"Correction : {this.currentQuestion.IdReponse + 1}.";
                }
                this.labelShowCorrectOrNo.Visible = true;
                btnControl.Text = "Suivant";
            }
            else
            {
                this.labelSelectAnAnswer.Visible = true;
            }
        }

        private bool CheckAnswer(RadioButton buttonChecked)
        {
            var idButtonCorrect = "radioButtonReponse_" + currentQuestion.IdReponse;
            if (buttonChecked.Name == idButtonCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ActionSuivant(object sender, EventArgs e)
        {
            if (this.nbQuestion < this.nbQuestionTotal)
            {
                this.labelSelectAnAnswer.Visible = false;
                this.labelShowCorrectOrNo.Visible = false;
                this.labelCorrection.Visible = false;
                for (int i = 0; i < this.currentQuestion.Reponses.Count; i++)
                {
                    // Suppression des reponses dans this.control
                    int index = this.Controls.Count - this.currentQuestion.Reponses.Count + i;
                    this.Controls.RemoveAt(index);
                }
                this.AskNewQuestion();

                btnControl.Text = "Valider";
            }
            else
            {
                // Question Dijsktra
                btnControl.Text = "Question sur Dijsktra !";
            }

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (btnControl.Text == "Valider") // l'utilisateur valide sa réponse
            {
                ActionValider(sender, e);
            }
            else if (btnControl.Text == "Suivant") // l'utilisateur veut la question suivante
            {
                ActionSuivant(sender, e);
            }
            else if (btnControl.Text == "Question sur Dijsktra !") // l'utilisateur va répondre à la dernière question : sur Dijsktra
            {
                // Ouvrir le questionnaire Dijkstra
                Pluscourtchemin.FormDijkstra formDijsktra = new FormDijkstra();
                formDijsktra.ShowDialog();

                // Voir si il a réussi
                List<bool> liste = formDijsktra.GetReussite();
                reussiteDij1 = liste[0];
                reussiteDij2 = liste[1];

                // Incrémenter les scores
                scoreMax += 3;

                if (reussiteDij1 == true)
                {
                    score += 2;
                }
                if (reussiteDij2 == true)
                {
                    score += 1;
                }

                ShowScoreForm userControlScore = new ShowScoreForm(score, scoreMax);
                ((Gestionnaire)this.Parent).ChangeControl(userControlScore);
            }
        }
    }
}

