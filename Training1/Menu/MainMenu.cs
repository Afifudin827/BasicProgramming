using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Users;

namespace Training1.Menu;
class MainMenu
{
    //Membuat menu Saat Belum Login
    public static void BaseMenu()
    {
        bool program = true;
        while (program)
        {
            Console.Clear();
            Console.WriteLine("== BASIC AUTHENTICATION ==");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Show User");
            Console.WriteLine("3. Search User");
            Console.WriteLine("4. Login User");
            Console.WriteLine("5. Exit");
            Console.Write("Input : ");
            int inputMenu = 10;
            while (!int.TryParse(Console.ReadLine(), out inputMenu))
                Console.WriteLine("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
            switch (inputMenu)
            {
                case 1:
                    Console.Clear();
                    UserControl.CreateMenu();
                    break;
                case 2:
                    Console.Clear();
                    UserMenu.ShowUser();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("* Keterangan : Sensitif Case");
                    Console.WriteLine("==Cari Akun==");
                    Console.Write("Masukan Nama : ");
                    string name = Console.ReadLine();
                    UserMenu.SearchUser(name);
                    break;
                case 4:
                    Console.Clear();
                    UserMenu.LoginMenu();
                    break;
                case 5:
                    program = false;
                    Console.Clear();
                    Console.WriteLine("Terimakasih Telah Menggunakan Program ini");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Mohon Maaf Inputan Yang Anda masukan salah");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
