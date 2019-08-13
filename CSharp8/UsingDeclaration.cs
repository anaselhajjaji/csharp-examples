using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    public class UsingDeclaration : IRunner
    {
        public async Task Run()
        {
            Console.WriteLine("Using Declaration");
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
