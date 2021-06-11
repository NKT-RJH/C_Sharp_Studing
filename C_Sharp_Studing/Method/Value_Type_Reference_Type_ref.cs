using System;

namespace C_Sharp_Studing
{
    class Value_Type_Reference_Type_ref
    {
        // 값 형식 : int double char bool ete... 그리고 enum struct
        // 참조 형식 : object string dynamic class interface delegate
        // **중요** C#은 포인터 대신 ref를 써서 주소를 전달한다.
        public static void Method()
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after passing";
        }

        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}