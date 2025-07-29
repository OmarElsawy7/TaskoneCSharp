using System.Collections.Generic;

namespace session2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simple calculator:
            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first number:");
            string  num1 = Console.ReadLine();
            double PNum1=double.Parse(num1);

            Console.WriteLine("Input the second number:");
            string num2 = Console.ReadLine();
            double PNum2 = double.Parse(num2);
            // Menu:
            Console.WriteLine("What do you want to do with those numbers ?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            string pres = Console.ReadLine();


            switch (pres) 
            {
                    case "A":
                    Console.WriteLine($"{PNum1}+{PNum2}= {PNum1 + PNum2}");
                    break; 

                    case "S":
                    Console.WriteLine($"{PNum1}-{PNum2}= {PNum1 - PNum2}");
                    break;

                    case "M":
                    Console.WriteLine($"{PNum1}*{PNum2}= {PNum1 * PNum2}");
                    break;

                    default:
                    Console.WriteLine("Invalid option (not A/S/M) ");
                    break;
            }

            Console.WriteLine("Press any key to close  ");
            Console.ReadKey();

        }
    }
}
