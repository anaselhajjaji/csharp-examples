using CSharp.CSharp8.Patterns;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    public class CSharp8Runner : IRunner
    {
        public async Task Run()
        {
            await new ReadonlyMembers().Run();
            await new PatternsRunner().Run();
            await new DefaultInterfaceImplementation().Run();
            await new UsingDeclaration().Run();
            await new StaticLocalFunctions().Run();
            await new AsynchronousStreams().Run();
        }
    }
}
