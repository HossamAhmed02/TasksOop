using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank a = new Bank("Hossam",12345678901234,"01123456789");
            Bank b = new Bank("Ahmed", 99999999999999, "01223456789", 1000);
            a.ShowAccountDetails();
            b.ShowAccountDetails();

        }
    }
}
