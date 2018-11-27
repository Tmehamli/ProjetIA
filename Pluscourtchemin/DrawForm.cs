﻿using System;
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
            this.CreatNewTextBox(new Point(150, 50));
            this.Controls.Add(listTextBox[0]);

            DrawGraph(lastFerme[0], new Point(150, 50), new Point(150, 50));
            var controls = this.Controls.Count;
            ////foreach (var textbox in listTextBox)
            ////{
            ////    this.Controls.Add(textbox);
            ////}
        }

        private void DrawGraph(GenericNode node, Point parentLocation, Point initLocation)
        {
            List<GenericNode> listChild = node.GetEnfants();
            Point myStartPoint = new Point();
            Point myEndPoint = new Point();
            for (int i = 0; i < listChild.Count; i++)
            {
                GenericNode child = listChild[i];
                var isIn = lastFerme.Where(f => ((Node2)f).numero == ((Node2)child).numero).ToList().Count != 0 ? true : false;
                if ((isIn) && (this.listTextBox.Count < this.lastFerme.Count))
                {
                    myStartPoint = parentLocation;
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
                    myEndPoint = new Point(x, y);
                    g.DrawLine(pen, myStartPoint, myEndPoint);
                    DrawGraph(child, myEndPoint, initLocation);
                    ////this.CreatNewTextBox(myEndPoint);
                }
            }
        }

        private void CreatNewTextBox(Point point)
        {
            // 
            // textBoxX
            // 
            var textBoxX = new TextBox();
            textBoxX.Location = new System.Drawing.Point(point.X - 10, point.Y);
            textBoxX.Name = "textBox" + (listTextBox.Count);
            textBoxX.Size = new System.Drawing.Size(20, 20);
            textBoxX.TabIndex = listTextBox.Count;
            listTextBox.Add(textBoxX);
        }

    }
}