using System;

namespace C_Sharp_Studing
{
    class Data_Type
    {
        public static void Method()
        {
            bool b = true; //true or false
            char c = 'A'; //just one character
            decimal d = 1.234m; //when we use decimal, we put 'm' at the finish of number. this data type's accuracy is very high but speed is so low out in number data type.
            double e = 1.23456789;
            float f = 1.23456789f; //when we use float, we put 'm' at the finish of number. i think using double is more good choice
            int i = 1234;
            string s = "Hello"; //Even i need not to use arrange

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
