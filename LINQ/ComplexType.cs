
using System;
using System.Collections.Generic;
using System.Linq;
public class ComplexType
{
    public void LearnLINQ()
    {
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
//HW Is there any African country in your data in your colllection?
//HW Print first 2 largest asian country names 
    }
}