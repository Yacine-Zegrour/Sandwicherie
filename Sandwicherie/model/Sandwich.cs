using System;
using System.Text;

namespace Sandwicherie.model
{
	public class Sandwich
	{
        public double Pain { get; private set; }
        public double Oeuf { get; private set; }
        public double Tomate { get; private set; }
        public double TrancheDePoulet { get; private set; }
        public double Mayonnaise { get; private set; }
        public double Salade { get; private set; }
        public double Beurre { get; private set; }
        public double TrancheDeJambon { get; private set; }
        public double Thon { get; private set; }
        public string Nom { get; private set; }
        public double Prix { get; private set; }

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

//.AppendIf(Pain > 0, "one")
//.AppendLine(Oeuf.ToString() + " oeuf")
//.AppendLine(Tomate.ToString() + " tomate")
//.AppendLine(TrancheDePoulet.ToString() + " TrancheDePoulet")
//.AppendLine(Mayonnaise.ToString() + " Mayonnaise")
//.AppendLine(Salade.ToString() + " Salade")
//.AppendLine(Beurre.ToString() + " Beurre")
//.AppendLine(TrancheDeJambon.ToString() + " TrancheDeJambon")
//.AppendLine(Thon.ToString() + " Thon")
//.ToString();
        }
    }
}

