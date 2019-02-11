using System;


namespace Inheritance
{
    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
        }

        public Member ()
        {
            Console.WriteLine("Parent constructor without parameters.");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent constructor with three parameters.");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;

        }

    }


    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor without parameters.");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with four parameters.");
            Console.WriteLine("Remarks = {0}", remarks);

        }

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }

    }

    class VIPMember : Member
    {
      
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with three parameters.");
        }

        public void CalculateAnnualFee()
        {
            annualFee = 1200;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            NormalMember stuff = new NormalMember("Special Rate", "Jamie", 1, 2015);
            VIPMember stuffVip = new VIPMember("Jamie", 1, 2015);

            stuff.CalculateAnnualFee();
            stuffVip.CalculateAnnualFee();

            Console.WriteLine(stuff.ToString());
            Console.WriteLine(stuffVip.ToString());

            Console.ReadLine();
        }
    }
}
