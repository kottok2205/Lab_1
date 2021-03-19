using System;

namespace Lab_1_2_2_
{
    delegate double Task_1(double a, double b, double c);
    delegate double Task_2(double x, double y);
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            //Завдання 1
            Console.WriteLine("Завдання 1");
            Task_1 task_1 = delegate (double a, double b, double c)
            {
                return (a + b + c) / 3;
            };
            Console.WriteLine(task_1(35, 5.78, 14.7));
            Console.ReadLine();
            //Завдання 2
            Console.WriteLine("Завдання 2");
            Console.Write("Введіть яку дію ви хотіли б зробити(+,-,*,/):");
            string oper = Console.ReadLine();
            Console.Write("Введіть перше число:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число:");
            double y = Convert.ToDouble(Console.ReadLine());
            Task_2 task_2;
            if (oper == "+")
            {
                task_2 = (x, y) => { return x + y; };
                Console.WriteLine(task_2(x,y));
            }
            else if (oper == "-")
            {
                task_2 = (x, y) => { return x - y; };
                Console.WriteLine(task_2(x, y));
            }
            else if (oper == "*")
            {
                task_2 = (x, y) => { return x * y; };
                Console.WriteLine(task_2(x, y));
            }
            else if (oper == "/")
            {
                if (y != 0)
                {
                    task_2 = (x, y) => { return x / y; };
                    Console.WriteLine(task_2(x, y));
                }
                else
                {
                    Console.WriteLine("Ділити на нуль неможна");
                }
            }
            else
            {
                Console.WriteLine("Введіть: \"+\",\"-\",\"*\",\"/\"");
            }
            //Завдання 3
            Console.WriteLine("Завдання 3");
        }
    }
}
