using System;

namespace C_Sharp_Studing
{
    class Add_Variable_values
    {
        public static void Method()
        {
            string a = "hello";
            string b = "h";

            b += "ello"; //connect two strings
            Console.WriteLine(a == b); //논리 연산
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x; //We can be put lots of strings in variable by + 
            Console.WriteLine("c = " + c);
        }
    }
}
