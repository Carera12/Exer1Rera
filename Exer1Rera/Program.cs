using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1Rera
{
    class Program
    {
        //Deklarasi array int dengan ukuran 83
        private int[] Rera = new int[83];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukkan
        public void read()
        {
            //Menerima angka untuk menetukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 83)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 83 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------");

            //Pengguna masukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Rera[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int SC = 0; SC < n; SC++)
            {
                Console.WriteLine(Rera[SC]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i =1; i <n; i++) //For n-1 passes
            {
                //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int SC = 0; SC < n - SC; SC++)
                {
                    if (Rera[SC] > Rera[SC + 1]) //Jika elemen tidak dalam urutan yangbenar
                    {
                        //Tukar elemen
                        int temp;
                        temp = Rera[SC];
                        Rera[SC] = Rera[SC + 1];
                        Rera[SC + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the BubbleSort class
            Program mylist = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            //Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar");
        }
    }
}
