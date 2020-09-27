using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query
            //LINQ to objects
            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10, 445, 32, 66, 69 };
            //fetch numbers which are greater than 50
            var result1 = numbers.Where(x => x > 50 && x < 70);
            //Using Sql query syntax - query expression
            var result2 = from x in numbers where x > 50 && x < 70 select x;

            string[] names = { "Anish", "Ram", "James", "Shyam", "Ronald", "Rajesh"};
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("R"));
            var result4 = from y in names where y.Length > 3 && y.ToLower().StartsWith("r") select y;
          //  foreach(var name in result4)
            //{
              //  Console.WriteLine(name);
            //}


            var countries = Country.GetCountries();
            var asianCountries = from country in countries where country.Continent == "Asia" select country.Name;
            var EuCountries = from country in countries
             where country.Continent == "Europe" && country.Population  < 100000
              select country.Name;
              Console.WriteLine("List of countries in Europe which have population less than 100k:");
      //      foreach(var country in asianCountries)
        //    {
          //      Console.WriteLine(country);
            //}
            foreach(var country in EuCountries)
            {
                Console.WriteLine(country);
            }
            var asianNonColonized = from country in countries
                                    where(country.Continent == "Asia") && ( country.IndependenceDay==default)
                                    select country;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var member in asianNonColonized)
            {
                Console.WriteLine(member.Name);
            }

//List countries in Europe which has population less than 100k.
//List countries in Asia which are not ever invaded.
        }
    }
}