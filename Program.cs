using System;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Threading;
using System.Text.RegularExpressions;

static string NaturalPrint(string line, int newLineDelay = 1000, int endDelay = 500)
{
    for (int i = 0; i < line.Length; i++)
    {
        switch (line[i])
        {
            case '.':
            case '!':
            case '?':
                Console.Write(line[i]);
                Thread.Sleep(endDelay);
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

    Console.WriteLine("");
    Console.WriteLine("");

    Thread.Sleep(newLineDelay);

    return line;
}

// Intro
NaturalPrint("Hello, adventurer!");

NaturalPrint("What is your name?");

var regex = new Regex(@"^[a-zA-Z]+$");

var playerName = Console.ReadLine();

var validName = playerName != null && regex.IsMatch(playerName);

while (!validName)
{
    Console.WriteLine("That's not a name!");
    playerName = Console.ReadLine();
    validName = playerName != null && regex.IsMatch(playerName);
}

NaturalPrint($"Ah.. welcome {playerName}!",
    2000);

NaturalPrint("Our adventure is starting");

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500); // wait for half a second
    Console.Write(".");
}

NaturalPrint("You're sitting by a campfire; the flames dance fiercely against a light wind.");

Console.WriteLine(@"

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

NaturalPrint(line, 2000);

Console.ForegroundColor = ConsoleColor.Green;
NaturalPrint("Does it matter? The fire is warm, and you feel safe.",
    2000);
Console.ResetColor();


NaturalPrint("'I guess not,' you say out loud.",
    2000);

NaturalPrint("Relaxing, you close your eyes and let the warmth of the fire calm you.",
    1500);

NaturalPrint("You're exhausted, although you don't seem to remember why.");

NaturalPrint("You realize you haven't eaten all day; you're starving." +
             " When was the last time you ate?",
    newLineDelay: 3000);


NaturalPrint("Hunger overcomes curiosity. You open your eyes and see a hiking sack on the ground to your right.",
    2000);
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

NaturalPrint("What will you do?");
var campfireFirstResponse = Console.ReadLine();

if (campfireFirstResponse != null)
{
    campfireFirstResponse = Regex.Replace(campfireFirstResponse, @"[^\w]", "");

    if (campfireFirstResponse!.Contains("look"))
    {
        Console.WriteLine("You look through the hiking sack.");
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

Console.Clear();


NaturalPrint("You're sitting by a campfire; your mind feels uneasy as the flame roars.");
Console.WriteLine(@"


        ______
jgs    /     /\
      /     /  \
     /_____/----\_    (  
    ""     ""          ).  
   _ ___          o (:') o   
  (@))_))        o ~/~~\~ o   
                  o  o  o
");

Thread.Sleep(20000);