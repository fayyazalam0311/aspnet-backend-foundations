using System.ComponentModel.DataAnnotations;

namespace Employee
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be empty.")]
        public string Name { get; set; }
        public string Department { get; set; }
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Salary cannot be negative.")]
        public decimal Salary { get; set; }
        public DateTime DateHired { get; set; }

        public Employee(int id, string name, string department, decimal salary, DateTime dateHired)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Management Console App!");

            List<Employee> EmployeeData = new List<Employee>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Press 1 for Add Employee.\n2. Press 2 for View All Employees.\n3. Press 3 for Update the Employee Details.\n4. Press 4 for Search Employee by Department.\n5. Press 5 to Delete the Employee.\n6. Press 6 to Exit the Application.");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Enter Employee Data");
                    Console.WriteLine("\nEnter Employee Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEnter Employee Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter Employee Department:");
                    string department = Console.ReadLine();
                    Console.WriteLine("\nEnter Employee Salary:");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\nEnter Employee Hire Date (yyyy-MM-dd):");
                    DateTime dateHired = DateTime.TryParse(Console.ReadLine(), out DateTime parsedDate) ? parsedDate : DateTime.MinValue;

                    Employee employee = new Employee(id, name, department, salary, dateHired);
                    EmployeeData.Add(employee);

                    Console.WriteLine("Employee Data Added Successfully!");
                }
                else if (input == "2")
                {
                    foreach (Employee e in EmployeeData)
                    {
                        Console.WriteLine($"Id: {e.Id}, \nName: {e.Name}, \nDepartment: {e.Department}, \nSalary: {e.Salary}, \nDate Hired: {e.DateHired}");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter the Employee Id to update:");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());

                    if (EmployeeData.Any(x => x.Id == idToUpdate))
                    {
                        var employeeToUpdate = EmployeeData.First(e => e.Id == idToUpdate);

                        Console.WriteLine($"Employee Details associated with Id {idToUpdate}: Id: {employeeToUpdate.Id}, Name: {employeeToUpdate.Name}, Department: {employeeToUpdate.Department}, Salary: {employeeToUpdate.Salary}, Date Hired: {employeeToUpdate.DateHired}");

                        Console.WriteLine("Enter new Employee Name (leave blank to keep current):");
                        string newName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newName))
                        {
                            employeeToUpdate.Name = newName;
                        }
                        Console.WriteLine("Enter new Employee Department (leave blank to keep current):");
                        string newDepartment = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newDepartment))
                        {
                            employeeToUpdate.Department = newDepartment;
                        }
                        Console.WriteLine("Enter new Employee Salary (leave blank to keep current):");
                        string newSalaryInput = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newSalaryInput) && decimal.TryParse(newSalaryInput, out decimal newSalary))
                        {
                            employeeToUpdate.Salary = newSalary;
                        }
                        Console.WriteLine("Enter new Employee Hire Date (yyyy-MM-dd) (leave blank to keep current):");
                        string newDateHiredInput = Console.ReadLine();
                        DateTime newDateHired = !string.IsNullOrWhiteSpace(newDateHiredInput) && DateTime.TryParse(newDateHiredInput, out DateTime parsedNewDate) ? parsedNewDate : employeeToUpdate.DateHired;
                        employeeToUpdate.DateHired = newDateHired;
                        Console.WriteLine("Employee Updated Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Emplpyee ID not found.");
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter the Department: ");
                    string SearchDepartment = Console.ReadLine();

                    List<Employee> EmployeeByDepartment = EmployeeData.Where(e => e.Department.ToLower() == SearchDepartment.ToLower()).ToList();

                    Console.WriteLine("\nList of Employees Found:");
                    foreach (Employee b in EmployeeByDepartment)
                    {
                        Console.WriteLine($"Id: {b.Id}, Name: {b.Name}, Department: {b.Department}, Salary: {b.Salary}, Date Hired: {b.DateHired}");
                    }
                }
                else if (input == "5")
                {
                    Console.WriteLine("Enter the ID: ");
                    int DeleteID = Convert.ToInt32(Console.ReadLine());

                    if (EmployeeData.Any(c => c.Id == DeleteID))
                    {
                        var DeleteEmployee = EmployeeData.First(e => e.Id == DeleteID);
                        EmployeeData.Remove(DeleteEmployee);
                        Console.WriteLine("Employee Deleted Successfully");
                    }

                }
                else if (input == "6")
                {
                    Console.WriteLine("Thank you for using the Application\nHave a Nice Day. Good Bye!");
                    break;
                }
            }
        }

    }
}

