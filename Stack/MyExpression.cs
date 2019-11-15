using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTDLGT_BT3
{
    class MyExpression
    {
        private string bieuthuc;
        public MyExpression(string bieuthuc)    
        {
            this.bieuthuc = bieuthuc;
        }
        public string ChuanHoaBieuThuc(string bieuthuc)
        {
            string chuanHoa = String.Copy(bieuthuc);
            chuanHoa = chuanHoa.Replace(" ", "");
            chuanHoa = Regex.Replace(chuanHoa, @"\+|\-|\*|\/|\%|\^|\)|\(", delegate (Match match)
            {
                return " " + match.Value + " ";
            });
            chuanHoa = chuanHoa.Replace("  ", " ");
            chuanHoa = chuanHoa.Trim();
            return chuanHoa;
        }
        public List<string> TaoListInfix(string bieuthuc)
        {
            List<string> infix = new List<string>();
            bieuthuc = ChuanHoaBieuThuc(bieuthuc);
            foreach (string s in bieuthuc.Split(' '))
                infix.Add(s);
            return infix;

        }
        public int DoUuTien(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        public static bool ToanTu(string token)
        {
            return Regex.Match(token, @"\+|\-|\*|\/|\%").Success;
        }
        public static bool ToanHang(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }

        public string InfixtoPostfix(string bieuthuc)
        {
            string result = "";
            MyStack stack = new MyStack(bieuthuc.Count());
            foreach (string c in TaoListInfix(bieuthuc))
            {
                if (ToanHang(c))
                {
                    result += c + " ";
                }
                else if (c == "(")
                {
                    stack.Push(c);
                }
                else if (c == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        result += x + " ";
                        x = stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count() > 0 && DoUuTien(c) <= DoUuTien(stack.Peek()))
                        result += stack.Pop() + " ";
                    stack.Push(c);
                }
            }
            while (stack.Count() > 0)
                result += stack.Pop() + " ";
            result = result.Trim();
            return result;
        }
        private List<string> TaoListPosfit(string bieuthuc)
        {
            List<string> posfit = new List<string>();
            string[] posfits = InfixtoPostfix(bieuthuc).Split(' ');
            foreach (string c in posfits)
            {
                posfit.Add(c);
            }

            return posfit;

        }
        public double Tinh()
        {
            string a = "";
            MyStack stack = new MyStack(bieuthuc.Count());
            foreach (string s in TaoListPosfit(bieuthuc))
            {
                if (ToanHang(s))
                {
                    stack.Push(s);
                }
                else
                {
                    double x = double.Parse(stack.Pop());
                    double y = double.Parse(stack.Pop());
                    switch (s)
                    {
                        case "+": y += x; break;
                        case "-": y -= x; break;
                        case "*": y *= x; break;
                        case "/": y /= x; break;
                        case "%": y %= x; break;
                    }
                    a += y;
                    stack.Push(a);
                    a = "";
                }
            }
            return double.Parse(stack.Peek());
        }
        public void Xuat()
        {
            Console.WriteLine(Tinh());
        }
    }
}
