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
    public partial class Form1 : Form
    {
        public Random alea = new Random();
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        static public List<List<GenericNode>> historiqueUtiOuvert;
        static public List<List<GenericNode>> historiqueUtiFerme;

        //ajout d'un commentair einutile pour tester git
        // test micro
        public Form1()
        {
            InitializeComponent();
            historiqueUtiOuvert = new List<List<GenericNode>>();
            historiqueUtiFerme = new List<List<GenericNode>>();
            this.labelShowCorrectOrNot.Visible = false;
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInit1_Click(object sender, EventArgs e)
        {

            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = alea.Next(1, 11); matrice[1, 0] = matrice[0, 1];
            matrice[0, 2] = alea.Next(1, 11); matrice[2, 0] = matrice[0, 2];
            matrice[0, 3] = alea.Next(1, 11); matrice[3, 0] = matrice[0, 3];
            matrice[1, 4] = alea.Next(1, 11); matrice[4, 1] = matrice[1, 4];
            matrice[2, 4] = alea.Next(1, 11); matrice[4, 2] = matrice[2, 4];
            matrice[4, 5] = alea.Next(1, 11); matrice[5, 4] = matrice[4, 5];
            matrice[5, 6] = alea.Next(1, 11); matrice[6, 5] = matrice[5, 6];

            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                {
                    if ((matrice[i, j] != -1) && (i <= j))
                    {
                        listBoxgraphe.Items.Add(i + "--->" + j + "   : " + Convert.ToString(matrice[i, j]));
                    }
                }
        }

        private void buttonAEtoile_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
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

            g.GetSearchTree(treeView1);

        }

        private bool Algorithme_AEtoile(SearchTree g)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            
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

            g.GetSearchTree(treeView1);

            bool reussite = false;
            reussite = (Correction(historiqueUtiFerme, g.historiqueIAFermes)&&(Correction(historiqueUtiOuvert, g.historiqueIAOuverts)));
            return reussite;
        }

        private void buttonInit2_Click(object sender, EventArgs e)
        {
            //Initialiser les historiques pour ce graphe
            historiqueUtiFerme = new List<List<GenericNode>>();
            historiqueUtiOuvert = new List<List<GenericNode>>();

            StreamReader monStreamReader = new StreamReader("graphe1.txt");

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
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();



        }

        public void btn_Valider_Click(object sender, EventArgs e)
        {

            string ouvert = champOuverts.Text;
            string ferme = champFermes.Text;
            if ((ouvert == "") && (ferme != ""))
            {
                SearchTree g = new SearchTree();
                bool reussite = Algorithme_AEtoile(g);
                if (reussite == true )
                {
                    this.labelShowCorrectOrNot.Text = "Bonne réponse";
                    this.labelShowCorrectOrNot.ForeColor = Color.Green;
                }
                else
                {
                    this.labelShowCorrectOrNot.Text = "Mauvaise réponse";
                    this.labelShowCorrectOrNot.ForeColor = Color.Red;
                }
                this.labelShowCorrectOrNot.Visible = true;

                AffichageHistoIA(g);
            }
            else
            {
                List<GenericNode> listeOuvert = new List<GenericNode>();
                List<GenericNode> listeFerme = new List<GenericNode>();

                string nouveauOuvert = "";
                string nouveauFerme = "";

                //récupérer champOuvert et champFermes


                foreach (char c in ouvert)
                {
                    if (c != ',')
                    {
                        try
                        {
                            int x = (int)Char.GetNumericValue(c);
                            Node2 N = new Node2();
                            N.numero = x;
                            listeOuvert.Add(N);
                            nouveauOuvert += Convert.ToString(N.numero)+", ";
                        }
                        catch { }
                    }
                }

                foreach (char c in ferme)
                {
                    if (c != ',')
                    {
                        try
                        {
                            int x = (int)Char.GetNumericValue(c);
                            Node2 N = new Node2();
                            N.numero = x;
                            listeFerme.Add(N);
                            nouveauFerme += Convert.ToString(N.numero) + ", ";
                        }
                        catch { }
                    }
                }

                // affichage listBox :

                listBoxShowOuvertUti.Items.Add(nouveauOuvert);
                listBoxShowFermeUti.Items.Add(nouveauFerme);
                
                //le mettre dans une liste statique.

                historiqueUtiFerme.Add(listeFerme);
                historiqueUtiOuvert.Add(listeOuvert);

               

            }
        }

        public bool Correction(List<List<GenericNode>> listeUt, List<List<GenericNode>> listeIA)
        {
            int nbEtape = listeIA.Count();
            if (listeUt.Count() != nbEtape) { return false; }
            else
            {

                for (int i = 0; i < nbEtape; i++) //parcourir chaque étape
                {
                    int nbNoeud = listeIA[i].Count();
                    if (listeUt[i].Count() != nbNoeud) { return false; }
                    else
                    {
                        //trier les listes pour ne pas avoir de problème d'odre
                        listeUt[i].Sort(Compare);
                        listeIA[i].Sort(Compare);

                        for (int j = 0; j < nbNoeud; j++) // pour chaque noeud
                        {
                            if (((Node2)listeUt[i][j]).numero != ((Node2)listeIA[i][j]).numero) { return false; }
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

      
    }
}
