using Converter.Models;
using System;

namespace Binaryconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vrushabh Patel";

            BinaryConverter binaryConverter = new BinaryConverter();
            string binaryValue = binaryConverter.ConvertTo(name);
            Console.WriteLine($"{name} as Binary: {binaryValue}");
            Console.WriteLine($"{name} from Binary to ASCII: {binaryConverter.ConvertBinaryToString(binaryValue)}");
        }
    }
}
