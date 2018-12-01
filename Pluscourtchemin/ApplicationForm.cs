using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pluscourtchemin
{
    public partial class FormDijkstra : Form
    {
        public Random alea = new Random();
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        static public List<List<GenericNode>> historiqueUtiOuvert;
        static public List<List<GenericNode>> historiqueUtiFerme;

        private bool reussite1;
        private bool reussite2;
        private ConfigForm graphConfig;

        public FormDijkstra()
        {
            InitializeComponent();
            historiqueUtiOuvert = new List<List<GenericNode>>();
            historiqueUtiFerme = new List<List<GenericNode>>();
            this.labelShowCorrectOrNot.Visible = false;
            reussite2 = false;
            reussite1 = false;

            groupBoxCor1Part.Visible = false;
            groupBoxCor2Part.Visible = false;
            panelGraphImage.Visible = true;

        }

        // affiche les labels liés a l'image du graphe de dijsktra 
        private void AfficherLabelDijsktra()
        {
            // selectionne tout les labels de dijkstra 
            var labels = this.Controls.OfType<Label>()
                          .Where(c => c.Name.StartsWith("ld"))
                          .ToList();
            // on affiche tout les labels de dijkstra 
            foreach (var label in labels)
            {
                label.Visible = true;
            }
        }

        private void DemarrerAleaDij()
        {
            // Reinitialisation des affichages
            this.ClearFormDisplays();

            AfficherLabelDijsktra();

            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
            {
                for (int j = 0; j < nbnodes; j++)
                {
                    matrice[i, j] = -1;
                }
            }

            int graphNumero = alea.Next(1, 4);
            // On choisit aléatoirement un graphe parmis trois différents  
            if (graphNumero == 1)
            {
                matrice[0, 1] = alea.Next(1, 11); matrice[1, 0] = matrice[0, 1];
                matrice[0, 2] = alea.Next(1, 11); matrice[2, 0] = matrice[0, 2];
                matrice[0, 3] = alea.Next(1, 11); matrice[3, 0] = matrice[0, 3];
                matrice[1, 4] = alea.Next(1, 11); matrice[4, 1] = matrice[1, 4];
                matrice[2, 4] = alea.Next(1, 11); matrice[4, 2] = matrice[2, 4];
                matrice[2, 5] = alea.Next(1, 11); matrice[5, 2] = matrice[2, 5];
                matrice[4, 5] = alea.Next(1, 11); matrice[5, 4] = matrice[4, 5];
                matrice[5, 6] = alea.Next(1, 11); matrice[6, 5] = matrice[5, 6];

                // initialisation des labels 
                ld11.Text = matrice[0, 1].ToString();
                ld12.Text = matrice[0, 2].ToString();
                ld13.Text = matrice[0, 3].ToString();
                ld15.Text = matrice[1, 4].ToString();
                ld18.Text = matrice[2, 4].ToString();
                ld17.Text = matrice[2, 5].ToString();
                ld20.Text = matrice[4, 5].ToString();
                ld22.Text = matrice[5, 6].ToString();
                ld14.Text = ld16.Text = ld19.Text = ld21.Text = "";

                // chargement de l'image 
                pictureBox1.Image = Image.FromFile(@"..\..\..\Partie1\Resources\graphe1.jpg");
            }

            if (graphNumero == 2)
            {
                matrice[0, 1] = alea.Next(1, 11); matrice[1, 0] = matrice[0, 1];
                matrice[0, 2] = alea.Next(1, 11); matrice[2, 0] = matrice[0, 2];
                matrice[1, 3] = alea.Next(1, 11); matrice[3, 1] = matrice[1, 3];
                matrice[2, 3] = alea.Next(1, 11); matrice[3, 2] = matrice[2, 3];
                matrice[3, 4] = alea.Next(1, 11); matrice[4, 3] = matrice[3, 4];
                matrice[3, 5] = alea.Next(1, 11); matrice[5, 3] = matrice[3, 5];
                matrice[4, 6] = alea.Next(1, 11); matrice[6, 4] = matrice[4, 6];
                matrice[5, 6] = alea.Next(1, 11); matrice[6, 5] = matrice[5, 6];

                // initialisation des labels 
                ld11.Text = matrice[0, 1].ToString();
                ld12.Text = matrice[0, 2].ToString();
                ld14.Text = matrice[1, 3].ToString();
                ld16.Text = matrice[2, 3].ToString();
                ld18.Text = matrice[3, 4].ToString();
                ld19.Text = matrice[3, 5].ToString();
                ld21.Text = matrice[4, 6].ToString();
                ld22.Text = matrice[5, 6].ToString();
                ld13.Text = ld15.Text = ld17.Text = ld20.Text = "";

                // chargement de l'image 
                pictureBox1.Image = Image.FromFile(@"..\..\..\Partie1\Resources\graphe2.jpg");
            }

            if (graphNumero == 3)
            {
                matrice[0, 1] = alea.Next(1, 11); matrice[1, 0] = matrice[0, 1];
                matrice[0, 2] = alea.Next(1, 11); matrice[2, 0] = matrice[0, 2];
                matrice[1, 4] = alea.Next(1, 11); matrice[4, 1] = matrice[1, 4];
                matrice[2, 5] = alea.Next(1, 11); matrice[5, 2] = matrice[2, 5];
                matrice[3, 5] = alea.Next(1, 11); matrice[5, 3] = matrice[3, 5];
                matrice[4, 6] = alea.Next(1, 11); matrice[6, 4] = matrice[4, 6];

                // initialisation des labels 
                ld11.Text = matrice[0, 1].ToString();
                ld12.Text = matrice[0, 2].ToString();
                ld15.Text = matrice[1, 4].ToString();
                ld17.Text = matrice[2, 5].ToString();
                ld19.Text = matrice[3, 5].ToString();
                ld21.Text = matrice[4, 6].ToString();
                ld13.Text = ld14.Text = ld16.Text = ld18.Text = ld20.Text = ld22.Text = "";


                // chargement de l'image 
                pictureBox1.Image = Image.FromFile(@"..\..\..\Partie1\Resources\graphe3.jpg");
            }

            for (int i = 0; i < nbnodes; i++)
            {
                for (int j = 0; j < nbnodes; j++)
                {
                    if ((matrice[i, j] != -1) && (i <= j))
                    {
                        listBoxGraphe.Items.Add(i + "--->" + j + "   : " + Convert.ToString(matrice[i, j]));
                    }
                }
            }
        }

        private void buttonGraphGeneration_Click(object sender, EventArgs e)
        {

            // Reinitialisation des affichages
            this.ClearFormDisplays();
            this.graphConfig = new ConfigForm();
            this.graphConfig.ShowDialog();

            numinitial = int.Parse(graphConfig.InitNode);
            numfinal = int.Parse(graphConfig.FinalNode);
            if (graphConfig.IsRandomGraph)
            {
                AfficherLabelDijsktra();
                DemarrerAleaDij();
            }
            else
            {
                DemarrerMemoire();
            }
            this.panelGraphImage.Visible = false;
            /*
            if (true)
            {
                DemarrerMemoire();
            }
            else*/
            ////AfficherLabelDijsktra();
        }

        private void ClearFormDisplays()
        {
            listBoxGraphe.Items.Clear();
            textBoxFermes.Text = string.Empty;
            textBoxOuverts.Text = string.Empty;
            listBoxShowOuvertUti.Items.Clear();
            listBoxShowFermeUti.Items.Clear();
            treeViewCorrection.Nodes.Clear();
            listBoxShowOuvertIA.Items.Clear();
            listBoxShowFermeIA.Items.Clear();
            listBox1.Items.Clear();
            groupBoxCor1Part.Visible = false;
            groupBoxCor2Part.Visible = false;
            isGraphInMemory.Visible = false;
            isGraphInMemory2.Visible = false;
            panelGraphImage.Visible = true;

        }

        private bool Algorithme_AEtoile(SearchTree g)
        {

            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile2(N0);

            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeViewCorrection);

            bool reussite = false;
            reussite = (Correction(historiqueUtiFerme, g.historiqueIAFermes) && (Correction(historiqueUtiOuvert, g.historiqueIAOuverts)));
            return reussite;
        }

        public void DemarrerMemoire()
        {
            this.ClearFormDisplays();
            panelGraphImage.Visible = false;

            //Initialiser les historiques pour ce graphe
            historiqueUtiFerme = new List<List<GenericNode>>();
            historiqueUtiOuvert = new List<List<GenericNode>>();

            StreamReader monStreamReader = new StreamReader(@"..\..\..\Partie1\Resources\graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxGraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();

            // On gère ici l'affichage du graphe mémoire 
            // chargement de l'image 
            pictureBox1.Image = Image.FromFile(@"..\..\..\Partie1\Resources\grapheMem1.jpg");
            ld11.Text = matrice[0, 1].ToString();
            ld12.Text = matrice[0, 2].ToString();
            ld13.Text = matrice[0, 3].ToString();
            ld15.Text = matrice[1, 4].ToString();
            ld18.Text = matrice[2, 4].ToString();
            ld20.Text = matrice[4, 5].ToString();
            ld22.Text = matrice[5, 6].ToString();
            ld14.Text = ld16.Text = ld17.Text = ld19.Text = ld21.Text = "";

        }

        public void btn_Valider_Click(object sender, EventArgs e)
        {
            if (matrice != null)
            {
                if ((textBoxOuverts.Text == "") && (textBoxFermes.Text != ""))
                {
                    this.AjoutOuvertFermetUti(textBoxFermes.Text, false);

                    SearchTree g = new SearchTree();
                    bool reussite = Algorithme_AEtoile(g);
                    if (reussite == true)
                    {
                        this.labelShowCorrectOrNot.Text = "Bonne réponse";
                        this.labelShowCorrectOrNot.ForeColor = Color.Green;
                        reussite1 = true;
                    }
                    else
                    {
                        this.labelShowCorrectOrNot.Text = "Mauvaise réponse";
                        this.labelShowCorrectOrNot.ForeColor = Color.Red;
                        reussite1 = false;
                    }
                    this.labelShowCorrectOrNot.Visible = true;
                    groupBoxCor1Part.Visible = true;
                    AffichageHistoIA(g);

                }
                else if ((textBoxOuverts.Text != "") && (textBoxFermes.Text != ""))
                {
                    this.AjoutOuvertFermetUti(textBoxFermes.Text, false);
                    this.AjoutOuvertFermetUti(textBoxOuverts.Text, true);
                }
            }
            else
            {
                isGraphInMemory2.Visible = true;
            }
        }

        public void AjoutOuvertFermetUti(string input, bool isOuvert)
        {
            // OF = Ouvert ou ferme
            List<GenericNode> listeOF = new List<GenericNode>();
            string nouveauOF = "";

            //récupérer champOF
            foreach (char c in input)
            {
                if (c != ',')
                {
                    int x = (int)Char.GetNumericValue(c);
                    Node2 N = new Node2();
                    N.numero = x;
                    listeOF.Add(N);
                    nouveauOF += Convert.ToString(N.numero) + ", ";
                }
            }
            // le mettre dans une liste statique,
            // affichage listBox ,
            // Vider la textBox de saise utilisateur.

            if (isOuvert)
            {
                if (historiqueUtiOuvert.Count == 0)
                {
                    // On ajoute l'ouvert {0} au début
                    var n = new Node2();
                    n.numero = int.Parse(this.graphConfig.InitNode);
                    n.numero = 0;
                    var listeInit = new List<GenericNode>();
                    listeInit.Add(n);
                    historiqueUtiOuvert.Add(listeInit);
                }
                historiqueUtiOuvert.Add(listeOF);
                listBoxShowOuvertUti.Items.Add(nouveauOF);
                textBoxOuverts.Text = string.Empty;
            }
            else
            {
                historiqueUtiFerme.Add(listeOF);
                listBoxShowFermeUti.Items.Add(nouveauOF);
                textBoxFermes.Text = string.Empty;
            }


        }

        public bool Correction(List<List<GenericNode>> listeUt, List<List<GenericNode>> listeIA)
        {
            int nbEtape = listeIA.Count();
            if (listeUt.Count() != nbEtape)
            {
                return false;
            }
            else
            {

                for (int i = 0; i < nbEtape; i++) //parcourir chaque étape
                {
                    int nbNoeud = listeIA[i].Count();
                    if (listeUt[i].Count() != nbNoeud)
                    {
                        return false;
                    }
                    else
                    {
                        //trier les listes pour ne pas avoir de problème d'odre
                        listeUt[i].Sort(Compare);
                        listeIA[i].Sort(Compare);

                        for (int j = 0; j < nbNoeud; j++) // pour chaque noeud
                        {
                            if (((Node2)listeUt[i][j]).numero != ((Node2)listeIA[i][j]).numero)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
        }

        private void AffichageHistoIA(SearchTree g)
        {
            string nouveauOuvert = "";
            string nouveauFerme = "";

            foreach (List<GenericNode> listeN in g.historiqueIAFermes) // état par état
            {
                nouveauFerme = "";
                foreach (GenericNode n in listeN) // noeud de chaque état
                {
                    nouveauFerme += Convert.ToString(((Node2)n).numero) + ", ";

                }
                listBoxShowFermeIA.Items.Add(nouveauFerme);
            }

            g.historiqueIAOuverts.RemoveAt(0);
            foreach (List<GenericNode> listeN in g.historiqueIAOuverts)
            {
                nouveauOuvert = "";
                foreach (GenericNode n in listeN)
                {
                    nouveauOuvert += Convert.ToString(((Node2)n).numero) + ", ";
                }
                listBoxShowOuvertIA.Items.Add(nouveauOuvert);
            }
        }

        private int Compare(GenericNode n1, GenericNode n2)
        {
            int num1 = ((Node2)n1).numero;
            int num2 = ((Node2)n2).numero;
            if (num1 > num2)
                return 1;
            else if (num1 < num2)
                return -1;
            else return 0;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            if (historiqueUtiOuvert.Count > 0 && historiqueUtiFerme.Count > 0)
            {
                historiqueUtiOuvert.RemoveAt(historiqueUtiOuvert.Count - 1);
                historiqueUtiFerme.RemoveAt(historiqueUtiFerme.Count - 1);
                listBoxShowOuvertUti.Items.RemoveAt(listBoxShowOuvertUti.Items.Count - 1);
                listBoxShowFermeUti.Items.RemoveAt(listBoxShowFermeUti.Items.Count - 1);
            }
        }

        private void buttonShowTree_Click(object sender, EventArgs e)
        {
            if (matrice != null)
            {
                isGraphInMemory.Visible = false;
                isGraphInMemory2.Visible = false;
                var g = new SearchTree();
                Algorithme_AEtoile(g);
                Node2 N0 = new Node2();
                N0.numero = numinitial;
                var l = g.RechercheSolutionAEtoile2(N0);

                Node2 NEnd = (Node2)l.Last();

                var lastFerme = g.L_Fermes;
                lastFerme.Add(NEnd);
                var drawForm = new TreeDrawForm(lastFerme);
                drawForm.ShowDialog();
                reussite2 = drawForm.GetReussite();
                groupBoxCor2Part.Visible = true;
                buttonQuitter.Visible = true;
            }
            else
            {
                isGraphInMemory.Visible = true;
                isGraphInMemory2.Visible = true;
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<bool> GetReussite()
        {
            List<bool> liste = new List<bool> { reussite1, reussite2 };
            return (liste);
        }

    }
}
