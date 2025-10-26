using System;

class Program
{
    // private class Student
    // {

    //     public string Name;
    // }

    //     #region 01
    // static void Main()
    // {
    //     Student s1 = new Student();
    //     s1.Name = "abc";

    //     Student s2 = new Student();
    //     s2.Name = s1.Name.ToUpper();

    //     Student s3 = new Student();
    //     s3.Name = s2.Name.ToLower();

    //     Console.WriteLine("s1 = " + s1.Name);
    //     Console.WriteLine("s2 = " + s2.Name);
    //     Console.WriteLine("s3 = " + s3.Name);

    // }
    //     #endregion

    /* #region Equality for all strings: The Compare() method: BuildASentence
     static void Main()
     {
         Console.WriteLine("Each line you enter will be added to a sentence unit you enter EXIT or QUIT");
         Console.Write("Enter a string: ");
         string line = Console.ReadLine();
         string sentence = "";
         string[] terms = { "EXIT", "QUIT" };
         bool quitting = false;

         foreach (string term in terms)
         {
             // string tmpLine = line.ToLower();
             // string tmTerm = term.ToLower();
             Console.WriteLine("line : " + line + " term :" + term);
             if (string.Compare(line, term) == 0)
             {
                 quitting = true;
             }

             if (quitting == true)
             {
                 break;
             }
             sentence = string.Concat(sentence, line);
             Console.WriteLine("\nyou've entered: " + sentence);
         }

         Console.WriteLine("\nTotal sentence: \n" + sentence);
     }
     #endregion */

    /*#region Equality for all strings: The Compare() method: BuildASentence
    static void Main()
    {
        Console.WriteLine("Each line you enter will be added to a sentence unit you enter EXIT or QUIT");

        string sentence = "";
        string[] terms = { "EXIT", "QUIT" };

        while (true)
        {
            Console.Write("Enter a string: ");
            string line = Console.ReadLine();

             bool quitting = false;
            if ((string.Compare("exit",line,true) == 0)||(string.Compare("quit",line,true)==0))
            {
                quitting = true;
            }

            if (quitting == true)
            {
                break;
            }
            sentence = string.Concat(sentence, line);
            Console.WriteLine("\nyou've entered: " + sentence);
        }

        Console.WriteLine("\nTotal sentence: \n" + sentence);
    }
    #endregion */

    /*#region 'loop'
    static void Main()
    {
        // loop 1 เข้าถึงตัวอักษรแต่ละตัวของสตริง

        // string food = "chesseburger";
        // foreach (char c in food)
        // {
        //     Console.WriteLine(c);
        // }

        // loop 2 อ่านเฉพาะตัวพิมทพ์ใหญ่เท่านั้น
        string food2 = "CHeSSeburGER";
        bool isUpperCase = true;
        foreach (char c2 in food2)
        {
            if (!char.IsUpper(c2)) //หากเจอตัวพิมพ์เล็กออกจากโปรแกรมทันที
            {
                isUpperCase = false;
                break;
            }
            Console.Write(c2);
        }
        Console.WriteLine($"All uppercase? {isUpperCase}");
    }
    #endregion */


#region 'หา index'
static void Main()
    {
        string food = "chesseburger";
        int indexOfLetter = food.IndexOf('s');
        Console.WriteLine(indexOfLetter);
        char[] charToLokeFor = { 'a', 'b', 'c' };
        int indexOfFirstFound = food.IndexOfAny(charToLokeFor);
        Console.WriteLine(indexOfFirstFound);
        int indexOfLastFound = food.LastIndexOf('s');
        Console.WriteLine(indexOfLastFound);
        if (food.Contains("ee"))
        {
            Console.WriteLine("Chesssssssss");
        }
        else
        {
            Console.WriteLine("Noooo Chessssss");
        }
        string sub = food.Substring(6, food.Length - 6);
        Console.WriteLine(sub);
        //Is my string Empty
        bool notThere = string.IsNullOrEmpty(food);
        Console.WriteLine(notThere);
        string name = "a";
        bool notThereName = string.IsNullOrEmpty(name);
        string name2 = string.Empty;
        bool notThereName2 = string.IsNullOrEmpty(name2);
        Console.WriteLine(notThereName);
         Console.WriteLine(notThereName2);
    }
    #endregion

}