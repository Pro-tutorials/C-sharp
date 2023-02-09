using System.Drawing;

namespace DataTypes
{
    internal class Program
    {
        static void Main()
        {
            //ExplainNumbers();
            ExplainString();
        }

        /// <summary>
        /// A variable is a container to store value
        /// <data type> <variable name> = <value>;  
        /// Some conventions to declare a variable in C# : 
        /// - Variable names must be unique.
        /// - Variable names can contain letters, digits, and the underscore _ only.
        /// - Variable names must start with a letter.
        /// - Variable names are case-sensitive, so greeting and Greeting are considered two different variables.
        /// - Variable names cannot contain reserved keywords in C#.
        /// </summary>
        static void ExplainNumbers() 
        {
            /// Numbers can be divided into two types: Integer type and Floating-point types.
            /// Integer type : Whole numbers without decimals, can be positive or negative.
            /// byte : can only be positive
            byte num1 = 1;
            Console.WriteLine($"byte can have min value : {byte.MinValue} and  max value : {byte.MaxValue} , and example has  a value : {num1}");

            /// sbyte : can be positive or negative values
            sbyte num2 = - 2;
            Console.WriteLine($"sbyte can have min value : {sbyte.MinValue} and  max value : {sbyte.MaxValue} , and example has  a value : {num2}");

            /// short : can be positive or negative values 
            short num3 = - 300;
            Console.WriteLine($"short can have min value : {short.MinValue} and  max value : {short.MaxValue} , and example has  a value : {num3}");

            /// ushort : can only be positive 
            ushort num4 = 300;
            Console.WriteLine($"ushort can have min value : {ushort.MinValue} and  max value : {ushort.MaxValue} , and example has  a value : {num4}");

            /// int : can be positive or negative values
            int num5 = - 55555;
            Console.WriteLine($"int can have min value : {int.MinValue} and  max value : {int.MaxValue} , and example has  a value : {num5}");

            /// uint : can only be positive
            uint num6  = 25445;
            Console.WriteLine($"uint can have min value : {uint.MinValue} and  max value : {uint.MaxValue} , and example has  a value : {num6}");

            /// int : can be positive or negative values
            long num7 = -5555565485454;
            Console.WriteLine($"long can have min value : {long.MinValue} and  max value : {long.MaxValue} , and example has  a value : {num7}");

            /// uint : can only be positive
            ulong num8 = 25445466464646;
            Console.WriteLine($"ulong can have min value : {ulong.MinValue} and  max value : {ulong.MaxValue} , and example has  a value : {num8}");

            /// Floating - point types : numbers with one or more decimal points can be positive or negative.

            /// float  7 digits precision
            float num9 = 555.55F;  
            Console.WriteLine($"float can have min value : {float.MinValue} and  max value : {float.MaxValue} , and example has  a value : {num9}");

            /// double  15 digits precision
            double num10 = 555.555646D;
            Console.WriteLine($"double can have min value : {double.MinValue} and  max value : {double.MaxValue} , and example has  a value : {num10}");

            /// decimal 28 digits precision
            decimal num11 = 555.55545454M;
            Console.WriteLine($"decimal can have min value : {decimal.MinValue} and  max value : {decimal.MaxValue} , and example has  a value : {num11}");

            /// Scientific Notation
            /// Use E to indicate the power of 10 as exponent part of scientific notation with float, double or decimal.
            double num12 = 54646E10;
        }

        /// <summary>
        /// A string : string is a series of characters, surrounded  by ""
        /// a string is a collection or an array of characters 
        /// </summary>
        static void ExplainString ()
        {
            string message = "Welcome to CSahrpPro tutorials";
            Console.WriteLine(message);

            foreach (var charachter in message)
            {
                Console.WriteLine(charachter);
            }

            /// We need to use escape character with some special characters like : 
            /// \, \n \\ \t, \"
            string intoduction = "Hello my name is \"John\"";
            Console.WriteLine(intoduction);

            /// Verbatim String : Verbatim string in C# ignores a special characters and line brakes, it can also use to create 
            /// multi-lines strings
            string moreInfo = @"And my family name is ""Doe\"".";
            Console.WriteLine(moreInfo);

            /// String concatenation using + 
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("My full name is " + firstName + " " + lastName);

            /// String interpolation
            /// Note :use two braces, "{{" or "}}" to include { or } in a string.
            Console.WriteLine($"My full name is {{ {firstName} {lastName} }}");
        }
    }
}