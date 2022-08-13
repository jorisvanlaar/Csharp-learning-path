using MethodOverridingLibrary.Models;


EmployeeModel employee = new EmployeeModel();
CommissionEmployeeModel commissionEmployee = new CommissionEmployeeModel();

Console.WriteLine(employee.GetPaycheckAmount(10)); 
Console.WriteLine(commissionEmployee.GetPaycheckAmount(10));

Volkswagen volkswagen = new Volkswagen();
Tesla tesla = new Tesla();

volkswagen.StartCar();
tesla.StartCar();

volkswagen.SetClock();
tesla.SetClock();
