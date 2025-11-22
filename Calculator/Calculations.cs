using System;

namespace Calculator
{
    internal class Calculations
    {
        public static double Calc(double m, double n, char op)
        {

            while (true)
            {
                try
                {


                    double res = 0;


                    if (op == '+')
                    {

                        res = m + n;
                        return res;
                    }
                    else if (op == '-')
                    {
                        res = m - n;
                        return res;
                    }
                    else if (op == '*')
                    {
                        res = m * n;
                        return res;
                    }
                    else if (op == '/')
                    {

                        res = m / n;
                        return res;

                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Попробуйте снова");

                      
                        return 0;

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
    }
}
