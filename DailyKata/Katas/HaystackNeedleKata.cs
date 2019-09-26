using System;

namespace DailyKata
{
    public class HaystackNeedleKata
    {
        public static string FindNeedle(object[] haystack)
        {
            if (haystack == null)
            {
                throw new ArgumentNullException("haystack");
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                object item = haystack[i];
                string needle = "needle";

                if (item != null && item.GetType() == needle.GetType() && (string)item == needle)
                    return "found the needle at position " + i;
            }

            return "needle not found";
        }
    }
}
