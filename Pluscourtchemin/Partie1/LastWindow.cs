﻿using System;
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
    public partial class LastWindow : Form
    {
        private int score;

        public LastWindow()
        {
            InitializeComponent();
        }

        public LastWindow(int score)
        {
            InitializeComponent();
            this.score = score;
            this.labelScore.Text = ""+ this.score;
        }

        private void ButtonFinir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
