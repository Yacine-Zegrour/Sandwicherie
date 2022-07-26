using System;
using Sandwicherie.model;

namespace Sandwicherie.utils
{
    public class SandwichDto
    {
        public Sandwich sandwich { get;  set; }
        public int nb { get;  set; }
        

        public SandwichDto(Sandwich sandwich, int nb)
        {
            this.sandwich = sandwich;
            this.nb = nb;
        }
        public SandwichDto()
        {
          
        }
    }
}

