// C# program to extract a substring from a larger 
// string using methods of the String class 
using System;
using System.Text;


class Geeks
{

    // Main Method 
    public static void Main()
    {
        string sentence = "Geeks For Geeks";                   // Extract the second word

        // taking the first space position value 
        int startpos = sentence.IndexOf(" ") + 1;
        Console.WriteLine(startpos);

        // taking the second space position value 
        int endpos2 = sentence.IndexOf(" ", startpos) - startpos;
        Console.WriteLine(endpos2);

        // now extract second word from the sentence 
        string wrd = sentence.Substring(startpos, endpos2);     //(startposition, howmanynextcharacters)
        Console.WriteLine(wrd);

        
        
        
        
        
        //String Builder
        StringBuilder object1 = new StringBuilder("This is the text");
        object1.Append(" and the attached ");                   //Append
        Console.WriteLine(object1);
        object1.Insert(5, "inserted text ");                    //Inserting at specific position
        Console.WriteLine(object1);
        object1.Remove(5, 9);
        Console.WriteLine(object1);                             //Removing
        object1.Replace('a', 'b');
        Console.WriteLine(object1);                             //Replacing



        



        
        Console.ReadLine();
    }
}