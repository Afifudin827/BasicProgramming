using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Authentication;
using Training1.Users;

namespace Training1.Menu;
class UserMenu
{
    //Menampilkan Seluruh User
    public static void ShowUser()
    {
        bool program = true;
        while (program)
        {
            Console.Clear();
            Console.WriteLine("== SHOW USER ==");
            foreach (UserData userData in UserData.UserDatas)
            {
                Console.WriteLine("========================");
                Console.WriteLine("ID       : " + userData.id);
                Console.WriteLine("Name     : " + userData.firstName + " " + userData.lastName);
                Console.WriteLine("Username : " + userData.username);
                Console.WriteLine("Password : " + userData.password);
                Console.WriteLine("========================");
            }
            Console.WriteLine("Menu");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Back");
            Console.Write("Input : ");
            int inputMenu = 10;
            while (!int.TryParse(Console.ReadLine(), out inputMenu))
                Console.Write("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
            int idUser;
            switch (inputMenu)
            {
                case 1:
                    Console.Write("Id Yang Ingin Di Ubah : ");
                    idUser = -1;
                    while (!int.TryParse(Console.ReadLine(), out idUser))
                        Console.Write("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
                    UserControl.EditUser(idUser);
                    break;
                case 2:
                    Console.Write("Id Yang Ingin Di hapus : ");
                    idUser = -1;
                    while (!int.TryParse(Console.ReadLine(), out idUser))
                        Console.Write("Maaf Inputan Anda Salah, \nSilahkan Input kembali :");
                    UserControl.DeletedUser(idUser);
                    break;
                case 3:
                    program = false;
                    break;
                default:
                    Console.WriteLine("Mohon maaf inputan yang ada masukan salah");
                    break;
            }
        }
    }

    public static void LoginMenu()
    {
        Console.WriteLine("==LOGIN==");
        Console.Write("USERNAME     : ");
        string username = Console.ReadLine();
        Console.Write("PASSWORD     : ");
        string password = Console.ReadLine();

        foreach (UserData userData in UserData.UserDatas)
        {
            if (userData.username.Equals(username) && userData.password.Equals(password))
            {
                Console.WriteLine("Login Berhasil!!!");
                Dashboard.MenuUser();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("LOGIN GAGAL !!!");
                Console.ReadKey();
            }
        }
    }

    public static void SearchUser(string name)
    {
        int count = 0;
        foreach (var item in UserData.UserDatas)
        {
            if (item.firstName.Contains(name) || item.lastName.Contains(name))
            {
                Console.WriteLine("========================");
                Console.WriteLine("ID       : " + item.id);
                Console.WriteLine("Name     : " + item.firstName + " " + item.lastName);
                Console.WriteLine("Username : " + item.username);
                Console.WriteLine("Password : " + item.password);
                Console.WriteLine("========================");
                count++;
            }

            
        }
        if (count < 1)
        {
            Console.WriteLine("Maaf User Yang Anda Cari tidak ditemukan");
        }
        Console.ReadKey();
    }
}
