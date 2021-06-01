using System;

namespace C_Sharp_Studing
{
    class Enumeration_Type_enum
    {
        // enum 기능은 define 한 것들을 묶어놓은 것이라 이해하면 편하다.
        enum Size { Short, Tall, Grande, Venti };
        static int[] price = { 3300, 3800, 4300, 4800 };
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 };

        public static void Method()
        {
            Console.WriteLine("커피 가격표");
            for(int i=0;i<4;i++)
            {
                if (i == (int)Size.Short)
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, price[i]);
                else if (i == (int)Size.Tall)
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, price[i]);
                else if (i == (int)Size.Grande)
                    Console.WriteLine("{0,10} : {1:C}", Size.Grande, price[i]);
                else if (i == (int)Size.Venti)
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, price[i]);
            }

            Console.WriteLine("\n커피 가격표(Enum iteration)");
            foreach (var size in Enum.GetValues(typeof(Size))) // Enum.GetValues(typeof(Size))를 사용하면 열거형 enum의 각 요소를 반복문에서 사용 가능
            {
                Console.WriteLine("{0,10} : {1:C}", size, price[(int)size]);
            }

            Console.WriteLine("\nColors Enum iteration");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine("{0,10} : {1}", color, Convert.ToInt32(color));
            }

            Console.WriteLine("\n커피 가격표(Enum iteration with value)");
            foreach (var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine("{0,10} : {1:C}", coffee, Convert.ToInt32(coffee));
            }
        }
    }
}
