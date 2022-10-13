using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        private int[] a = new int[56];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("masukkan banyaknya jumlah elemen array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 56)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 56 elemen");
            }
            Console.WriteLine("");
            Console.WriteLine("MASUKKAN ELEMEN ARRAY");
            Console.WriteLine("---------------------");

            for (int i = 0; i < n ; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("ELEMENT ARRAY TELAH TERSUSUN");
            Console.WriteLine("----------------------------");
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine(a[r]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int r = 0; r < n ; r++)
                {
                    if (a[r] > a[r + 1])
                    {
                        int temp;
                        temp = a[r];
                        a[r] = a[r + 1];
                        a[r + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.BubbleSortArray();
            myList.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar");
            Console.Read();
        }
    }
}