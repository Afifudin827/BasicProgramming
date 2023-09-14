using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Authentication;

namespace Training1.Users;
class UserControl
{
    static public int id = 1;
    public static void EditUser(int idUser)
    {
        if (UserData.UserDatas.Count() > idUser - 1 && idUser > 0)
        {
            bool program = true;
            string? passwordEdit = "";
            string? firstNameEdit = "";
            string? lastNameEdit = "";

            while (program)
            {
                Console.Write("Fist Name : ");
                firstNameEdit = Console.ReadLine();
                Console.Write("Last Name : ");
                lastNameEdit = Console.ReadLine();
                if (!Validate.NameValidate(firstNameEdit, lastNameEdit))
                {
                    Console.Clear();
                    Console.WriteLine("Maaf Silahkan Masukan Nama Dengan Benar");
                    Console.WriteLine("*Nama Tidak Boleh Hanya 1 Karakter");
                    program = true;
                }
                else
                {
                    program = false;
                }
            }

            program = true;
            while (program)
            {
                Console.Write("Password     :");
                passwordEdit = Console.ReadLine();
                if (!Validate.PasswordValidate(passwordEdit))
                {
                    Console.WriteLine("Password must have at least 8 characters");
                    Console.WriteLine("*with at least one Capital letter, at least one lower case letter and at least one number.");
                    program = true;
                }
                else
                {
                    program = false;
                }
            }

            UserData.UserDatas[idUser - 1].firstName = firstNameEdit;
            UserData.UserDatas[idUser - 1].lastName = lastNameEdit;
            UserData.UserDatas[idUser - 1].username = firstNameEdit.Substring(0, 2) + lastNameEdit.Substring(0, 2);
            UserData.UserDatas[idUser - 1].password = passwordEdit;
            Console.WriteLine("Data Berhasil Di Ubah");
        }
        else
        {
            Console.WriteLine("Data User Tidak DI Temukan!!!");
        }
        Console.ReadKey();
    }

    public static void DeletedUser(int idUser)
    {
        if (UserData.UserDatas.Count() > idUser - 1 && idUser > 0)
        {
            UserData.UserDatas.RemoveAt(idUser - 1);
            Console.WriteLine("User Berhasil Di Hapus");
        }
        else
        {
            Console.WriteLine("Data User Tidak DI Temukan!!!");
        }
        Console.ReadKey();
    }

    //Menu Halaman Untuk Membuat User
    public static void CreateMenu()
    {
        string? fistNames = "";
        string? lastNames = "";
        string? passwords = "";
        bool program = true;
        while (program)
        {
            Console.Write("Fist Name : ");
            fistNames = Console.ReadLine();
            Console.Write("Last Name : ");
            lastNames = Console.ReadLine();
            if (!Validate.NameValidate(fistNames, lastNames))
            {
                Console.Clear();
                Console.WriteLine("Maaf Silahkan Masukan Nama Dengan Benar");
                Console.WriteLine("*Nama Tidak Boleh Hanya 1 Karakter");
                program = true;
            }
            else
            {
                program = false;
            }
        }
        program = true;
        while (program)
        {
            Console.Write("password : ");
            passwords = Console.ReadLine();
            if (!Validate.PasswordValidate(passwords))
            {
                Console.WriteLine("Password must have at least 8 characters");
                Console.WriteLine("*with at least one Capital letter, at least one lower case letter and at least one number.");
                program = true;
            }
            else
            {
                program = false;
            }
        }

        string userNames = fistNames.Substring(0, 2) + lastNames.Substring(0, 2);
        UserData.UserDatas
            .Add(new UserData(id++, fistNames, lastNames, passwords, userNames));

        Console.WriteLine("Data User Berhasil Dibuat");
        Console.ReadKey();
    }

}
