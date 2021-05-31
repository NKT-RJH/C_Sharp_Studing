using System;

namespace C_Sharp_Studing
{
    class Way_to_use_WriteLine2
    {
        public static void Method()
        {
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); // 출력 방식은 Console.WriteLine 혹은 Console.Write 이다

            string primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
