using System;
public class Program
{
    /*
     * Berfungsi untuk membuat tampilan Menu
     */
    static void Menu()
    {
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
        if(input < 0)
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
    public static void Main(string[] args)
    {
        Menu();
    }
}