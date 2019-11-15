using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT2    
{
    class IntArray
    {

        private int[] a;



        public int[] A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public int Chieudai
        {
            get
            {
                return chieudai;
            }

            set
            {
                chieudai = a.Length;
            }
        }

        public IntArray()
        {
            this.a = null;

        }
        public IntArray(int k)
        {
            a = new int[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                a[i] = random.Next(0, 10);
            }

        }

        public IntArray(int[] b)
        {

            this.A = b;
        }
        public IntArray(IntArray obj)
        {
            this.A = obj.A;
            this.Chieudai = obj.chieudai;

        }
        public void Nhap()
        {
            Console.Write("Nhap chieu dai mang: ");
            int k = int.Parse(Console.ReadLine());
            a = new int[k];
            for (int i = 0; i < a.Length; i++)
            { a[i] = int.Parse(Console.ReadLine()); }



        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            { Console.Write(a[i] + " "); }

        }
        public int timKiemTuanTu(int x)
        {
            int i = 0;
            while (a[i] != x && i < a.Length - 1)
            { i++; }
            if (a[i] != x)
                return -1;
            else return i + 1;

        }
        public int timKiemNhiPhan(int x)
        {

            int left = 0;
            int right = a.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x) return mid + 1;
                if (a[mid] < x) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        public void HoanVi(ref int a, ref int b)
        {
            {
                int tam = a;
                a = b;
                b = tam;
            }
        }
        public void InterchangeSort()
        {
            for (int i = 0; i < A.Length - 1; i++)
                for (int j = i + 1; j < A.Length; j++)
                    if (A[i] > A[j])
                        HoanVi(ref A[i], ref A[j]);
        }
        public void InsertSort()
        {
            int pos;
            int x;
            for (int i = 1; i < a.Length; i++)
            {
                x = a[i];
                pos = i - 1;
                while (pos >= 0 && a[pos] > x)
                {
                    a[pos + 1] = a[pos];
                    pos--;
                }
                a[pos + 1] = x;
            }
        }
        private int chieudai;
        public void Quicksort(int left, int right)
        {
            int i = left, j = right;
            int x = A[(left + right) / 2];
            do
            {
                while (A[i] < x) i++;
                while (A[j] > x) j--;
                if (i <= j)
                {
                    HoanVi(ref A[i], ref A[j]);
                    i++;
                    j--;
                }
            }
            while (i < j);
            if (left < j) Quicksort(left, j);
            if (i < right) Quicksort(i, right);
        }
        public void ShellSort()
        {
            int i, j, post, temp;
            post = 3;
            while (post > 0)
            {
                for (i = 0; i < a.Length; i++)
                {
                    j = i;
                    temp = a[i];
                    while ((j >= post) && (a[j - post] > temp))
                    {
                        a[j] = a[j - post];
                        j = j - post;
                    }
                    a[j] = temp;
                }
                if (post / 2 != 0)
                    post = post / 2;
                else if (post == 1)
                    post = 0;
                else
                    post = 1;
            }
        }
        public void ShakerSort()
        {
            int Left = 0;
            int Right = chieudai - 1;
            int k = 0;
            while (Left < Right)
            {
                for (int i = Left; i < Right; i++)
                {
                    if (a[i] >= a[i + 1])
                    {
                        HoanVi(ref a[i], ref a[i + 1]);
                        k = i;
                    }
                }
                Right = k;
                for (int i = Right; i > Left; i--)
                {
                    if (a[i] < a[i - 1])
                    {
                        HoanVi(ref a[i], ref a[i - 1]);
                        k = i;
                    }
                }
                Left = k;
            }
        }
    }
}
