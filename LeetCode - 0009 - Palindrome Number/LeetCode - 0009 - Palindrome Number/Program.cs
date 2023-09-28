using System.Runtime.ExceptionServices;

namespace LeetCode___0009___Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given an integer 'x', return 'true' if x is a palindrome, and 'false' otherwise.

            Example 1:
            Input: x = 121
            Output: true
            Explanation: 121 reads as 121 from left to right and from right to left.
            
            Example 2:
            Input: x = -121
            Output: false
            Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
            
            Example 3:
            Input: x = 10
            Output: false
            Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

            Constraints:
            -231 <= x <= 231 - 1

            Follow up: Could you solve it without converting the integer to a string?
            */

            //// Method 1 - Convert to String

            //// Always an integer
            //var x = -121;
            ////var x = 121;

            //// String method
            //var numberAsString = x.ToString();

            //var charArrayX = numberAsString.ToCharArray();
            //var reverseX = charArrayX.Reverse();
            //var reverseStringX = String.Join("", reverseX);

            //var isPalindrome = String.Equals(numberAsString, reverseStringX);

            //Console.WriteLine("First: {0}, Second: {1}", numberAsString, reverseStringX);
            //Console.WriteLine("Is this a palindrome: {0}", isPalindrome);



            // Method 2 - No convert to string

            // Always an integer
            //var x = -121;
            //var x = 121;
            var x = 321;
            //var x = 0;

            int constructingReverseX = 0;
            int modifiedDigit;

            int deconstructingX = x;

            if ((x < 0) || (x %10 == 0 && x != 0))
            {
                Console.WriteLine("Integer {0} is not a palindrome.", x);
            }
            else
            {
                while (deconstructingX > 0)
                {
                    modifiedDigit = deconstructingX % 10;
                    deconstructingX = deconstructingX / 10;
                    constructingReverseX = constructingReverseX * 10 + modifiedDigit;

                }

                Console.WriteLine("Is {0} a palindrome? This is {1}", x, Int32.Equals(x, constructingReverseX));
            }

        }
    }
}