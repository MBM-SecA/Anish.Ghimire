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

    public Department Department {get;set;}
    public int DepartentId{get;set;}
    



}