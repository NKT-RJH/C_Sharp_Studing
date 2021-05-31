using System;

namespace C_Sharp_Studing
{
    class Class_String
    {
        public static void Method()
        {
            string s = " Hello, World! ";
            string t;


            Console.WriteLine(s.Length); // 문자열의 길이
            Console.WriteLine(s[8]); // 문자열을 배열처럼 쓸 수 있음
            Console.WriteLine(s.Insert(8, "C# ")); // 문자열의 특정 위치에 또 다른 문자열을 삽입
            Console.WriteLine(s.PadLeft(20, '.')); // 문자열 앞에 특정 문자를 삽입하여 글자 수를 맞춘다
            Console.WriteLine(s.PadRight(20, '.')); // 문자열 뒤에 특정 문자를 삽입하여 글자 수를 맞춘다
            Console.WriteLine(s.Remove(6)); // 문자열의 지정한 위치부터 삭제한다
            Console.WriteLine(s.Remove(6, 7)); // 문자열의 지정한 위치까지 삭제한다
            Console.WriteLine(s.Replace('l', 'm')); // 특정 문자를 다른 문자로 바꾼다
            Console.WriteLine(s.ToLower()); // 문자열의 알파벳을 모두 소문자로 바꾼다
            Console.WriteLine(s.ToUpper()); // 문자열의 알파벳을 모두 대문자로 바꾼다
            Console.WriteLine('/' + s.Trim() + '/'); // 앞뒤의 공백문자를 모두 없앤다
            Console.WriteLine('/' + s.TrimStart() + '/'); // 앞의 공백문자만 없앤다
            Console.WriteLine('/' + s.TrimEnd() + '/'); // 뒤의 공백문자만 없앤다


            string[] a = s.Split(','); // 문자열을 , 로 구분하여 문자열 배열을 만든다
            foreach (var i in a) // " Hello, World! "가 " Hello"와 "World! "로 분리되었고 이를 아래 WriteLine 통해 따로따로 출력
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6); // 문자열의 일부분을 문자 배열로 저장
            Console.WriteLine(destination);
            Console.WriteLine('/' + s.Substring(8) + '/'); // 지정한 범위부터 맨 뒤까지의 문자열을 반환 후 출력
            Console.WriteLine('/' + s.Substring(8, 5) + '/'); // 지정한 범위부터 지정한 갯수까지의 문자열을 반환하고 출력

            Console.WriteLine(s.Contains("ll")); // 문자열에 지정한 문자열이 있으면 참을 반환 후 출력
            Console.WriteLine(s.IndexOf('o')); // 문자열에서 지정한 문자가 처음 나오는 위치를 반환 후 출력
            Console.WriteLine(s.LastIndexOf('o')); // 문자열에서 지정한 문자가 마지막에 나오는 위치를 반환 후 출력
            Console.WriteLine(s.CompareTo("abc")); // 비교당하는 문자열(s)과 비교하는 문자열(t)을 사전식으로 비교하여 비교당하는 문자열이 비교하는 문자열보다 앞에 나오면 마이너스 값을, 같으면 0을, 반대면 플러스를 반환


            Console.WriteLine(String.Concat("Hi~", s)); // 두 개의 문자열을 합쳐준다
            Console.WriteLine(String.Compare("abc", s)); // CompareTo의 반환값과 반대로 나옵니다
            Console.WriteLine(t = String.Copy(s)); // 문자열을 복사한다

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(", ", val); // 배열의 요소들을 지정한 문자열로 연결하여 반환합니다
            Console.WriteLine(result);
        }
    }
}