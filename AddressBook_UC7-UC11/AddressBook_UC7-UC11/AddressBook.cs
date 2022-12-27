using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC7_UC11
{
    public class AddressBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public AddressBook[] ContactArray { get; set; }
        public int Contact = 0;
        public AddressBook()
        {
            this.ContactArray = new AddressBook[5];
        }
        public AddressBook(string firstName, string lastName, string address, string state, int zip, long phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }   
        public void DisplayContact(AddressBook[] ContactArray,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nmae {0} {1}", ContactArray[i].FirstName, ContactArray[i].LastName);
                Console.WriteLine("Address :{0}", ContactArray[i].Address);
                Console.WriteLine("State :{0} ", ContactArray[i].State);
                Console.WriteLine("Email :{0} ", ContactArray[i].Email);
                Console.WriteLine("Zip :{0}", ContactArray[i].Zip);
                Console.WriteLine("PhoneNumber :{0} ", ContactArray[i].PhoneNumber);
            }
        }
        public void CreatContact(string FirstNmae,string LastName,string Address,string State,int Zip,long PhoneNumber,string Email)
        {
            ContactArray[this.Contact] = new AddressBook(FirstName, LastName, Address, State, Zip, PhoneNumber, Email);
            Contact++;
            AddressBook address = new AddressBook();
            address.DisplayContact(ContactArray, Contact);
        }
    }
}
