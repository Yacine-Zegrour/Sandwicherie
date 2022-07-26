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

        public static Panier writeCommande(Catalogue menu, Panier panier)
        {


            Console.WriteLine("Quels sandwich souhaitez vous ?");
            string commandActual = Console.ReadLine();
            Console.Clear();
            return getPanier(menu, commandActual);

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

        public static List<Panier> ReadCommandeTxt(Catalogue menu)
        {
           
            string[] ligne = System.IO.File.ReadAllLines(@"/Users/yacinezegrour/Documents/Ecole/C#/commande.txt");

            //CommandeDtoJSon ligne = JsonParser.GetCommandeDtoJSon();

            //Console.WriteLine("ici " + ligne.ToString);
            List<Panier> panier = new List<Panier>();
            for (int l = 0; l < ligne.Length; l++)
            {
                Panier panier1 = new Panier();
               panier.Add(getPanier(menu, ligne[l]));
                 
               
            }
            return panier;

                }

        internal static void ReadCommandeXML(Catalogue menu)
        {
           
            using (StreamWriter sw = File.CreateText("/Users/yacinezegrour/Documents/Ecole/C#/facture.xml"))
            {
                List<String> xml = new List<string>();
                
            }
        }

        public static void createTxt(List<Panier> panier)
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

       
     

        public static void createXml(Panier panier)
        {
            string xml = "";
            List<SandwichDto> list = panier.sandwichs.Select(p => new SandwichDto { sandwich = p.Key, nb = p.Value }).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<SandwichDto>));
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, list);
                    xml = sww.ToString();
                }
            }

            using (StreamWriter sw = File.CreateText("/Users/yacinezegrour/Documents/Ecole/C#/facture.xml"))
            {

                sw.WriteLine(xml);
            }
        }

        public static List<String> ReadCommandeJSon()
        {
            StreamReader r = new StreamReader("/Users/yacinezegrour/Documents/Ecole/C#/commande.json");
            string jsonString = r.ReadToEnd();
           CommandeDtoJSon commandeDtoJSon = JsonConvert.DeserializeObject<CommandeDtoJSon>(jsonString)!;
 

            return commandeDtoJSon.message;
            
       }
        public static void createJson( Object obj)
        {
            using (StreamWriter file = File.CreateText("/Users/yacinezegrour/Documents/Ecole/C#/facture.json"))
            {
                string objectToJson = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
                file.Write(objectToJson);
            }


        }

        public static void WriteTxt(Panier panier )
        {
            // Create a file to write to.
            using (StreamWriter file = File.CreateText(@"/Users/yacinezegrour/Documents/Ecole/C#/facture.txt"))
            {

                file.WriteLine("################################################################################################################");
                file.WriteLine("#############################################Facture du menu##################################################");
                file.WriteLine("################################################################################################################");
                int price = 0;
                foreach (KeyValuePair<Sandwich, int> item in panier.sandwichs)
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

