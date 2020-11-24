using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id{get;set;}
    [Display(Name="First Name")]  
    public string FirstName {get;set;}
    [Display(Name="Last Name")]  
    public string SurName{get;set;}
    public string Address{get;set;}
    public char Gender{get;set;}='M';
    public double Salary {get;set;}

    public static List<Person> GetPerson()
    {
        //object Initializer Syntax
        Person emp1= new Person(){Id=1, FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp2= new Person(){ Id=2, FirstName= "Ayush",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
         Person emp3= new Person(){Id=3, FirstName= "Ram",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
         Person emp4= new Person(){Id=4, FirstName= "Shyam",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp5= new Person(){Id=5, FirstName= "Ravi",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp6= new Person(){Id=6, FirstName= "Phulkumar",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
    
         List<Person> employees= new List<Person> {emp1,emp2,emp3,emp4,emp5,emp6};
         return employees;

    }




}