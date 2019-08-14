using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class AsynchronousStreams : IRunner
    {
        public string Name => "Asynchronous streams";

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }
    }
}
