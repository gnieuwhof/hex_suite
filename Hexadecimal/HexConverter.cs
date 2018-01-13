namespace Hexadecimal
{
    public class HexConverter
    {
        public static string FromBytes(byte[] bytes, bool uppercase = false)
        {
            // Every byte will be converted to two chars in the result.
            var result = new char[bytes.Length * 2];

            for (int i = 0; i < bytes.Length; ++i)
            {
                // Get the byte.
                uint value = uppercase ?
                    Lookup.Uppercase[bytes[i]] :
                    Lookup.Lowercase[bytes[i]];

                // Set the HEX chars.
                int doubleI = (i * 2);
                result[doubleI] = (char)value;
                result[++doubleI] = (char)(value >> 16);
            }

            return new string(result);
        }
    }
}
