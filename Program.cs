using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter User ID:");

            string ID_Number = Console.ReadLine();

            Console.WriteLine("The one next to you is: " + (Convert.ToInt32(ID_Number) + 1));*/

            /*int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; ++i)
                Console.WriteLine(numbers[i]);*/


            Console.WriteLine("Enter a word to check: ");
            string word = Console.ReadLine();
            Console.WriteLine(isPallindrome(word));

        }

        static bool isPallindrome(string word)
        {
            for(int i=0; i<word.Length/2; ++i)
                if(word[i] != word[(word.Length - 1) - i] && Math.Abs(Convert.ToInt32(word[i]) - Convert.ToInt32(word[(word.Length - 1) - i])) != 32 )
                    return false;
            return true;
        }
    }
}
