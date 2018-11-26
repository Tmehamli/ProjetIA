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
    public partial class DrawForm : Form
    {
        private Graphics g;
        private Pen pen;
        private List<TextBox> listTextBox;
        private List<GenericNode> lastFerme;


        public DrawForm(List<GenericNode> lastFerme)
        {
            InitializeComponent();
            this.lastFerme = lastFerme;
            this.listTextBox = new List<TextBox>();
        }

        private void DrawForm_Paint(object sender, PaintEventArgs pe)
        {

            // Declares the Graphics object and sets it to the Graphics object  
            // supplied in the PaintEventArgs.  
            g = pe.Graphics;
            // Insert code to paint the form here.  
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            ;
            this.Controls.Add(this.CreatNewTextBox(new Point(150, 50)));

            DrawGraph(lastFerme[0], new Point(150, 50), new Point(150, 50));
            var controls = this.Controls.Count;
            ////for (int i = 1; i < listTextBox.Count; i++)
            ////{
            ////    this.Controls.Add(listTextBox[i]);
            ////}
            ////foreach(var textbox in listTextBox)
            ////{
            ////    this.Controls.Add(textbox);
            ////}
        }

        private void DrawGraph(GenericNode node, Point parentLocation, Point initLocation)
        {
            List<GenericNode> listChild = node.GetEnfants();
            for (int i = 0; i < listChild.Count; i++)
            {
                GenericNode child = listChild[i];
                var isIn = lastFerme.Where(f => ((Node2)f).numero == ((Node2)child).numero).ToList().Count != 0 ? true : false;
                if ((isIn) && (this.listTextBox.Count < this.lastFerme.Count))
                {
                    Point myStartPoint = parentLocation;
                    int x; int y;
                    if (listChild.Count == 1)
                    {
                        x = initLocation.X;
                    }
                    else
                    {
                        x = (initLocation.X) - (initLocation.X / listChild.Count) + (initLocation.X / listChild.Count) * i;
                    }
                    y = parentLocation.Y + 50;
                    Point myEndPoint = new Point(x, y);
                    ////if (this.listTextBox.Count < this.lastFerme.Count + 1)
                    ////{
                    ////}
                    g.DrawLine(pen, myStartPoint, myEndPoint);
                    this.Controls.Add(this.CreatNewTextBox(myEndPoint));
                    DrawGraph(child, myEndPoint, initLocation);
                }
            }
        }

        private TextBox CreatNewTextBox(Point point)
        {
            // 
            // textBoxX
            // 
            var textBoxX = new TextBox();
            textBoxX.Location = new System.Drawing.Point(point.X - 10, point.Y);
            textBoxX.Name = "textBox" + (listTextBox.Count + 1);
            textBoxX.Size = new System.Drawing.Size(20, 20);
            textBoxX.TabIndex = listTextBox.Count + 1;
            return textBoxX;
            ////this.listTextBox.Add(textBoxX);
            ////this.Controls.Add(textBoxX);
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
