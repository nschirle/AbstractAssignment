using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    abstract class Member
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        public string _Name { get { return Name; } set { Name = value; } }
        public string _Address { get { return Address; } set { Address = value; } }
        public string _Phone { get { return Phone; } set { Phone = value; } }
        public abstract double _Dues { get;  set; }

        protected Member(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address} Phone: {Phone} Dues {_Dues}";
        }
    }
}
