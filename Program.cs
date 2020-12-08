using System;
using System.Collections.Generic;

namespace _15.SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            // SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();
            SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();
            //declaring a sorted dictionary  //SortedDictionary

            dict["Peter"] = "123"; //not sorted dictioanry, the keys are not sorted alphabetically
            dict["George"] = "123";
            dict["Simon"] = "123";

            sortedDict["Peter"] = "123";  // Keys are sored alphabetically//automaticaaly dsorted by key !!
            sortedDict["George"] = "123";
            sortedDict["Simon"] = "123";

            Console.WriteLine(string.Join('\n', dict));
            Console.WriteLine();
            Console.WriteLine(string.Join('\n', sortedDict));


        }
    }
}
