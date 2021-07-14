using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static float mutplier = 1.0f;
        private static float intial_bet = 500;



        static void Main()
        {
            menu();
        }

        static void menu()
        {
            // menu code here 
            main_func();
        }

        static void main_func()
        {
            Console.Clear();
            Console.WriteLine($@"Intial bet {intial_bet} : Multiplier {mutplier}");
            Console.WriteLine("add - add's 100 to intial bet \nset - set custom bet under 10000 \nstart - wait and see!");

            string value = Console.ReadLine();

            if (value == "add")
            {
                Add();
            }
            if (value == "set")
            {
                Set();
            }
            if (value == "start")
            {
                start_func();
            }
        }
        static void Add()
        {
            Console.Clear();
            Console.WriteLine("add");
            Console.WriteLine($"intial bet is {intial_bet}");
            Console.WriteLine($"adding 100 to intial bet, intial bet is {intial_bet + 100}");
            Console.WriteLine("do you want to revert this, if so type n.");
            if (Console.ReadLine() != "n")
            {
                intial_bet += 100;
                menu();
            }
            else
            {
                menu();
            }
        }
        static void Set()
        {
            Console.Clear();
            Console.WriteLine("set");
            Console.WriteLine("enter an amount and this will be added to the intial bet, aslong as the overall total is under 10000 : if you wish to exit to menu type n");
            if (Console.ReadLine() != "n")
            {
                int bet;
                bet = int.Parse(Console.ReadLine());
                if (intial_bet + bet <= 10000)
                {
                    Console.WriteLine($"bet has now been increased to {intial_bet += bet}");
                    Console.ReadLine();
                    menu();
                }
                else
                {
                    Console.WriteLine("Your bet was too high");
                    Console.WriteLine(bet);
                    Console.ReadLine();
                    menu();
                }
            }
            else
            {
                menu();
            }
        }

        static void start_func()
        {
            mutplier = 1.0f;
            Random rand = new Random();
            Console.WriteLine("start");
            mutplier = rand.Next(-100000, 100000);
            Console.WriteLine("Your bet will now be mutiplied by a number between -100000 and 100000");
            float result = intial_bet * mutplier;
            if (result <= 0)
            {
                intial_bet = 0;
            }
            Console.ReadLine();
            menu();
        }
    }
}
