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
        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("Enter First Name to Edit");
            string FirstName = Console.ReadLine();
            while (ContactArray[i].FirstName != FirstName)
            {
                i++;
            }
            Console.WriteLine("Enter field to be Modify\n1.FirstName\n2.LastName\n3.Address\n4.State\n5.Zip\n6.PhoneNumber\n7.Email");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Enter Modify Value");
                    string firstnmae = Console.ReadLine();
                    ContactArray[i].FirstName = firstnmae; 
                    break;
                case 2:
                    Console.WriteLine("Enter Modify Value");
                    string lastname = Console.ReadLine();
                    ContactArray[i].LastName = lastname; 
                    break;
                case 3:
                    Console.WriteLine("Enter Modify Value");
                    string address = Console.ReadLine();
                    ContactArray[i].Address = address; 
                    break;
                case 4:
                    Console.WriteLine("Enter Modify Value");
                    string state = Console.ReadLine();
                    ContactArray[i].State = state; 
                    break;
                case 5:
                    Console.WriteLine("Enter Modify Value");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].Zip = zip; 
                    break;
                case 6:
                    Console.WriteLine("Enter Modify Value");
                    long phonenumber = Convert.ToInt64(Console.ReadLine());
                    ContactArray[i].PhoneNumber = phonenumber; 
                    break;
                case 7:
                    Console.WriteLine("Enter Modify Value");
                    string email = Console.ReadLine();
                    ContactArray[i].Email = email; 
                    break;

            }
            AddressBook Edit = new AddressBook();
            Edit.DisplayContact(ContactArray, Contact);
             
        }
    }
}
