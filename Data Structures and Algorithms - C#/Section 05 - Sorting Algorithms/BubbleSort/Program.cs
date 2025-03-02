namespace BubbleSort
{
    internal class Program
    {
        public static int[] BubbleSort(int[] arr)
        {
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }   
            }

            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("Array: ");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 13, 134, 312, 50, 2, 58 };

            BubbleSort(arr);

            PrintArray(arr);
        }
    }
}
