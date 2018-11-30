using System;
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
    public partial class Gestionnaire : Form
    {
        public Gestionnaire()
        {
            InitializeComponent();
            Accueil userControlAccueil = new Accueil();
            Controls.Add(userControlAccueil);
        }

        public void ChangeControl(UserControl userControl)
        {
            if (this.Controls.Count != 0)
            {
                this.Controls.Clear();
            }
            this.Controls.Add(userControl);
        }
    }
}
