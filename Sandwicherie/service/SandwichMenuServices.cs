using System;
using System.Collections;
using Sandwicherie.db;
using Sandwicherie.model;

namespace Sandwicherie.service
{
	public class SandwichMenuServices
	{
		private Db db = new Db();


        public void addSandwich(Sandwich sandwich)
        {
			db.sandwichsMenu.Add(sandwich);

		}

		private List<Sandwich> getSandwichs()
		{
			return db.sandwichsMenu;
		}

        public void getMenu()
        {
			Console.WriteLine("################################################################################################################");
			Console.WriteLine("#############################################Affichage du menu##################################################");
			Console.WriteLine("################################################################################################################");
			foreach ( Sandwich element in db.sandwichsMenu)
			{
				Console.Write(element.nom + ": " );

				foreach (string e in element.ingrediants)
				{
					Console.Write(e+" ") ;
				}

				Console.WriteLine();
			}
			Console.WriteLine("");
			Console.WriteLine("################################################################################################################");

		}
	}
}

