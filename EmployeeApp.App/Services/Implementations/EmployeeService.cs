using EmployeeApp.App.Services.Interfaces;
using EmployeeApp.Core.Models;
using EmployeeApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EmployeeApp.App.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        public void Create()
        {
            Employee employee = new Employee();

            Console.WriteLine("Add FirstName");

            employee.FirstName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                Console.WriteLine("Add valid FisrtName");

                employee.FirstName = Console.ReadLine();
            }

            Console.WriteLine("Add LastName");

            employee.LastName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(employee.LastName))
            {

                Console.WriteLine("Add valid LastName");

                employee.LastName = Console.ReadLine();

            }
            Console.WriteLine("Add Position");

            employee.Position = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(employee.Position))
            {

                Console.WriteLine("Add valid Position");

                employee.Position= Console.ReadLine();
            }

            Console.WriteLine("Add Salary");

            employee.Salary = double.Parse(Console.ReadLine());

            while (employee.Salary <= 0)
            {
                Console.WriteLine("Add valid Salary");

                employee.Salary = double.Parse(Console.ReadLine());
            }
            

            _employeeRepository.Create(employee);
        }

        public void Delete()
        {
            Console.WriteLine("Enter Id");

            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                _employeeRepository.Delete(employee);

                Console.WriteLine("Employee deleted");
            }
        }

        

        public void Get()
        {
            Console.WriteLine("Enter Id");

            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine(employee);
            }
        }

        public void GetAll()
        {
           List<Employee> employees = _employeeRepository.GetAll();

            if (employees == null)
            {
                Console.WriteLine("No Employees");
            }
            else
            {
                foreach (var item in employees)
                {
                    Console.WriteLine(item);
                }

            }


        }

        public void Update()
        {
            Console.WriteLine("Enter Id");

            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine("What do you want to update?");

                Console.WriteLine("1.FirstName");

                Console.WriteLine("2.LastName");

                Console.WriteLine("3.Position");

                Console.WriteLine("4.Salary");

                Console.WriteLine("5.UpdateAll");

                string num = Console.ReadLine();

                while (num != null)
                {
                    switch (num)
                    {
                        case "1":
                            employee.FirstName = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.FirstName))
                            {
                                Console.WriteLine("Add valid FisrtName");

                                employee.FirstName = Console.ReadLine();
                            }
                            Console.WriteLine("FistName updated");
                            break;
                        case "2":
                            employee.LastName = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.LastName))
                            {

                                Console.WriteLine("Add valid LastName");

                                employee.LastName = Console.ReadLine();

                            }
                            Console.WriteLine("LaastName updated");
                            break;
                            case "3":
                            employee.Position = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.Position))
                            {

                                Console.WriteLine("Add valid Position");

                                employee.Position = Console.ReadLine();
                            }
                            Console.WriteLine("Position updated");
                            break;
                            case "4":
                            employee.Salary = double.Parse(Console.ReadLine());

                            while (employee.Salary <= 0)
                            {
                                Console.WriteLine("Add valid Salary");

                                employee.Salary = double.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Salary updated");
                            break;
                            case "5":
                            employee.FirstName = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.FirstName))
                            {
                                Console.WriteLine("Add valid FisrtName");

                                employee.FirstName = Console.ReadLine();
                            }

                            employee.LastName = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.LastName))
                            {

                                Console.WriteLine("Add valid LastName");

                                employee.LastName = Console.ReadLine();

                            }

                            employee.Position = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(employee.Position))
                            {

                                Console.WriteLine("Add valid Position");

                                employee.Position = Console.ReadLine();
                            }
                            employee.Salary = double.Parse(Console.ReadLine());

                            while (employee.Salary <= 0)
                            {
                                Console.WriteLine("Add valid Salary");

                                employee.Salary = double.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Updated all");
                            break;
                            default: 
                            Console.WriteLine("Select valid option");
                            break;
                    }


                }

            }


        }
    }
}












