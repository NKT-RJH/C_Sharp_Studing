using System;

namespace C_Sharp_Studing
{
    class Add_Variable_values
    {
        public static void Method()
        {
            string a = "hello";
            string b = "h";

            b += "ello"; // 두 문자열 연결
            Console.WriteLine(a == b); //논리 연산
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x; // +를 이용해서 문자열을 연혈한 뒤 저장 가능 
            Console.WriteLine("c = " + c);
        }
    }
}
