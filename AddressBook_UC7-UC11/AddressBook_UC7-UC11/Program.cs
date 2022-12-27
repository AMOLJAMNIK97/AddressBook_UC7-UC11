using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC7_UC11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook Add = new AddressBook();
            Console.WriteLine("Enter Number of Contact Add");
            int Contact = Convert.ToInt32(Console.ReadLine());
            while (Contact > 0)
            {
                Console.WriteLine("Enter First Name");
                string FirstName=Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                string LastName=Console.ReadLine();
                Console.WriteLine("Enter Address ");
                string Addreess = Console.ReadLine();
                Console.WriteLine("Enter State Name");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                int Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number ");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email Address");
                string Email = Console.ReadLine();
                Add.CreatContact(FirstName, LastName, Addreess, State, Zip, PhoneNumber, Email);
                Contact--;

            }
            Console.WriteLine("Do you want to Modify(Y/N)");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                Add.EditContact();
            }
            /*AddressBook Contact = new AddressBook("Amol", "Jamnik", "Akola","Maharashtra", 444401, 8380804110, "ajamnik.mech@gmail.com");
            Contact.DisplayContact();*/
        }
    }
 
}