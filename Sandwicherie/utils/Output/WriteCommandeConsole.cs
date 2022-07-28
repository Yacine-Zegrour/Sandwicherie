using System;
using Newtonsoft.Json;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.Output
{
    public class WriteCommandeConsole : IParserOutput
    {
       

        public void Output(List<Panier> panier)
        {
            foreach (var item in panier)
            {
                item.getSandwichs();
            }
           
        }
    }
}

