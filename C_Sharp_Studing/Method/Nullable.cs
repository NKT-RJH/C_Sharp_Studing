using System;

namespace C_Sharp_Studing{
    class nullable
    {
        // int형 같은 값 형식의 자료형의 변수는 null값을 할당할 수 없습니다
        // 따라서 nullable형을 통해서 값 형식의 변수에 null을 할당할 수 있습니다
        // 혹은 ?를 붙여 사용할 수도 있습니다
        // nullable형을 nullable형이 아닌 타입에 할당할 때는 ?? 연산자를 사용합니다
        public static void Method()
        {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            int? x = null;
            int j = x ?? 0;
            Console.WriteLine("x = {0}, j = {1}", x, j);

            Console.WriteLine("x >= 10 ? {0}", x >= 10);
            Console.WriteLine("x < 10 ? {0}", x < 10);

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
}
