using System;

namespace C_Sharp_Studing
{
    class Use_Write
    {
        public static void Method()
        {
            Console.Write("Hello "); // 줄바꿈 없이 출력
            Console.WriteLine("World!"); // 줄바꿈 포함 출력

            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine(); // 변수 선언할 때 scanf 기능을 사용 가능
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
