using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class ArrayPrograms
    {
        public static void RotateArrayLeft(int[] arr)
        {
            int length = arr.Length;
            int temp = arr[0];

            for (int i = 0; i < length - 1; i++)
            {
                var value = arr[i + 1];
                arr[i] = arr[i + 1];
            }

            arr[length - 1] = temp;
        }

        public static void RotateArrayRight(int[] arr)
        {
            int length = arr.Length;
            int temp = arr[arr.Length - 1];

            for (int i = length - 1; i > 0; i--)
            {
                var value = arr[i- 1];
                arr[i] = arr[i - 1];
            }

            arr[0] = temp;
        }

        public static void FindDuplicates(int[] arr)
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            List<int> duplicateElements = new List<int>();

            foreach (int num in arr)
            {
                if (!uniqueElements.Add(num))
                {
                    // Duplicate element found
                    duplicateElements.Add(num);
                }
            }

            Console.WriteLine("Duplicate elements in the array:");
            foreach (int num in duplicateElements)
            {
                Console.WriteLine(num);
            }
        }

        public static void SecondLargest(int[] numbers)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }
        }

        public static void TwoIntegersSumToTarget(int[] arr, int target)
        {
            Array.Sort(arr);

            int left = 0;
            int right = arr.Length - 1;
            int count = arr.Length;

            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if ( sum == target)
                {
                    return;
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
    }
}
