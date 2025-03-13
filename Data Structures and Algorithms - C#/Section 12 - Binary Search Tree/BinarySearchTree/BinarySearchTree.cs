namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        public Node<T>? Root { get; set; }

        public void Insert(Node<T> temproot, T element)
        {
            Node<T> temp = null!;

            while (temproot != null)
            {
                temp = temproot;
                if (AreInstancesEqual(temproot.Element, element))
                {
                    return;
                }
                else if (IsFirstGreaterThanSecond(element, temproot.Element))
                {
                    temproot = temproot.Right;
                }
                else
                {
                    temproot = temproot.Left;
                }
            }

            Node<T> node = new Node<T>(element, null!, null!);
            if (Root != null)
            {
                if (IsFirstGreaterThanSecond(temp!.Element, element))
                {
                    temp.Left = node;
                }
                else
                {
                    temp.Right = node;
                }
            }
            else
            {
                Root = node;
            }
        }

        public Node<T> InsertRecursive(Node<T> temproot, T element)
        {
            if (temproot != null)
            {
                if(IsFirstGreaterThanSecond(temproot.Element, element))
                {
                    temproot.Left = InsertRecursive(temproot.Left, element);
                }
                else
                {
                    temproot.Right = InsertRecursive(temproot.Right, element);
                }
            }
            else
            {
                Node<T> node = new Node<T>(element, null!, null!);
                temproot = node;
            }
            return temproot!;
        }

        public void InOrder(Node<T> temproot)
        {
            if (temproot != null)
            {
                InOrder(temproot.Left);
                Console.Write(temproot.Element + " ");
                InOrder(temproot.Right);
            }
        }

        public void PreOrder(Node<T> temproot)
        {
            if(temproot != null)
            {
                Console.Write(temproot.Element + " ");
                PreOrder(temproot.Left);
                PreOrder(temproot.Right);
            }
        }

        private static bool AreInstancesEqual<T>(T first, T second)
        {
            return EqualityComparer<T>.Default.Equals(first, second);
        }

        private static bool IsFirstGreaterThanSecond<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) > 0;
        }
    }
}
