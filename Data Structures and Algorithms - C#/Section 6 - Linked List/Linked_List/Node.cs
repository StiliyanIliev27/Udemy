namespace Linked_List
{
    public class Node<T>
    {
        public T element;
        public Node<T>? next;

        public Node(T element)
        {
            this.element = element;
            next = null;
        }
    }
}
