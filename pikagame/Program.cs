using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace pikagame
{

    class Program
    {
        static public string GameName = "PikaHack";
        static public string Nickname;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Features.Spooker();
            Features.HaHa();
            Console.WriteLine("Welcome to the " + GameName);
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Say your name: ");
            Nickname = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Okay, {Nickname}, you want to become a netrunner, you came to the right place.");
            Thread.Sleep(5000);
            Console.Clear();
            Level.Level1();
            Level.Level2();
            Level.Level3();
        }
    }
}
