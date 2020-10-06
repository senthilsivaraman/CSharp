using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();


            //Adding elements to the dictionary

            myDict.Add("Messi", "Greatest of All time");
            myDict.Add("RonaldoCR7", "Goal Scoring Machine");
            myDict.Add("Puyol", "Best Captain Ever");
            myDict.Add("Cryuff", "What Barca now is, him");
            myDict.Add("Xavi", "Pass Pass Pass");
            myDict.Add("Ronaldo", "Best Striker of all time");
            myDict.Add("Pique", "Next Barca President");
            
                //Replacing
            myDict["Xavi"] = "Upcoming coach of Barca"; //It replaces the value at key3
            //myDict.Add("Xavi", "Upcoming coach of Barca"); --> This throws error

            //Printing specific Value
            Console.WriteLine("Value at Dict[4] is {0}\n\n", myDict["Messi"]);

            //Printing all values
            foreach(KeyValuePair<string, string> obj in myDict)
            {
                Console.WriteLine("Key: {0}\n Value: {1}\n\n", obj.Key, obj.Value);
            }


            //Priting total number of values in Dictionary
            Console.WriteLine("Total values in this dictionary: {0}", myDict.Count);
            Console.WriteLine("\n");
            
            //Check for an Existing Elements
            Console.WriteLine("Contains Key Messi: {0}", myDict.ContainsKey("Messi"));
            Console.WriteLine("Contains Key Neymar: {0}", myDict.ContainsKey("Neymar"));
            Console.WriteLine("Contains Key-Value pair Messi - Greatest of all time: {0}", myDict.Contains(new KeyValuePair<string, string>("Messi", "Greatest of All time")));

            //Removing element
            myDict.Remove("Ronaldo");


            Console.ReadKey();
        }
    }
}
