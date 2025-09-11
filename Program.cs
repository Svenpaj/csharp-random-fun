// See https://aka.ms/new-console-template for more information
using App;

Console.WriteLine("Hello, from Game!");


Console.Write("Start by telling me your Hero name: ");
string hero_name = Console.ReadLine();
Console.WriteLine("Trying to initialize hero class..\n");

Hero myHero = new Hero(hero_name);
Console.WriteLine("Successfull Hero creation..");
Boss theBoss = new Boss("Trumpu Man", 10, 10, "The Sword of a Thousand Truths", "Roar!....hee..hee.. ROAR!!!");
Console.WriteLine("Successfull Boss creation..");

Item sword = new Item("The Sword of a Hundred Truths", 100, 500, 100);

myHero.AddItem(sword);

Console.WriteLine("Trying to use method from Hero class to show stats..\n");
myHero.Stats();

Console.WriteLine("Testing item display stats method..");
sword.Display();

Console.WriteLine("Trying to use method from Boss class to present the boss..\n");
theBoss.Present();
theBoss.MakeSound();


Console.WriteLine("\n\nPress enter to quit.");
Console.ReadLine();

Console.WriteLine("End of Program.");
