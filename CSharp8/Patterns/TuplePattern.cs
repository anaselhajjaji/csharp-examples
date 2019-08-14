using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8.Patterns
{
    class TuplePattern : IRunner
    {
        public string Name => "Tuple pattern";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            Console.WriteLine($"{ RockPaperScissors("rock", "scissors") }");
        }

        public static string RockPaperScissors(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };
    }
}
