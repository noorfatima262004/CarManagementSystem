using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class PersonalInformation
    {  
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Contact { get; private set; }
        public string Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public string BankAccount { get; private set; }

        public string age { get; private set; } 

        public PersonalInformation(string name, string email, string contact, string address, DateTime dateOfBirth, string gender, string bankAccount, string Age)
        {
            Name = name;
            Email = email;
            Contact = contact;
            Address = address;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            BankAccount = bankAccount;
            age =Age;
        }
    }
}
