using System;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Calcultrice
    {
        public int Add(string entree)
        {
            if (entree.Length == 1)
            {
                return Convert.ToInt32(entree);
            }

            if (string.IsNullOrEmpty(entree))
            {
                return 0;
            }

            string[] tableau;
            string[] delimiteurs;
            if (entree.StartsWith("//"))
            {
                tableau = entree.Split('\n');
                delimiteurs = new [] { tableau[0].Replace("//", "")};
                entree = tableau[1];
            }
            else
            { 
                if (entree.Contains(",\n") || entree.Contains("\n,"))
                {
                    throw new ArgumentException(nameof(entree));
                }

                delimiteurs = new [] { ",", "\n" };
            }

            tableau = entree.Split(delimiteurs, StringSplitOptions.RemoveEmptyEntries);

            int somme = 0;
            foreach (string chiffre in tableau)
            {
                somme += Convert.ToInt32(chiffre);
            }
            return somme;
        }
    }
}