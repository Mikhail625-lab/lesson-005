using System;
using System.IO;
using System.Text;

/*
ver: 0.1b date: 2021.04.18
autor: Mikhail625@protonmail.com
*/

/*
   Выполнена (увы) только задача #1
 
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
            Task2();
            //Task3();

            static void Task1()
            { // Task № 01  
              // block declare init vars
                string nameFile1 = "file_txt";
                string extFile = ".txt";
                string textContent2;
                string folderFiles3 = @"_files"; // name folder with text file(s)
                string pathCurrStart = Directory.GetCurrentDirectory(); // current folder   
                // string workFldr = lvlUpPath(pathCurrStart, 3) + "\\" + folderFiles3; 
                string workFldr = folderFiles3;

                // string vars for default
                string nameDef1 = "";
                string nameDef3 = "Я не ропщу на трудный путь земной,   \n" +
                                    "Я буйного не слушаю невежды:       \n" +
                                    "Моим ушам понятен звук иной,       \n" +
                                    "И сердцу голос слышится надежды    \n" +
                                    "С тех пор, как Санцио передо мной  \n" +
                                    "Изобразил склоняющую вежды,        \n" +
                                    "И этот лик, и этот взор святой,    \n" +
                                    "Смиренные и легкие одежды,         \n" +
                                    "И это лоно матери, и в нем         \n" +
                                    "Младенца с ясным, радостным челом, \n" +
                                    "С улыбкою к Марии наклоненной.     \n" +
                                    "О, как душа стихает вся до дна!    \n" +
                                    "Как много со святого полотна       \n" +
                                    "Ты шлешь, мой Бог, с пречистою Мадонной!";

                //string var for question text 
                string textQuestion1 = " Enter pleas name files, and press key [Enter] \n or press key [Enter] for set default value:";
                string textQuestion2 = " Enter any data , and press key [Enter] \n or press key [Enter] for set default value:";
                string inputStr;

                Console.WriteLine(pathCurrStart);

                nameDef1 = nameFile1;
                // block executive

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("***************     Run Task 1     ***************");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(pathCurrStart);

                inputStr = GetStrFromCons(textQuestion1 , nameDef1 );
                inputStr = (inputStr.Replace('\t', ' ')).Trim(' '); // избавляемся от вкравшихся табов и пограничных пробелов 
                nameFile1 = inputStr+extFile ; inputStr = "";

                inputStr = GetStrFromCons(textQuestion2, nameDef3);
                inputStr = (inputStr.Replace('\t', ' ')).Trim(' '); // избавляемся от вкравшихся табов и пограничных пробелов 
                textContent2 = inputStr; inputStr = "";

                // Get info about file 
                System.IO.FileInfo fi = new System.IO.FileInfo(pathCurrStart + "\\" + nameFile1);
                // stream for write
                System.IO.StreamWriter sw ;

                //
                if (fi.Exists == true) { sw = fi.AppendText(); }
                else { sw = fi.CreateText(); }
                sw.WriteLine(textContent2);
                sw.Close();


                // shutdown countdown 
                Console.WriteLine("   \n \n   Screen clear after :");
                ClearScr(7, 3);

                // end of  Task № 01  
            }

            static void Task2() // Task № 02 Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            { // Task № 02 Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
              // block declare init vars
                string nameFile1 = "startup";
                string extFile = ".txt";
                string postfix = ""; // DateTime.Now.Date.ToString("n");
                //rtbAdd(String.Format("Submitted on {0:MM/dd/yyyy} at {0:HH:mm:ss.ffffff}", DateTime.Now));
                postfix = Convert.ToString (DateTime.Now.Hour) ;
                postfix += ":" + Convert.ToString(DateTime.Now.Minute);
                postfix += ":" + Convert.ToString(DateTime.Now.Second);

                // block executive

                // run parsing 

                // Report:
                /*
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("*************** Output  report  & results   ******");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("   " + "Source string : \""); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("   " + inputStr); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\" ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  Detected {0} numbers ", countNumbers);
                Console.WriteLine(""); Console.ForegroundColor = ConsoleColor.Gray;
                */

                //countNumbers
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.WriteLine("");



                Console.WriteLine("   \n \n   Screen clear after :");
                ClearScr(10, 5);
                // end of  Task № 02

            }



            static void Task3()
            {

                string textQuestion1 = "Quo vadis?";
                Random rnd = new Random();

                // block declare init vars


                Console.WriteLine("***************     Run Task 3     ***************");
                Console.WriteLine("*                                                *");
                //string inputStr = GetStrFromCons(Convert.ToString(textQuestion1 , Convert.ToString( rnd.Next(1, 12))   ) );



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

        static bool   TestForNullOrEmpty(string s)
        {
            bool result;
            result = (s == null || s == string.Empty);
            return result;
        }

        static void   ClearScr(int countDown, int warningTimer)
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

