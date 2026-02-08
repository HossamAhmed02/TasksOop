using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {/* //Assignment session 2,3
            Bank a = new Bank("Hossam",12345678901234,"01123456789");
            Bank b = new Bank("Ahmed", 99999999999999, "01223456789", 1000);
            a.ShowAccountDetails();
            b.ShowAccountDetails();
            */
            /* Bank c1 = new SavingAccount();
             Bank c2 = new CurrentAccount();
             List<Bank> d = new List<Bank>()
             {
                 c1, c2
             };
             foreach (Bank b in d)
             {
                 b.ShowAccountDetails();
             }
            */
            List<CustomerAccount> a = new List<CustomerAccount>();
            a.Add(new CustomerAccount("Hossam", 30203198800654, "01113456709", 500));
            a.Add(new CustomerAccount("Ahmed", 99999999999999, "01224567899", 2000));
            a.Add(new CustomerAccount("Ibrahim", 32223198800678, "01524681012", 0));

            foreach (var c in a) 
            {
                a[0].UpdateName("HOSO");
                c.ShowAccountDetails();
                Console.WriteLine(c.ID);
            }

        }
    }
}
