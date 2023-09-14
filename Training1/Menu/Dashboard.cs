using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Function;

namespace Training1.Menu;
class Dashboard
{
    /*
     * Berfungsi untuk membuat tampilan Menu Setelah Login
     */
    public static void MenuUser()
    {
        Console.Clear();
        /*Untuk Membuat program selalu berulang*/
        bool program = true;
        while (program)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("     Menu Ganjil Genap       ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Cek Ganjil Genap");
            Console.WriteLine("2. Print Ganjil/Genap (Dengan Limit)");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Pilihan : ");
            int selection = 10;
            while (!int.TryParse(Console.ReadLine(), out selection))
                Console.Write("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
            switch (selection)
            {
                case 1:
                    Console.Write("Masukan bilangan yang ingin di cek : ");
                    int number = 0;
                    while (!int.TryParse(Console.ReadLine(), out number))
                        Console.WriteLine("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
                    Console.Write(EvenOddControl.EvenOddCheck(number));
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Write("Pilih (Ganjil/Genap) : ");
                    string choose = Console.ReadLine();
                    Console.Write("Masukan Limit : ");
                    int limit = 0;
                    while (!int.TryParse(Console.ReadLine(), out limit))
                        Console.Write("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
                    EvenOddControl.PrintEvenOdd(limit, choose);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Terimakasih Telah Menggunakan Program Ini.");
                    program = false;
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Maaf Inputan Anda Tidak Valid.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            Console.WriteLine("==============================");
        }

    }
}
