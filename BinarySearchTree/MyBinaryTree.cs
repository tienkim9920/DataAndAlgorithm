using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    class MyBinaryTree
    {
        MyNode root = null;
        internal MyNode Root
        {
            get { return root; }
            set { root = value; }
        }

        private int count = 0;
        public int Count
        {
            get { return count; }
        }

        private int height = 0;
        public int HeightTree()
        {
            return root.TreeHeight();
        }
        public int Height
        {
            get { return height = HeightTree(); }
        }

        public int LeafCount 
        {
            get { return CountLeaf(root); }
        }

        public int CountLeaf(MyNode node)
        {
            if (node == null)
                return 0;
            if (node.leftChild == null && node.rightChild == null)
                return 1;
            else
                return CountLeaf(node.leftChild) + CountLeaf(node.rightChild);
        }

        public bool Insert(int x)
        {
            if (root == null)
            {
                root = new MyNode(x);
                return true;
            }
            else
            {
                if (root.InsertData(x))
                {
                    count++;
                    return true;

                }
            }
            return false;
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Enter new Node: (-1 exit): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x < 0)
                    break;
                else
                {
                    bool inSert = Insert(x);
                }
            } while (true);
        }

        public void PreOrder()
        {
            if (root == null)
                return;
            root.NLR();
            Console.Write("Null");
        }

        public void InOrder()
        {
            if (root == null)
                return;
            root.LNR();
            Console.Write("Null");
        }

        public void PostOrder()
        {
            if (root == null)
                return;
            root.LRN();
            Console.Write("Null");
        }

        public MyNode SearchNode(int x)
        {
            if (root == null)
                return null;
            return root.SearchX(x);
        }

        public MyNode MaxNode()
        {
            if (root == null)
                return null;
            return root.RightMost();
        }

        public MyNode MinNode()
        {
            if (root == null)
                return null;
            return root.LeftLeast();
        }

        public bool Remove(int x)
        {
            if (root == null)
                return false;

            if (x.CompareTo(root.Data) == 0)
            {
                MyNode tmp = new MyNode();
                tmp.leftChild = root;
                bool res = root.Remove(x, tmp);
                root = tmp.leftChild;
                return res;
            }
            return root.Remove(x, null);
        }

        public int printGivenLevel(MyNode root, int level)
        {
            if (root == null)
                return 0;
            if (level == 1)
                Console.Write(root.Data + " ");
            else if (level > 1)
            {
                printGivenLevel(root.leftChild, level - 1);
                printGivenLevel(root.rightChild, level - 1);
            }
            return 0;
        }

        public void ListByLevel()
        {
            int h = Height;
            int i;
            for (i = 1; i <= h; i++)
            {
                Console.Write("Level {0} -> Data: ", i);
                printGivenLevel(root, i);
                Console.WriteLine();
            }
        }

        public void ListLastLevel()
        {
            Console.Write("List Last Level: ");
            printGivenLevel(root, Height);
        }
    }
}
