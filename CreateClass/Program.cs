﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Béla", DateTime.Now, Gender.Male);
            Console.WriteLine(person.ToString());
            Console.ReadKey();

            Employee employee = new Employee("Jolika", DateTime.Now, Gender.Female, 100, "varrónő", new Room(1));
            Console.WriteLine(employee.ToString());
            Console.ReadKey();
        }
    }
}
