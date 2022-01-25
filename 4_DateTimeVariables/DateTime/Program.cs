using System.Globalization;             

DateTime today = DateTime.Now;          
Console.WriteLine(today);
Console.WriteLine(today.ToString("d")); 
Console.WriteLine(today.ToString("t")); 

DateTime birthday = DateTime.Parse("10/18/1985");
Console.WriteLine(birthday);                        

birthday = DateTime.ParseExact("18/10/1985", "d/M/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(birthday);

DateTime today2 = DateTime.Now;
Console.WriteLine(today2.ToString("MMMM dd, yyyy hh:mm tt zzz"));    
                                                                     
DateTime today3 = DateTime.UtcNow;
Console.WriteLine(today3.ToString("MMMM dd, yyyy hh:mm tt zzz"));

Console.ReadLine();