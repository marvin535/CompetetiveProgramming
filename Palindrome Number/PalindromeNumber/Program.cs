namespace PalindromeNumber
{
    public class Program
    {
        public bool IsPalindrome(int x)
        {
            // Negative numbers are not palindromes
            if (x < 0) return false;

            // Store the original number
            int original = x;
            int reversed = 0;

            while (x > 0)
            {
                int remainder = x % 10;

                // Check for overflow before reversing
                if (reversed > (int.MaxValue - remainder) / 10)
                {
                    return false; // Overflow will occur
                }

                reversed = (reversed * 10) + remainder;
                x /= 10;
            }

            return original == reversed;
        }
    }
}
