using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class ArrayBasics
    {
        public static void RotateRight(int[] nums, int k)
        {
            int[] temp = new int[k];
            int n = nums.Length;

            //for (int i =k+1; i < n; i++)
            //{
            //    temp[i - (n-k)] = nums[i];
            //}

            //// Shift the remaining elements to the right
            //for (int i = n - k - 1; i >= 0; i--)
            //{
            //    nums[i + k] = nums[i];
            //}

            //// Move the elements from temp to the beginning of the array
            //for (int i = 0; i < k; i++)
            //{
            //    nums[i] = temp[i];
            //}

            Reverse(nums, 0, n- k - 1);
            Reverse(nums, n-k, n - 1);
            Reverse(nums, 0, n - 1);
        }

        public static void RotateLeft(int[] nums, int k)
        {
            int[] temp = new int[k];
            int n = nums.Length;

            //for (int i = 0; i < k; i++)
            //{
            //    temp[i] = nums[i];
            //}

            //for (int i = k; i < nums.Length; i++)
            //{
            //    nums[i - k] = nums[i];
            //}

            //for (int i = n - k; i < nums.Length; i++)
            //{
            //    nums[i] = temp[i - (n-k)];
            //}

            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n-1);
            Reverse(nums, 0, n-1);
        }

        public static void Reverse(int[] arr, int start, int end)
        {
            while(start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
