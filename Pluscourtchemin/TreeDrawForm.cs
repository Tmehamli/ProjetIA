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
        private List<Point> nodesLocation;

        public int nbCall { get; private set; }

        public TreeDrawForm(List<GenericNode> lastFerme)
        {
            InitializeComponent();
            this.lastFerme = lastFerme;
            this.nodesLocation = new List<Point>();
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
                var initPoint = new Point(250, 50);
                nodesLocation.Add(initPoint);
                DrawGraph(lastFerme[0], initPoint, initPoint);
                foreach (var point in nodesLocation)
                {
                    this.CreatNewTextBox(point);
                }
            }
        }

        private void DrawGraph(GenericNode node, Point parentLocation, Point initLocation)
        {
            List<GenericNode> lChilds = node.GetEnfants();
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
                        x = initLocation.X;
                    }
                    else
                    {
                        x = (initLocation.X) - (initLocation.X / lChilds.Count) + (initLocation.X / lChilds.Count) * i;
                    }
                    y = parentLocation.Y + 50;
                    Point myEndPoint = new Point(x, y);
                    g.DrawLine(pen, myStartPoint, myEndPoint);

                    DrawGraph(child, myEndPoint, initLocation);
                    nodesLocation.Add(myEndPoint);
                }
            }
        }

        private void CreatNewTextBox(Point point)
        {
            // 
            // textBoxX
            // 
            var textBoxX = new TextBox();
            textBoxX.Location = new System.Drawing.Point(point.X - 17, point.Y-2);
            textBoxX.Name = "textBox" + point.X;
            textBoxX.Size = new System.Drawing.Size(35, 20);
            textBoxX.TabIndex = this.Controls.Count;
            textBoxX.MaxLength = 5;
            this.Controls.Add(textBoxX);
        }
    }
}
