namespace _01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\b(?<!\.|\-|_)([a-zA-Z][\w-.]+\@[A-Za-z-]+)(\.[a-zA-Z-]+)+\b");
            var matches = regex.Matches(text);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
