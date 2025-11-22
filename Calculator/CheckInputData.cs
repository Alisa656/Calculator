using System;


namespace Calculator
{
    internal class CheckInputData
    {
        public static double ConvertDataToDouble(string num, out string message)
        {

            try
            {
                message = null;
                return double.Parse(num);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return 0;

            }

        }

        public static char ConvertDataToChar(string num, out string message)
        {

            try
            {
                message = null;
                return char.Parse(num);
            }
            catch (Exception ex)
            {
                message = ex.Message;

                return '0';

            }

        }
    }
}
