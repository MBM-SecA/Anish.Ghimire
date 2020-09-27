using System;
using System.Collections.Generic;


public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}

    public Country( string n, string c, double a, long p, DateTime i= default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country( "Nepal", "Asia", 147181 , 3456545);
        Country c2 = new Country( "Panama", "South America", 4765575, 55837374, new DateTime(1945,02,10));
        Country c3 = new Country( "Austria", "Europe", 47653.34, 8347377, new DateTime(1998,05,23));
        Country c4 = new Country( "UAE", "Asia", 78453.45, 845747,new DateTime(1979,12,23));
        Country c5 = new Country( "Vietnam", "Asia", 837483.43, 34456545 ,new DateTime(1975,08,09));
        Country c6 = new Country( "Canada", "North America", 234982.34, 8457454);
        Country c7 = new Country( "France", "Europe", 423434.7, 7458345);
        Country c8 = new Country( "Indonesia", "Asia", 86785.45, 83039);
        Country c9 = new Country( "Congo", "Africa", 85847.45, 8484734);
        Country c10 = new Country( "Germany", "Europe", 37483.67, 7364343);
        Country c11 = new Country( "Mongolia", "Asia", 845739.45, 94845);
        Country c12 = new Country( "Egypt", "Africa", 83473.3, 9836462);
        Country c13 = new Country( "Mexico", "North America", 847573.34, 58387263);
        Country c14 = new Country( "Chad", "Africa", 98594.54, 2945768);
        Country c15 = new Country( "Sudan", "Africa", 934387.56, 383473);
        Country c16 = new Country( "Australia", "Australia", 745746, 36462);
        Country c17 = new Country( "Iran", "Asia", 923892, 88727346);
        Country c18 = new Country( "Pakistan", "Asia", 76744364, 3526163,new DateTime(1945,01,25));
        Country c19 = new Country( "Portugal", "Europe", 845784.4, 913);
        Country c20 = new Country( "Maldives", "Asia", 586578.34, 3647372);
        Country c21 = new Country( "Cambodia", "Asia", 857575.87, 88902);
        Country c22 = new Country( "Paraguay", "South America", 7346368.3, 3736452);
        Country c23 = new Country("Latvia", "Europe", 874754.4, 98273);
        Country c24 = new Country( "Japan", "Asia", 784785.35, 382746,new DateTime(1750,12,09));
        Country c25 = new Country( "Brunei", "Asia", 745874.3, 1827364);

        
        var countries = new List<Country>() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25 };

        return countries;
    }
}