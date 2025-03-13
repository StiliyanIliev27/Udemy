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

        public void PostOrder(Node<T> temproot)
        {
            if(temproot != null)
            {
                PostOrder(temproot.Left);
                PostOrder(temproot.Right);
                Console.Write(temproot.Element + " ");
            }
        }

        public void LevelOrder()
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            
            Node<T> temproot = Root!;
            Console.Write(temproot.Element + " ");
            queue.Enqueue(temproot);

            while (queue.Any())
            {
                temproot = queue.Dequeue();
                if (temproot.Left != null)
                {
                    Console.Write(temproot.Left.Element + " ");
                    queue.Enqueue(temproot.Left);
                }
                if (temproot.Right != null)
                {
                    Console.Write(temproot.Right.Element + " ");
                    queue.Enqueue(temproot.Right);
                }
            }
        }

        public bool IterativeSearch(T key)
        {
            Node<T> temproot = Root!;
            while (temproot != null)
            {
                if(AreInstancesEqual(temproot.Element, key))
                {
                    return true;
                }
                else if(IsFirstGreaterThanSecond(key, temproot.Element))
                {
                    temproot = temproot.Right;
                }
                else
                {
                    temproot = temproot.Left;
                }
            }
            return false;
        }

        public bool RecursiveSearch(Node<T> temproot, T key)
        {
            if (temproot == null)
            {
                return false;
            }

            if (AreInstancesEqual(temproot.Element, key))
            {
                return true;
            }
            else if (IsFirstGreaterThanSecond(key, temproot.Element))
            {
                return RecursiveSearch(temproot.Right, key);
            }
            else
            {
                return RecursiveSearch(temproot.Left, key);
            }
        }

        public bool Delete(T element)
        {
            Node<T> temproot = Root!;
            Node<T> parent = null!;

            while (temproot != null && !AreInstancesEqual(temproot.Element, element))
            {
                parent = temproot;
                if (IsFirstGreaterThanSecond(temproot.Element, element))
                {
                    temproot = temproot.Left;
                }
                else
                {
                    temproot = temproot.Right;
                }
            }

            if (temproot == null)
            {
                return false;
            }

            if (temproot.Left != null && temproot.Right != null)
            {
                Node<T> successor = temproot.Left;
                Node<T> successorParent = temproot;

                while (successor.Right != null)
                {
                    successorParent = successor;
                    successor = successor.Right;
                }
                temproot.Element = successor.Element;
                temproot = successor;
                parent = successorParent;
            }

            Node<T> c = null!;
            if (temproot.Left != null)
            {
                c = temproot.Left;
            }
            else
            {
                c = temproot.Right!;
            }
            if (temproot == Root)
            {
                Root = null;
            }
            else
            {
                if (temproot == parent.Left)
                {
                    parent.Left = c;
                }
                else
                {
                    parent.Right = c;
                }
            }
            return true;
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
