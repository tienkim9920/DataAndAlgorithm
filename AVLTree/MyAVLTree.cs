using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    class MyAVLTree
    {
        private MyAVLNode root;

        public MyAVLNode Root
        {
          get { return root; }
          set { root = value; }
        }
        private int count;

        public int Count
        {
          get { return count; }
          set { count = value; }
        }
        public int height;

        public int Height
        {
            get { return height = getHeight(root); }
            set { height = value; }
        }

        public void Add(int data)
        {
            
            MyAVLNode newItem = new MyAVLNode(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
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
                    Add(x);
                    count++;
                }
            } while (true);
        }

        private MyAVLNode RecursiveInsert(MyAVLNode current, MyAVLNode n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.Data < current.Data)
            {
                current.leftChild = RecursiveInsert(current.leftChild, n);
                current = balance_tree(current);
            }
            else if (n.Data > current.Data)
            {
                current.rightChild = RecursiveInsert(current.rightChild, n);
                current = balance_tree(current);
            }
            return current;
        }
        private MyAVLNode balance_tree(MyAVLNode current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.leftChild) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.rightChild) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        public void RemoveX(int target)
        {
            root = RemoveX(root, target);
        }
        private MyAVLNode RemoveX(MyAVLNode current, int target)
        {
            MyAVLNode parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target < current.Data)
                {
                    current.leftChild = RemoveX(current.leftChild, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.rightChild) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target > current.Data)
                {
                    current.rightChild = RemoveX(current.rightChild, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.leftChild) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.rightChild != null)
                    {
                        //delete its inorder successor
                        parent = current.rightChild;
                        while (parent.leftChild != null)
                        {
                            parent = parent.leftChild;
                        }
                        current.Data = parent.Data;
                        current.rightChild = RemoveX(current.rightChild, parent.Data);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.leftChild) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.leftChild;
                    }
                }
            }
            return current;
        }
        public void Find(int key)
        {
            if (Find(key, root).Data == key)
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
        private MyAVLNode Find(int target, MyAVLNode current)
        {

            if (target < current.Data)
            {
                if (target == current.Data)
                {
                    return current;
                }
                else
                    return Find(target, current.leftChild);
            }
            else
            {
                if (target == current.Data)
                {
                    return current;
                }
                else
                    return Find(target, current.rightChild);
            }

        }
        public void LNR()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }

        public void NLR()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            PreOrderDisplayTree(root);
            Console.WriteLine();
        }

        public void LRN()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            PostOrderDisplayTree(root);
            Console.WriteLine();
        }


        private void InOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.leftChild);
                Console.Write("{0} ", current.Data);
                InOrderDisplayTree(current.rightChild);
            }
        }

        private void PreOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {
                Console.Write("{0} ", current.Data);
                PreOrderDisplayTree(current.leftChild);
                PreOrderDisplayTree(current.rightChild);
            }
        }

        private void PostOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {             
                PostOrderDisplayTree(current.leftChild);
                PostOrderDisplayTree(current.rightChild);
                Console.Write("{0} ", current.Data);
            }
        }


        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(MyAVLNode current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.leftChild);
                int r = getHeight(current.rightChild);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(MyAVLNode current)
        {
            int l = getHeight(current.leftChild);
            int r = getHeight(current.rightChild);
            int b_factor = l - r;
            return b_factor;
        }
        private MyAVLNode RotateRR(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.rightChild;
            parent.rightChild = pivot.leftChild;
            pivot.leftChild = parent;
            return pivot;
        }
        private MyAVLNode RotateLL(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.leftChild;
            parent.leftChild = pivot.rightChild;
            pivot.rightChild = parent;
            return pivot;
        }
        private MyAVLNode RotateLR(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.leftChild;
            parent.leftChild = RotateRR(pivot);
            return RotateLL(parent);
        }
        private MyAVLNode RotateRL(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.rightChild;
            parent.rightChild = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
