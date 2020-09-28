using System;
using System.Collections.Generic;
using System.Linq;

public class ComplexType
{
    private object country;

    public void LearnLINQ()
    {
        var countries = Country.GetCountries();
            var asianCountries = from country in countries where country.Continent == "Asia" select country;
            var EuCountries = from country in countries
             where country.Continent == "Europe" && country.Population  < 100000
              select country.Name;
              Console.WriteLine("List of countries in Europe which have population less than 100k:");
        //    foreach(var country in asianCountries)
        //    {
        //        Console.WriteLine(country.Name);
        //     }
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
         //HW Is there any African country in your data in your colllection?
         //HW Print first 2 largest asian country names 
      var africanCountry=countries.Any(x=>x.Continent=="Africa");
      if (africanCountry)
      {
          Console.WriteLine("There are African countries on the list");


      }
      var asian= from country in countries where country.Continent=="Asia" select country;
      var orderofAsianCountries=countries.OrderByDescending(asian=>asian.Area);
      var twoLargest= orderofAsianCountries.Take(2);
      Console.WriteLine("The largest 2 countries in Asia are:");
    //   foreach (var country in twoLargest)
    //   {
        
    //       Console.WriteLine(country.Name);



    //   }




    }
}