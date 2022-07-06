using Sandwicherie.model;


Catalogue menu = new Catalogue();
Panier panier = new Panier();

SandwichBuilder sandwichBuilder = new SandwichBuilder();
Sandwich jambonbeurre = sandwichBuilder
    .WithPain(1)
    .WithTrancheDeJambon(1)
    .WithBeurre(10)
    .Build("jambonbeurre",3.50);

Sandwich pouletcrudités = sandwichBuilder
    .WithPain(1)
    .WithOeuf(1)
    .WithTomate(0.5)
    .WithTrancheDePoulet(1)
    .WithMayonnaise(10)
    .WithSalade(10)
    .Build("Poulet crudités", 5);

Sandwich dieppois = sandwichBuilder
    .WithPain(1)
    .WithThon(50)
    .WithTomate(0.5)
    .WithMayonnaise(10)
    .WithSalade(10)
    .Build("Dieppois", 4.50);

menu.addSandwich(dieppois);
menu.addSandwich(pouletcrudités);
menu.addSandwich(jambonbeurre);

string continu = "y";


menu.getMenu();

string command = "";
while ("n" != continu)
{
    Console.WriteLine("Quels sandwich souhaitez vous ?");
    string commandActual = Console.ReadLine();
    string[] commandes = commandActual.Split(',');
    for (int i = 0; i < commandes.Length; i++)
    {

        string quantity = commandes[i].Substring(0, 1);

        string name = commandes[i].Substring(2);

       Sandwich sandwich =  menu.GetSandwich(name);
        if (sandwich!= null)
        {
            int quantityInt = int.Parse(quantity);
            panier.addSandwich(quantityInt, sandwich);

            panier.getSandwichs();
            panier = new Panier();

        }
       
        }
    

       




    



}




 