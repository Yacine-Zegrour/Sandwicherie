using System;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.Output
{
    public class WriteCommandeTxt : IParserOutput
    {
        public void Output(List<Panier> panier)
        {
            // Create a file to write to.
            using (StreamWriter file = File.CreateText(@"/Users/yacinezegrour/Documents/Ecole/C#/facture.txt"))
            {
                for (int i = 0; i < panier.Count(); i++)
                {
                    file.WriteLine("################################################################################################################");
                    file.WriteLine("#############################################Facture du menu##################################################");
                    file.WriteLine("################################################################################################################");
                    int price = 0;



                    foreach (KeyValuePair<Sandwich, int> item in panier[i].sandwichs)
                    {
                        file.WriteLine(item.Value + "  " + item.Key.Nom + " - " + (Convert.ToInt32(item.Key.Prix) * item.Value) + " euros");
                        price = price + (Convert.ToInt32(item.Key.Prix) * item.Value);
                        file.WriteLine();
                        file.WriteLine(item.Key.ToString());
                        file.WriteLine("-------------------------------------------------------");


                    }



                    file.WriteLine("Le prix du panier est : " + price + " euros");
                    file.WriteLine("-------------------------------------------------------");
                    file.WriteLine("");
                    file.WriteLine("################################################################################################################");
                }

            }
        }
    }
}

