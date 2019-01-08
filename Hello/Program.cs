using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            ValueTypes();

            for (; ; )
            {
                Greetings();
                CheckAge();
                ResetSettings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("mainnt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Reset settings to default
        /// </summary>
        private static void ResetSettings()
        {
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }

        /// <summary>
        /// Check given age
        /// </summary>
        private static void CheckAge()
        {
            Console.Write("Podaj swój wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Jesteś pełnoletni.");
            }
            else if (!result)
            {
                Console.WriteLine("Podałeś niepoprawny wiek.");
            }
            else
            {
                Console.WriteLine("Niestety nie jesteś pełnoletni.");
            }
        }
        
        /// <summary>
        /// Print given name to console
        /// </summary>
        private static void Greetings()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
