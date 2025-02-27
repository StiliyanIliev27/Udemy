namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            //list.AddLast(3);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(6);

            list.InsertSorted(5);
            list.InsertSorted(60);
            list.InsertSorted(2);
            list.InsertSorted(1);

            list.Display();

            //Console.WriteLine("Removed element: " + list.RemoveLast());
            //Console.WriteLine("Removed element: " + list.RemoveAny(2));
            //list.Display();

            Console.WriteLine("Index of searched element: " + list.Search(5));
        }
    }
}
