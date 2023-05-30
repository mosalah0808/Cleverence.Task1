using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverence.Task1
{
    internal class Algo
    {
        public static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder compressed = new StringBuilder();
            char current = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        compressed.Append(current);
                        compressed.Append(count);
                    }
                    else
                    {
                        compressed.Append(current);
                    }
                    current = input[i];
                    count = 1;
                }
            }

            if (count > 1)
            {
                compressed.Append(current);
                compressed.Append(count);
            }
            else
            {
                compressed.Append(current);
            }

            return compressed.ToString();
        }

        public static string DecompressString(string input)
        {
            StringBuilder decompressed = new StringBuilder();
            int i = 0;
            while (i < input.Length)
            {
                char c = input[i];
                i++;
                if (i >= input.Length || !char.IsDigit(input[i]))
                {
                    decompressed.Append(c);
                    continue;
                }
                int count = 0;
                while (i < input.Length && char.IsDigit(input[i]))
                {
                    count = count * 10 + (input[i] - '0');
                    i++;
                }
                for (int j = 0; j < count; j++)
                {
                    decompressed.Append(c);
                }
            }
            return decompressed.ToString();
        }
    }
}
