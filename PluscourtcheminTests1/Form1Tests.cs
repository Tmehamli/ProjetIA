using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluscourtchemin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluscourtchemin.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        /* Conseil pour les tests
         * Elaborer les tests avec la structure qui suit : 
         * 1) On initialise les variables nécéssaires pour réaliser le test
         * 2) On execute la methode à tester et on mets en place des variables de controle
         * 3) On utilise Assert.XXX() sur la/les variable(s) de cotroles
         * 
         * DebugAllTests : Ctrl+R, Ctrl+A
         * DebugAllTestsInContext : Ctrl+R, Ctrl+T
         * RunAllTests : Ctrl+R, A
         * RunAllTestsInContext : Ctrl+R, T
        */
        private FormDijkstra form1;
        private object sender;
        private EventArgs e;

        private void Initialize()
        {
            form1 = new FormDijkstra();
            sender = new object();

            e = new EventArgs();
        }

        [TestMethod]
        public void Compare()
        {
            // TO DO : Tester la methode compare


            // A modifier pour l'adapter au test à considerer
            Assert.Equals(1, 3);

        }

        [TestMethod]
        public void btn_Valider_Clik()
        {
            // 1) On initialise
            this.Initialize();
            form1.buttonInitMemoire_Click(sender, e);

            form1.textBoxInitialNode.Text = "" + 0;
            form1.textBoxFinalNode.Text = "" + 6;
            var fermes = new List<List<int>>() {
                new List<int>(){0},
                new List<int>(){0,1},
                new List<int>(){0,1,2} ,
                new List<int>(){0,1,2,3} ,
                new List<int>(){0,1,2,3,4},
                new List<int>(){0,1,2,3,4, 5}
            };
            var ouverts = new List<List<int>>() {
                new List<int>(){1,2,3,},
                new List<int>(){2,3,4},
                new List<int>(){3,4},
                new List<int>(){4},
                new List<int>(){5},
            };

            // 2) On rempli l'historique uti en utlisant la fonction à tester(btn_Valider_Click)
            for (int i = 0; i < fermes.Count; i++)
            {
                if (i < ouverts.Count - 1)
                {
                    string ouvertStr = string.Empty;
                    foreach (var o in ouverts[i])
                    {
                        ouvertStr += o.ToString() + ",";
                    }
                    form1.textBoxOuverts.Text = ouvertStr;
                }
                string fermeStr = string.Empty;
                foreach (var f in fermes[i])
                {
                    fermeStr += f.ToString() + ",";
                }
                form1.textBoxFermes.Text = fermeStr;
                form1.btn_Valider_Click(sender, e);
            }
            // Cas délicas, le premier ouvert est {0}
            ouverts.Reverse();
            List<int> ouvert1 = new List<int>() { 0 };
            ouverts.Add(ouvert1);
            ouverts.Reverse();

            // 3) On verifie que les numéros sont les mêmes que ceux d'origines
            // Pour les ouverts
            int nbOuvertOk = 0;
            for (int i = 0; i < FormDijkstra.historiqueUtiOuvert.Count; i++)
            {
                var ouvertConsidere = FormDijkstra.historiqueUtiOuvert[i];
                int nbNoeudOk = 0;
                for (int j = 0; j < ouvertConsidere.Count; j++)
                {
                    var noeudFromValider = (Node2)ouvertConsidere[j];
                    var noeudFromMem = ouverts[i][j];
                    if (noeudFromMem == noeudFromValider.numero)
                    {
                        nbNoeudOk++;
                    }
                }
                if (nbNoeudOk == ouvertConsidere.Count)
                {
                    nbOuvertOk++;
                }
            }
            // Pour les fermes
            int nbFermesOk = 0;
            for (int i = 0; i < FormDijkstra.historiqueUtiFerme.Count; i++)
            {
                var fermeConsidere = FormDijkstra.historiqueUtiFerme[i];
                int nbNoeudOk = 0;
                for (int j = 0; j < fermeConsidere.Count; j++)
                {
                    var noeudFromValider = (Node2)fermeConsidere[j];
                    var noeudFromMem = fermes[i][j];
                    if (noeudFromMem == noeudFromValider.numero)
                    {
                        nbNoeudOk++;
                    }
                }
                if (nbNoeudOk == fermeConsidere.Count)
                {
                    nbFermesOk++;
                }
            }

            Assert.AreEqual(nbOuvertOk, FormDijkstra.historiqueUtiOuvert.Count);
            Assert.AreEqual(nbFermesOk, FormDijkstra.historiqueUtiFerme.Count);
        }

        [TestMethod]
        public void CorrectionGrapheMemoire()
        {
            this.Initialize();
            form1.buttonInitMemoire_Click(sender, e);

            form1.textBoxInitialNode.Text = "" + 0;
            form1.textBoxFinalNode.Text = "" + 6;
            // To do : Utiliser a* pour generer les liste uti

            form1.btn_Valider_Click(sender, e);

            ////Assert.AreEqual(Form1.historiqueUtiOuvert, Form1.);

            // A modifier pour l'adapter au test à considerer
            Assert.Equals(1, 3);
        }

        [TestMethod()]
        public void Correction()
        {
            var nbnodes = 10;
            var matrice = new double[nbnodes, nbnodes];
            var alea = new Random();

            matrice[0, 1] = alea.Next(1, 11); matrice[1, 0] = matrice[0, 1];
            matrice[0, 2] = alea.Next(1, 11); matrice[2, 0] = matrice[0, 2];
            matrice[0, 3] = alea.Next(1, 11); matrice[3, 0] = matrice[0, 3];
            matrice[1, 4] = alea.Next(1, 11); matrice[4, 1] = matrice[1, 4];
            matrice[2, 4] = alea.Next(1, 11); matrice[4, 2] = matrice[2, 4];
            matrice[4, 5] = alea.Next(1, 11); matrice[5, 4] = matrice[4, 5];
            matrice[5, 6] = alea.Next(1, 11); matrice[6, 5] = matrice[5, 6];
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = 0;
            List<GenericNode> solution = g.RechercheSolutionAEtoile2(N0);

            List<List<GenericNode>> listeUt = new List<List<GenericNode>>();
            listeUt.Add(new List<GenericNode>());
            List<List<GenericNode>> listeIA;

            // A modifier pour l'adapter au test à considerer
            Assert.Equals(1, 3);
        }
    }
}