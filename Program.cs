using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════╗");
            Console.WriteLine("║   RandomNumberGenerator   ║");
            Console.WriteLine("╚═══════════════════════════╝");

            bool playAgain = true;

            while (playAgain)
            {
                Game game = new Game();
                game.Start();

                Console.Write("Möchtest du noch einmal spielen? (ja/nein): ");
                string playAgainResponse = Console.ReadLine();

                playAgain = (playAgainResponse.ToLower() == "ja");
            }
        }
    }

    class Game
    {
        private Random random;
        private int Number;
        private int attempts;

        public Game()
        {
            random = new Random();
            Number = random.Next(1, 101);
            attempts = 0;
        }

        public void Start()
        {
            Console.WriteLine("Willkommen!");
            Console.WriteLine("Versuche die Zahl von 1 bis 100 zu erraten.");

            while (true)
            {
                int guess = GetUserGuess();

                attempts++;

                if (guess < Number)
                {
                    Console.WriteLine("Die Zahl ist höher.");
                }
                else if (guess > Number)
                {
                    Console.WriteLine("Die Zahl ist niedriger.");
                }
                else
                {
                    Console.WriteLine($"Glückwunsch! Du hast die Zahl {Number} in {attempts} Versuchen erraten.");
                    break;
                }
            }
        }

        private int GetUserGuess()
        {
            int guess;
            while (true)
            {
                Console.Write("Dein Tipp: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 100 ein.");
                    continue;
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 100 ein.");
                    continue;
                }
                return guess;
            }
        }
    }
}
