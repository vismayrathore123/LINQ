using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperator
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id= 1,Name="Vismay",Email="vismay@gmail.com"},
                new Employee(){Id= 2,Name="Dipesh",Email="dipesh@gmail.com"},
                new Employee(){Id= 3,Name="Sourabh",Email="Sourabh@gmail.com"},
                new Employee(){Id=4,Name="Kamlesh",Email="kamlesh@gmail.com"}
            };

            //operations

            //var basicProQuery=(from emp in employees select new { Id=emp.Id,Name=emp.Name }).ToList();

            //foreach(var item in basicProQuery)
            //{
            //    Console.WriteLine($"Id={item.Id}, Name={item.Name}");
            //}

            var basicProQuery = (from emp in employees select new Student { StudentId= emp.Id, FullName = emp.Name, StEmail=emp.Email }).ToList();

            foreach (var item in basicProQuery)
            {
                Console.WriteLine($"Id={item.StudentId}, Name={item.FullName},Email={item.StEmail}");
            }
            Console.ReadLine();

        }
    }
}
