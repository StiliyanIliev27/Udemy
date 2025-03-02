namespace ShellSort
{
    internal class Program
    {
        public static int[] ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;

            while(gap > 0)
            {
                for(int i = gap; i< arr.Length; i++) 
                {
                    int temp = arr[i];
                    int j = i - gap;

                    while(j >= 0 && arr[j] > temp)
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }

                    arr[j + gap] = temp;
                }       
                gap /= 2;
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
            int[] arr = { 13, 124, 50, 34, 2 };

            ShellSort(arr);

            PrintArray(arr);
        }
    }
}
