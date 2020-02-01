using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.Name = "Fadi";
            emp.Salary = 700000;
            emp.Address = "Canada";
            emp.Department = "Softwar Development";

         

    
            Mapper map = new Mapper( new MapperConfiguration(cfg=> cfg.CreateMap<Employee, EmployeeDTO>()));
            var empDTO = map.Map<Employee, EmployeeDTO>(emp);
            //OR
            //var empDTO = map.Map<EmployeeDTO>(emp);

            Console.WriteLine("Name:" + empDTO.Name + ", Salary:" + empDTO.Salary + ", Address:" + empDTO.Address + ", Department:" + empDTO.Department);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeDTO
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}
