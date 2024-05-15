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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);