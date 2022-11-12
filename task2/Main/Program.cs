var emp = new Employee(1,"Jack", "Chan", 1000);
System.Console.WriteLine(new string('.',35));
System.Console.WriteLine("Id: " + emp.GetId());
System.Console.WriteLine("Firstname: " + emp.GetFirstName());
System.Console.WriteLine("Lastname: " + emp.GetLastName());
System.Console.WriteLine("Fullname: " + emp.GetName());
System.Console.WriteLine("Salary: " + emp.GetSalary()+"$");
System.Console.WriteLine("Annual Salary: " + emp.GetAnnualSalary()+"$");
System.Console.WriteLine("Month salary raised to: " + emp.RaiseSalary(15)+"$");
System.Console.WriteLine(new string('.',35));
System.Console.WriteLine(emp.ToString());

/* var list = new List<Employee>();
list.Add(emp);
foreach (var employee in list)
{
    System.Console.WriteLine("Id: " + employee.GetId() + " || " + "Fullname: " + employee.GetName() + " || " + "Salary: " + employee.GetSalary()+"$");
} */
