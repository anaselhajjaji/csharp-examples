using CSharp.CSharp8.Patterns;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class CSharp8Runner : AbstractRunner
    {
        public override string Name => "C# 8 Features";

        protected override IRunner[] Runners => new IRunner[]
            {
                new ReadonlyMembers(),
                new PatternsRunner(),
                new DefaultInterfaceImplementation(),
                new UsingDeclaration(),
                new StaticLocalFunctions(),
                new NullableReferenceType(),
                new AsynchronousStreams(),
                new IndicesAndRanges()
            };
    }
}
