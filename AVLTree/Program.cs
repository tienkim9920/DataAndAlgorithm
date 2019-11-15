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
        public static void RemoveX()
        {
            /* Xóa Node trong cây */
            MyAVLTree Tree = new MyAVLTree();
            Tree.Input();

            Console.Write("LNR: ");
            Tree.LNR();
            Console.WriteLine();

            Console.Write("Nhap Node Can Xoa: ");
            int x = int.Parse(Console.ReadLine());
            Tree.RemoveX(x);

            Console.Write("LNR: ");
            Tree.LNR();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyAVLTree tree = new MyAVLTree();
            tree.Input();

            Console.Write("Count: ");
            Console.WriteLine(tree.Count);

            Console.Write("Height: ");
            Console.WriteLine(tree.Height);

            Console.Write("LNR:");
            tree.LNR();
            Console.WriteLine();

            Console.Write("NLR:");
            tree.NLR();
            Console.WriteLine();

            Console.Write("LRN:");
            tree.LRN();
            Console.WriteLine();

            //RemoveX();
            Console.ReadKey();
        }
    }
}
