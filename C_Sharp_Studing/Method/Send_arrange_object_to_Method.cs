using System;

namespace C_Sharp_Studing
{
    class Send_arrange_object_to_Method
    {
        public static void Method()
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);
            Change(arr); // 배열의 이름을 매개변수로 전달
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);

            Student s1 = new Student(); // 객체 생성
            s1.name = "Alpha";
            Console.WriteLine("Main() before: " + s1.name);
            Change(s1);
            Console.WriteLine("Main() after: " + s1.name);
        }
        private static void Change(int[] arr) // 배열을 매개변수로 받음
        {
            arr[0] = -10;
        }
        private static void Change(Student s1) // 객체를 매개변수로 받음
        {
            s1.name = "Beta";
        }
        class Student // 멤버로 public string name을 갖는 클래스
        {
            public string name;
        }
    }
}