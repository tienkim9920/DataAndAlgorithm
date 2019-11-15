using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT3
{
    class MyStack
    {
        private int stkTop;
        private int stkMax;
        private string[] stkArray;

        public int StkTop
        {
            get
            {
                return stkTop;
            }

            set
            {
                stkTop = value;
            }
        }

        public int StkMax
        {
            get
            {
                return stkMax;
            }

            set
            {
                stkMax = value;
            }
        }

        public string[] StkArray
        {
            get
            {
                return stkArray;
            }

            set
            {
                stkArray = value;
            }
        }

        public int Count()
        {
            return stkTop + 1;
        }

        public MyStack(int maxItem = 0)
        {
            StkArray = new string[maxItem];
            StkMax = maxItem;
            StkTop = -1;
        }

        public bool IsEmpty()
        {
            if (StkTop == -1)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (StkTop == StkMax - 1)
                return true;
            return false;
        }

        public bool Push(string newItem)
        {
            if (IsFull())
                return false;
            StkTop++;
            StkArray[StkTop] = newItem;
            return true;
        }

        public string Pop()
        {
            if (IsEmpty())
                return "Nothing to Pop";
            string outItem = StkArray[StkTop];
            StkTop--;
            return outItem;
        }

        public string Peek()
        {
            if (IsEmpty())
                return "Nothing to Peek";
            return StkArray[StkTop];
        }

        public void Clear()
        {
            for (int i = 0; i < StkArray.Length; i++)
            {
                Pop();
            }
        }
        public bool Contains(string x)
        {
            for (int i = 0; i < stkTop; i++)
                if (StkArray[i] == x)
                    return true;
            return false;
        }

        public void Nhap()
        {
            do
            {
                string x;
                Console.Write("Nhap X can them vao Stack: ");
                x = Console.ReadLine();
                //if (x <= 0)
                //    break;
                bool kq = Push(x);
                if (kq == true)
                {
                    Console.WriteLine("Da them {0} vao Stack!", x);
                }
                if (IsFull())
                {
                    break;
                }
            }
            while (true);
        }
        public void Xuat()
        {
            int pos = StkTop;
            for (int i = StkTop + 1; i > 0; i--)
            {
                Console.WriteLine("Stack {0} = {1}", i, StkArray[pos--]);
            }

        }
    }
}

