using System;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

static string NaturalPrint(string line)
{
    for (int i = 0; i < line.Length; i++)
    {
        switch (line[i])
        {
            case '.':
            case '!':
            case '?':
                Console.Write(line[i]);
                Thread.Sleep(500);
                break;
            case ',':
            case ';':
                Console.Write(line[i]);
                Thread.Sleep(250);
                break;
            default:
                Console.Write(line[i]);
                Thread.Sleep(50);
                break;
        }
    }

    return line;
}

// This is an text-based adventure game. The player will be able to move around the map and interact with objects.
NaturalPrint("Hello, adventurer!");
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
Console.Write("Our adventure is starting");
for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500); // wait for half a second
    Console.Write(".");
}
Console.WriteLine(@"

You're sitting by a campfire; the flames dance fiercely against a light wind.
        ______
jgs    /     /\
      /     /  \
     /_____/----\_    (  
    ""     ""          ).  
   _ ___          o (:') o   
  (@))_))        o ~/~~\~ o   
                  o  o  o
");

Thread.Sleep(2000);

var line = "You look around. Surrounded by a forest, neither the surrounding trees nor the log you're" +
           "sitting on seem familiar.";

NaturalPrint(line);

Console.WriteLine("");
Thread.Sleep(2000);

line = "Does it matter? The fire is warm, and you feel safe.";
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < line.Length; i++)
{
    Console.Write(line[i]);
}
Console.ResetColor();
Console.WriteLine("");

Thread.Sleep(2000);
line = "'I guess not,' you say out loud. \n";
for (int i = 0; i < line.Length; i++)
{
    Console.Write(line[i]);
    Thread.Sleep(50);
}
Thread.Sleep(2000);

Console.WriteLine("Relaxing, you close your eyes and let the warmth of the fire calm you. \n");
Thread.Sleep(1500);
Console.WriteLine("You're exhausted, although you don't seem to remember why. \n");
Thread.Sleep(1000);
Console.WriteLine("You realize you haven't eaten all day; you're starving." +
                  " When was the last time you ate? \n");

Thread.Sleep(3000);
Console.WriteLine("Hunger overcomes curiosity. You open your eyes and see a hiking sack on the ground to your right. \n");
Console.WriteLine(@"

       .--._ .
        \ ).'
         )|/
      _.'''-._
     (        \
      \        )
      )'-.    (
  '  /     _.-'\
  ''/           )'''
'''('-._       /''';';'
 '''\        _/ ''""''       
''""''-.__=='' ''""''''
''""'''""'''""'''""""'''
");

Thread.Sleep(2200);

Console.WriteLine("What will you do?");
var campfireFirstResponse = Console.ReadLine();

if (campfireFirstResponse != null)
{
    campfireFirstResponse = Regex.Replace(campfireFirstResponse, @"[^\w]", "");

    if (campfireFirstResponse!.Contains("look"))
    {
        Console.WriteLine("You look through the hiking sack.)");
        Thread.Sleep(1000);
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(600);
            Console.Write(".");
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You should've gone to sleep.");
        Console.ResetColor();

        Console.WriteLine();
    }
}

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500); // wait for half a second
    Console.Write(".");
}



