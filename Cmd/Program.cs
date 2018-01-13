namespace Cmd
{
    using Hexadecimal;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var guid = Guid.NewGuid();

            string lower = HexConverter.FromBytes(guid.ToByteArray());
            string upper = HexConverter.FromBytes(guid.ToByteArray(), uppercase: true);

            if (lower.ToUpper() != upper)
            {
                ;
                throw new Exception();
            }

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
