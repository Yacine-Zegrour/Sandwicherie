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
            return sandwichsMenu.FirstOrDefault(e => e.Nom==name);
        }

        public void getMenu()
        {
            Console.WriteLine("################################################################################################################");
            Console.WriteLine("#############################################Affichage du menu##################################################");
            Console.WriteLine("################################################################################################################");
            foreach (Sandwich element in sandwichsMenu)
            {
                Console.Write(element.Nom);
                Console.WriteLine();
                Console.Write(element.ToString());

              

                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("################################################################################################################");

        }
    }
}

