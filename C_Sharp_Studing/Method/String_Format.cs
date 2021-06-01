using System;

namespace C_Sharp_Studing
{
    class String_Format
    {
        public static void Method()
        {
            // String Format : 지정된 형식에 따라 객체, 변수, 수식의 값을 문자열로 변환하여 다른 문자열에 삽입
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("소요 시간: {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}
