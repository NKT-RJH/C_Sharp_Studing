using System;

namespace C_Sharp_Studing
{
    class Casting_and_Change_Datatype
    {
        public static void Method()
        {
            int num = 2147483647;
            long bigNum = num; // 암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x; // 명시적 형변환
            Console.WriteLine(a);
        }
    }
}