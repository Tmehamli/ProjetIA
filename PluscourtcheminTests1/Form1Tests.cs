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
        [TestMethod()]
        public void btn_Valider_ClickTest()
        {
            List<GenericNode> listeOuvert = new List<GenericNode>();

            string ouvert = "1,2,3";
            string nouveauOuvert = "";

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
                        nouveauOuvert += Convert.ToString(N.numero) + ", ";
                    }
                    catch { }
                }

               
            }
            Assert.AreEqual("1, 2, 3, ", nouveauOuvert);
        }
    }
}