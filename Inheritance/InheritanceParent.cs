using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class InheritanceParent
    {
        public void Car()
        {
            int a = 10;
            Console.WriteLine("Car()- Parent Inheritance Class and local Var" + a);
        }

        public void Wheels()
        {
            Console.WriteLine("Wheels()- Parent Inheritance Class and local Var");
        }

    }
}
