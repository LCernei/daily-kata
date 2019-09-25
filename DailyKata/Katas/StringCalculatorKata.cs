using System;

namespace DailyKata
{
    public class StringCalculatorKata
    {
        public static int Calculate(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            if (input == "")
            {
                throw new ArgumentException("Empty String", "input");
            }

            int result = 0;
            string[] substrings = input.Split(',');
            foreach (var item in substrings)
            {
                int number;
                if (Int32.TryParse(item, out number))
                {
                    result += number;
                }
            }

            return result;
        }
    }
}
