using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Sandra",
    LastName = "Martinez",
    BirthDate = new Date(1990, 5, 25),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M


};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Patricia",
    LastName = "Marin",
    BirthDate = new Date(1997, 8, 11),
    HiringDate = new Date(2015, 3, 25),
    IsActive = true,
    Sales = 32000000M,
    CommissionPercentaje = 0.03F
   


};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1997, 8, 11),
    HiringDate = new Date(2015, 3, 25),
    IsActive = true,
    HourValue = 123456.56M,
    Hours =12.23F



};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4,
    FirstName = "Marta",
    LastName = "Ramos",
    BirthDate = new Date(1985, 5, 15),
    HiringDate = new Date(2010, 8, 21),
    IsActive = true,
    Base = 860.45M,
    Sales = 58000M,
    CommissionPercentaje = 0.015F 



};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3, employee4 };

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll+= employee.GetValueToPay();

}

Console.WriteLine("                                  ===================");
Console.WriteLine($"Total                             {$"{payroll:C2}",18}");