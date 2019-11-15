using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT4
{
    class IntNode
    {
        private int data;
        private IntNode next = null;


        public IntNode(int x = 0)
        {
            Data = x;
            Next = null;
        }

        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        internal IntNode Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }
    }
}
