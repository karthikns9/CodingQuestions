using BenchmarkDotNet.Running;

namespace CodingQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringBuilderReplaceTest>();

            StringPrograms.ReverseString("Hello World");

            StringPrograms.IsPalindrome("liril");

            StringPrograms.ReverseTheOrderOfString("Welcome to Csharp corner");

            StringPrograms.ReverseEachWordInString("Welcome to Csharp corner");

            StringPrograms.CountEachOccurancesInString("hello world");

            StringPrograms.CountNumberOfWords("Welcome to Csharp corner");

            StringPrograms.RemoveDuplicateCharactersFromString("google");

            StringPrograms.CheckAnagram("Silent", "Listen");

            StringPrograms.FindAllPossibleSubStrings("abcd");

            StringPrograms.HighestOccuredCharInString("hello");

            StringPrograms.CheckIfStringHasUniqueCharacters("hello");

            string s = StringPrograms.ReverseStringUsingRecursion("Hello");

            //Array programs
            int[] arr = { 1, 2, 3, 4, 5};
            ArrayPrograms.FindDuplicates(arr);

            //ArrayPrograms.RotateArrayLeft(arr);

            ArrayPrograms.RotateArrayRight(arr);

            int[] arr1 = { 3,2,1,5,4 };
            ArrayPrograms.SecondLargest(arr1);

            int[] arr2 = { 1,2,3,4 };
            ArrayPrograms.TwoIntegersSumToTarget(arr2, 4);


            //Number programs
            NumberProgram.SumOfNumbers(125);
        }
    }
}