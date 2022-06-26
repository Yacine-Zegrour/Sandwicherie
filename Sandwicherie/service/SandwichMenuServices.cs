using System;
using System.Collections;
using Sandwicherie.db;
using Sandwicherie.model;

namespace Sandwicherie.service
{
	public class SandwichMenuServices
	{
		private Db db;


        public void addSandwich(Sandwich sandwich)
        {
			db.sandwichsMenu.Add(sandwich);

		}

		private List<Sandwich> getSandwichs()
		{
			return db.sandwichsMenu;
		}

	}
}

