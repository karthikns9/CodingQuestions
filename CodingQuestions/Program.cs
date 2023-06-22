namespace CodingQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringPrograms.ReverseString("Hello World");

            StringPrograms.IsPalindrome("liril");

            StringPrograms.ReverseTheOrderOfString("Welcome to Csharp corner");

            StringPrograms.ReverseEachWordInString("Welcome to Csharp corner");

            StringPrograms.CountEachOccurancesInString("hello world");

            StringPrograms.RemoveDuplicateCharactersFromString("hello");

            StringPrograms.FindAllPossibleSubStrings("abcd");

            string s = StringPrograms.ReverseStringUsingRecursion("Hello");

            //Array programs
            int[] arr = { 1, 2, 3, 4, 5};
            ArrayPrograms.FindDuplicates(arr);

            //ArrayPrograms.RotateArrayLeft(arr);

            ArrayPrograms.RotateArrayRight(arr);

            int[] arr1 = { 3,2,1,5,4 };
            ArrayPrograms.SecondLargest(arr1);


            //Number programs
            NumberProgram.SumOfNumbers(125);
        }
    }
}