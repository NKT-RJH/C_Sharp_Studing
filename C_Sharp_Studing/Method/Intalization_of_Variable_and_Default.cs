using System;

namespace C_Sharp_Studing
{
    class Intalization_of_Variable_and_Default
    {
        // C#은 초기화되지 않은 변수를 사용할 수 없음
        // default를 사용하면 어떤 형식이라도 초기화시켜줍니다

        /*                                           -형식에 따른 기본값-
                참조 형식 : null
                숫자 값 형식 : 0
                bool : false
                char : '\0'
                enum : 식 (E)0 값이며 여기서 E는 열거형 식별자입니다
                struct : 모든 값 형식 필드를 기본값으로 설정하고 모든 참조 형식 필드를 null로 설정하여 생성한 값
                nullable 형식 : HasValue 속성은 false이고 Value 속성은 정의되지 않은 인스턴스
        */
        enum E { Red, Green, Blue }; // enum은 무조건 메소드 밖에서 선언
        
        public static void Method()
        {
            int a = default;
            string s = default; // 이 상태에서 출력하면 아무것도 안 뜸
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E)); // enum의 default는 첫 번째 요소
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetLast());
            
            MyList<int> sList = new MyList<int>();
            Console.WriteLine("sList : " + sList.GetLast());

            MyList<string> myList = new MyList<string>();
            MyList<int> myList1 = new MyList<int>();
        }
    }
    public class MyList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }
        private Node head = default;

        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode;
        }
        public T GetLast()
        {
            T temp = default(T);

            Node current = head;
            while(current!=null)
            {
                temp = current.data;
                current = current.next;
            }

            return temp;
        }
    }
}