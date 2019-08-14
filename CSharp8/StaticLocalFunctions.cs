using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class StaticLocalFunctions : IRunner
    {
        public string Name => "Static local functions";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            int y = 5;
            int x = 7;
            Console.WriteLine($"Call to static local function returns { Add(x, y) }");

            static int Add(int left, int right) => left + right;
        }
    }
}
