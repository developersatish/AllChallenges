using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class ClassVsInstance
    {
        public int age;
        public ClassVsInstance(int initialAge)
        {
            if(initialAge<0){
                Console.WriteLine("Age is not valid, setting age to 0.");
                initialAge=0;
            }
            // Add some more code to run some checks on initialAge
            this.age = initialAge;
        }
        public void amIOld()
        {
            string msg = "You are old.";
            
            if (this.age < 13)
            {
                msg = " You are young.";
            }
            if (this.age >= 13 && this.age < 18)
            {
                msg = "You are a teenager.";
            }

            Console.WriteLine(msg);
        }

        public void yearPasses()
        {
            this.age++;
        }

        public static void Entry()
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                ClassVsInstance p = new ClassVsInstance(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

        }
    }
}
