using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Function;
class EvenOddControl
{
    /*
     exec : PrintEvenOdd(3, "Ganjil")
     out : 1, 3,
    
     exec : PrintEvenOdd(6, "Genap")
     out : 2, 4, 6,

     @Param limit : agar method dapat memberikan batas angka yang akan di tampilkan
     @Param choice : method akan memilih tipe angka apa yang akan di tampilkan
     */
    static void PrintEvenOdd(int limit, string choice)
    {
        Console.WriteLine("Print Bilangan 1 - " + limit + " :");
        if (limit <= 0)
        {
            Console.WriteLine("Inputan Limit Tidak Valid");
        }
        else
        {
            switch (choice)
            {
                case "Ganjil":
                    for (int i = 1; i <= limit; i++)
                    {
                        Console.Write(i % 2 == 1 ? i + ", " : "");
                    }
                    Console.WriteLine();
                    break;
                case "Genap":
                    for (int i = 1; i <= limit; i++)
                    {
                        Console.Write(i % 2 == 0 ? i + ", " : "");
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Inputan Pilihan Tidak Valid!!!");
                    break;
            }
        }

    }
    /*
     * Berguna untuk menampilkan hasil apakah angka yang di masukan ganjil atau genap
     * @Param input : untuk mengecek angka yang di inputkan ganjil atau genap
     */
    static String EvenOddCheck(int input)
    {
        if (input < 0)
        {
            return ("Invalid Input!!!");
        }
        else
        {
            if (input % 2 == 0)
                return "Ganjil";
            else
                return "Genap";
        }
    }
}
