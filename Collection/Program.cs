using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // list 
            List<int> listname = new List<int>();
            listname.Add(10);
            listname.Add(20);
            listname.Add(30);
            listname.Add(40);
            Console.WriteLine("Total number of data inside the list: " + listname.Count);
            foreach (var list in listname)
            {
                Console.WriteLine("Complete list data using foreach:" +  list);
            }
            //index of
            int index = listname.IndexOf(10); // Exists.
            Console.WriteLine(index);

            index = listname.IndexOf(50); // Does not exist.
            Console.WriteLine(index);
           

            //specific index print
            Console.WriteLine(listname[1]);
            Console.WriteLine(listname.ElementAt(2));
            Console.ReadLine();
        }
    }
}
