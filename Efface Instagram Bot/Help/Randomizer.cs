using System;
using System.Text;

namespace Efface_Instagram_Bot.Help
{
    internal class Randomizer
    {
        static readonly Random r = new Random();

        public static string Parse(string input)
        {
            int start = 0;
            return Parse(input, ref start);
        }
        static string Parse(string input, ref int start)
        {
            var buffer = new StringBuilder();

            while (start < input.Length)
            {
                var token = input[start++];
                switch (token)
                {
                    case '{': buffer.Append(PickRandom(input, ref start)); break;
                    case '}': return buffer.ToString();
                    default: buffer.Append(token); break;
                }
            }
            return buffer.ToString();
        }

        static string PickRandom(string input, ref int start)
        {
            var choices = Parse(input, ref start).Split('|');
            return choices[r.Next(choices.Length)];
        }
    }
}
