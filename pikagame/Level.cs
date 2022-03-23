using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pikagame
{
    public static class Level
    {
        public static void Level1()
        {
            Console.WriteLine("This should be easy.");
            Thread.Sleep(2000);
            Console.WriteLine("anVzdCBhIGxpdHRsZSBtYXRoIHRlc3Q6NzQqOT0/");
            while (true)
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 666)
                {
                    Console.Clear();
                    Console.WriteLine("Good.");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again...");
                }

            }

        }
        public static void Level2()
        {
            Console.Clear();
            Console.WriteLine("Let's try something harder this time");
            Thread.Sleep(2000);
            Console.WriteLine(@"   ▄▄▄▄▄▄▄  ▄     ▄▄  ▄▄ ▄▄▄▄▄▄▄  
   █ ▄▄▄ █ ▀█▄█▀ ▄ ▄  ▄  █ ▄▄▄ █  
   █ ███ █ ▀▀▄▀▄▄▄▄▀▀█▄█ █ ███ █  
   █▄▄▄▄▄█ █ █ ▄▀█▀█ █ ▄ █▄▄▄▄▄█  
   ▄▄▄▄▄ ▄▄▄▄▄ █▀▄█ ▄▀█▀▄ ▄ ▄ ▄   
   ▄█▀██ ▄▀██ ▄▄  ▀▀▄▄▀ ▄▀███ ▀▀  
   ▀█▀ ▀█▄▄ █▀█  ▀ ▀▄ █▀█▀▀▀▀▄▀▀  
   ▀▀█ ▄█▄▄▀▄█ ▀███▄ █▀█▀█▀█▀█▀▀  
    ▀██▄▀▄▄  ▀ █▀▄ ▀▄ █▀  █▀▀▄▄▄  
   █ █▄▄▀▄▀ ▀█▄▄  ▄▀▀▄▀█▀▀███ ▀▀  
   █  ▀ ▀▄██▄██  ▀▀▀▄▄▀██▄▄██▄▀▄  
   ▄▄▄▄▄▄▄ ██▀ ▀██▄▀ █▄█ ▄ █▀ ▀▀  
   █ ▄▄▄ █ ▄█  █▀▄▀▀▄▀▀█▄▄▄█▀ ▄   
   █ ███ █ █▄▄▄▄  ▄█▀█▀  ▄▄▄  █▀  
   █▄▄▄▄▄█ █▄ █  ▀█▀▄▀▄▀█▄█▄█▄▀   ");
            while (true)
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 7355608)
                {
                    Console.Clear();
                    Console.WriteLine("Good.");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again...");
                }
            }
        }
        public static void Level3()
        {
            Console.Clear();
            Console.WriteLine("Oh, this one is gonna be tough...\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine(@"Netrunners are savvy hackers, but with a cybernetically augmented
interface system implanted into their body. Using their brain-computer
interface implants, they roam the Internet, looking for systems to hack
and information to sell to fixers. Although anyone can enter the Net (also
known as cyberspace), most people can't use the Menu. The Menu is a 
group of Applications (Apps) that are Interface programs that allows a
Netrunner to Locate Remote, Run Software, Control Remote, LDL Link,
Load, Create and Delete.");
            Console.WriteLine("8/1\n4/5\n4/28\n1/2\n1/1\n8/9\n4/12");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "LifeNet")
                {
                    Console.Clear();
                    Console.WriteLine("Good.");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again...");
                }
            }
        }
    }
}
