using System;
using Newtonsoft.Json;
using Sandwicherie.model;
using Sandwicherie.service;
using Sandwicherie.utils;

namespace Sandwicherie.Input
{
    public class ReadCommandeJson : IParserInput
    {
        public List<Panier> Input(Catalogue menu)
        {
            StreamReader r = new StreamReader("/Users/yacinezegrour/Documents/Ecole/C#/commande.json");
            string jsonString = r.ReadToEnd();
            CommandeDtoJSon commandeDtoJSon = JsonConvert.DeserializeObject<CommandeDtoJSon>(jsonString)!;

            List<String> Commands = Parser.ReadCommandeJSon();
            List<Panier> paniers = new List<Panier>();
            for (int i = 0; i < Commands.Count; i++)
            {
                paniers.Add(Parser.getPanier(menu, Commands[i]));
            }
            return paniers;
        }
    }
}

