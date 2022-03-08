

try
{
    BadCall();
}
catch (Exception ex)
{
    Console.WriteLine($"Hi user, there was an error: {ex.Message}");
}

static void BadCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++)
    {
        try
        {
            Console.WriteLine(ages[i]);
        }
        catch (Exception ex)                            
        {
            Console.WriteLine("Handle the exception");
            throw;          
        }
    }
}
