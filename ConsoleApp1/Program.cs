using ConsoleApp1.Controller;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!^___^!!!");

            MainMeun mainMeun = new();
            while (!mainMeun.IsExitGame)
            {
                mainMeun.ShowMenu();
            }


        }
    }
}
