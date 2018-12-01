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
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        public string InitNode { get; private set; }
        public string FinalNode { get; private set; }
        public bool IsRandomGraph { get; private set; }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            this.InitNode = textBoxInitialNode.Text;
            this.FinalNode = textBoxFinalNode.Text;
            this.IsRandomGraph = radioButtonRandom.Checked;
            this.Close();
        }
    }
}
