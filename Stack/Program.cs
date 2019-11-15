using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStack stack = new MyStack(5);
            //stack.Push("0");
            //stack.Push("1");
            //stack.Push("2");
            //stack.Push("3");
            //stack.Push("4");
            //stack.Pop();
            //stack.Xuat();
            //Console.WriteLine("Peek: " + stack.Peek());
            //Console.WriteLine("Count: " + stack.Count());
            ////stack.Clear();
            //if (stack.IsEmpty())
            //    Console.WriteLine("stack is empty");
            //else
            //    Console.WriteLine("stack is not empty");

            //if (stack.IsFull())
            //    Console.WriteLine("stack is full");
            //else
            //    Console.WriteLine("stack is not full");
            //if (stack.Contains("4"))
            //    Console.WriteLine("found x");
            //else
            //    Console.WriteLine("Not Found");
            MyExpression Infit = new MyExpression(" 2*2+2+18 ");
            Infit.Xuat();
        }
    }
}
