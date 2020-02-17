using System;
using System.Linq;

namespace ArrayConcept
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            //dec an array
            string[] EmploymentDetails = { "zaec", "Veerappa", "apple", "sindhu" };
            int[] FamilyMemberAge = { 16665, 2, 4644, 89, 0};

            for(int i =0; i<EmploymentDetails.Length; i++)
            {
                Console.WriteLine("Array- For: " + EmploymentDetails[i]);
                //Console.ReadLine();

            }

            foreach (int i in FamilyMemberAge)
            {
                Console.WriteLine("Array- foreach()--> " + i);
            }

            //Sorting 
            Array.Sort(EmploymentDetails); // its will sort and store in same an array element based on 1st alpha
            foreach(string i in EmploymentDetails)
            {
                Console.WriteLine("Array - String Sorting:  " + i);
            }

            Array.Sort(FamilyMemberAge);
            foreach(int i in FamilyMemberAge)
            {
                Console.WriteLine("Array - Int - Sort:  " + i);
            }

            //Find largest num ber in an array
            Console.WriteLine("Array- Largest num -" + FamilyMemberAge.Max());
            Console.WriteLine("Array - Smallest num->" +FamilyMemberAge.Min());
            Console.WriteLine("Array - Total Sum-->" + FamilyMemberAge.Sum());





        }
    }
}
