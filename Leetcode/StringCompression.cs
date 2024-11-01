using System;
using System.Text;

public class Program
{
	static int Compress(char[] chars)
	{
		int write = 0;
		int read = 0;
		int n = chars.Length;
		
		while (read < n)
		{
			char currentChar = chars[read];

			int count = 0;
			
			while (Read < n && chars[read] == currentChar)
			{
				read++;
				count++;
			}
			
			chars[write] = currentChar;
			write++;
			
			if (count > 1)
			{
				foreach (char digit in count.ToString())
				{
					chars[write] = digit;
							
					write++;
				}
			}
		}
		
		return write;
	}
	
	static void Main(string[] args)
	{
		char[] arrayOfLetters = new char[] { 'a', 'a', 'b', 'b', 'b', 'c', 'c', 'c' };
		int compressedLength = Compress(arrayOfLetters);
		
		Console.WriteLine($"Compressed Length: {compressedLength}");
                Console.Write("Compressed Array: ");
                for (int i = 0; i < compressedLength; i++)
                {
                     Console.Write(arrayOfLetters[i]);
                }
	}
}