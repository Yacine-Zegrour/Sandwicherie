using System;
using Sandwicherie.model;

namespace Sandwicherie.Output
{
    public class OutputStrategy
    {
        public IParserOutput ChoseOutputStrategy(List<Panier> panier)
        {
            IParserOutput outputStrategy;


            Console.WriteLine("1 - Ecrire dans un fichier TXT");
            Console.WriteLine("2 - Ecrire dans un fichier JSON");
            Console.WriteLine("3 - Ecrire dans un fichier XML");
            Console.WriteLine("4 - Ecrire dans la console");
            String number = Console.ReadLine()!;

            switch (number)
            {

                case "1":
                    Console.Clear();
                    return outputStrategy = new WriteCommandeTxt();



                case "2":
                    Console.Clear();
                    return outputStrategy = new WriteCommandeJson();


                case "3":
                    Console.Clear();
                    return outputStrategy = new WriteCommandeXml();
                

                case "4":
                    Console.Clear();
                     outputStrategy = new WriteCommandeConsole();
                    return outputStrategy;

                default:
                    return null;

            }
        }
    }
}

