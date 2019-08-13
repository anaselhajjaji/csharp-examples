using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    public class C8 : IRunner
    {
        public async Task Run()
        {
            await new UsingDeclaration().Run();
            await new StaticLocalFunctions().Run();
            await new AsynchronousStreams().Run();
        }
    }
}
