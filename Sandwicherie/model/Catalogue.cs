using System;
namespace Sandwicherie.model
{
    public class Catalogue
    {
        public List<Sandwich> sandwichsMenu = new List<Sandwich>();
        public Catalogue()
        {

        }
        public void addSandwich(Sandwich sandwich)
        {
            sandwichsMenu.Add(sandwich);
        }

        public Sandwich? GetSandwich(String name)
        {
            return sandwichsMenu.FirstOrDefault(e => e.nom==name);
        }

        public void getMenu()
        {
            Console.WriteLine("################################################################################################################");
            Console.WriteLine("#############################################Affichage du menu##################################################");
            Console.WriteLine("################################################################################################################");
            foreach (Sandwich element in sandwichsMenu)
            {
                Console.Write(element.nom + ": ");

                foreach (string e in element.ingrediants)
                {
                    Console.Write(e + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("################################################################################################################");

        }
    }
}

