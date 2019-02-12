using System;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearly = new YearlyMember("nathan", "test", "123", 100.0);
            var lifetime = new LifeTimeMember("nathan", "test", "123", 100.0);
            Console.WriteLine(yearly.ToString());
            Console.WriteLine(lifetime.ToString());
            PrintMemberInfo(yearly);
            PrintMemberInfo(lifetime);
        }

        private static void PrintMemberInfo(Member member)
        {
            Console.WriteLine(member);
        }
    }
}
