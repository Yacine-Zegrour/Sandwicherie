using System;
namespace Sandwicherie.model
{
    public class Catalogue
    {
        public List<Sandwich> sandwichsMenu = new List<Sandwich>();

       

        private static Catalogue _instance;

        
        private static Catalogue GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Catalogue();
            }
            return _instance;
        }

        public void addSandwich(Sandwich sandwich)
        {
            sandwichsMenu.Add(sandwich);
        }

        public Sandwich? GetSandwichByName(String name)
        {
            return sandwichsMenu.FirstOrDefault(e => e.Nom==name);
        }

        public  void getMenu()
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

