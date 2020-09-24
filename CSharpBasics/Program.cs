using LearnCollections;
using System;
using System.IO;
using System.Linq;

public class Program
{
    static void Main()
    {
        // Collections collections = new Collections();
        // collections.LearnDictionary();
        // var square= new Square(20);
        // square.Display();   //var squareArea=square.GetArea();
        
        //square.GetDiagonal();
        // var rectangle =new Rectangle(20,30);
        // var rectangleArea=rectangle.GetArea();

        // var circle= new Circle(20);
        // var circleArea= circle.GetArea();
        // FileIO fileIO= new FileIO();
        // fileIO.LearnFileHandling();
        string countriesText =File.ReadAllText("Countries.txt");
        string[] countries=countriesText.Split("\r\n");

        var countriesWithNInitial=countries.Where(x=>x.StartsWith("N")).Select(x=>x);
        foreach(var country in countriesWithNInitial)
        {
            Console.WriteLine(country);

        }
        






      
    }
    
}
