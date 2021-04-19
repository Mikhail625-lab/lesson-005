using System;
using System.Text;

/*
ver: 0.0a date: 2021.04.18
autor: Mikhail625@protonmail.com
*/

/*
 * Great sorry ... пока ничего толкового не сделано : ((( 
 * ноя я активно работаю над этим 
 * пок только шаблон\рыба 
 
 */

namespace lesson_005
{

    /*
     * 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

        2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
4. Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;

Конструктор класса должен заполнять эти поля при создании объекта;
Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
Создать массив из 5 сотрудников

Пример:
Person[] persArray = new Person[5]; // Вначале объявляем массив объектов
persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30); // потом для каждой ячейки массива задаем объект
persArray[1] = new Person(...);
...
persArray[4] = new Person(...);
     * 
     * 
     * 
     * 
     * 
     */


    class Program
    {


        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();

            static void Task1()
            { // Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
              // block declare init vars
                string name1;
                string name2;
                string name3;
                string name4;

                bool Finish = false;


                // string vars for default
                string nameDef1 = "file_txt";
                string nameDef2 = "";
                string nameDef3 = "О, как душа стихает вся до дна!";  
                //string var for question text 
                string textQuestion1 = " Enter pleas name files, and press key [Enter]:";
                string textQuestion2 = " Enter any data , and press key [Enter]:";
                string textQuestion3 = " ";
                string inputStr;

                // block executive
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("***************     Run Task 1     ***************");
                Console.ForegroundColor = ConsoleColor.Gray;


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

        
        // under

                static string GetStrFromCons(string strQuestion, string strByDef)
        {
            string strResult = "";
            if (TestForNullOrEmpty(strQuestion) == true)
            { strQuestion = "   Enter value:"; }

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

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = (s == null || s == string.Empty);
            return result;
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



    }
}

