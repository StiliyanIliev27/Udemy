namespace InsertionSort
{
    internal class Program
    {
        public static int[] InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int position = i;

                while(position > 0 && arr[position - 1] > temp)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }

                arr[position] = temp;
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
            int[] arr = { 13, 123, 31, 86, 20 };

            InsertionSort(arr);

            PrintArray(arr);
        }
    }
}
