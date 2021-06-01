using System;

namespace C_Sharp_Studing
{
    class MAIN_of_this_project
    {
        public static void Main(string[] args)
        {
            int choice;

            Console.Write("실행할 코드 선택 : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Print_HelloWorld.Method();
                    break;
                case 2:
                    Add_Variable_values.Method();
                    break;
                case 3:
                    Data_Type.Method();
                    break;
                case 4:
                    Standard_Numeric_Format_Specifiers1.Method();
                    break;
                case 5:
                    Standard_Numeric_Format_Specifiers2.Method();
                    break;
                case 6:
                    Use_Write.Method();
                    break;
                case 7:
                    Way_to_use_WriteLine1.Method();
                    break;
                case 8:
                    Way_to_use_WriteLine2.Method();
                    break;
                case 9:
                    Way_to_use_WriteLine3.Method();
                    break;
                case 10:
                    Write_and_ReadLine.Method();
                    break;
                case 11:
                    Data_Type_Realnumber.Method();
                    break;
                case 12:
                    Casting_and_Change_Datatype.Method();
                    break;
                case 13:
                    Change_of_String_and_integer.Method();
                    break;
                case 14:
                    Convert_Class_and_Print_Computer_Numer_System.Method();
                    break;
                case 15:
                    Class_String.Method();
                    break;
                case 16:
                    String_Format.Method();
                    break;
                case 17:
                    String_and_StringBuilder.Method();
                    break;
                case 18:
                    Enumeration_Type_enum.Method();
                    break;
                case 19:
                    Const_and_Readonly.Method();
                    break;
            }
        }
    }
}