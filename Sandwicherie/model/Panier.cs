using System;

namespace Sandwicherie.model
{
    public class Panier
    {

        public Dictionary<Sandwich, int> sandwichs = new Dictionary<Sandwich, int>();
        

        public Panier()
        {

        }

        public void addSandwich(int quantity, Sandwich sandwich)
        {
            if (sandwichs.ContainsKey(sandwich))
            {
                sandwichs[sandwich] += quantity;
            }
            else
            {
                sandwichs.Add(sandwich, quantity);
            }
          
        }
             public void getSandwichs()
        {
              Console.WriteLine("################################################################################################################");
            Console.WriteLine("#############################################Facture du menu##################################################");
            Console.WriteLine("################################################################################################################");
            int price = 0;
            foreach (KeyValuePair<Sandwich, int> item in sandwichs)
            {
                Console.WriteLine(item.Value+ "  "+ item.Key.nom + " - "+ (Convert.ToInt32(item.Key.prix)*item.Value) + " euros");
                price = price + (Convert.ToInt32(item.Key.prix) * item.Value);
                foreach (String element in item.Key.ingrediants)
                {
                    Console.WriteLine(" - " + element);
                }
                Console.WriteLine("-------------------------------------------------------");

              
            }


            
            Console.WriteLine("Le prix du panier est : "+price+" euros");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("################################################################################################################");

        }

    }
}

