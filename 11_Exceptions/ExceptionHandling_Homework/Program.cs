

try
{
    ExceptionMethod();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static void ExceptionMethod()
{
    int[] ages = { 34, 45, 378, 765, 9 };

    for (int i = 0; i <= ages.Length; i++)
    {
        Console.WriteLine(ages[i]);
    }
}
