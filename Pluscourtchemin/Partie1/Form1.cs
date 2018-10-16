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
        List<Question> questions;

        public Questionnaire()
        {
            InitializeQuestion();
            InitializeComponent();
            questions = new List<Question>();
        }

        private void InitializeQuestion()
        {
            throw new NotImplementedException();
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
