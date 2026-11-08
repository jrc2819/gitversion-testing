using System;

try
{
    Console.WriteLine("Do something 1 - branch test");


    Console.WriteLine("Program finished successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}