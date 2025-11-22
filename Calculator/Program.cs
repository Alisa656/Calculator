using System;



namespace Calculator
{
    internal class Program
    {
        static public void Main()
        {
            bool restart = true;
            while (restart)
            {
                restart = false;

                double m;
                double n;
                double op;

                m = GetDoubleData("Введите первое число");
                op = GetCharData("Введите знак операции (+, -, *, /)");
                n = GetDoubleData("Введите второе число");
                double result = Calculations.Calc(m, n, (char)op);
                Console.WriteLine($"{result}");
                Console.WriteLine("Начать заново?(да/нет)");
                if (Console.ReadLine().ToLower() == "да")
                {
                    restart = true;
                    continue;
                }
                else 
                {
                    restart = false;
                    continue;
                    
                }
                
            }



        }

        public static double GetDoubleData(string inputMessage)
        {


            Console.WriteLine(inputMessage);

            string message;

            double result = CheckInputData.ConvertDataToDouble(Console.ReadLine(), out message);

            Console.WriteLine(message);


            return result;

        }
        public static double GetCharData(string inputMessage)
        {


            Console.WriteLine(inputMessage);

            string message;

            char result = CheckInputData.ConvertDataToChar(Console.ReadLine(), out message);

            Console.WriteLine(message);


            return result;


        }
    }
}
