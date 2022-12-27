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
        public void DisplayContact()
        {
            Console.WriteLine("Nmae :{0} {1}", FirstName, LastName);
            Console.WriteLine("Address :{0}", Address);
            Console.WriteLine("State :{0} ", State);
            Console.WriteLine("Email :{0} ", Email);
            Console.WriteLine("Zip :{0}", Zip);
            Console.WriteLine("PhoneNumber :{0} ", PhoneNumber);
        }
    }
}
