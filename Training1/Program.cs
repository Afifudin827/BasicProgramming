using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Training1.Authentication;

public class Program
{
    static public int id=1; 
    
    //Membuat menu Saat Belum Login
    static void BaseMenu()
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
            int inputMenu = int.Parse(Console.ReadLine());

            switch (inputMenu)
            {
                case 1:
                    Console.Clear();
                    CreateMenu();
                    break;
                case 2:
                    Console.Clear();
                    ShowUser();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("* Keterangan : Sensitif Case");
                    Console.WriteLine("==Cari Akun==");
                    Console.Write("Masukan Nama : ");
                    string name = Console.ReadLine();
                    SearchUser(name);
                    break;
                case 4:
                    Console.Clear();
                    LoginMenu();
                    break;
                case 5:
                    program = false;
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }

    //Menampilkan Seluruh User
    static void ShowUser()
    {
        bool program = true;
        while (program)
        {
            Console.Clear();
            Console.WriteLine("== SHOW USER ==");
            foreach(UserData userData in UserData.UserDatas)
            {
                Console.WriteLine("========================");
                Console.WriteLine("ID       : "+userData.id);
                Console.WriteLine("Name     : "+userData.firstName + " "+ userData.lastName);
                Console.WriteLine("Username : "+userData.username);
                Console.WriteLine("Password : " + userData.password);
                Console.WriteLine("========================");
            }
            Console.WriteLine("Menu");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Back");
            Console.Write("Input : ");
            int inputMenu = int.Parse(Console.ReadLine());
            int idUser;
            switch (inputMenu)
            {
                case 1:
                    Console.Write("Id Yang Ingin Di Ubah : ");
                    idUser = int.Parse(Console.ReadLine());
                    EditUser(idUser);
                    break;
                case 2:
                    Console.Write("Id Yang Ingin Di hapus : ");
                    idUser = int.Parse(Console.ReadLine());
                    DeletedUser(idUser);
                    break;
                case 3:
                    program = false;
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }

    static void EditUser(int idUser)
    {
        if (UserData.UserDatas.Count() > idUser-1 && idUser > 0 )
        {
            bool program = true;
            string passwordEdit = "";
            string firstNameEdit = "";
            string lastNameEdit = "";

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
            
            UserData.UserDatas[idUser -1].firstName = firstNameEdit;
            UserData.UserDatas[idUser - 1].lastName = lastNameEdit;
            UserData.UserDatas[idUser-1].username = firstNameEdit.Substring(0, 2) + lastNameEdit.Substring(0, 2);
            UserData.UserDatas[idUser-1].password = passwordEdit;
            Console.WriteLine("Data Berhasil Di Ubah");
        }
        else
        {
            Console.WriteLine("Data User Tidak DI Temukan!!!");
        }
        Console.ReadKey();
    }

    static void DeletedUser(int idUser)
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

    static void SearchUser(string name)
    {
        foreach (var item in UserData.UserDatas)
        {
            if(item.firstName.Contains(name) || item.lastName.Contains(name)){
                Console.WriteLine("========================");
                Console.WriteLine("ID       : "+ item.id);
                Console.WriteLine("Name     : "+ item.firstName + " "+ item.lastName);
                Console.WriteLine("Username : "+ item.username);
                Console.WriteLine("Password : "+ item.password);
                Console.WriteLine("========================");
                Console.ReadKey();
            }else { Console.WriteLine("data User yang di cari tidak di temukan");
                Console.ReadKey();
            }
        }
    }
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

    static void LoginMenu()
    {
        Console.WriteLine("==LOGIN==");
        Console.Write("USERNAME     : ");
        string username = Console.ReadLine();
        Console.Write("PASSWORD     : ");
        string password = Console.ReadLine();

        foreach (UserData userData in UserData.UserDatas)
        {
            if(userData.username.Equals(username)&& userData.password.Equals(password)) 
            {
                Console.WriteLine("Login Berhasil!!!");
                MenuUser();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("LOGIN GAGAL !!!");
                Console.ReadKey();
            }
        }
    }

    //Menu Halaman Untuk Membuat User
    static void CreateMenu()
    {
        string fistNames = "";
        string lastNames = "";
        string passwords = "";
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

        string userNames = fistNames.Substring(0,2) + lastNames.Substring(0,2);

        

        UserData.UserDatas
            .Add(new UserData(id++, fistNames, lastNames, passwords, userNames));

        Console.WriteLine("Data User Berhasil Dibuat");
        Console.ReadKey();
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
        BaseMenu();
    }
}