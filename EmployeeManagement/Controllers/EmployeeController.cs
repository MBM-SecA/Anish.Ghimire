using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;


public class EmployeeController:Controller
{
    public ActionResult Index()
    {
        
        List<Person> employees= Person.GetPerson();
        
        
        return View(employees);

    }
    public ActionResult Details([FromQuery] int id)
    {
    //    List<Person> employees = Person.GetPerson();
    //     foreach(var employee in employees)
    //     {
    //         if(employee.FirstName == firstName)
    //         {
    //             return View(employee);
    //         }
    //     }
    //     return View();
    var employees= Person.GetPerson();
    var employee=employees.FirstOrDefault(x=>x.Id==id);
    return View(employee);


    }

    public ActionResult Add()
    {
        return View();

    }
    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Record saved";

    }

}
