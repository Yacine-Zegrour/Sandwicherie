using System;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sandwicherie.model;
using Sandwicherie.utils;

namespace Sandwicherie.Output
{
    public class WriteCommandeXml : IParserOutput
    {
        public void Output(List<Panier> panier)
        {
            {
                string xml = "";
                for (int i = 0; i < panier.Count; i++)
                {
                    


                    XmlSerializer serializer = new XmlSerializer(typeof(List<Panier>));
                    using (var stringWriter = new StringWriter())
                    {
                        using (XmlWriter writer = XmlWriter.Create(stringWriter))
                        {
                            serializer.Serialize(writer, panier[i]);
                            xml = xml+stringWriter.ToString();

                        }
                    }
                    
                }
                

               
                using (StreamWriter file = File.CreateText("facture.xml"))
                {
                    file.WriteLine(xml);
                }
            }
        }
    }
}

