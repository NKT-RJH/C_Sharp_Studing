using System;

namespace C_Sharp_Studing
{
    class Convert_Class_and_Print_Computer_Numer_System
    {
        public static void Method()
        {
            // Convert 클래스는 여러 자료형의 변환을 도와줍니다. ex)ToParse, ToString
            int x, y;

            Console.WriteLine("첫 번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            //2진수, 8진수, 10진수, 16진수로 출력하기
            short value = short.MaxValue; // Int16.MaxValue와 같음
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);
        }
        
    }
}