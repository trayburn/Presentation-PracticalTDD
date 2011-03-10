using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PracticalTDD.NoIoCContainer;
using PracticalTDD.Dependencies;

namespace PracticalTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo key = DisplayMenu();
                switch (key.KeyChar)
                {
                    case '1':
                        Console.WriteLine("No IoC Container");
                        Console.WriteLine("================");
                        var demo = new ExistingClass();
                        demo.SendMailToAllUsers();
                        break;
                    case '2':
                        Console.WriteLine("Monster Class");
                        Console.WriteLine("=============");
                        var demo2 = new Monster();
                        demo2.DoSomething();
                        break;
                    case 'q':
                        return;
                }
            }
        }
        private static ConsoleKeyInfo DisplayMenu()
        {
            ConsoleKeyInfo key;
            while (true)
            {
                var validChoices = new char[] { 'q', '1', '2' };

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Practical Test Driven Development");
                Console.WriteLine("=================================");
                Console.WriteLine("  1) No IoC Container");
                Console.WriteLine("  2) Monster Class");
                Console.Write(">>");

                key = Console.ReadKey();
                Console.Clear();
                if (validChoices.Contains(key.KeyChar)) break;
            }
            return key;
        }
    }
}
