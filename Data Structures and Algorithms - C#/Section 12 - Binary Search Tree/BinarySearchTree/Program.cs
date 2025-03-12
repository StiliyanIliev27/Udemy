namespace BinarySearchTree
{
    public class Program
    {

        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            binarySearchTree.Insert(binarySearchTree.Root!, 50);
            binarySearchTree.Insert(binarySearchTree.Root!, 30);
            binarySearchTree.Insert(binarySearchTree.Root!, 80);
            binarySearchTree.Insert(binarySearchTree.Root!, 10);
            binarySearchTree.Insert(binarySearchTree.Root!, 400);
            binarySearchTree.Insert(binarySearchTree.Root!, 60);
            binarySearchTree.Insert(binarySearchTree.Root!, 90);

            binarySearchTree.InsertRecursive(binarySearchTree.Root!, 70);

            Console.Write("Elements: ");
            binarySearchTree.InOrder(binarySearchTree.Root!);
        }
    }
}
