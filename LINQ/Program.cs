using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };
            //var querySyntax = from sc in list where sc % 2 == 0 select sc;
            //foreach (var sc in querySyntax)
            //{

            //    Console.WriteLine(sc);


            //    var methodSyntax = list.Where(sc1 => sc1 % 2 == 1);
            //    foreach (var sc2 in methodSyntax)
            //    {
            //        Console.WriteLine(sc2);
            //    }

            //    var mixedSyntax = (from sc3 in list where sc3 > 2 select sc3);
            //    foreach (var sc3 in mixedSyntax)
            //    {
            //        Console.WriteLine(sc3);
            //    }

                List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id= 1, Name="vismay"},
            new Employee(){Id= 2,Name="Deepesh" },
            new Employee(){Id=3, Name="Somesh"}
            };
                IEnumerable<Employee> query = from obj in employees
                                              where obj.Id == 1
                                              select obj;

           

            IQueryable<Employee> query1 = employees.AsQueryable().Where(x=>x.Id == 1);
                                       

            //    Console.ReadLine();
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Id + item.Name);
            //}
            foreach (var item in query1)
            {
                Console.WriteLine(item.Id + item.Name);
            }
            Console.ReadLine();

        }

        }
    }


