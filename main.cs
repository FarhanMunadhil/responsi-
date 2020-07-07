using System;
using System.Collections.Generic;

namespace ProjectCustomer
{
    internal class Program
    {
        public static List<Customers> daftarCustomer;

        private static void HapusCustomer()
        {
                                    ulang1:
                        Console.Write("Hapus Data Customer ");
                        Console.Write("Kode Customer: ");
                        int cari = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(daftarCustomer.Count);
                        if (cari < daftarCustomer.Count)
                        {
                            daftarCustomer.RemoveAt(cari);
                        }
                        else
                        {
                            Console.Write("Kode Customer tidak ditemukan : ");
                            Console.WriteLine("Tekan ENTER untuk kembali ke menu");
                            Console.ReadKey();
                            goto ulang1;
                        }
                        break;
        }

        private static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                Program.TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                    {
                        Program.TambahCustomer();
                        break;
                    }
                    case 2:
                    {
                        Program.HapusCustomer();
                        break;
                    }
                    case 3:
                    {
                        Program.TampilCustomer();
                        break;
                    }
                    case 4:
                    {
                        return;
                    }
                }
            }
        }
        
        public static void TambahCustomer()
        {
                        ulang:
                        Customers Customer= new Customers();
                        Console.WriteLine("Tambah Data Customer \n");
                        Console.WriteLine("\n");
                        
                        int pil = Convert.ToInt32(Console.ReadLine());
                        if (pil == 1)
                        {
                            Console.Write("Kode Customer: ");
                            Customer.kode = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nama Customer: ");
                            Customer.nama = Console.ReadLine();
                            Console.Write("Total Piutang: ");
                            Customer.piutang = Convert.ToInt32(Console.ReadLine());
                            Customers.Add(daftarCustomer);

                        }
                        else
                        {
                            Console.WriteLine("Inputan Salah");
                            goto ulang;
                        }
            Console.Clear();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        private static void TampilCustomer()
        {
            int noUrut = 0;
            foreach (daftarCustomer daftarCustomer in daftarCustomer)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Piutang: {3},{4} ", noUrut, ListCustomer.kode, ListCustomer.nama, ListCustomer.piutang());
                    noUrut++;
                }
            Console.Clear();
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
            break;
        }

        private static void TampilMenu()
        {
                Console.WriteLine("Pilih Menu Aplikasi: ");
                Console.WriteLine("1.Tambah Customer:");
                Console.WriteLine("2.Hapus Hapus Customer:");
                Console.WriteLine("3.Tampilkan Customer:");
                Console.WriteLine("4.Keluar:");
            Console.Clear();
        }
    }
}