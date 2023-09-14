using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Menu;
class Dashboard
{
    /*
     * Berfungsi untuk membuat tampilan Menu Setelah Login
     */
    static void MenuUser()
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
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.Write("Masukan bilangan yang ingin di cek : ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(EvenOddCheck(number));
                    break;
                case 2:
                    Console.Write("Pilih (Ganjil/Genap) : ");
                    string choose = Console.ReadLine();
                    Console.Write("Masukan Limit : ");
                    int limit = int.Parse(Console.ReadLine());
                    PrintEvenOdd(limit, choose);
                    break;
                case 3:
                    Console.WriteLine("Terimakasih Telah Menggunakan Program Ini.");
                    program = false;
                    break;
                default:
                    Console.WriteLine("Maaf Inputan Anda Tidak Valid.");
                    break;
            }
            Console.WriteLine("==============================");
        }

    }
}
