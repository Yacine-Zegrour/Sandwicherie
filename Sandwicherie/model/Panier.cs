using System;
using System.Runtime.Serialization;
using Sandwicherie.utils;

namespace Sandwicherie.model
{
    [DataContract]
    public class Panier
    {
        [DataMember]
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
                Console.WriteLine(item.Value+ "  "+ item.Key.Nom + " - "+ (Convert.ToInt32(item.Key.Prix)*item.Value) + " euros");
                price = price + (Convert.ToInt32(item.Key.Prix) * item.Value);
                Console.WriteLine();
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine("-------------------------------------------------------");

              
            }


            
            Console.WriteLine("Le prix du panier est : "+price+" euros");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("################################################################################################################");

            
            
        }

    }
}

