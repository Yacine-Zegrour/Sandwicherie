using System;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.service
{
    public class ReadCommandeTxt : IParserInput
    {
        public List<Panier> Input(Catalogue menu)
        {
            string[] ligne = System.IO.File.ReadAllLines(@"/Users/yacinezegrour/Documents/Ecole/C#/commande.txt");

            
            List<Panier> panier = new List<Panier>();
            for (int l = 0; l < ligne.Length; l++)
            {
                Panier panier1 = new Panier();
                panier.Add(Parser.getPanier(menu, ligne[l]));


            }
            return panier;

        }
    }
    
}

