class Program
{
    static void Main()
    {
        //การประกาศค่าคงที่
        const int MAXIMUMINTEREST = 50;
        Console.Write("Enter principal: ");//เงินต้้น
        decimal principal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter interest: ");//อัตราดอกเบี้ย
        decimal interest = Convert.ToDecimal(Console.ReadLine());
        if (principal < 0)
        {
            Console.WriteLine("Pricipal cannot be negative!!!");
            principal = 0;
        }
        else
        {
            if (interest < 0 | interest > MAXIMUMINTEREST)
            {
                Console.WriteLine("Interest cannot be negative or greater than " +
                MAXIMUMINTEREST);
                interest = 0;
            }
            else
            {
                Console.Write("Enter number of years: ");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Principal = " + principal);
                Console.WriteLine("Duration = " + duration + "years.");
                Console.WriteLine();


                decimal interestPaid = principal * (interest / 100);
                decimal total = principal + interestPaid;

                Console.WriteLine();
                Console.WriteLine("Interest paid = " + interestPaid);
                Console.WriteLine("Total = " + total);
            }

        }
    }
}