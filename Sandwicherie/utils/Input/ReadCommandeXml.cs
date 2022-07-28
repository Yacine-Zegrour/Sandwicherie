using System;
using Sandwicherie.model;
using Sandwicherie.service;

namespace Sandwicherie.Input
{
    public class ReadCommandeXml: IParserInput
    {
        public List<Panier> Input(Catalogue menu)
        {
            using (StreamWriter sw = File.CreateText("/Users/yacinezegrour/Documents/Ecole/C#/facture.xml"))
            {
                List<String> xml = new List<string>();

            }
            return null;
        }
    }
}

