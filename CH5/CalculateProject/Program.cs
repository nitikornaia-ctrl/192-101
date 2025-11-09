using System;
					
public class Program
{
	public static void Main()
	{	
/*int MaximumInterest = 50;
decimal principal;
decimal interest;
while (true)
{
 Console.Write("Enter principle: ");
principal = Convert.ToDecimal(Console.ReadLine());
	
if(principal >= 0 ){
	
break;
}
	
Console.Write("Principal cannot be negative!!");
Console.Write("Try again!!");
Console.WriteLine("");
}

while (true)
{
 Console.Write("Enter interest: ");
interest = Convert.ToDecimal(Console.ReadLine());
	
if(interest >= 0 & interest <= MaximumInterest){

break;
}
	
Console.Write("Interest cannot be negative or greater than " + MaximumInterest);
Console.Write("Try again!!");
Console.WriteLine("");
}
		Console.Write("Enter number of year: ");
		int duration = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Principle = " + principal + " %");
		Console.WriteLine("Interest = "+interest + " %");
		Console.WriteLine("Duration = "+duration +" years");
		Console.WriteLine("");
		
		int year = 1;
		while(year<= duration)
		{
			decimal interestPaid = principal * (interest/100);
			principal = principal + interestPaid;
			principal = decimal.Round(principal,2);
			Console.WriteLine(year + " - " + principal);
			year++;
			
		}
        
        */


        #region การใช้งาน ทั้งแบบลูปไม่รู้จบ และแบบมาตรฐาน
        /*
        รุปแบบ for แบบมาตรฐาน
        for(กำหนดค่า;เงื่อนไข;step)
        {
         //statement
        }
        รูปแบบวนไม่รู้จบ
        for(;;){
        //statement
        }
        */
       int MaximumInterest = 50;
decimal principal;
decimal interest;
for (;;)
{
 Console.Write("Enter principle: ");
principal = Convert.ToDecimal(Console.ReadLine());
	
if(principal >= 0 ){
	
break;
}
	
Console.Write("Principal cannot be negative!!");
Console.Write("Try again!!");
Console.WriteLine("");
}

for (;;)
{
 Console.Write("Enter interest: ");
interest = Convert.ToDecimal(Console.ReadLine());
	
if(interest >= 0 & interest <= MaximumInterest){

break;
}
	
Console.Write("Interest cannot be negative or greater than " + MaximumInterest);
Console.Write("Try again!!");
Console.WriteLine("");
}
		Console.Write("Enter number of year: ");
		int duration = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Principle = " + principal + " %");
		Console.WriteLine("Interest = "+interest + " %");
		Console.WriteLine("Duration = "+duration +" years");
		Console.WriteLine("");
		
	
		for(int year = 1;year<= duration;year++)
		{
			decimal interestPaid = principal * (interest/100);
			principal = principal + interestPaid;
			principal = decimal.Round(principal,2);
			Console.WriteLine(year + " - " + principal);

			
		}
        #endregion
		
	}

}