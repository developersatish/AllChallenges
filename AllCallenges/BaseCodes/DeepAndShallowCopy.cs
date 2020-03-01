using System;
using System.Collections.Generic;
using System.Text;

namespace AllCallenges
{
   public class DeepAndShallowCopy
    {
        public static void Entry()
        {
            Company c1 = new Company(548, "GeeksforGeeks",
                                  "Sandeep Jain");

            // Performing Shallow copy                       
            Company c2 = (Company)c1.DeepCopy();

            Console.WriteLine("Before Changing: ");

            // Before changing the value of 
            // c2 GBRank and CompanyName 
            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c2.desc.CompanyName);
            Console.WriteLine(c1.desc.CompanyName);

            // changing the value of c2 GBRank 
            // and CompanyName 
            c2.GBRank = 59;
            c2.desc.CompanyName = "GFG";

            Console.WriteLine("\nAfter Changing: ");

            // After changing the value of  
            // c2 GBRank and CompanyName 
            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c2.desc.CompanyName);
            Console.WriteLine(c1.desc.CompanyName);
        }
    }

    class Company
    {

        public int GBRank;
        public CompanyDescription desc;

        public Company(int gbRank, string c,
                                   string o)
        {
            this.GBRank = gbRank;
            desc = new CompanyDescription(c, o);
        }

        // method for cloning object 
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

        // method for cloning object 
        public Company DeepCopy()
        {
            Company deepcopyCompany = new Company(this.GBRank,
                                desc.CompanyName, desc.Owner);
            return deepcopyCompany;
        }
    }


    class CompanyDescription
    {

        public string CompanyName;
        public string Owner;
        public CompanyDescription(string c, string o)
        {
            this.CompanyName = c;
            this.Owner = o;
        }
    }
}
