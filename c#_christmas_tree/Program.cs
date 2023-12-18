using System;
class Program
{
    static void Main()
    {
        int treeHeight = 100; // You can change this to get a bigger or smaller tree
        for (int i = 0; i < treeHeight; i++)
        {
            // Print leading spaces
            for (int j = 0; j < treeHeight - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks
            for (int j = 0; j < (2 * i + 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Print the tree trunk
        for (int i = 0; i < treeHeight / 2; i++)
        {
            for (int j = 0; j < treeHeight - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
        Console.ReadLine(); // Keeps the console window open
    }
}

