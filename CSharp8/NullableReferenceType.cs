using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8
{
#nullable enable
    class NullableReferenceType : IRunner
    {
        public string Title { get; set; } // Warning here should be initialized
        public string? Message { get; set; }

        public string Name => "Nullable Reference Type";

        public NullableReferenceType()
        {
            Title = string.Empty;
            Message = "See the class for the usage of the nullable.";
        }

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            Console.WriteLine(Message?.ToLower()); // Warning here Message may be null, so I added '?'
        }
    }
#nullable restore
}
