using System;
using Sandwicherie.db;
using Sandwicherie.model;

namespace Sandwicherie.service
{
	public class SandwichUtilisateurServices
	{
		private Db db;

        public SandwichUtilisateurServices(Db db)
        {
            this.db = db;
        }

        private void addSandwich(Sandwich sandwich)
		{
			db.sandwichsUtilisateur.Add(sandwich);

		}

		private List<Sandwich> getSandwichs()
		{
			return db.sandwichsUtilisateur;
		}
	}
}

