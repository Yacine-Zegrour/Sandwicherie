using Sandwicherie.service;
using Sandwicherie.model;


SandwichMenuServices menu = new SandwichMenuServices();

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
    command += commandActual+ ",";
    Console.WriteLine("souhaitez vous en ajouter encore  ? y/n");
    continu = Console.ReadLine();
}
command = command.Substring(0,command.Length-1);
int nb = command.Count(n => n == ',')+1;
Console.WriteLine(command);
Console.WriteLine("");

Console.WriteLine("################################################################################################################");
Console.WriteLine("#############################################Affichage du panier##################################################");
Console.WriteLine("################################################################################################################");
string[] words = command.Split(',');
for (int i = 0; i<nb; i ++){

    if(words[i].ToLower()== "jambon beurre")
    {
        Console.WriteLine(words[i]);
        Console.WriteLine("        1 pain");
        Console.WriteLine("        1 tranche de jambon");
        Console.WriteLine("        10g de beurre");
    }
    if (words[i].ToLower() == "poulet crudités")
    {
        Console.WriteLine(words[i]);
        Console.WriteLine("        1 pain");
        Console.WriteLine("        1 oeuf");
        Console.WriteLine("        0.5 tomate");
        Console.WriteLine("        1 tranche de poulet");
        Console.WriteLine("        10g de mayonnaise");
        Console.WriteLine("        10g de salade");
    }
    if(words[i].ToLower() == "dieppois")
    {
        Console.WriteLine(words[i]);
        Console.WriteLine("        1 pain");
        Console.WriteLine("        50g de thon");
        Console.WriteLine("        0.5 tomate");
        Console.WriteLine("        10g de mayonnaise");
        Console.WriteLine("        10g de salade");
    }
    
}


 