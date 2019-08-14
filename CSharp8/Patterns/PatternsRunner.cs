using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8.Patterns
{
    class PatternsRunner : AbstractRunner
    {
        public override string Name => "Patterns";

        protected override IRunner[] Runners => new IRunner[]
            {
                new SwitchExpressions(),
                new PropertyPattern(),
                new TuplePattern(),
                new PositionalPattern()
            };
    }
}
