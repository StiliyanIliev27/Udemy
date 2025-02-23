using System.Reflection.Metadata;

namespace BinarySearch
{
    internal class Program
    {
        public static int SearchIterative(int[] arr, int searchValue)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                
                if(arr[mid] == searchValue)
                {
                    return mid;
                }
                else if (arr[mid] > searchValue)
                {
                    right = mid - 1;
                }
                else if (arr[mid] < searchValue)
                {
                    left = mid + 1;
                }
            }
            return -1;
        }


        public static int SearchRecursive(int[] arr, int searchValue, int left, int right)
        {
            if(left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;

                if (searchValue == arr[mid])
                {
                    return mid;
                }
                else if (searchValue < arr[mid])
                {
                    return SearchRecursive(arr, searchValue, left, mid - 1);
                }
                else if (searchValue > arr[mid])
                {
                    return SearchRecursive(arr, searchValue, mid + 1, right);
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 25, 40, 55, 70 };
            int searchValue = 25;

            //int index = SearchIterative(arr, searchValue);
            int index = SearchRecursive(arr, searchValue, 0, 4);

            if(index < 0)
            {
                Console.WriteLine("Not found!");
            }
            else
            {
                Console.WriteLine($"Iterative search index of {searchValue} in the array is: {index}");
            }
        }
    }
}
