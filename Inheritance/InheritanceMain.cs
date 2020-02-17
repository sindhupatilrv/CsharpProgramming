using System;

namespace Inheritance
{
    public class InheritanceMain
    {
        public static void Main(string[] args)
        {
            /* InheritanceParent pt = new InheritanceParent();
            pt.Car();
            pt.Wheels(); */

            //Child Object
            InheritanceChild child = new InheritanceChild();
            child.Start();
            child.Car();
            child.Wheels();
        }
    }
}
