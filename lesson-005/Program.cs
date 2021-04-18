using System;
using System.Text;

/*
ver: 0.0a date: 2021.04.18
autor: Mikhail625@protonmail.com
*/

/*
 * пок только шаблон\рыба 
 
 */

namespace lesson_004
{
    enum BTet
    { }


    enum Month
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

    class Program
    {
        static string GetStrFromCons(string strByDef, string strQuestion)
        {
            string strResult = "";
            if (TestForNullOrEmpty(strQuestion) == true)
            { strQuestion = "Enter value:"; }

            Console.Write(strQuestion);
            strResult = Console.ReadLine();

            // check/verife isNull Empty
            if (TestForNullOrEmpty(strResult) == true)
            {
                strResult = strByDef;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("       " + "Not value, set by default: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(strResult);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

            }
            return strResult;
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return ("  " + firstName + " " + lastName + " " + patronymic);
        }

        static void ClearScr(int countDown, int warningTimer)
        {
            bool bWarning = false;

            for (int i = (countDown + 1); i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000);
                if (i == warningTimer) { bWarning = true; }
                if (bWarning == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\r         ");
                Console.Write("\r     [{0}]", i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();



        }


        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();

            static void Task1()
            { // Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
              // block declare init vars
                string name1;
                string name2;
                string name3;
                string name4;

                bool Finish = false;

                string[] arrNegativeAnswear = { "0", "n", "N", "no", "NO", "н", "Н", "нет", "НЕТ", "", "", "", "", "", "", "" };
                string[] arrPostiveAnswear = { "1", "y", "Y", "yes", "YES", "д", "Д", "да", "ДА", "", "", "", "", "", "", "", "" };


                string nameDef1 = "Тарковский";
                string nameDef2 = "Арсений";
                string nameDef3 = "Александрович";

                string textQuestion1 = " Enter firstName:";
                string textQuestion2 = " Enter lastName:";
                string textQuestion3 = " Enter patronymic:";
                string answer;

                // block executive
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("***************     Run Task 1     ***************");
                Console.ForegroundColor = ConsoleColor.Gray;

                while (Finish == false)  // do
                {
                    answer = "";
                    name1 = GetStrFromCons(nameDef1, textQuestion1);
                    name2 = GetStrFromCons(nameDef2, textQuestion2);
                    name3 = GetStrFromCons(nameDef3, textQuestion3);

                    name4 = GetFullName(name1, name2, name3);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("*************** Output  report  & results   ******");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" Result:");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0}", GetFullName(name1, name2, name3));
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("    Next? (Y/N) :  ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    answer = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (answer.ToUpper().Equals("N") == true)
                    { Finish = true; }
                    else
                    { Finish = false; }
                }

                // shutdown countdown 
                Console.WriteLine("   \n \n   Screen clear after :");
                ClearScr(10, 5);

                // end of  Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
            }

            static void Task2()
            { // Task № 02 
              // block declare init vars

                int summaNumbers = 0;
                int countNumbers = 0; // количество слов и\или чисел вычлененных из строки; необязательный 

                string inputStr;
                string textQuestion1 = "   Enter a group of numbers separated by a space: \n   or press key [ENTER] for set value by default:";
                string valueByDefault;
                //for testing:
                /*
                valueByDefault = "01 326 625 11 0 27 147 "; // 	 correct result : 1137
                valueByDefault = "144 1"; //correct result : 145  Test:OK! 
                valueByDefault = "147 326 625 11 0 27 01 "; //correct result : 1137 Test:OK! 
                valueByDefault = "01 326 625 11 0 27 147"; //correct result : 1137 Test:OK! 
                valueByDefault = "5369 8001	2914 7786 81 7989 2139 4026";     //	 correct result :38305  Test:OK!  range 10-10000	+ \t in middle string  
                valueByDefault = "5369 8001	2914 7786	81	7989	2139	4026";    //	 correct result :38305  Test:OK!  range 10-10000	+ double SPACE in middle string  
                valueByDefault = " 6270	4245	2736	8936	4795	4932	1703	4424";// correct result :38041	range 1000-10000	+ prime symbol is SPACE
                valueByDefault = " 6270	4245	2736	8936	4795	4932	1703	4424";// correct result :38041	range 1000-10000	+ prime symbol is SPACE
                valueByDefault = "32	55	59	87	71	33	15	98 "; // correct result : 450	range 10-100    + SPACE end string 	
                */
                valueByDefault = "458	908	485	704	800	342	740	0440";// correct result : 4877  Test:OK! 	range 100-1000	 + last number 0xx

                var sb = new StringBuilder();

                // block executive
                Console.WriteLine("***************     Run Task 2     ***************");
                inputStr = GetStrFromCons(valueByDefault, textQuestion1);
                inputStr = (inputStr.Replace('\t', ' ')).Trim(' '); // избавляемся от вкравшихся табов и пограничных пробелов 
                char[] arrChars = inputStr.ToCharArray();

                // run parsing 
                {
                    int i = 0; // int j = 0;
                    do
                    {
                        if ((arrChars[i] != ' ') && (i < arrChars.Length - 1)) // or end lenth\range massive
                        {
                            sb.Append(arrChars[i]);
                        }
                        else if ((arrChars[i] != ' ') && i == arrChars.Length - 1)
                        {
                            sb.Append(arrChars[i]);
                            summaNumbers = summaNumbers + Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            countNumbers++;
                        }
                        else if (arrChars[i] == ' ')
                        {
                            summaNumbers = summaNumbers + Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            countNumbers++;
                        }
                        i++;
                    }
                    while (i < arrChars.Length);

                }
                // Report:
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("*************** Output  report  & results   ******");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("   " + "Source string : \""); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("   " + inputStr); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\" ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  Detected {0} numbers ", countNumbers);
                Console.WriteLine(""); Console.ForegroundColor = ConsoleColor.Gray;

                //countNumbers
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.WriteLine("");

                Console.Write("   " + "Summa =");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(summaNumbers);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

                Console.WriteLine("   \n \n   Screen clear after :");
                ClearScr(10, 5);
                // end of  Task № 02

            }



            static void Task3()
            {
                // block declare init vars
                Random rnd = new Random();
                string textQuestion1 = "   Введите номер месяца \n   или нажмите клавишу [Enter] \n   для ввода значения по умолчанию \n   ";
                string strErr = "   Ошибка: введите число от 1 до 12";


                Console.WriteLine("***************     Run Task 3     ***************");
                Console.WriteLine("*                                                *");
                string inputStr = GetStrFromCons(Convert.ToString(rnd.Next(1, 12)), textQuestion1);



            }


        }

    }
}

