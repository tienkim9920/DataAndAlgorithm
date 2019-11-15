using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Globalization;

namespace LuyenTap
{
    class Program
    {
        public static void FirstProcess()
        {
            MyBinaryTree myTree = new MyBinaryTree();
            myTree.Input();

            Console.Write("Count: ");
            Console.WriteLine(myTree.Count);

            Console.Write("Height: ");
            Console.WriteLine(myTree.Height);

            Console.Write("So Luong Lode La Trong Cay: ");
            Console.WriteLine(myTree.CountLeaf(myTree.Root));

            Console.Write("NLR: ");
            myTree.PreOrder();
            Console.WriteLine();

            Console.Write("LNR: ");
            myTree.InOrder();
            Console.WriteLine();

            Console.Write("LRN: ");
            myTree.PostOrder();
            Console.WriteLine();

            Console.WriteLine();
            myTree.ListByLevel();
            Console.WriteLine();
            myTree.ListLastLevel();
        }
        
        public static void FindX()
        {
            /* Tìm Node có trong cây không ? */
            MyBinaryTree myTree = new MyBinaryTree();
            myTree.Input();
            Console.Write("Nhap Node Can Tim: ");
            int x = int.Parse(Console.ReadLine());
            MyNode node = new MyNode(x);
            MyNode temp = new MyNode();
            temp = myTree.SearchNode(node.Data);
            if (temp != null)
                Console.WriteLine("Da Tim Thay Node: " + temp.Data);
            else
                Console.WriteLine("Khong Tim Thay Node");
        }

        public static void MinAndMax()
        {
            /* Min Max Node của cây */
            MyBinaryTree myTree = new MyBinaryTree();
            myTree.Input();
            MyNode maxNode = new MyNode();
            MyNode minNode = new MyNode();
            maxNode = myTree.MaxNode();
            minNode = myTree.MinNode();
            if (maxNode != null)
                Console.WriteLine("Max Node -> " + maxNode.Data);
            else
                Console.WriteLine("Node is NULL");

            if (minNode != null)
                Console.WriteLine("Min Node -> " + minNode.Data);
            else
                Console.WriteLine("Node is NULL");
        }

        public static void Remove()
        {
            /* Xóa Node trong cây */
            MyBinaryTree myTree = new MyBinaryTree();
            myTree.Input();

            Console.Write("LNR: ");
            myTree.InOrder();
            Console.WriteLine();

            Console.Write("Nhap Node Can Xoa: ");
            int x = int.Parse(Console.ReadLine());
            myTree.Remove(x);

            Console.Write("LNR: ");
            myTree.InOrder();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //FirstProcess();
            //FindX();
            //MinAndMax();
            //Remove();
            Console.ReadKey();
        }
    }
}
