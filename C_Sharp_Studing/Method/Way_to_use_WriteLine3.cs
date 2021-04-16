using System;

namespace C_Sharp_Studing
{
    class Way_to_use_WriteLine3
    {
        public static void Method()
        {
            int v1 = 100;
            double v2 = 1.234;
            //Console.WriteLine(v1, v2); This is incorrect way to print.
            Console.WriteLine(v1.ToString() + ", " + v2.ToString()); //when print console, change data type to string by variable's name.ToString()
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2); //system is simuliar printf
            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); //if we use $ in front of "", we can put variable name in {}
        }
    }
}
