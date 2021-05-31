using System;

namespace C_Sharp_Studing
{
    class Standard_Numeric_Format_Specifiers1
    {
        public static void Method()
        {
            //Console.Clear(); 콘솔창의 모든 글자를 지움

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine( // {0:C}에서, 0은 파라미터의 위치이고 and C는 형식지정자이다.
                "(C) Currency: . . . . . . . . {0:C}\n" + // 통화
                "(D) Decimal:. . . . . . . . . {0:D}\n" + // 십진수(정수)
                "(E) Scientific: . . . . . . . {1:E}\n" + // 지수(과학)
                "(F) Fixed point:. . . . . . . {1:F}\n" + // 고정자릿수
                "(G) General:. . . . . . . . . {0:G}\n" + // 일반
                "(N) Number: . . . . . . . . . {0:N}\n" + // 천 단위 구분 기호 숫자
                "(P) Percent:. . . . . . . . . {1:P}\n" + // 퍼센트
                "(R) Round-trip: . . . . . . . {1:R}\n" + // 라운드트립
                "(X) Hexadecimal:. . . . . . . {0:X}\n",  // 16진수
                -12345678, -1234.5678f);
        }
    }
}
