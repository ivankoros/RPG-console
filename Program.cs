using System;
using System.Threading;
using System.Text.RegularExpressions;

// This is an text-based adventure game. The player will be able to move around the map and interact with objects.
Console.WriteLine("Hello, adventurer!");
Thread.Sleep(500);
Console.WriteLine("What is your name?");

var regex = new Regex(@"^[a-zA-Z]+$");

var playerName = Console.ReadLine();

var validName = playerName != null && regex.IsMatch(playerName);

while (!validName)
{
    Console.WriteLine("That's not a name!");
    playerName = Console.ReadLine();
    validName = playerName != null && regex.IsMatch(playerName);
}

Console.WriteLine($"Ah.. welcome {playerName}!");
Thread.Sleep(2000);

System.Threading.Thread.Sleep(500);
Console.WriteLine("Our adventure will start in...");
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"{i} seconds");
    System.Threading.Thread.Sleep(1000);
    
}

Console.WriteLine("Let's go! :D");
Console.WriteLine(@"
You sit by the campfire, the flames dancing in the wind.
        ______
jgs    /     /\
      /     /  \
     /_____/----\_    (  
    ""     ""          ).  
   _ ___          o (:') o   
  (@))_))        o ~/~~\~ o   
                  o  o  o
");

Console.WriteLine("");


