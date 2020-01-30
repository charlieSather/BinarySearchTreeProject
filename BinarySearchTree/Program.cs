using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Add(20);
            bst.Add(10);
            bst.Add(15);
            bst.Add(25);
            bst.Add(21);
            bst.Add(1);
            bst.Add(26);
            bst.Add(40);
            bst.Add(13);


            Console.WriteLine(bst.Search(21).data);
            Console.ReadLine();



        }
    }
}
