namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Display();

            list.Add(3);
            list.Add(4);
            list.Display();
        }
    }
}
