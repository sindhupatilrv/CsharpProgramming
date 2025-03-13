namespace Datatypes
{
    public class Datatypelearning
    {
        public static void Main(String[] args)
        {
            numericExample();
            referenceType();
            nullableExample();
        }
        //DATATYPE & Variable

        //sbyte	-128 to 127	- Signed 8-bit integer    System.SByte
        //byte	0 to 255	Unsigned 8-bit integer  System.Byte
        //short	-32,768 to 32,767	Signed 16-bit integer   System.Int16
        //ushort	0 to 65,535	Unsigned 16-bit integer System.UInt16
        //int	-2,147,483,648 to 2,147,483,647	Signed 32-bit integer   System.Int32
        //uint	0 to 4,294,967,295	Unsigned 32-bit integer System.UInt32
        //long	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	Signed 64-bit integer   System.Int64
        //ulong	0 to 18,446,744,073,709,551,615	Unsigned 64-bit integer System.UInt64
        //    nint    Depends on platform(computed at runtime)   Signed 32-bit or 64-bit integer System.IntPtr
        //    nuint   Depends on platform(computed at runtime)   Unsigned 32-bit or 64-bit integer   System.UIntPt
        private static void numericExample()
        {
            //Signed integer
            /*------------------------------------------*/
            sbyte sbytenumber = -127;
            short shortNumber = 32767;
            int intNumber = 123;
            long intlong = 9223372036854775807;

            Console.WriteLine("Numeric Type \n " +
                              "\nsbyte value is" + sbytenumber +
                              "\nshort value is:" + shortNumber +
                              "\nint Value is:" + intlong +
                              "\nuLong Value is:" + intlong);

            //Unsigned integer 
            /*------------------------------------------*/
            Console.WriteLine("/*------------------------------------------*/");

            byte byteexnumber1 = 200;
            byte byteexnumber2 = 50;

            byte difference = (byte)(byteexnumber1 - byteexnumber2); 
            Console.WriteLine("\nDifference of Byte Value is: " + difference);
            Console.WriteLine("/*------------------------------------------*/");


            /*------------------------------------------*/
            ushort ushortexNumber1 = 65000;
            ushort ushortexNumber2 = 500;

            ushort ushortexSum = (ushort)(ushortexNumber1 + ushortexNumber2); // Cast needed to avoid overflow
            Console.WriteLine("\nSum of Ushort number is: " + ushortexSum);
            Console.WriteLine("/*------------------------------------------*/");


            /*------------------------------------------*/

            uint uintexNumber1 = 65000;
            uint uintexNumber2 = 500;
            uint uintexSum = uintexNumber1 + uintexNumber2;
            Console.WriteLine("\nSum of UInt number is: " + uintexSum);
            Console.WriteLine("/*------------------------------------------*/");


            /*------------------------------------------*/
            ulong ulongExNum1 = 18446744073709551615;
            ulong ulongExNum2 = 1844674407370955161;
            ulong ulongSum = ulongExNum1 + ulongExNum2;
            Console.WriteLine("\nSum of ulong number is: " + ulongSum);
            Console.WriteLine("/*------------------------------------------*/");

            /*------------------------------------------*/
            float floatex = 4.67f;
            Console.WriteLine("The Float Value is:" + floatex);
            Console.WriteLine("/*------------------------------------------*/");


            /*------------------------------------------*/

            double doubleex = 5.75;
            Console.WriteLine("The Float Value is:" + doubleex);
            Console.WriteLine("/*------------------------------------------*/");

            /*------------------------------------------*/

            decimal decimalEx = 3.25m;
            Console.WriteLine("The Float Value is:" + decimalEx);
            Console.WriteLine("/*------------------------------------------*/");

            //Logical 
            bool isSunny = true;
            Console.WriteLine(isSunny ? "Logical bool Ex:It's a sunny day!" : "Logical bool Ex:It's not sunny today.");
            Console.WriteLine("/*------------------------------------------*/");

            /*------------------------------------------*/
            Console.WriteLine("/*-------------------Cha-----------------------*/");

            //Character
            char a = 'a';
            Console.WriteLine("Character datatype:" + a);
            if (char.IsLetter(a))
            {
                Console.WriteLine("Given Character is a letter");
            }
            // Convert lowercase into upper case
            char uppercase = char.ToUpper(a);
            Console.WriteLine("The Given Char type convert into uppercase and letter is: \t" + uppercase);
            /*------------------------------------------*/
        }

        private static void referenceType()
        {
            //String 
            // Object
            Console.WriteLine("/*------------String Example------------------------------*/");

            String stringex = "Explore C# Basic";
            Console.WriteLine("Reference Type: String Example" + stringex);

            Console.WriteLine("Convert the string into UpperCase:" + stringex.ToUpper());
            if (stringex.IndexOf("c#", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("String Contain(): The Given string contains c# example string" );
            }
            else
            {
                Console.WriteLine("The Given string doesn't contains C#");
            }
            Console.WriteLine("Trim the Given trim():\t"+ stringex.Trim());
            Console.WriteLine("Length of the String is:" + stringex.Length);
           
            Console.WriteLine("Length of the String is:" + stringex.Insert(1, "And learn more C#"));
            Console.WriteLine("/*-----------Object Example-------------------------------*/");


            // Declare and initialize object variables
            object obj1 = 123; // Integer
            object obj2 = "Hello, World!"; // String
            object obj3 = 45.67;

            if (obj2 is string)
            {
                string strObj = (string)obj2;
                Console.WriteLine("Object 2 cast to string: " + strObj);
            }
            Console.WriteLine("/*------------------------------------------*/");


        }

        private static void nullableExample()
        {
            Console.WriteLine("/*-------------Nullable-----------------------------*/");
            int? number1 = 23;
            int? number2 = null;

            if (number1.HasValue)
            {
                Console.WriteLine("Given Number has Nullable and it's Value is:" + number1.Value);
            } 
            if (number2.HasValue)
            {
                Console.WriteLine("Given Number has Nullable and it's Value is:" + number2.Value);
            }
            else
            {
                Console.WriteLine("Nullable value");
            }
            Console.WriteLine("/*------------Learn More-Nullable-----------------------------*/");
            int nullableInt = number2 ?? 0; // value will be 0 if nullableInt is null
            Console.WriteLine("Null-Coalescing Operator (??):" + nullableInt);
            int? length = number2?.ToString().Length; // length will be null if nullableInt is null
            Console.WriteLine("Null-Conditional Operator (?.):" + length);

            int value = number2.GetValueOrDefault(); // value will be 0 (default for int) if nullableInt is null
            int valueWithDefault = number2.GetValueOrDefault(5); // valueWithDefault will be 5 if nullableInt is null
            Console.WriteLine("Nullable Type -GetValueOrDefault()" + value, valueWithDefault);
            // Using explicit casting
            try
            {
                int value4 = (int)number2; // Throws InvalidOperationException if nullableInt is null
                Console.WriteLine("Value4 (using casting): " + value4);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }
    }
}