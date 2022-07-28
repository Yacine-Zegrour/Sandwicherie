using System;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.service
{
    public class ReadCommandeConsole: IParserInput
    {
        public ReadCommandeConsole()
        {
        }

        public List<Panier> Input(Catalogue menu)
        {
            Console.WriteLine("Quels sandwich souhaitez vous ?");
            string commandActual = Console.ReadLine();
            Console.Clear();
           
            List<Panier> panier = new List<Panier>();
            Console.WriteLine(Parser.getPanier(menu, commandActual));
            panier.Add(Parser.getPanier(menu, commandActual));
            return panier;


        }

      
    }
}

