using System;
using System.IO;
using System.Collections.Generic;

namespace CycleDetection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var inputStrings = File.ReadAllLines(args[0]);

            foreach (var inputString in inputStrings)
            {
                var inputArray = inputString.Split(' ');
                var inputLength = inputArray.Length;

                // Alternative: make a dictionary
                var dict = new Dictionary<string, int>();

                var i = 0;
                var entry = inputArray[i];

                // Keep putting numbers into the dictionary until we hit a duplicate.
                while (!dict.ContainsKey(entry))
                {
                    dict.Add(entry, i);
                    i++;
                    entry = inputArray[i];
                }

                // The variable i should now be the first element of the cycle.
                int firstEntry = dict[entry];

                var outputList = new List<string>();
                for (int j = firstEntry; j < i; j++)
                {
                    outputList.Add(inputArray[j]);
                }
                    
                Console.WriteLine(string.Join(" ",outputList));
            }
        }
    }
}
