using System;
using CalcLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usage
{

    public static class MyClass
    {
        public static void Welcome(this Calc obj)
        {
            Console.WriteLine("Welcome to calculator");
        }
        public static double Avg(this Calc ob, double num1, double num2)
        {
            double result = ((ob.Add(num1, num2)) / 2);
            return result;
        }

    }

    internal class program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("enter first number");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("choose operation");
                Console.WriteLine("1.Add \n2.Sub \n3.Multi \n4.Div");
                int op = int.Parse(Console.ReadLine());
                Calc cal = new Calc();
                cal.Welcome();
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Result after addition is: ", num1, num2, cal.Add(num1, num2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Result after subtraction is: ", num1, num2, cal.Sub(num1, num2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Result after multiplication is: ", num1, num2, cal.Multi(num1, num2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Result after division {0} by {1} is: ", num1, num2, cal.Div(num1, num2));
                            break;
                        }
                     case 5:
                        {
                            Console.WriteLine("average of {0} and {1} =: {2}", num1, num2, cal.Avg(num1, num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation choice!!");
                            break;
                        }
                }
                Console.WriteLine("if wanna contiue press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}

