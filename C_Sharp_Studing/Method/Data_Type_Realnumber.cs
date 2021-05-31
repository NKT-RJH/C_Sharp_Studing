using System;

namespace C_Sharp_Studing
{
    class Data_Type_Realnumber
    {
        public static void Method()
        {
            float flt = 1F / 3; // 실수를 표현하는 자료형들
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2} bytes", sizeof(float), sizeof(double), sizeof(decimal)); // 자료형 메모리 크기
            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue); // float 자료형 최대값, 최소값
            Console.WriteLine("dobule : {0}~{1}", double.MinValue, double.MaxValue); // double 자료형 최대값, 최소값
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue); // decimal 자료형 최대값, 최소값
        }
    }
}
