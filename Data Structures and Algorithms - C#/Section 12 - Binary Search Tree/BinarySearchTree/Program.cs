namespace BinarySearchTree
{
    public class Program
    {

        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            //Iterative insertion
            binarySearchTree.Insert(binarySearchTree.Root!, 50);
            binarySearchTree.Insert(binarySearchTree.Root!, 30);
            binarySearchTree.Insert(binarySearchTree.Root!, 80);
            binarySearchTree.Insert(binarySearchTree.Root!, 10);
            binarySearchTree.Insert(binarySearchTree.Root!, 40);
            binarySearchTree.Insert(binarySearchTree.Root!, 60);
            binarySearchTree.Insert(binarySearchTree.Root!, 90);

            //Recursive insertion
            binarySearchTree.InsertRecursive(binarySearchTree.Root!, 70);

            //Displaying elements by different traversals
            Console.Write("Elements: ");
            //binarySearchTree.InOrder(binarySearchTree.Root!);
            binarySearchTree.PreOrder(binarySearchTree.Root!);
        }
    }
}
