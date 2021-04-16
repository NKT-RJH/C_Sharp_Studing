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

            x = i; //At this time, i's value dosen't get damaged because double's memory space is big than int's memory space
            i = (int)x; //But i's memory space is small than double's memory space. so we change data type of x to protect x's value
            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
