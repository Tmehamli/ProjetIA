using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluscourtchemin
{
    public partial class TreeDrawForm : Form
    {
        private Graphics g;
        private Pen pen;
        private List<GenericNode> lastFerme;
        private Dictionary<int, Point> nodesLocation;
        private Dictionary<int, bool> nodeIsCorrect;

        private bool reussite;

        private int nbCall;
        private int pos;

        public TreeDrawForm(List<GenericNode> lastFerme)
        {
            InitializeComponent();
            this.lastFerme = lastFerme;
            this.nodesLocation = new Dictionary<int, Point>();
            this.nodeIsCorrect = new Dictionary<int, bool>();
            this.nbCall = new int();
            this.pos = new int();
        }

        private void DrawForm_Load(object sender, System.EventArgs e)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawForm_Paint);
        }

        private void DrawForm_Paint(object sender, PaintEventArgs pe)
        {
            if (this.nbCall < 1)
            {
                this.nbCall++;
                // Declares the Graphics object and sets it to the Graphics object  
                // supplied in the PaintEventArgs.  
                g = pe.Graphics;

                pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                pen.Width = 3;
                var initPoint = new Point(200, 125);
                DrawGraph(lastFerme[0], initPoint, initPoint);
                foreach (KeyValuePair<int, Point> kvp in nodesLocation)
                {
                    this.CreatNewTextBox(kvp);
                }
            }
        }

        private void DrawGraph(GenericNode node, Point parentLocation, Point initLocation)
        {
            List<GenericNode> lChilds = node.GetEnfants();
            nodesLocation.Add(((Node2)node).numero, parentLocation);
            Point myStartPoint = new Point();
            for (int i = 0; i < lChilds.Count; i++)
            {
                GenericNode child = lChilds[i];
                var isIn = lastFerme.Where(f => ((Node2)f).numero == ((Node2)child).numero).ToList().Count != 0 ? true : false;
                if ((isIn) && (this.nodesLocation.Count < this.lastFerme.Count))
                {
                    myStartPoint = parentLocation;
                    int x; int y;
                    if (lChilds.Count == 1)
                    {
                        x = myStartPoint.X;
                    }
                    else
                    {
                        x = (myStartPoint.X) - (myStartPoint.X / lChilds.Count) + (myStartPoint.X / lChilds.Count) * i;
                    }
                    y = parentLocation.Y + 50;
                    Point myEndPoint = new Point(x, y);
                    g.DrawLine(pen, myStartPoint, myEndPoint);
                    DrawGraph(child, myEndPoint, initLocation);

                }
            }
        }

        private void CreatNewTextBox(KeyValuePair<int, Point> kvp)
        {
            // 
            // textBoxX
            // 
            var textBoxX = new TextBox();
            textBoxX.Location = new System.Drawing.Point(kvp.Value.X - 17, kvp.Value.Y - 2);
            textBoxX.Name = kvp.Key.ToString();
            textBoxX.Size = new System.Drawing.Size(35, 20);
            textBoxX.MaxLength = 5;
            this.Controls.Add(textBoxX);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (buttonValider.Text == "Valider")
            {
                var nbVide = 0;
                for (int i = 3; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i].Text == "")
                    {
                        nbVide++;
                    }
                }
                if (nbVide == 0)
                {
                    ////repondu = true;
                    this.TreeCorrection(lastFerme[0]);
                    bool isCorrectTreeQuestion = true;
                    int nbInputCorrect = 0;
                    foreach (KeyValuePair<int, bool> kvp in nodeIsCorrect)
                    {
                        nbInputCorrect = nodeIsCorrect[kvp.Key] == true ? nbInputCorrect + 1 : nbInputCorrect;
                    }
                    isCorrectTreeQuestion = nbInputCorrect == nodeIsCorrect.Count ? true : false;
                    if (isCorrectTreeQuestion == true)
                    {
                        reussite = true;
                        labelCorrectOrNoTree.Text = "Bravo ";
                        labelCorrectOrNoTree.ForeColor = Color.Green;
                        labelCorrectOrNoTree.Visible = true;
                    }
                    else
                    {
                        reussite = false;
                        labelCorrectOrNoTree.Text = "Mauvaise réponse ";
                        labelCorrectOrNoTree.ForeColor = Color.Red;
                        labelCorrectOrNoTree.Visible = true;
                    }
                    buttonValider.Text = "Quitter";
                }

            }
            else
            {
                this.Close();
            }

        }
        public bool GetReussite()
        {
            return reussite;
        }
        private void TreeCorrection(GenericNode node)
        {

            var text = this.Controls[3 + pos].Text.Split(':');
            var noeudText = text[0];
            string valText = text[1];
            if (noeudText == ((Node2)node).numero.ToString() && valText == node.GetGCost().ToString())
            {
                nodeIsCorrect.Add(((Node2)node).numero, true);
            }
            else
            {
                nodeIsCorrect.Add(((Node2)node).numero, false);
            }
            List<GenericNode> lChilds = node.GetEnfants();
            for (int i = 0; i < lChilds.Count; i++)
            {
                GenericNode child = lChilds[i];
                var isIn = lastFerme.Where(f => ((Node2)f).numero == ((Node2)child).numero).ToList().Count != 0 ? true : false;
                if (isIn)
                {
                    pos++;
                    TreeCorrection(child);
                }
            }
        }
    }
}
