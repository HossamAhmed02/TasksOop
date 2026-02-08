using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class CustomerAccount : Bank
    {
        private static int count = 0;
        private int _ID;
        public int ID
        {
            get{ return _ID; }
        }
        public CustomerAccount(string name, double id, string phoneNumber, float balance)
        {
            FullName = name;
            NationalID = id;
            PhoneNumber = phoneNumber;
            Balance = balance;
            _ID = count++;
        }
        public void UpdateName(string Name)
        {
            FullName = Name;
        }
     /*   public void RemoveAccount()
        {
            if (Balance == 0)
            {
                _ID = 0;
                FullName = "NULL";
            }
        }
     */
        public void Search(string name , int id)
        {
            if (name == FullName || id == _ID)
            {
                Console.WriteLine(NationalID);
            }
        }
        

 
    }
}
