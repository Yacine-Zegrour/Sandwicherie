using System;
using System.Runtime.Serialization;
using System.Text;

namespace Sandwicherie.model
{
    
    public class Sandwich
	{
        public double Pain { get;  set; }
        public double Oeuf { get;  set; }
        public double Tomate { get;  set; }
        public double TrancheDePoulet { get;  set; }
        public double Mayonnaise { get;  set; }
        public double Salade { get;  set; }
        public double Beurre { get;  set; }
        public double TrancheDeJambon { get;  set; }
        public double Thon { get;  set; }
        public string Nom { get;  set; }
        public double Prix { get;  set; }

        public Sandwich(double pain, double oeuf, double tomate, double trancheDePoulet, double mayonnaise, double salade, double beurre, double trancheDeJambon, double thon, string nom, double prix)
        {
            Pain = pain;
            Oeuf = oeuf;
            Tomate = tomate;
            TrancheDePoulet = trancheDePoulet;
            Mayonnaise = mayonnaise;
            Salade = salade;
            Beurre = beurre;
            TrancheDeJambon = trancheDeJambon;
            Thon = thon;
            Nom = nom;
            Prix = prix;
        }

        public Sandwich()
        {
        }

        public override string ToString()
        {
            var str =
    new StringBuilder()
        .AppendIf(Pain > 0, Pain.ToString() + " Pain \n")
        .AppendIf(Tomate > 0, Tomate.ToString() + " tomate \n")
        .AppendIf(TrancheDePoulet > 0, TrancheDePoulet.ToString() + " TrancheDePoulet \n")
        .AppendIf(Mayonnaise > 0, Mayonnaise.ToString() + " Mayonnaise \n")
        .AppendIf(Salade > 0, Salade.ToString() + " Salade \n")
        .AppendIf(Beurre > 0, Beurre.ToString() + " Beurre \n")
        .AppendIf(TrancheDeJambon > 0, TrancheDeJambon.ToString() + " TrancheDeJambon \n")
        .AppendIf(Thon > 0, Thon.ToString() + " Thon \n")
        .ToString();
            return str;
        }
    }
}

