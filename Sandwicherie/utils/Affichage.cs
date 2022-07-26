using System;
using Sandwicherie.model;

namespace Sandwicherie.utils
{
    public class Affichage
    {
        public Affichage()
        {
        }

        public static void getChoiceInput(Catalogue menu, Panier panier) {


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
                    List<Panier> paniers = new List<Panier>();
                    paniers.Add(Parser.writeCommande(menu, panier));
                    getChoiceOutput( menu,  paniers);
                    break;

                case "2":
                    Console.Clear();
                    paniers = Parser.ReadCommandeTxt(menu);
                    getChoiceOutput(menu, paniers);
                    break;

                case "3":
                    Console.Clear();
                    List<String> Commands = Parser.ReadCommandeJSon();
                    List<Panier> panierss = new List<Panier>();
                    for (int i = 0; i < Commands.Count; i++)
                    {
                        panierss.Add(Parser.getPanier(menu, Commands[i]));
                    }
                   
                    
                    getChoiceOutput(menu, panierss);
                    break;

                case "4":
                    Console.Clear();
                   Parser.ReadCommandeXML(menu);
                    break;

                default:
                    Console.Clear();
                    getChoiceInput(menu, panier);
                    break;


            }
        }
            public static void getChoiceOutput(Catalogue menu, List<Panier> panier)
            {

            Console.WriteLine("1 - Ecrire dans un fichier TXT");
            Console.WriteLine("2 - Ecrire dans un fichier JSON");
            Console.WriteLine("3 - Ecrire dans un fichier XML");
            Console.WriteLine("4 - Ecrire dans la console");

            String number = Console.ReadLine()!;

            switch (number) {

                case "1":
                    Console.Clear();
                    Parser.createTxt(panier);
                    
                    break;

                case "2":
                    Console.Clear();
                    Parser.createJson(panier);
                    break;

                case "3":
                    Console.Clear();
                    //Parser.createXml(panier);
                    break;

                case "4":
                    Console.Clear();
                    foreach (var item in panier)
                    {
                        item.getSandwichs();
                    }
                    break;

                default:
                    Console.Clear();
                    getChoiceOutput(menu, panier);
                    break;


            }


        }
    }
}

