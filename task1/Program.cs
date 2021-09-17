using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуй!{name}");
            Console.ReadLine();

            Console.WriteLine("Упражнение 2.2");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
                double x = a / b;
                Console.WriteLine(x);
            }
            Console.ReadLine();

            Console.WriteLine("Домашнее задание 2.1");
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'я')
            {
                Console.WriteLine('а');
            }
            else
            {
                Console.WriteLine((char)((int)letter + 1));
                Console.ReadLine();

                Console.WriteLine("Домашнее задание 2.2");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    double x = -b / c;
                    Console.WriteLine(x);
                }
                else
                {
                    double D = b * b - 4 * a * c;
                    double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine($"x1={x1}, x2={x2}");
                    Console.ReadLine();
                }
            }
        }
    }
}
