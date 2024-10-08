using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }  // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public int Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public void DisplayInfo()
        {
            //output the book information to the console
            Console.WriteLine("Member Information:");
            Console.WriteLine("--------------");
            Console.WriteLine($"MemberID: {MemberId}");
            Console.WriteLine($"Book Author: {Name}");
            Console.WriteLine($"Book Pages: {Address}");
            Console.WriteLine($"Book ISBN: {Phone}");
            Console.WriteLine();
        }
    }
}
