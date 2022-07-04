using System;
using System.Text;

namespace Sandwicherie.model
{
    internal class SandwichBuilder
    {
        public double _pain { get; private set; }
        public double _oeuf { get; private set; }
        public double _tomate { get; private set; }
        public double _trancheDePoulet { get; private set; }
        public double _mayonnaise { get; private set; }
        public double _salade { get; private set; }
        public double _beurre { get; private set; }
        public double _trancheDeJambon { get; private set; }
        public double _thon { get; private set; }

        internal SandwichBuilder WithPain(double pain)
        {
            _pain = pain;
            return this;
        }
        internal SandwichBuilder WithOeuf(double oeuf)
        {
            _oeuf = oeuf;
            return this;
        }
        internal SandwichBuilder WithTomate(double tomate)
        {
            _tomate = tomate;
            return this;
        }
        internal SandwichBuilder WithTrancheDePoulet(double trancheDePoulet)
        {
            _trancheDePoulet = trancheDePoulet;
            return this;
        }
        internal SandwichBuilder WithMayonnaise(double mayonnaise)
        {
            _mayonnaise = mayonnaise;
            return this;
        }

        internal SandwichBuilder WithSalade(double salade)
        {
            _salade = salade;
            return this;
        }
        internal SandwichBuilder WithBeurre(double beurre)
        {
            _beurre = beurre;
            return this;
        }
        internal SandwichBuilder WithTrancheDeJambon(double trancheDeJambon)
        {
            _trancheDeJambon = trancheDeJambon;
            return this;
        }
        internal SandwichBuilder WithThon(double thon)
        {
            _thon = thon;
            return this;
        }
        internal Sandwich Build(string nom, double prix)
        {
            return new Sandwich(_pain, _oeuf, _tomate, _trancheDePoulet, _mayonnaise, _salade, _beurre, _trancheDeJambon, _thon, nom, prix);
        }

        

    }

}