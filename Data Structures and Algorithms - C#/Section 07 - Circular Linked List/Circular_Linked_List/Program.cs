namespace Circular_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<int> circularLinkedList = new CircularLinkedList<int>();

            circularLinkedList.AddLast(1);
            circularLinkedList.AddLast(2);
            circularLinkedList.AddLast(3);
            circularLinkedList.AddLast(4);
            circularLinkedList.AddLast(5);

            //circularLinkedList.AddFirst(0);
            //circularLinkedList.AddAny(20, 2);

            //circularLinkedList.RemoveFirst();
            //circularLinkedList.RemoveLast();
            circularLinkedList.RemoveAny(4);

            circularLinkedList.Display();
        }
    }
}
