using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ -Language Integrated Query
            //LINQ to objects

            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10 };
            //Fetch numbers whic are greater than 50
            //Using method syntax - lambda expression
            // var numbersGreaterThan50= numbers.Where(x=>x>50);
            //var result1 = numbers.Where(x => x > 50 && x < 70);

            // //Using sql Query Syntax
            // var numbersGreaterThanFifty= from num in numbers
            //                              where num>50
            //                              select num;

            string[] names = { "bisnu", "abc", "ram", "ramesh", "james", "ronald" };
            var namesStartingWithR = names.Where(x => x.Length > 3 && x.StartsWith("r"));


            var namesThatStartWithR = from x in names
                                      where x.Length > 3 && x.ToUpper().StartsWith("R")
                                      select x;
            foreach( var name in namesThatStartWithR )
            {
                Console.WriteLine(name);
            }






        }
    }
}
