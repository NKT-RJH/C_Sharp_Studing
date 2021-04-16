using System;

namespace C_Sharp_Studing
{
    class Use_Write
    {
        public static void Method()
        {
            Console.Write("Hello "); //Write string, no ENTER
            Console.WriteLine("World!"); //Write string, put ENTER in console

            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine(); //it can use at variable declaration part. simuliar scanf
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
