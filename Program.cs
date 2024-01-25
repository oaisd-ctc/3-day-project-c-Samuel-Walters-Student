using System;
using System.Linq.Expressions;
public class Program
{
    public static void Main(string[] args)
    {
        int numberOfPlayers = 1;
        bool loop = true;
        while (loop == true)
        {

            Console.Clear();
            Console.WriteLine("█▀▀▀   ▀█▀   █     █    █     █            ");
            Console.WriteLine("█▄▄▄    █    █     █     ▀▄▄▄▀     ██  ██  ");
            Console.WriteLine("   █    █    █     █       █               ");
            Console.WriteLine("▄▄▄█   ▄█▄   █▄▄   █▄▄     █      ▀▄▄▄▄▄▄▀ ");
            Console.WriteLine("                                           ");
            Console.WriteLine("█▀▀▀█  ▄▀▀▄  █  █  █   █▀▀ ▀▀█▀▀ ▀▀█▀▀ █▀▀ ");
            Console.WriteLine("█▄▄▄█  █  █  █  █  █   █     █     █   █   ");
            Console.WriteLine("█▀▄    █  █  █  █  █   █▀▀   █     █   █▀▀ ");
            Console.WriteLine("█  ▀▄   ▀▀    ▀▀   █▄▄ █▄▄   █     █   █▄▄ ");
            Console.WriteLine();
            Console.WriteLine($"        press the < or > arrow keys ");
            Console.WriteLine($"        to change nummber of players");
            Console.WriteLine($"                    <{numberOfPlayers}>       ");
            Console.WriteLine("           press enter to start             ");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key.ToString() == "RightArrow")
            {
                Console.WriteLine("right");
                numberOfPlayers++;
            }
            else if (cki.Key.ToString() == "LeftArrow" && numberOfPlayers > 1)
            {
                Console.WriteLine("left");
                numberOfPlayers--;
            }
            else if (cki.Key.ToString() == "Enter")
            {
                Console.WriteLine("enter");
                break;
            }
            else
            {
                Console.WriteLine("can't go below 1");
                Console.ReadKey();
            }
        }
        Console.Clear();
        int randnum = new Random().Next(1, 7);
        Console.WriteLine(randnum);
        bool[] Isdead = bool[numberOfPlayers - 1];
    } 
    //     _
    //    /@\\  
    // |-------|
    // |    /  |
    // |       |
    // |       |
}