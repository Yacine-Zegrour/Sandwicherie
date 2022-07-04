using Sandwicherie.model;


Catalogue menu = new Catalogue();
Panier panier = new Panier();

List<String> ingrediantsJambonBeurre = new List<string>();
ingrediantsJambonBeurre.Add("1 pain");
ingrediantsJambonBeurre.Add("1 tranche de jambon");
ingrediantsJambonBeurre.Add("10g de beurre");
Sandwich sandwichJambonBeurre = new Sandwich("jambon beurre", ingrediantsJambonBeurre, 3.50);


List<String> ingrediantsPouletcrudités = new List<string>();
ingrediantsPouletcrudités.Add("1 pain");
ingrediantsPouletcrudités.Add("1 oeuf");
ingrediantsPouletcrudités.Add("0.5 tomate");
ingrediantsPouletcrudités.Add("1 tranche de poulet");
ingrediantsPouletcrudités.Add("10g de mayonnaise");
ingrediantsPouletcrudités.Add("10g de salade");
Sandwich sandwichPouletcrudités = new Sandwich("Poulet crudités", ingrediantsPouletcrudités, 5);

List<String> ingrediantsDieppois = new List<string>();
ingrediantsDieppois.Add("1 pain");
ingrediantsDieppois.Add("50g de thon");
ingrediantsDieppois.Add("0.5 tomate");
ingrediantsDieppois.Add("10g de mayonnaise");
ingrediantsDieppois.Add("10g de salade");
Sandwich sandwichDieppois = new Sandwich("Dieppois", ingrediantsDieppois, 4.50);
menu.addSandwich(sandwichDieppois);
menu.addSandwich(sandwichPouletcrudités);
menu.addSandwich(sandwichJambonBeurre);

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
        }
       
        }
    

       




    



}

Console.WriteLine("################################################################################################################");
Console.WriteLine("#############################################Affichage du panier##################################################");
Console.WriteLine("################################################################################################################");




 