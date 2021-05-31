using System;

namespace C_Sharp_Studing
{
    class Standard_Numeric_Format_Specifiers2
    {
        public static void Method()
        {
            Console.WriteLine("{0,8}", 1234);       // Print : ____1234
            Console.WriteLine("{0,-8}", 1234);      // Print : 1234____

            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);
            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);
            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s);

            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.00}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);

            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);

        }
    }
}
