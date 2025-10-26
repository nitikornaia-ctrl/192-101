using System; //เรียกใช้ namespace ของ class System

/*
โปรแกรมรับชื่อจากผู้ใช้ผ่านทาง Console
โดยใช้ตัวแปลในการเก็บค่า
*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter you firstname: "); // ขึ้นบรรทัดใหม่
        string firstName = Console.ReadLine();      // รับข้อมูลเป็นตัวอักษรเท่านั้น
        Console.Write("Enter you lastname: ");      // ไม่ขึ้นบรรทัดใหม่
        string lastName = Console.ReadLine(); 

        /*
        แสดงผ่านทางจอภาพโดยมีรูปแบบดังนี้ 
        Hollo firstname lastname
        */
        Console.WriteLine("Hello " + firstName + " " + lastName);
    }
}

