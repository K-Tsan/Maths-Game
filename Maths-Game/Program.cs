using System;
using System.ComponentModel.Design;
using Maths_Game;

namespace Maths_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Menu();
            var option = menu.runMenu();
            Console.WriteLine($"{option} has been picked.");
            Console.WriteLine("Press any button to close");
            Console.ReadKey();

        }
    }
}
