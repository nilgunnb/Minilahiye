using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.App.Services.Interfaces
{
    public interface IEmployeeService
    {
        public void Create();

        public void Update();

        public void Delete();

   

        public void GetAll();

        public void Get();
    }
}
