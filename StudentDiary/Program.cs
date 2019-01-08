using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 0 - 10");

                double mark;
                bool line = double.TryParse(Console.ReadLine(), out mark);

                if (mark == 11)
                {
                    break;
                }

                if (line && mark >= 0 && mark <= 10)
                {
                    diary.AddMark(mark);
                }
                else if (line)
                {
                    Console.WriteLine("Liczba spoza zakresu.");
                }
            }

            Console.WriteLine("Średnia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.ReturnMax());
            Console.WriteLine("Najniższa ocena to: " + diary.ReturnMin());
            Console.ReadKey();
        }
    }
}
