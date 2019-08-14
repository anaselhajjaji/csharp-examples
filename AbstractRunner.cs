using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    abstract class AbstractRunner : IRunner
    {
        public abstract string Name { get; }

        protected abstract IRunner[] Runners { get; }

        public async Task Run()
        {
            foreach (var runner in Runners)
            {
                await runner.Run();
            }
        }
    }
}
