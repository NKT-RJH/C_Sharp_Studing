using System;

namespace C_Sharp_Studing
{
    class Write_and_ReadLine
    {
        public static void Method()
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine()); // 문자열을 받아 int형으로 변환
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine()); // 문자열을 받아 float형으로 변환

            Console.Write("안녕하세요, ");
            Console.WriteLine(name + "님!"); // +로 ""안 문자열과 변수의 값을 연결 가능. 함께 출력됨

            Console.Write("나이는 ");
            Console.Write(age + "세, 키는 ");
            Console.WriteLine(height + "cm 이군요!");
        }
    }
}