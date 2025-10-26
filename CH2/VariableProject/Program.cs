using System;
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #region Declare Variable
              // //รูปแบบ การประกาศตัวแปล DataType VariableName;
              // //ประกาศก่อน แล้วเรียกใช้ภายหลัง
              // int number1; //ประกาศตัวแปลชื่อ number1 มีชนิดข้อมูลเป็น Integer
              // number1 = 2; //เรียกใช้ตัวแปล n โดยกำหนดให้เก็บค่า 2 ไว้
              // Console.WriteLine("number1 = "+ number1);
              // //ประกาศพร้อมกำหนดค่า
              // int number2 = 200;
              //  Console.WriteLine("number2 = "+ number2);
              //  //นำค่า number2 กำหนดค่าให้ number1
              //  number1 = number2;
              //  Console.WriteLine("number1 = "+ number1);
              //  int m;
              //  int n = m=10;
              //  m = 100;
              //  Console.WriteLine("m : " + m);

              //  //
              //  int a = 109/10;
              //  int b = 1 / 2;
              //  Console.WriteLine("109 / 10 = " + a);
              //  Console.WriteLine("1 / 2 : " + b);

              // int fahr = 14;
              // int celsius = (fahr - 32) * (5 / 9);
              // Console.WriteLine("Fahrenheit : "+ fahr);
              // Console.WriteLine("Celsius : "+ celsius);


              int fahr = 14;
              int celsius = (fahr - 32) * (5 / 9);
              Console.WriteLine("Fahrenheit : "+ fahr);
              Console.WriteLine("Celsius : "+ celsius);
              #endregion */

            /* #region การใช้งาน Floating-Point
             int fahr = 40;

             double celsiusD = (fahr - 32.0) * (5.0 / 9.0);
             float celsiusF = (fahr - 32.0f) * (5.0f / 9.0f);
             Console.WriteLine("Fahrenheit : "+ fahr);
             Console.WriteLine("Celsius D: " + celsiusD);
             Console.WriteLine("Celsius F: "+ celsiusF);
             #endregion */

            /* #region Bool มี 2 ค่า true,false
            bool IsTrue = true;
            bool IsFalse = false;
            #endregion */

            /* #region Charector ตัวอักษร ประกอบด้วย char และ string
             //char ใช้เครื่องหมาย '' ครอบ
             char a = 'a';
             char b = 'b';
             char c = a+b;
             Console.WriteLine("Char c = " + c);

            #endregion */

            /*#region การใช้ @ นำ string
            string string2 = "This is a line"
                            + "and so is this";
                            
            string string3 = @"This is a line 
                             and so is this";

            string string4 = @"c:\document\a\text.txt";

            string string5 = "c:\name\text";
            Console.WriteLine("string4 = " + string4);
            Console.WriteLine("string5 = " + string5);
            #endregion*/

            #region การใช้ Date Time
            /*
            ปีอธิกสุรทิน หาก
                 ปีนั้นหารด้วย 4 ลงตัว
                     และถ้าปีนั้นหารด้วย 100 ลงตัว
                         ต้องหารด้วย 400 ลงตัวด้วย
            */
            DateTime randomYear = new DateTime(2020, 10, 19);
            bool isLeapYear = DateTime.IsLeapYear(randomYear.Year);
            Console.WriteLine(randomYear.Year + " is leap year " + isLeapYear);

            DateTime currentTime = DateTime.Now;
            isLeapYear = DateTime.IsLeapYear(currentTime.Year);
            Console.WriteLine(currentTime.Year + " is leap year " + isLeapYear);

            DateTime currentMoment = DateTime.Now;
            Console.WriteLine("Current Date : " + currentMoment.Date);
            Console.WriteLine("Current Year : " + currentMoment.Year);
            Console.WriteLine("Current Month : " + currentMoment.Month);
            Console.WriteLine("Current Day : " + currentMoment.Day);
            Console.WriteLine("Current DayOfWeek : " + currentMoment.DayOfWeek);
            Console.WriteLine("Current DayOfYear : " + currentMoment.DayOfYear);
            Console.WriteLine("Current Hour : " + currentMoment.Hour);
            Console.WriteLine("Current Minute : " + currentMoment.Minute);  
            Console.WriteLine("Current Second : " + currentMoment.Second);    
            #endregion
          
        }
    }
}