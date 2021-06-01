using System;
using System.Diagnostics; // Stopwatch의 사용을 위해 추가
using System.Text;

namespace C_Sharp_Studing
{
    class String_and_StringBuilder
    {
        public static void Method()
        {
            // StringBuilder : 문자열 변수 선언 후, 변수 안 문자열의 내용이 자주 바뀔 때 사용하면 좋은 자료형이다.
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Clear(); // 변수 sb 초기화
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string."); // 다른 문자열 뒤에 추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz ", 2); // sb의 5번째 위치에 "xyz "를 2번 삽입
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4); // sb의 5번째 위치에서 4개의 문자 삭제
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz", "abc"); // 문자열 xyz를 abc로 대체
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch(); // Stopwatch 객체 생성
            string test = string.Empty; // 문자열 초기화
            time.Start(); // 시간 측정 시작
            for (int i = 0; i < 100000; i++)
                test += i;
            time.Stop(); // 시간 측정 끝
            Console.WriteLine("String: " + time.ElapsedMilliseconds + " ms"); // 시간 출력

            StringBuilder test1 = new StringBuilder();
            time.Reset(); // 변수 초기화
            time.Start(); // 시간 측정 시작
            for (int i = 0; i < 100000; i++)
                test1.Append(i);
            time.Stop(); // 시간 측정 끝
            Console.WriteLine("StirngBuilder: " + time.ElapsedMilliseconds + " ms");
        }
    }
}
