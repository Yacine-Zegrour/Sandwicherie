using System;
using Newtonsoft.Json;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.Output
{
    public class WriteCommandeJson : IParserOutput
    {


        public void Output(List<Panier> panier)
        {
            using (StreamWriter file = File.CreateText("/Users/yacinezegrour/Documents/Ecole/C#/facture.json"))
            {
                string objectToJson = JsonConvert.SerializeObject(panier, Newtonsoft.Json.Formatting.Indented);
                file.Write(objectToJson);
            }
            
        }
    }
}

