using System;

namespace C_Sharp_Studing
{
    class Way_to_use_WriteLine2
    {
        public static void Method()
        {
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); //The way to put variable in Console.WriteLine or Console.Write

            string primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
