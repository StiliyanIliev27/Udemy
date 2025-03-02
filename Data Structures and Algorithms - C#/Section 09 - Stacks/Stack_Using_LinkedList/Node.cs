namespace Stack_Using_LinkedList
{
    public class Node<T>
    {
        public T element;
        public Node<T> next;
        public Node(T element, Node<T> next)
        {
            this.element = element;
            this.next = next;
        }
    }
}
