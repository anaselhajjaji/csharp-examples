using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    interface IRunner
    {
        public string Name { get;  }

        public void WriteRunnerName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
            Console.ResetColor();
        }

        public Task Run();
    }
}
