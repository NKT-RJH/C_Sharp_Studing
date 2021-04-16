using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Studing
{
    class Standard_Numeric_Format_Specifiers
    {
        public static void Method()
        {
            //Console.Clear(); Did footnote to print before things

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine( //at {0:C}, 0 is path of parameter and C define print shape
                "(C) Currency: . . . . . . . . {0:C}\n" + //accounting sign
                "(D) Decimal:. . . . . . . . . {0:D}\n" + //int
                "(E) Scientific: . . . . . . . {1:E}\n" + //scientific notation
                "(F) Fixed point:. . . . . . . {1:F}\n" + //fixed point
                "(G) General:. . . . . . . . . {0:G}\n" + //Normal
                "(N) Number: . . . . . . . . . {0:N}\n" + //put , when chiper is thousands
                "(P) Percent:. . . . . . . . . {1:P}\n" + //percentage
                "(R) Round-trip: . . . . . . . {1:R}\n" + //ignore
                "(X) Hexadecimal:. . . . . . . {0:X}\n",  //hexadecimal
                -12345678, -1234.5678f);
        }
    }
}
