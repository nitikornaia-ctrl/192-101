using System;

class Program
{
    static void Main()
    {
        // #region การใช้งาน if และการแปลงชนิดข้อมูลด้วย class convert
        // /* รูปแบบเงื่อนไข if
        // if(condition)
        // {
        //  code ทำงานเมื่อเงื่อนไขเป็นจริง
        // }
        // */

        // //แบบ 1

        // // Console.Write("Enter number 1- 10: ");
        // // string numberInput = Console.ReadLine();
        // // //เป็นการแปลงชนิดข้อมูล string ไปเป็นชนิดข้อมูลที่เป็นตัวเลข
        // // int number = Convert.ToInt32(numberInput);

        // //แบบ 2
        // Console.Write("Enter number 1- 10: ");
        // //เป็นการแปลงชนิดข้อมูล string ไปเป็นชนิดข้อมูลที่เป็นตัวเลข
        // int number = Convert.ToInt32(Console.ReadLine());
        // if (number == 10)
        // {
        //     Console.WriteLine("You number is 10");
        // }
        // #endregion

        /*   #region Name
           string username = "admin";
           int password = 123;
           Console.Write("Enter username: ");
           string user = Console.ReadLine();
           Console.Write("Enter password: ");
           int pass = Convert.ToInt32(Console.ReadLine());
           if (user == username && pass == password)
           {
               Console.WriteLine("Login Success");
           }
           else
           {
               Console.WriteLine("Username or Password wrong");
           }
           #endregion

           #region terary การเขียนประโยคเงื่อนไขแบบสั้น
           Console.Write("Enter Number: ");
           int number = Convert.ToInt32(Console.ReadLine());
           string str = (number >= 0) ? "Positive Number" : "Negative Number";
           Console.WriteLine($"ตัวเลขที่ผู้ใช้กรอก {number} เป็น " + str);
           #endregion */

        /* #region โปรแกรมคำนวณผลตอบแทน (CalculateInterest) ด้วย if
         Console.Write("Enter principal: ");//เงินต้้น
         decimal principal = Convert.ToDecimal(Console.ReadLine());
         Console.Write("Enter interest: ");//อัตราดอกเบี้ย
         decimal interest = Convert.ToDecimal(Console.ReadLine());
         if (interest < 0)
         {
             Console.WriteLine("Interest cannot be negative!!!");
             interest = 0;
         }

         decimal interestPaid = principal * (interest / 100);
         decimal total = principal + interestPaid;
         Console.WriteLine();
         Console.WriteLine("Principal = " + principal);
         Console.WriteLine("Interest = " + interest + " %");
         Console.WriteLine();
         Console.WriteLine("Interest paid = " + interestPaid);
         Console.WriteLine("Total = " + total);
         #endregion */

        #region โปรแกรมคำนวณผลตอบแทน (CalculateInterest) ด้วย if-else
        Console.Write("Enter principal: ");//เงินต้้น
        decimal principal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter interest: ");//อัตราดอกเบี้ย
        decimal interest = Convert.ToDecimal(Console.ReadLine());
        if (interest < 0)
        {
            Console.WriteLine("Interest cannot be negative!!!");
            interest = 0;
        }
        else
        {
            decimal interestPaid = principal * (interest / 100);
            decimal total = principal + interestPaid;
            Console.WriteLine();
            Console.WriteLine("Principal = " + principal);
            Console.WriteLine("Interest = " + interest + " %");
            Console.WriteLine();
            Console.WriteLine("Interest paid = " + interestPaid);
            Console.WriteLine("Total = " + total);
        }


        #endregion
    }
}