using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT2
{
    class Program
    {
        static void Interchangesort(IntArray obj)
        {
            IntArray tamobj = new IntArray(obj);
            Console.WriteLine("Mang ban dau: ");
            obj.Xuat();
            tamobj.InterchangeSort();
            Console.WriteLine("\nInterchangeSort: ");
            tamobj.Xuat();
        }
        static void Insertsort(IntArray obj)
        {
            IntArray b = new IntArray(obj);
            Console.WriteLine("\nMang ban dau: ");
            obj.Xuat();
            b.InsertSort();
            Console.WriteLine("\nInsertSort: ");
            b.Xuat();
        }
        static void Quicksort(IntArray obj)
        {
            IntArray tamobj = new IntArray(obj);
            Console.WriteLine("\nMang ban dau: ");
            obj.Xuat();
            tamobj.Quicksort(0, tamobj.Chieudai - 1);
            Console.WriteLine("\nQuickSort:  ");
            tamobj.Xuat();
        }
        static void ShellSort(IntArray obj)
        {
            IntArray tamobj = new IntArray(obj);
            Console.WriteLine("\nMang ban dau: ");
            obj.Xuat();
            tamobj.ShellSort();
            Console.WriteLine("\nShellSort:  ");
            tamobj.Xuat();
        }
        static void ShakerSort(IntArray obj)
        {
            IntArray tamobj = new IntArray(obj);
            Console.WriteLine("\nMang ban dau: ");
            tamobj.Xuat();
            tamobj.ShakerSort();
            Console.WriteLine("\nShakerSort:  ");
            tamobj.Xuat();
        }

        static void Main(string[] args)
        {

            IntArray obj = new IntArray(10);
            Interchangesort(obj);
            //Insertsort(obj);
            //Quicksort(obj);
            //ShellSort(obj);
            //ShakerSort(obj);


            //Console.Write("\nNhap x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (arr1.timKiemTuanTu(x) == -1)
            //{ Console.WriteLine("khong tim thay x trong mang"); }
            //else Console.WriteLine("Vi tri cua x la: " + arr1.timKiemTuanTu(x));
            //IntArray arr2 = new IntArray(arr1);
            //arr2.Nhap();
            //arr2.Xuat();
            //Console.Write("Nhap x: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (arr1.timKiemNhiPhan(y) == -1)
            //{
            //    Console.WriteLine("khong tim thay x trong mang");
            //}
            //else
            //Console.WriteLine("Vi tri cua X: " + arr2.timKiemNhiPhan(y));

        }
    }
}
