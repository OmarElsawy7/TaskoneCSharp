namespace Task1Calculators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region simple..calculator:
            //simple calculator:
            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first number:");
            string num1 = Console.ReadLine();
            double PNum1 = double.Parse(num1);
            // bool PNum1=double.TryParse(num1 , out double n1 );

            Console.WriteLine("Input the second number:");
            string num2 = Console.ReadLine();
            // bool PNum2 = double.TryParse(num2 , out double n2);
            double PNum2 = double.Parse(num1);
            // Menu:
            bool ValidChoice = false;
            while (!ValidChoice)
            {
                Console.WriteLine("What do you want to do with those numbers ?");
                Console.WriteLine("[A]dd");
                Console.WriteLine("[S]ubtract");
                Console.WriteLine("[M]ultiply");
                string pres = Console.ReadLine().ToUpper();


                switch (pres)
                {
                    case "A":
                        Console.WriteLine($"{PNum1}+{PNum2}= {PNum1 + PNum2}");
                        ValidChoice = true;
                        break;

                    case "S":
                        Console.WriteLine($"{PNum1}-{PNum2}= {PNum1 - PNum2}");
                        ValidChoice = true;
                        break;

                    case "M":
                        Console.WriteLine($"{PNum1}*{PNum2}= {PNum1 * PNum2}");
                        ValidChoice = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option (not A/S/M) ");
                        break;
                }

            }

            Console.WriteLine("Press any key to close  ");
            Console.ReadKey();
            #endregion
        }
    }
}
