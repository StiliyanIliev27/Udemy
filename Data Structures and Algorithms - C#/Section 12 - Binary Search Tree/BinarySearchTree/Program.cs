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
           // binarySearchTree.InsertRecursive(binarySearchTree.Root!, 70);

            //Displaying elements by different traversals
            Console.Write("In order: ");
            binarySearchTree.InOrder(binarySearchTree.Root!);
            Console.WriteLine();

            Console.Write("Pre order: ");
            binarySearchTree.PreOrder(binarySearchTree.Root!);
            Console.WriteLine();

            Console.Write("Post order: ");
            binarySearchTree.PostOrder(binarySearchTree.Root!);
            Console.WriteLine();

            Console.Write("Level order: ");
            binarySearchTree.LevelOrder();
            Console.WriteLine();


            //Searching for an element with iterative and recursive methods
            bool searchResult = binarySearchTree.IterativeSearch(60);
            Console.Write($"Search for 60 (iterative): {searchResult}");

            Console.WriteLine();

            searchResult = binarySearchTree.RecursiveSearch(binarySearchTree.Root!, 61);
            Console.Write($"Search for 60 (recursive): {searchResult}");
        }
    }
}
