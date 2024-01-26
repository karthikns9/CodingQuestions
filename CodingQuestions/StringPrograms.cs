using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
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

        public static void CountNumberOfWords(string input)
        {
            //Trim whitespace from beginning and end of string
            input = input.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            if (input == "")
                return;

            //Ensure there is only one space between each word in the passed string
            while (input.Contains("  "))
                input = input.Replace("  ", " ");

            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int length =  words.Length;
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

        public static bool CheckAnagram(string input1, string input2)
        {
            ////step 1  
            //char[] char1 = input1.ToLower().ToCharArray();
            //char[] char2 = input2.ToLower().ToCharArray();

            ////Step 2  
            //Array.Sort(char1);
            //Array.Sort(char2);

            ////Step 3  
            //string NewWord1 = new string(char1);
            //string NewWord2 = new string(char2);

            ////Step 4  
            ////ToLower allows to compare the words in same case, in this case, lower case.  
            ////ToUpper will also do exact same thing in this context  
            //if (NewWord1 == NewWord2)
            //{
            //    Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            //}
            //else
            //{
            //    Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            //}

            if (input1.Length != input2.Length)
            {
                return false;
            }

            string s1 = input1.ToLower();
            string s2 = input2.ToLower();

            for (int i = 0; i < s1.Length; i++)
            {
                if (!s2.Contains(s1[i]))
                {
                    return false;
                }
            }

            return true;
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

        public static void HighestOccuredCharInString(string input)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
            var x = input.GroupBy(x => x).Select(x => x.Count());
            var mostFrequentChar = input.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault();

            var character = dic.OrderByDescending(x => x.Value).Select(x => x.Key).FirstOrDefault();

            //char mostFrequentChar = default;
            //int max = 0;

            //foreach (var c in dic) { 
                
            //    if(c.Value > max)
            //    {
            //        mostFrequentChar = c.Key;
            //        max = c.Value;
            //    }
            //}
            //Console.WriteLine($"Most frequent Character is {mostFrequentChar} and its value is {max}");
        }

        public static bool CheckIfStringHasUniqueCharacters(string input)
        {
            //var a = input.GroupBy(x => x).Where(x => x.Count() > 1);

            //if(a.Any())
            //{
            //    return false;
            //}

            string unique = string.Empty;
            foreach (var x in input)
            {
                if (unique.Contains(x))
                {
                    return false;
                }
                else
                {
                    unique += x;
                }
            }

            //Dictionary<char, int> d = new Dictionary<char, int>();

            //foreach (char c in s)
            //{
            //    if (d.ContainsKey(c))
            //        return false;
            //    else
            //        d.Add(c, 1);
            //}
            //return true;

            return true;
        }
    }
}
