using System.Text.RegularExpressions;

namespace RPG_console.forgotten_forest_game
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            NaturalPrint("Our adventure is starting.....");


            NaturalPrint("You're sitting by a campfire; the flames dance fiercely against a light wind.",
                newLineDelay: 0);

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

            var line =
                "You look around. Surrounded by a forest, neither the trees that encapsulate your campground nor the log you're" +
                " sitting on seem familiar.";

            NaturalPrint(line, 2000);

            Console.ForegroundColor = ConsoleColor.Green;
            NaturalPrint("Does it matter? The fire is warm, and you feel safe.",
                2000);
            Console.ResetColor();

            var doItMatter = null as string;
            while (doItMatter == null)
            {
                doItMatter = Console.ReadLine();
            }

            NaturalPrint("'I guess not,' you say out loud.",
                2000);

            NaturalPrint("Relaxing, you close your eyes and let the warmth of the fire calm you.",
                1500);

            NaturalPrint("You're exhausted, although you don't seem to remember why.");

            NaturalPrint("You realize you haven't eaten all day; you're starving." +
                         " When was the last time you ate?",
                newLineDelay: 3000);


            NaturalPrint(
                "Hunger overcomes curiosity. You open your eyes and see a hiking sack on the ground to your right.",
                0);
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
            var campfireFirstResponse = null as string;

            while (campfireFirstResponse == null)
            {
                campfireFirstResponse = Console.ReadLine();
            }

            campfireFirstResponse = Regex.Replace(campfireFirstResponse, @"[^\w]", "");

            if (campfireFirstResponse!.Contains("look"))
            {
                NaturalPrint("You decide to ruffle through the hiking sack.",
                    newLineDelay: 0);

                NaturalPrint(".....");

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You should've just gone to sleep.");
                Console.ResetColor();

                Console.WriteLine();
            }
            
            if (campfireFirstResponse!.Contains("sleep"))
            {
                NaturalPrint("You decide to get some sleep, hoping that things will make more sense in the morning.");

                NaturalPrint("You lie down near the fire and let the warmth and the sound of crackling wood lull you to sleep.");

                NaturalPrint("You wake up to the sound of birds singing, and the sun is shining through the trees.");

            NaturalPrint(@"""Restart"" ?");

            var restart = null as string;

            while (restart == null)
            {
                restart = Console.ReadLine();
            }

            if (restart.Contains('y'))
            {
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

                NaturalPrint("The fire feels familiar.");
                Thread.Sleep(20000);
            }
        }

        private static string NaturalPrint(string line, int newLineDelay = 1000, int endDelay = 500)
        {
            foreach (var word in line)
            {
                switch (word)
                {
                    case '.':
                    case '!':
                    case '?':
                        Console.Write(word);
                        Thread.Sleep(endDelay);
                        break;
                    case ',':
                    case ';':
                        Console.Write(word);
                        Thread.Sleep(250);
                        break;
                    default:
                        Console.Write(word);
                        Thread.Sleep(50);
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Thread.Sleep(newLineDelay);

            return line;
        }
    }
}