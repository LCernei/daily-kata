using System;

namespace DailyKata
{
    public class StringCalculatorKata
    {
        public static double Calculate(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input == "")
            {
                throw new ArgumentException("Empty String", "input");
            }

            if (input.Trim() == "")
            {
                throw new ArgumentException("String has only whitespace", "input");
            }
            
            
            input.Replace(" ", "");
            double result = 0;

            char separator;
            if (input.Contains("\n"))
                separator = input[0];
            else
                separator = ',';

            string[] substrings = input.Split(separator);
            foreach (var item in substrings)
            {
                if (Double.TryParse(item, out double number))
                {
                    if (number < 0)
                    {
                        throw new ArgumentException("Negative numbers not supported", "input");
                    }
                    result += number;
                }
            }

            return result;
        }
    }
}
