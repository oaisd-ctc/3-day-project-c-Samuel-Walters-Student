using System;
using System.Linq.Expressions;
public class Program
{
    public static int numberOfPlayers = 2;
    public static int alivePlayers  = numberOfPlayers+ 1;
    public static void Main(string[] args)
    {
        TitleScreen();
        Directions();
        Game();
    }



    //     _
    //  __/@\\__  
    // |-------|
    // |*    # |
    // | SILLY |
    // | #   * |
    // |     # |
    // |_______|


    public static void Directions()
    {

    }
    public static void Game()
    {

        int sillyNummber = 5;
        bool[] players = new bool[numberOfPlayers];
        Console.Clear();
        while (alivePlayers > 1)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                int randnum = new Random().Next(1, 7);
                if (players[i])
                {
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Player " + (i + 1));
                    Console.WriteLine("press any key to risk it all");
                    Console.WriteLine("");
                    Console.WriteLine("     _");
                    Console.WriteLine("  __/@\\__ ");
                    Console.WriteLine(" |-------|");
                    Console.WriteLine(" |*    # |");
                    Console.WriteLine(" | SILLY |");
                    Console.WriteLine(" | #   * |");
                    Console.WriteLine(" |     # |");
                    Console.WriteLine(" |_______|");
                    Console.ReadKey();


                    if (randnum == sillyNummber)
                    {
                        players[i] = true;
                        diescreen();
                        Thread.Sleep(2000);
                        alivePlayers--;
                    }
                    else
                    {
                        Console.WriteLine(" you live to silly another day");
                        Thread.Sleep(1000);

                    }





                }

            }
        }
        for (int i = 0; i < numberOfPlayers; i++){
        if (alivePlayers == 1 && players[i])
        {

            Console.Clear();
            Console.WriteLine("congradulatons player "+ (i-1)+ " you are the last unsillyed YAY!");
        }
        else if(alivePlayers == 0)
        {
            Console.Clear();
            Console.WriteLine("everyone got silly you got the bad end");
        }
        }

    }
    public static void TitleScreen()
    {

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
            else if (cki.Key.ToString() == "LeftArrow" && numberOfPlayers > 2)
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
                Console.WriteLine("invalid input");
                Console.ReadKey();
            }



        }
    }
    public static void diescreen()
    {
        
        Console.WriteLine("             _________");
        Console.WriteLine("            |         |");
        Console.WriteLine("            |  R.I.P  |");
        Console.WriteLine("            |   got   |");
        Console.WriteLine("     {@}    |too silly|");
        Console.WriteLine("______|_____|_________|_________");
    }















}