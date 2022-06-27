using Sandwicherie.service;


string continu = "y";

Console.WriteLine("################################################################################################################");
Console.WriteLine("#############################################Affichage du menu##################################################");
Console.WriteLine("################################################################################################################");
Console.WriteLine("- Jambon beurre : 1 pain, 1 tranche de jambon, 10g de beurre => 3,50€");
Console.WriteLine("- Poulet crudités : 1 pain, 1 oeuf, 0.5 tomate, 1 tranche de poulet, 10g de mayonnaise, 10g de salade => 5€");
Console.WriteLine("- Dieppois : 1 pain, 50g de thon, 0.5 tomate, 10g de mayonnaise, 10g de salade => 4,50€");
Console.WriteLine("");
Console.WriteLine("################################################################################################################");

Console.WriteLine("");
Console.WriteLine("");

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

    Console.WriteLine(words[i]);
}


/*
 * 
Sandwich
 SandwichMenuServices menu = new SandwichMenuServices();
 menu.addSandwich()

 */