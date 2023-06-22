using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{

    interface Im
    {

    }

    public abstract class Imd
    {

    }

    public class StringPrograms
    {

        public static void ReverseString(string input)
        {
           
            //Space: O(n), Time: O(n)
            StringBuilder reversedString = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            Console.WriteLine(reversedString);
        }

        public static string ReverseStringUsingRecursion(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            string substr = str.Substring(1);
            char c = str[0];

            return ReverseStringUsingRecursion(str.Substring(1)) + str[0];
        }

        public static bool IsPalindrome(string input)
        {
            //space: O(1), Time: O(n)
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;

            #region my approach
            //space: O(1), Time: O(n)
            //StringBuilder reversedString = new StringBuilder();
            //bool isPalindrome = true;

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString.Append(input[i]);
            //}

            //for (int i = 0; i < reversedString.Length; i++)
            //{

            //    if (input[i] != reversedString[i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome);
            #endregion
        }

        public static void ReverseTheOrderOfString(string input)
        {
            //Space: O(n), Time: O(n)
            string[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder reversedString = new StringBuilder();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedString.Append(array[i]);
                reversedString.Append(" ");
            }

            Console.WriteLine(reversedString);
        }

        public static void ReverseEachWordInString(string input)
        {
            //Space: O(n), Time: O(n)
            string[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder reversedString = new StringBuilder();

            for (int i = 0; i <= array.Length - 1; i++)
            {
                string word = array[i];

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedString.Append(word[j]);
                }

                reversedString.Append(" ");
            }

            Console.WriteLine(reversedString);
        }

        public static void CountEachOccurancesInString(string input)
        {
            //Space: O(1), Time: O(n)
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (dictionary.ContainsKey(input[i]))
                    {
                        dictionary[input[i]]++;
                    }
                    else
                    {
                        dictionary.Add(input[i], 1);
                    }
                }
            }

            foreach (var c in dictionary)
            {
                Console.WriteLine($"{c.Key} - {c.Value}");
            }
        }

        public static void RemoveDuplicateCharactersFromString(string input)
        {
            //Space: O(n), Time: O(m) where m is the number of unique characters in the input string.
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }

        public static void FindAllPossibleSubStrings(string input)
        {
            //Space: O(n^2), Time: O(n^3)
            List<string> substrings = new List<string>();

            for (int start = 0; start < input.Length; start++)
            {
                for (int end = start + 1; end <= input.Length; end++)
                {
                    string substring = input.Substring(start, end - start);
                    substrings.Add(substring);
                }
            }
        }
    }
}
