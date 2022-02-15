

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";
lookup.Add("bird", "Not a human that flies");   

Console.WriteLine($"The definition of fish is: {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Joris van Laar";
employees[28] = "Sue Storm";

Console.WriteLine($"The employee with ID 28: {employees[28]} ");