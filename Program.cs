using CSharp.CSharp8;
using System;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await new CSharp8Runner().Run();
        }
    }
}
