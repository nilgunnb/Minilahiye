using EmployeeApp.App.Services.Implementations;

EmployeeService employeeService = new EmployeeService();

Console.WriteLine("0. Close App");

Console.WriteLine("1. Add Employee");

Console.WriteLine("2. Delete Employee");


Console.WriteLine("3. Get by Id Employee");

Console.WriteLine("4. Get all Employees");

Console.WriteLine("5. Update Employee");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch(RequestNumber)
    {
        case "1":
            employeeService.Create();
            break;
            case "2": 
            employeeService.Delete();
            break;
           
            case "3":
            employeeService.Get();
            break;
            case "4":
            employeeService.GetAll();
            break;
        case "5":
            employeeService.Update();
            break;
        default:
            Console.WriteLine("Select valid option");
            break;
    }
    Console.WriteLine("0. Close App");

    Console.WriteLine("1. Add Employee");

    Console.WriteLine("2. Delete Employee");

 

    Console.WriteLine("3. Get by Id Employee");

    Console.WriteLine("4. Get all Employees");

    Console.WriteLine("5. Update Employee");

   RequestNumber = Console.ReadLine();


}