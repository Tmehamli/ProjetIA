﻿using System;
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
        public Random alea = new Random(10);
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        public List<List<GenericNode>> historiqueUtiOuvert;
        public List<List<GenericNode>> historiqueUtiFerme;

        //ajout d'un commentair einutile pour tester git
        // test micro
        public Form1()
        {
            InitializeComponent();
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

            matrice[0, 1] = Convert.ToDouble(alea);      matrice[1, 0] = matrice[0, 1];
            matrice[0, 2] = Convert.ToDouble(alea);      matrice[2, 0] = matrice[0, 2];
            matrice[0, 3] = Convert.ToDouble(alea);      matrice[3, 0] = matrice[0, 3];
            matrice[1, 4] = Convert.ToDouble(alea);      matrice[4, 1] = matrice[1, 4];
            matrice[2, 4] = Convert.ToDouble(alea);      matrice[4, 2] = matrice[2, 4];
            matrice[4, 5] = Convert.ToDouble(alea);      matrice[5, 4] = matrice[4, 5];
            matrice[5, 6] = Convert.ToDouble(alea);      matrice[6, 5] = matrice[5, 6];
        }

        private void buttonAEtoile_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

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

        private void Algorithme_AEtoile()
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

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

            //bool reussite = (Correction(historiqueUtiFerme, g.Hist

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

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            string ouvert = txtOuvert.Text;
            string ferme = txtFerme.Text;
            if ((ouvert == "") && (ferme != ""))
            {
                //faire A* et correction (faire une méthode pour correction) (et la lancer depuis a*)
            }
            else
            {
                List<GenericNode> listeOuvert = new List<GenericNode>();
                List<GenericNode> listeFerme = new List<GenericNode>();

                //récupérer champOuvert et champFermes


                foreach (char c in ouvert)
                {
                    if (c != ',')
                    {
                        try
                        {
                            int x = (int)c;
                            Node2 N = new Node2();
                            N.numero = x;
                            listeOuvert.Add(N);
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
                            int x = (int)c;
                            Node2 N = new Node2();
                            N.numero = x;
                            listeFerme.Add(N);
                        }
                        catch { }
                    }
                }

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

        private int Compare(GenericNode n1, GenericNode n2)
        {
            int num1 = ((Node2)n1).numero;
            int num2 = ((Node2)n2).numero;
            if (num1 > num2)
                return -1;
            else if (num1 < num2)
                return 1;
            else return 0;
        }

    }

}
