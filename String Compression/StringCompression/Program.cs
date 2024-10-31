using System;

namespace StringCompression
{
    public class Program
    {
        public int Compress(char[] chars)
        {
            int write = 0; // Pointer na kung saan isusulat yung mga compressed characters
            int read = 0;  // Pointer para mag-traverse sa array
            int n = chars.Length; // Length ng chars array 

            // Loop habang may natitirang characters na babasahin
            while (read < n)
            {
                char currentChar = chars[read]; // Kumuha ng current character
                int count = 0; // Variable para bilangin ang occurrences ng current character 

                // Bilangin ang occurrences ng current character
                while (read < n && chars[read] == currentChar)
                {
                    read++; // Mag-move sa susunod na character
                    count++; // Increment count
                }

                // Isulat ang character sa tamang position
                chars[write] = currentChar;
                write++; // Increment write pointer 

                // Isulat yung count kung ito ay higit sa 1
                if (count > 1)
                {
                    foreach (char digit in count.ToString())
                    {
                        chars[write] = digit; // Isulat yung digit sa tamang position
                        write++; // Increment write pointer
                    }
                }
            }

            return write; // balik lang yung length ng compressed array
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int newLength = program.Compress(chars);

            Console.WriteLine("Compressed length: " + newLength);
            Console.Write("Compressed characters: ");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(chars[i]);
            }
            Console.WriteLine();
        }
    }
}
