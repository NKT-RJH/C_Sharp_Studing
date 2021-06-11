using System;

namespace C_Sharp_Studing
{
    class ConstEx
    {
        public const int number = 3;
    }
    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }
    class Const_and_Readonly
    {
        // 상수는 변하지 않는 값
        // const : 선언할 때부터 값 고정
        // readonly : 선언 시점과 생성자 메소드에서 값 변경 가능. 그 외는 오류 발생
        public static void Method()
        {
            Console.WriteLine(ConstEx.number); // const 사용

            ReadonlyEx inst1 = new ReadonlyEx(); // readonly 사용
            Console.WriteLine(inst1.number);
            
            ReadonlyEx inst2 = new ReadonlyEx(100); // readonly 사용
            Console.WriteLine(inst2.number);
        }
        
    }
}