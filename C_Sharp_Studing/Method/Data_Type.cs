using System;

namespace C_Sharp_Studing
{
    class Data_Type
    {
        public static void Method()
        {
            bool b = true; // 참 혹은 거짓을 저장하는 자료형
            char c = 'A'; // 문자 저장하는 자료형
            decimal d = 1.234m; // decimal 자료형을 사용할 때, 마지막에 m넣기. 다른 자료형보다 정확하지만, 속도가 느림
            double e = 1.23456789;
            float f = 1.23456789f; // float 자료형을 사용할 때, 마지막에 f넣기
            int i = 1234;
            string s = "Hello"; // 문자열을 저장하는 자료형. 문자 자료형의 배열을 만들지 않아도 됨

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
