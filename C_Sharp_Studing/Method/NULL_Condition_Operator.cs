using System;

namespace C_Sharp_Studing
{
    class NULL_Condition_Operator
    {
        public static void Method()
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름: ");
            } while ((animal = Console.ReadLine()) != ""); // 아무것도 입력하지 않으면, 프로그램 종료
        }
        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4) // ?를 사용하면 변수의 값이 NULL이라면 Length를 찾지 않습니다. 만약 이를 사용하지 않는다면 animal != null을 사용해야합니다
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}