using System;
using Sandwicherie.model;

namespace Sandwicherie.service
{
    public interface IParserInput
    {
        List<Panier> Input(Catalogue menu);



    }
}

