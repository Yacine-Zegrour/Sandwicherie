using Sandwicherie.Input;
using Sandwicherie.model;
using Sandwicherie.Output;
using Sandwicherie.service;
using Sandwicherie.utils;

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
    Console.Clear();
    IParserInput parserStrategyInput = new InputStrategy().ChoseInputStrategy(menu);
    List<Panier> paniers = parserStrategyInput.Input(menu);

    IParserOutput parserStrategyOutput = new OutputStrategy().ChoseOutputStrategy(paniers);
    parserStrategyOutput.Output(paniers);

    Console.ReadLine();

    
}




