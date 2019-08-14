using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp8.Patterns
{
    class PropertyPattern : IRunner
    {
        public string Name => "Property pattern";

        public async Task Run()
        {
            (this as IRunner).WriteRunnerName();
            await Task.Delay(10); // just to delete the warning

            Console.WriteLine($"Sale tax {ComputeSalesTax(new Address("WA"), 10)}");
        }

        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.75M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };

        public class Address
        {
            public string State { get; }

            public Address(string state)
            {
                State = state;
            }
        }
    }
}
