using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculator.Tests
{
    [TestClass]
    public class Calculator_AddShould
    {
        [TestMethod]
        public void SiLEntreeEstChaineVide_Retourne0()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("");

            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void SiLEntreeEst2_Retourne2()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("2");

            Assert.AreEqual(2, resultat);
        }

        [TestMethod]
        public void SiLEntreeEst3_Retourne3()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("3");

            Assert.AreEqual(3, resultat);
        }


        [TestMethod]
        public void SiLEntreeEst1vir2_Retourne3()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("1,2");

            Assert.AreEqual(3, resultat);
        }

        [TestMethod]
        public void SiLEntreeEst1vir2vir3_Retourne6()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("1,2,3");

            Assert.AreEqual(6, resultat);
        }

        [TestMethod]
        public void SiLEntreeEst1vir2vir3Newline4_Retourne10()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("1,2,3\n4");

            Assert.AreEqual(10, resultat);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SiLEntreeEst1virNewline4_RetourneUneErreur()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("1,\n4");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SiLEntreeEst1NewlineVir4_RetourneUneErreur()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("1\n,4");

        }

        [TestMethod]
        public void SiLEntreeEstSlashSlashPlusNewLine1Plus2_Retourne3()
        {
            Calcultrice calcultrice = new Calcultrice();

            int resultat = calcultrice.Add("//+\n1+2");

            Assert.AreEqual(3, resultat);
        }
    }
}
