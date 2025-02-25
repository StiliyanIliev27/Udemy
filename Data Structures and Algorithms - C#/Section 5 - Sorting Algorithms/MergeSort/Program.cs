namespace MergeSort
{
    internal class Program
    {
        public static void MergeSort(int[] arr, int left, int right)
        {       
            if(left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] b = new int[right + 1];
            int i = left;
            int j = mid + 1;
            int k = left;

            while(i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    b[k] = arr[i];
                    i++;            
                }
                else
                {
                    b[k] = arr[j];
                    j++;
                }
                k++;
            }
            while(i <= mid)
            {
                b[k] = arr[i];
                i++;
                k++;
            }
            while(j <= right)
            {
                b[k] = arr[j];
                j++;
                k++;
            }

            for(int x = left; x < right; x++)
            {
                arr[x] = b[x];
            }
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
            int[] arr = { 12, 74, 140, 20, 25 };

            MergeSort(arr, 0, arr.Length - 1);

            PrintArray(arr);
        }
    }
}
