using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class DefaultInterfaceImplementation : IRunner
    {
        public async Task Run()
        {
            Console.WriteLine("Readonly members");
            await Task.Delay(10); // just to delete the warning

            var interfaceImplementor = new InterfaceImplentor();
            interfaceImplementor.ImplementThis();
        }

        interface InterfaceWithDefault
        {
            public void DoDefault() => Console.WriteLine("Default Impl Called!");
            

            public void ImplementThis();
        }

        class InterfaceImplentor : InterfaceWithDefault
        {
            public void ImplementThis() => Console.WriteLine("Implemented method Called!");
        }
    }
}
