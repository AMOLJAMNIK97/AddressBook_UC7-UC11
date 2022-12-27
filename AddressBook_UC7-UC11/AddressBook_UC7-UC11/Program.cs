using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC7_UC11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook Contact = new AddressBook("Amol", "Jamnik", "Akola","Maharashtra", 444401, 8380804110, "ajamnik.mech@gmail.com");
            Contact.DisplayContact();
        }
    }
 
}