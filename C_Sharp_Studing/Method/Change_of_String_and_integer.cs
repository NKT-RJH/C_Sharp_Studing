using System;

namespace C_Sharp_Studing
{
    class Change_of_String_and_integer
    {
        public static void Method()
        {
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            // 아래의 메소드 TryParse가 변환 성공 시, result의 값은 참. 실패하면 거짓이다
            bool result = Int32.TryParse(input, out value); // TryParse : 문자열을 정수형으로 변환시켜줌. 단, 문자열 사이에 공백이 있거나, 정수로 바꿀 수 없는 문자가 있으면 false 반환
                                                            //            원래 TryParse의 리턴값은 bool형이지만, out을 이용해서 정수값을 받는 형식이다
            if (!result)
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.", input);
            else
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            try // 일단 코드를 실행한다. 하지만 코드에 에러가 발생하면 catch로 이동한다
            {
                double m = Double.Parse(input); // TryParse : 문자열을 정수형으로 변환시켜줌. 단, 문자열 사이에 공백이 있거나, 정수로 바꿀 수 없는 문자가 있으면 시스템 에러가 발생되어 실행이 안됨
                // double m = Convert.ToDouble(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
            }
            catch (FormatException e) // 에러에 맞는 에러메시지를 출력한다. 이 코드 덕분에 Parse를 사용할 때 변환에 실패해도 프로그램이 실행되지 않는 것을 방지할 수 있음
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}