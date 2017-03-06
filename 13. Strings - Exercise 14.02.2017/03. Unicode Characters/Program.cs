namespace _03.UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            foreach (var item in text)
            {
                Console.Write(GetEscapeSequence(item).ToLower());
            }
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
