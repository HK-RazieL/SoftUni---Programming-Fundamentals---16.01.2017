namespace _02.Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var escape = Regex.Escape("@");
            var message = new Regex(@"(\d+)\s(<->)\s([0-9A-Za-z]+)");
            var broadcast = new Regex(@"([^\d]+)(\s<->\s)([0-9A-Za-z]+)");
            var messageStore = new Dictionary<string, string>();
            var broadcastStore = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                var matchMessage = message.Match(input);
                var matchBroadcast = broadcast.Match(input);

                var leftHalfMessage = matchMessage.Groups[1].Value;
                var rightHalfMessage = matchMessage.Groups[3].Value;
                var leftHalfBroadcast = matchBroadcast.Groups[1].Value;
                var rightHalfBroadcast = matchBroadcast.Groups[3].Value;

                var codeReversed = new string(leftHalfMessage.Reverse().ToArray());
                string reversedCase = new string(rightHalfBroadcast.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                                              char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

                if (message.IsMatch(input))
                {
                    if (!messageStore.ContainsKey(codeReversed))
                    {
                        messageStore[codeReversed] = rightHalfMessage;
                    }
                    else if (messageStore.ContainsKey(codeReversed))
                    {
                        messageStore[codeReversed] = rightHalfMessage;
                    }
                }

                if (broadcast.IsMatch(input))
                {
                    if (!broadcastStore.ContainsKey(leftHalfBroadcast))
                    {
                        broadcastStore[reversedCase] = leftHalfBroadcast;
                    }
                    else if (broadcastStore.ContainsKey(leftHalfBroadcast))
                    {
                        broadcastStore[reversedCase] = leftHalfBroadcast;
                    }
                }               
                
            }

            Console.WriteLine("Broadcasts:");
            foreach (var broadcasts in broadcastStore)
            {
                Console.WriteLine($"{broadcasts.Key} -> {broadcasts.Value}");
            }

            Console.WriteLine("Messages:");
            foreach (var messages in messageStore)
            {
                Console.WriteLine($"{messages.Key} -> {messages.Value}");
            }
        }
    }
}
