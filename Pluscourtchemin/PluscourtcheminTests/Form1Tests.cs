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
            string ouvert = "2,5";

            List<GenericNode> listeOuvert = new List<GenericNode>();

            string nouveauOuvert = "";

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
            Assert.AreEqual(nouveauOuvert, "2,5");
        }
    }
}