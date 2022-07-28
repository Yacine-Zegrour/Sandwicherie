using System;
using Sandwicherie.model;
using Sandwicherie.service;
using Sandwicherie.utils;

namespace Sandwicherie.Input
{
    public class InputStrategy
    {
        public IParserInput ChoseInputStrategy(Catalogue menu)
        {
            IParserInput inputStrategy;

            Console.WriteLine("comment voulez vous charger votre commande :");
            Console.WriteLine("1 - écrire ma commande");
            Console.WriteLine("2 - A partir du fichier TXT");
            Console.WriteLine("3 - A partir du fichier JSON");
            Console.WriteLine("4 - A partir du fichier XML");

            String number = Console.ReadLine()!;
            switch (number)
            {
                case "1":
                    Console.Clear();
                    return inputStrategy = new ReadCommandeConsole();
                    break;

                case "2":
                    Console.Clear();
                  
                    return inputStrategy = new ReadCommandeTxt();
                    // getChoiceOutput(menu, paniers);
                    break;

                case "3":
                    Console.Clear();
                    return inputStrategy = new ReadCommandeJson();


                    // getChoiceOutput(menu, panierss);
                    break;

                case "4":
                    Console.Clear();
                    return inputStrategy = new ReadCommandeXml();

                    break;

                default:
                    return null;
                    break;
            }
        }
    }
}

