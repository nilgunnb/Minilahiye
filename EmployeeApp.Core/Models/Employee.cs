using EmployeeApp.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EmployeeApp.Core.Models
{
    public class Employee : BaseModel
    {
        private static int _id;

        public string lastName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        public DateTime LastModifiedDate { get; set; }
        public string? FirstName { get; set; }

        public Employee()
        {
            _id++;

            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, FirstName: {lastName}, LastName: {LastName}, Position: {Position}, Salary: {Salary}, CreatedDate: {CreatedDate}, LastModifiedDate: {LastModifiedDate}";
        }
    }
}
  



  
