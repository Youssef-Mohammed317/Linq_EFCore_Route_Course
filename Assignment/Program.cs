using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {

                #region InsertData

                // Load Data From Json File
                // Load Departments
                //string DepartmentsJsonString = File.ReadAllText("Files/Departments.json");
                //var Departments = JsonSerializer.Deserialize<List<JsonModels.Department>>(DepartmentsJsonString);

                //string EmployeesJsonString = File.ReadAllText("Files/Employees.json");
                //var Employees = JsonSerializer.Deserialize<List<JsonModels.Employee>>(EmployeesJsonString);

                // Insert Departments
                //foreach (var department in Departments)
                //{
                //    context.Departments.Add(new Models.Department
                //    {
                //        Name = department.Name
                //    });
                //}
                //foreach (var employee in Employees)
                //{
                //    context.Employees.Add(new Models.Employee
                //    {
                //        Name = employee.EmpName,
                //        Age = employee.Age,
                //        Email = employee.Email,
                //        Salary = employee.Salary,
                //        PhoneNumber = employee.PhoneNumber,
                //        EmpAddress_City = employee.EmpAddress.City,
                //        EmpAddress_Country = employee.EmpAddress.Country,
                //        EmpAddress_Street = employee.EmpAddress.Street,
                //        DepartmentId = employee.DepartmentId
                //    });
                //}

                // Save Changes
                //context.SaveChanges();

                #endregion

                #region AddNewDepartment

                //context.Departments.Add(new Models.Department
                //{
                //    Name = "Accounting",
                //});

                //context.SaveChanges();
                #endregion

                #region UpdateData

                //var dept = context.Departments.FirstOrDefault(d => d.Name == "Accounting");

                //if (dept is not null)
                //    dept.Name = "Finance";
                //try
                //{
                //    context.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                #endregion

                #region DeleteData


                //var dept = context.Departments.FirstOrDefault(d => d.Name == "Finance");
                //if (dept is not null)
                //    context.Departments.Remove(dept);
                //try
                //{
                //    context.SaveChanges();

                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                #endregion

                #region SelectData

                #region Eager Loading

                //var depts = context.Departments
                //    .Include(d => d.Employees) // level 1
                //                               // .ThenInclude(e => e....) // level 2
                //                               // .ThenInclude(...) // level 3
                //    .ToList();

                //foreach (var dept in depts)
                //{
                //    Console.WriteLine($"Department: {dept.Name}");
                //    foreach (var emp in dept.Employees)
                //    {
                //        Console.WriteLine($"\tEmployee: {emp.Name}");
                //    }
                //}

                #endregion

                #region Explict Loading

                //var depts = context.Departments.ToList();

                //foreach (var dept in depts)
                //{
                //    Console.WriteLine($"Department: {dept.Name}");
                //    // Explicit Loading
                //    context.Entry(dept) // Get the Entity Entry for the Department
                //        .Collection(d => d.Employees) // Specify the Collection to Load // For List
                //        .Load(); // Load the Collection
                //    foreach (var emp in dept.Employees)
                //    {
                //        Console.WriteLine($"\tEmployee: {emp.Name}");
                //    }
                //}

                //var employees = context.Employees.ToList();
                //foreach (var emp in employees)
                //{
                //    Console.WriteLine($"Employee: {emp.Name}");
                //    // Explicit Loading
                //    context.Entry(emp) // Get the Entity Entry for the Employee
                //        .Reference(e => e.Department) // Specify the Reference to Load // For Single Object
                //        .Load(); // Load the Reference
                //    Console.WriteLine($"\tDepartment: {emp.Department.Name}");
                //}

                #endregion

                #region Lazy Loading
                // Step 01: Proxies Package
                // Step 02: Make Navigation Properties Virtual
                // useLazyLoadingProxies

                //var depts = context.Departments.ToList();

                //foreach (var dept in depts)
                //{
                //    Console.WriteLine($"Department: {dept.Name}");
                //    foreach (var emp in dept.Employees) // data loaded automatically when accessed
                //    {
                //        Console.WriteLine($"\tEmployee: {emp.Name}");
                //    }
                //}
                #endregion
                #endregion
            }



        }
    }
}
