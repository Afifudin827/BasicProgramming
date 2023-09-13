using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Authentication;
internal class UserData
{
    public int id { get;  set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string password { get; set; }
    public string username { get; set;}

    public static List<UserData> UserDatas = new List<UserData>();



    public UserData() { }

    public UserData(int id,string fistName, string lastName, string password, string username)
    {
        this.id = id;
        this.firstName = fistName;
        this.lastName = lastName;
        this.password = password;
        this.username = username;

    }

    

    public void ShowUser()
    {
        Console.WriteLine("Fist Name : {0}", firstName);
        Console.WriteLine("Last Name : {0}", lastName);
        Console.WriteLine("Password: {0}", password);
        Console.WriteLine("Username: {0}", username);
    }

}
