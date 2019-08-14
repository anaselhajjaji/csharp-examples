using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class UsingDeclaration : IRunner
    {
        public string Name => "Using Declaration";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            using var disposeImplementer = new DisposeImplementer();
            disposeImplementer.Call();
        }

        class DisposeImplementer : IDisposable
        {
            public void Call()
            {
                Console.WriteLine("Call a method.");
            }

            public void Dispose()
            {
                Console.WriteLine("Dispose Called!");
            }
        }
    }
}
