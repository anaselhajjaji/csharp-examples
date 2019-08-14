using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
    class DefaultInterfaceImplementation : IRunner
    {
        public string Name => "Default Interface Implementation";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            var interfaceImplementor = new InterfaceImplentor();
            interfaceImplementor.ImplementThis();
            
            InterfaceWithDefault interfaceWithDefault = interfaceImplementor;
            interfaceWithDefault.DoDefault();
        }

        interface InterfaceWithDefault
        {
            public void DoDefault() => Console.WriteLine("Default Impl Called!");
            public void ImplementThis();
        }

        class InterfaceImplentor : InterfaceWithDefault
        {
            // Can be extended
            // public void DoDefault() => Console.WriteLine("Default extended and Called!");

            public void ImplementThis() => Console.WriteLine("Implemented method Called!");
        }
    }
}
