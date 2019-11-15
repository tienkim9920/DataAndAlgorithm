using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            myList.InsertAfterMin(100);
            //myList.InsertXAfterY(99, 4);
            //myList.InsertBeforeMax(55);
            //myList.InsextXBeforeY(99, 5);
            //myList.RemoveAt(3);
            //myList.RemoveX(5);
            //myList.InsertAt(100, 2);
            myList.ShowList();
            Console.ReadKey();
        }
    }
}
