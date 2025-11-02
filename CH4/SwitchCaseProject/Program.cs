using System;

class Program
{
    static void Main()
    {
        // Console.Write("Enter number 1 - 7 : ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // switch (num)
        // {
        //     case 1: Console.WriteLine("วันจันทร์"); break;
        //     case 1: Console.WriteLine("วันอังคาร"); break;
        //     case 1: Console.WriteLine("วันพุธ"); break;
        //     case 1: Console.WriteLine("วันพฤหัสบดี"); break;
        //     case 1: Console.WriteLine("วันศุกร์"); break;
        //     case 1: Console.WriteLine("วันเสาร์"); break;
        //     case 1: Console.WriteLine("วันอาทิตย์"); break;
        //     default : Console.WriteLine("กรุณากรอก 1 - 7 เท่านั้น!!!"); break;
        // }


        // Console.Write("Enter number 1 : ");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter number 2 : ");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter +, -, * : ");
        // char sige = Convert.ToChar(Console.ReadLine());
        // switch (sige)
        // {
        //     case '+': Console.WriteLine($"ผลบวกของ {num1} กับ {num2} = {num1 + num2}"); break;
        //     case '-': Console.WriteLine($"ผลลบของ {num1} กับ {num2} = {num1 - num2}"); break;
        //     case '*': Console.WriteLine($"ผลคูณของ {num1} กับ {num2} = {num1 * num2}"); break;
        //     default: Console.WriteLine("กรุณากรอกเครื่องหมาย + หรือ - หรือ * เท่านั้น!!!"); break;
        // }

        Console.Write("Enter A or B or C: ");
        string alpha = Console.ReadLine().ToUpper();
        switch (alpha)
        {
            case "A": Console.WriteLine("กด A"); break;
            case "B": Console.WriteLine("กด B"); break;
            case "C": Console.WriteLine("กด C"); break;
            default: Console.WriteLine("กรุณาพิมพ์ A หรือ B หรือ C เท่านั้น!!!"); break;
        }
    }
}