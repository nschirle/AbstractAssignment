using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractAssignment
{
    class YearlyMember : Member
    {
    
        private double Dues { get; set; }
        public override double _Dues { get { return Dues; } set { Dues = value;} }
        public double WeeklyDues { get { return Dues / 52; } }
        public double MonthlyDues { get { return Dues / 12; } }
        public YearlyMember(string name, string address, string phone, double dues) : base(name, address, phone)
        {
            Dues = dues;
        }

        public override string ToString()
        {
           

            return $"Name: {base._Name}, Address: {base._Address} Phone: {base._Phone} Dues {Dues.ToString("C", CultureInfo.CurrentCulture)} Weekly Dues {WeeklyDues.ToString("C", CultureInfo.CurrentCulture)} Monthly dues{MonthlyDues.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
