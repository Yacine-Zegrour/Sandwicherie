using System;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sandwicherie.model;

namespace Sandwicherie.utils
{
    public class Parser
    {
        public Parser()
        {
        }
         public static Panier getPanier(Catalogue menu, string commandActual)
        {
            Panier panier = new Panier();
            string[] commandes = commandActual.Split(',');
            for (int i = 0; i < commandes.Length; i++)
            {

                string quantity = commandes[i].Substring(0, 1);

                string name = commandes[i].Substring(2);

                Sandwich sandwich = menu.GetSandwichByName(name);

                if (sandwich != null)
                {
                    int quantityInt = int.Parse(quantity);
                    panier.addSandwich(quantityInt, sandwich);



                }

            }

            return panier;
        }
        public static List<String> ReadCommandeJSon()
        {
            StreamReader r = new StreamReader("/Users/yacinezegrour/Documents/Ecole/C#/commande.json");
            string jsonString = r.ReadToEnd();
            CommandeDtoJSon commandeDtoJSon = JsonConvert.DeserializeObject<CommandeDtoJSon>(jsonString)!;


            return commandeDtoJSon.message;

        }
    }
}

