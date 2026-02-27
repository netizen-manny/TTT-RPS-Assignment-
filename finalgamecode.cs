using System;

public class Program
{
    static Random rand = new Random();

    static string[] bibleVerses =
    {
        "Philippians 4:13 - I can do all things through Christ who strengthens me 🤲.",
        "Psalm 23:1 - The Lord is my shepherd; I shall not want🐏.",
        "Jeremiah 29:11 - For I know the plans I have for you, declares the Lord 📖.",
        "Proverbs 3:5 - Trust in the Lord with all your heart❤️.",
        "Romans 8:28 - All things work together for good for those who love God🫂.",
        "Isaiah 41:10 - Do not fear, for I am with you👨‍👩‍👧‍👦.",
        "Matthew 11:28 - Come to me, all who are weary, and I will give you rest💤."
    };

    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- Welcome to Immanuel's Game Console -----");
            Console.WriteLine("----- We hope you enjoy your stay inside the console or forever hold your peace -----");
            Console.WriteLine("1. Naughts and Crosses (PVP)");
            Console.WriteLine("2. Rock Paper Scissors (PVC)");
            Console.WriteLine("3. Exit");
            Console.WriteLine("4. Bible Verse");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    PlayNC();
                    break;

                case "2":
                    PlayRPS();
                    break;

                case "3":
                    Console.WriteLine("Exiting program...");
                    return;

                case "4":
                    ShowBibleVerse();
                    break;

                default:
                    Console.WriteLine("Invalid selection. Press ENTER to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // ------------------ RPS GAME ------------------

    static void PlayRPS()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("Press 1 for Rock, 2 for Paper, 3 for Scissors");
            Console.WriteLine("Press 0 to return to menu");

            int userInput;
            bool valid = int.TryParse(Console.ReadLine(), out userInput);

            if (!valid || userInput < 0 || userInput > 3)
            {
                Console.WriteLine("Invalid input. Press ENTER to try again.");
                Console.ReadLine();
                continue;
            }

            if (userInput == 0)
                return;

            Console.WriteLine("The player chose {ConvertChoice(userInput)}");

            int computerInput = randomNumberGenerator();
            Console.WriteLine("The computer chose {ConvertChoice(computerInput)}");

            if (computerInput == userInput)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (computerInput == 1 && userInput == 2 ||
                     computerInput == 2 && userInput == 3 ||
                     computerInput == 3 && userInput == 1)
            {
                Console.WriteLine("Player wins!");
            }
            else
            {
                Console.WriteLine("Player loses!");
            }

            Console.WriteLine("\nPress ENTER to play again...");
            Console.ReadLine();
        }
    }

    static int randomNumberGenerator()
    {
        return rand.Next(1, 4);
    }

    static string ConvertChoice(int choice)
    {
        if (choice == 1) return "Rock";
        if (choice == 2) return "Paper";
        if (choice == 3) return "Scissors";
        return "Unknown";
    }

    // ------------------ NC CODE ------------------

    static void PlayNC()
    {
        Console.Clear();
        Console.WriteLine("Naughts and Crosses not built yet.");
        Console.WriteLine("Press ENTER to return to menu.");
        Console.ReadLine();
    }

    // ------------------ BIBLE VERSE SYSTEM ------------------

    static void ShowBibleVerse()
    {
        Console.Clear();
        int index = rand.Next(0, bibleVerses.Length);
        Console.WriteLine("📖 Bible Verse of the Moment:\n");
        Console.WriteLine(bibleVerses[index]);
        Console.WriteLine("\nPress ENTER to return to menu.");
        Console.ReadLine();
    }
}
