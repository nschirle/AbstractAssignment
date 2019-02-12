using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractAssignment
{
    class LifeTimeMember : Member
    {

        private double Dues { get; set; }
        private double Discount { get; set; }
        public double _Discount { get { return Discount; } set { Discount = value;} }
        public override double _Dues { get { return Dues; } set { Dues = value * (1 - (Discount/100)); } }

        public LifeTimeMember(string name, string address, string phone, double dues) : base(name, address, phone)
        {
            if (dues >= 0)
            {
                _Discount = 15;
                _Dues = dues;
                
            }
            else
            {
                throw new ArgumentOutOfRangeException("dues must not be zero or negative");
            }

            
        }

        public override string ToString()
        {


            return $"Name: {base._Name}, Address: {base._Address} Phone: {base._Phone} Dues {_Dues.ToString("C", CultureInfo.CurrentCulture)} discount {_Discount}%";
        }
    }
}

