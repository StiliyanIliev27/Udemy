namespace SelectionSort
{
    internal class Program
    {
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int position = i;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[position])
                    {
                        position = j;
                    }

                    int temp = arr[i];
                    arr[i] = arr[position];
                    arr[position] = temp;
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
            int[] arr = { 12, 53, 17, 92, 10 };

            SelectionSort(arr);

            PrintArray(arr);
        }
    }
}
