using Homework;

Person person = new Person
{
    FirstName = "Joris",
    LastName = "van Laar"
};

Console.WriteLine(person);
person.Greet();

Employee employee = new Employee();
employee.Greet();
