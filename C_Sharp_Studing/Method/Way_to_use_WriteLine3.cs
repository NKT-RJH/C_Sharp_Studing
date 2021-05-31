using System;

namespace C_Sharp_Studing
{
    class Way_to_use_WriteLine3
    {
        public static void Method()
        {
            int v1 = 100;
            double v2 = 1.234;
            //Console.WriteLine(v1, v2); 이런 식으로 하면 에러 발생
            Console.WriteLine(v1.ToString() + ", " + v2.ToString()); // 출력 시, 형식을 문자열로 바꿔서 출력하려면 ToString() 사용
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2); // printf와 비슷한 파라미터 사용방법
            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); // ""앞에 $을 넣으면 중괄호 안에 변수명을 넣어서 출력 가능
        }
    }
}
