using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone; // changed to string to keep the leading zeros

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // Private setter makes it read only
        }
        public string Name
        {
            get { return name; } // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; } // get method
            set { address = value; } // set method
        }

        public string Phone
        {
            get { return phone; } // get method
            set { phone = value; } // set method
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; // Assigns calCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone number: {Phone}");
            Console.WriteLine();
        }
    }
}

