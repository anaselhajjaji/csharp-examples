using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class IndicesAndRanges : IRunner
    {
        public string Name => "Indices And Ranges";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            Console.WriteLine($"The last word is { words[^1] }"); // writes "dog"

            var quickBrownFox = words[1..4]; // It includes words[1] through words[3]. The element words[4] is not in the range.
            Console.WriteLine($"The range [1..4] is { FormatArrayContent(quickBrownFox) }");

            var lazyDog = words[^2..^0]; // It includes words[^2] and words[^1]. The end index words[^0] is not included
            Console.WriteLine($"The range [^2..^0] is { FormatArrayContent(lazyDog) }");

            var allWords = words[..]; // contains "The" through "dog".
            Console.WriteLine($"The range [..] is { FormatArrayContent(allWords) }");

            var firstPhrase = words[..4]; // contains "The" through "fox"
            Console.WriteLine($"The range [..4] is { FormatArrayContent(firstPhrase) }");

            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Console.WriteLine($"The range [6..] is { FormatArrayContent(lastPhrase) }");

            Range phrase = 1..4;
            var text = words[phrase];
            Console.WriteLine($"The range [1..4] is { FormatArrayContent(text) }");
        }

        static string FormatArrayContent(string[] array)
        {
            string result = "[ ";
            foreach (var item in array)
            {
                result += item + " ";
            }
            result += "]";

            return result;
        }
    }
}
