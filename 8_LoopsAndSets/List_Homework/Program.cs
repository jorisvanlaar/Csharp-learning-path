

List<string> classRoster = new List<string>();
string anotherStudent;

do
{
    Console.Write("Please enter the student's first name: ");
    string? studentName = Console.ReadLine();

    if (studentName != "")
    {
        classRoster.Add(studentName);
    }

    Console.Write("Do you want to enter another student (y/n): ");
    anotherStudent = Console.ReadLine();

} while (anotherStudent.ToLower() == "y");

Console.WriteLine($"Number of students: {classRoster.Count}");