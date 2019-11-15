using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT4
{
    class MyList
    {
        private IntNode first = null;
        private IntNode last = null;
        private int Length = 0;

        public int Count
        {
            get { return Length; }
        }
        internal IntNode First
        {
            get
            {
                return first;
            }

            set
            {
                first = value;
            }
        }

        internal IntNode Last
        {
            get
            {
                return last;
            }

            set
            {
                last = value;
            }
        }

        public bool IsEmpty()
        {
            return First == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
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
                    IntNode newNode = new IntNode(x);
                    Length++;
                    //AddFirst(newNode); Delete comment if use want to list reverse
                    AddLast(newNode);

                }
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = First;
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.Next;
            }
            Console.WriteLine("NULL");
        }

        public IntNode FindX(IntNode x)
        {

            for (IntNode temp = First; temp != null; temp = temp.Next)
            {
                if (temp.Data == x.Data)
                {
                    return x;
                }
            }
            return null;
        }

        public IntNode GetMax()
        {
            IntNode maxNode = new IntNode();
            maxNode = First;

            for (IntNode pointer = First; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data >= maxNode.Data)
                {
                    maxNode = pointer;
                }
            }
            return maxNode;
        }

        public IntNode GetMin()
        {
            IntNode minNode = new IntNode();
            minNode = First;

            for (IntNode pointer = First; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data <= minNode.Data)
                {
                    minNode = pointer;
                }
            }
            return minNode;
        }

        public void GetEvenList()
        {

            for (IntNode pointer = First; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data % 2 == 0)
                {
                    Console.Write(pointer.Data + " -> ");
                }
            }
            Console.WriteLine("NULL");
        }

        public void GetOddList()
        {
            for (IntNode pointer = First; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data % 2 != 0)
                {
                    Console.Write(pointer.Data + " -> ");
                }
            }
            Console.WriteLine("NULL");
        }

        public void Sort()
        {
            for (IntNode i = First; i != null; i = i.Next)
            {
                for (IntNode j = i.Next; j != null; j = j.Next)
                {
                    if (i.Data > j.Data)
                    {
                        int temp = j.Data;
                        j.Data = i.Data;
                        i.Data = temp;
                    }
                }
            }
        }

        public void RemoveAt(int position)
        {
            IntNode head = First;
            if (head == null)
                return;

            IntNode temp = head;

            if (position == 0)
            {
                head = temp.Next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
                return;
            IntNode next = temp.Next.Next;

            temp.Next = next;
        }

        public void RemoveX(int x)
        {
            IntNode temp = First, prev = null;

            if (temp != null && temp.Data == x)
            {
                First = temp.Next;
                return;
            }

            while (temp != null && temp.Data != x)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null) return;
            prev.Next = temp.Next;

        }

        public void InsertAt(int x, int pos)
        {
            IntNode node = new IntNode();
            node.Data = x;
            node.Next = null;


            if (First == null)
            {
                if (pos != 0)
                    return;
                else
                    First = node;
            }

            if (First != null && pos == 0)
            {
                node.Next = First;
                First = node;
                return;
            }

            IntNode current = First;
            IntNode previous = null;

            int i = 0;
            while (i < pos)
            {
                previous = current;
                current = current.Next;
                if (current == null)
                    break;
                i++;
            }
            node.Next = current;
            previous.Next = node;

        }

        public void InsertAfterP(IntNode p, IntNode newNode)
        {
            if (p == Last)
                AddLast(newNode);
            else
            {
                IntNode pSau = p.Next;
                newNode.Next = pSau;
                p.Next = newNode;
            }
        }

        public void InsertAfterMin(int z)
        {
            IntNode temp = new IntNode(z);
            IntNode node = GetMin();
            InsertAfterP(node, temp);
        }

        public void InsertXAfterY(int x, int y)
        {
            int pos = 0;
            for (IntNode temp = First; temp != null; temp = temp.Next)
            {
                pos++;
                if (temp.Data == y)
                {
                    break;
                }
            }
            InsertAt(x, pos);
        }

        public void InsertBeforeP(IntNode p, IntNode newNode)
        {
            InsertAfterP(p, newNode);
            //Hoan Vi
            int temp = p.Data;
            p.Data = newNode.Data;
            newNode.Data = temp;
        }

        public void InsertBeforeMax(int x)
        {
            IntNode temp = new IntNode(x);
            IntNode node = GetMax();
            InsertBeforeP(node, temp);
        }

        public void InsextXBeforeY(int x, int y)
        {
            int pos = 0;
            for (IntNode temp = First; temp != null; temp = temp.Next)
            {
                pos++;
                if (temp.Data == y)
                {
                    break;
                }
            }
            InsertAt(x, pos - 1);
        }
    }
}
