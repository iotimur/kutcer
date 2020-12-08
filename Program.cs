using System;

namespace bikvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the coefficients(целые числа)");
            string n1, n2, n3;
            n1 = Console.ReadLine();
            n2 = Console.ReadLine(); 
            n3 = Console.ReadLine();
            int a, b, c;
            bool result1 = int.TryParse(n1, out a);
            bool result2 = int.TryParse(n2, out b);
            bool result3 = int.TryParse(n3, out c);
            if ((result1 == true) & (result2 == true) & (result3 == true))
            {
                int d = b * b - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b - Math.Sqrt(d)) / 2 * a;
                    double x2 = (-b + Math.Sqrt(d)) / 2 * a;
                    if (x1 > 0)
                    {
                        
                        Console.WriteLine("Корни  :");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(-Math.Sqrt(x1) + "; " + Math.Sqrt(x1));
                        Console.ResetColor();
                    }
                    if (x2 > 0)
                    {
                        
                        Console.WriteLine("Корни  :");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(-Math.Sqrt(x2) + "; " + Math.Sqrt(x2));
                        Console.ResetColor();
                    }

                }
                else if (d == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No solution");
                    Console.ResetColor();
                }
            }
            else
                Console.WriteLine("enter again");






        }
    }
}
