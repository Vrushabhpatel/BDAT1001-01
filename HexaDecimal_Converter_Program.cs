using System;

namespace HexaDecimalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vrushabh Patel";

            HexadecimalConverter hexadecimalConverter = new HexadecimalConverter();
            string hexadecimalValue = hexadecimalConverter.ConvertTo(name);
            Console.WriteLine($"{name} as Hexadecimal: {hexadecimalValue}");
            Console.WriteLine($"{name} from Hexadecimal to ASCII: {hexadecimalConverter.ConveryFromHexToASCII(hexadecimalValue)}");
        }
    }
}
