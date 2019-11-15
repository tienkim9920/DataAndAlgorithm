using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    class MyAVLNode
    {
        private int data;
        private MyAVLNode left;
        private MyAVLNode right;

        public MyAVLNode leftChild
        {
          get { return left; }
          set { left = value; }
        }

        public MyAVLNode rightChild
        {
          get { return right; }
          set { right = value; }
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public MyAVLNode(int x) 
        { 
            data = x; 
        }
    }
}
