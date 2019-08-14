using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8.Patterns
{
    class PatternsRunner : IRunner
    {
        public async Task Run()
        {
            await new SwitchExpressions().Run();
            await new PropertyPattern().Run();
            await new TuplePattern().Run();
            await new PositionalPattern().Run();
        }
    }
}
