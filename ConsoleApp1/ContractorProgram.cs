using System;

namespace Contractor
{
    public class ContractorProgram
    {
        public string Name = "Golbal";
        public int Age = 12;

        public ContractorProgram()
        {
            Name = "without Parameter";
            Age = 10;

        }
        public ContractorProgram(string canName, int canAge)
        {
            canName = Name;
            canAge = Age;
        }
        public static void Main(string[] args)
            {
                //Console.WriteLine(Age);
            ContractorProgram ctwithoutParameter = new ContractorProgram();
            Console.WriteLine("ContractorProgram(): Name --->" +ctwithoutParameter.Name);
            Console.WriteLine("ContractorProgram(): Age --->" + ctwithoutParameter.Age);
            ContractorProgram ctwithParameter = new ContractorProgram("twoParameter", 67);
            Console.WriteLine("ContractorProgram(string canName, int canAge): Age-->" + ctwithParameter.Age);
            Console.WriteLine("ContractorProgram(string canName, int canAge): Name-->" + ctwithParameter.Name);
            Console.ReadLine();
            }
        
    }
}
