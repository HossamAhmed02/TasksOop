using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Bank
    {
        const string BankCode = "BNK001";
        readonly DateTime CreatedDate;
        private int _accountNumber;
        private string _fullName;
        private double _nationalID;
        private string _phoneNumber;
        private string _address;
        private float _balance;

        public string FullName 
        {
            get { return _fullName; } 
            set {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new Exception("Please Enter Your Name. Try Again..");
                }
                else
                {
                    _fullName = value;
                }
            }
        }
        public double NationalID 
        { 
            get { return _nationalID; }
            set{
                if(value.ToString().Length == 14)
                {
                    _nationalID = value;
                }
                else { throw new Exception("Please Enter a Valid National ID."); }
            } 
        }
        public string PhoneNumber 
        { 
            get { return _phoneNumber; }
            set {
                if (value.Length == 11 && value.StartsWith("01"))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception("Please Enter a Valid Phone Number.");
                }
            }
        }
        public float Balance
        {
            get { return _balance; }
            set
            {
                if(value > 0)
                {
                    _balance = value;
                }
                else { Console.WriteLine("Enter Valid Balance."); }
            }
        }
        public string Address 
        { 
            get { return _address; }
            set { _address = value; }
        }
        public Bank()
        {
            Console.WriteLine("This is Default Constructor");
        }
        public Bank(string name , double ID , string phoneNumber , float balance)
        {
            _fullName = name;
            _nationalID = ID;
            _phoneNumber = phoneNumber;
            _balance = balance;
        }
        public Bank(string name, double ID, string phoneNumber ) : this (name , ID , phoneNumber , 0)
        {
            _fullName = name;
            _nationalID = ID;
            _phoneNumber = phoneNumber;
        }
        public virtual void ShowAccountDetails()
        {
            Console.WriteLine(_fullName + "  " + _nationalID + "  " + _phoneNumber + "  " + _balance);
            Console.WriteLine("----------");
        }
        public bool IsValidNationalID()
        {
            if (_nationalID.ToString().Length == 14)
            {
                Console.WriteLine("Validation ID True");
                return true;
            }
            else
            {
                throw new Exception("Please Enter a Valid National ID.");
                return false;
            }
        }
        public bool IsValidPhoneNumber()
        {
            if (_phoneNumber.Length == 11 && _phoneNumber.StartsWith("01"))
            {
                Console.WriteLine("Validation Phone Number true");
                return true;
            }
            else
            {
                throw new Exception("Please Enter a Valid Phone Number.");
                return false;
            }
        }
    }
}
