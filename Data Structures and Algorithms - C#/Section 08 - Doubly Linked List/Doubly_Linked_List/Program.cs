namespace Doubly_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> doublyLinkedList = new();

            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);
            doublyLinkedList.AddLast(4);
            doublyLinkedList.AddLast(5);

            doublyLinkedList.AddFirst(0);
            doublyLinkedList.AddAny(40, 4);

            doublyLinkedList.RemoveFirst();
            doublyLinkedList.RemoveLast();
            doublyLinkedList.RemoveAny(3);

            doublyLinkedList.Display();
        }
    }
}
