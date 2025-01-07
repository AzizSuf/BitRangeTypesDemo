using BitRangeTypes;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BitRangeTypesTest")]

namespace BitRangeTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UBit<BitCount1> data1 = new();
            SBit<BitCount5> data2 = new();

            data1 = 1;
            data2 = -14;

            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }
    }
}
