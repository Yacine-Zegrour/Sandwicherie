using System;
namespace Sandwicherie.model
{
	public class Sandwich
	{
		public String nom { get; private set; }
        public List<String> ingrediants { get; private set; }
        public double prix { get; private set; }

        public Sandwich(string nom, List<string> ingrediants, double prix)
        {
            this.nom = nom;
            this.ingrediants = ingrediants;
            this.prix = prix;
        }

        public override bool Equals(object? obj)
        {
            return obj is Sandwich sandwich &&
                   nom == sandwich.nom &&
                   EqualityComparer<List<string>>.Default.Equals(ingrediants, sandwich.ingrediants) &&
                   prix == sandwich.prix;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nom, ingrediants, prix);
        }

        public override string? ToString()
        {
            return nom + " :" + ingrediants.ToString() + prix;
        }
    }
}

