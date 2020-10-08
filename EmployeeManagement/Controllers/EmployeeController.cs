using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController:Controller
{
    public ActionResult Index()
    {
        //object Initializer Syntax
        Person emp1= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp2= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
         Person emp3= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
         Person emp4= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp5= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        Person emp6= new Person(){FirstName= "Anish",SurName="Ghimire", Address="Baneshwor",Salary=20000 };
        List<Person> employees= new List<Person>(){emp1,emp2,emp3,emp4,emp5,emp6};
        
        
        
        return View(employees);

    }

}
