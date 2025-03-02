namespace QuickSort
{
    internal class Program
    {
        static void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low + 1;
            int j = high;

            do
            {
                while (i < j && arr[i] <= pivot)
                    i++;
                while (i <= j && arr[j] > pivot)
                    j--;
                if (i <= j)
                    Swap(arr, i, j);
            } 
            while (i < j);

            Swap(arr, low, j);

            return j;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(int[] arr)
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
            int[] arr = { 13, 51, 83, 20, 5 };

            QuickSort(arr, 0, 4);

            PrintArray(arr);
        }
    }
}
