class Program
{
    static void Main()
    {
        // //CalculateTable1
        // const int MAXIMUMINTEREST = 50;
        // Console.Write("Enter principal: ");//เงินต้้น
        // decimal principal = Convert.ToDecimal(Console.ReadLine());
        // Console.Write("Enter interest: ");//อัตราดอกเบี้ย
        // decimal interest = Convert.ToDecimal(Console.ReadLine());
        // if (principal < 0)
        // {
        //     Console.WriteLine("Pricipal cannot be negative!!!");
        //     principal = 0;
        // }
        // else
        // {
        //     if (interest < 0 | interest > MAXIMUMINTEREST)
        //     {
        //         Console.WriteLine("Interest cannot be negative or greater than " +
        //         MAXIMUMINTEREST);
        //         interest = 0;
        //     }
        //     else
        //     {
        //         Console.Write("Enter number of years: ");
        //         int duration = Convert.ToInt32(Console.ReadLine());
        //         Console.WriteLine("Principal = " + principal);
        //         Console.WriteLine("Duration = " + duration + " years.");
        //         Console.WriteLine();

        //         int year = 1;
        //         /*        #region การใช้ while loop

        //                 while (year <= duration)
        //                 {
        //                     decimal interestPaid = principal * (interest / 100);
        //                     principal = principal + interestPaid;
        //                     principal = decimal.Round(principal, 2);

        //                     Console.WriteLine(year + " - " + principal);

        //                     year += 1;// year = year + 1
        //                 }

        //                 #endregion */

        //         /*   #region การใช้ do...while loop

        //            do
        //            {
        //                decimal interestPaid = principal * (interest / 100);
        //                principal = principal + interestPaid;
        //                principal = decimal.Round(principal, 2);

        //                Console.WriteLine(year + " - " + principal);

        //                year += 1;// year = year + 1
        //            }  while (year <= duration) ;

        //            #endregion */


        //         #region การใช้ Break up เพื่่อหยุดการทำงานของโปรแกรม

        //         while (year <= duration)
        //         {
        //             decimal interestPaid = principal * (interest / 100);
        //             principal = principal + interestPaid;
        //             principal = decimal.Round(principal, 2);

        //             Console.WriteLine(year + " - " + principal);

        //             year += 1;// year = year + 1

        //             if (principal >= 2000) break;
        //         }
        //         ;

        //         #endregion

        //     } 

        //     //CalculateInterestTable 2 หากกรอกเลขติดลบ ให้วนกลับไปกรอกค่าใหม่ จนกว่าจะเป็นบวกถึงคำนวณ

        // }
        const int MAXIMUMINTEREST = 50;
        decimal principal;
        while (true)
        {
            Console.Write("Enter principal: ");//เงินต้้น
            principal = Convert.ToDecimal(Console.ReadLine());

            if (principal >= 0)
            {
                break;
            }
            Console.WriteLine("Pricipal cannot be negative!!!");
            Console.WriteLine("Try again!!!");
            Console.WriteLine();
        }

        decimal interest;
        while (true)
        {
            Console.Write("Enter interest: ");
            interest = Convert.ToDecimal(Console.ReadLine());

            if (interest < 0 | interest > MAXIMUMINTEREST)
            {
                break;
            }
            Console.WriteLine("Interest cannot be negative!!!");
            Console.WriteLine("Try again!!!");
            Console.WriteLine();
        }
        Console.Write("Enter number of years: ");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Principal = " + principal);
        Console.WriteLine("Duration = " + duration + " years.");
        Console.WriteLine();

        int year = 1;

        while (year <= duration)
        {
            decimal interestPaid = principal * (interest / 100);
            principal = principal + interestPaid;
            principal = decimal.Round(principal, 2);

            Console.WriteLine(year + " - " + principal);

            year += 1;// year = year + 1
            if (principal >= 2000) break;
        }

    }
}