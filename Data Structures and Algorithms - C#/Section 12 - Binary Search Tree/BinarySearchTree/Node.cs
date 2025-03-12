namespace BinarySearchTree
{
    public class Node<T>
    {
        public Node(T element, Node<T> left, Node<T> right)
        {
            Element = element;
            Left = left;
            Right = right;
        }
        public T Element { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

    }
}
