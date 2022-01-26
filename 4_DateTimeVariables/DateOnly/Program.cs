

DateTime today = DateTime.Now;
Console.WriteLine($"Just the date from today: {today.Date}");   

DateOnly birthday = DateOnly.Parse("10/18/1985");       
Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));  
