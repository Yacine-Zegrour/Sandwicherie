using System;
namespace Sandwicherie.model
{
	public class Sandwich
	{
		private String nom { get; set; } 
		private String ingrediants { get; set; }


        public Sandwich(string nom, string ingrediants)
        {
            this.nom = nom;
            this.ingrediants = ingrediants;
        }
    }
}

