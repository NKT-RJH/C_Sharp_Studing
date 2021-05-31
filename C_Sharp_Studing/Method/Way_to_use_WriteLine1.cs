using System;

namespace C_Sharp_Studing
{
    class Way_to_use_WriteLine1
    {
        public static void Method()
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i = " + i + ", x = " + x);

            x = i; // i의 값이 깨지지 않음. x의 자료형의 메모리 크기가 i의 자료형의 메모리 크기보다 크기 때문 -> 암시적 형변환
            i = (int)x; // i에 x의 값을 넣으면 깨지기 때문에, x의 자료형을 i와 같이 만들어주고 값을 넣음 -> 명시적 형변환
            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
