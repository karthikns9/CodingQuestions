

namespace Sorting
{
    public static class Sort
    {
        //select minimum and swap
        public static void SelectionSort(int[] arr)
        {
            var length = arr.Length;

            for (int i = 0; i <= length - 2; i++)
            {
                int min = i;

                for (int j = i; j <= length - 1; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[min];
                        arr[min] = temp;
                    }
                }
            }
        }

        //push the max to the last by adjacent swaps
        //select max and swap adjacent
        public static void BubbleSort(int[] arr)
        {
            var length = arr.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                int didSwap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swap
                        int temp = arr[j];
                        arr[j] = (arr[j + 1]);
                        arr[j + 1] = temp;
                        didSwap = 1;
                    }
                }

                if (didSwap == 0)
                {
                    break;
                }
            }
        }

        //Take the element & place it in the correct order
        public static void InsertionSort(int[] arr)
        {
            var length = arr.Length;

            for (int i = 0; i <= length - 1; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    //swap
                    int temp = arr[j];
                    arr[j] = (arr[j -1]);
                    arr[j -1] = temp;
                    j--;
                }
            }
        }

        public static void MergeSort(int[] arr, int low, int high)
        {
            if(low >= high)
            {
                return;
            }

            var mid = (low + high) / 2;
            
            MergeSort(arr, low, mid);
            MergeSort(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }


        private static void Merge(int[] arr, int low, int mid, int high)
        {
           List<int> temp = new List<int>();
            var left = low;
            var right = mid + 1;

            while(left <= mid &&  right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            while(left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            for(int i = low; i <= high; i++)
            {
                arr[i] = temp[i -low];
            }
        }
    }
}
